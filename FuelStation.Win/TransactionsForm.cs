using FuelStation.Web.Shared;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using FuelStation.Model.Enums;
using System.Data;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;
using FuelStation.Model;

namespace FuelStation.Win {
    public partial class TransactionsForm : Form {
        private readonly HttpClient client;
        private CustomerListDto _customer;
        private List<ItemListDto?>? _items;

        public TransactionsForm(CustomerListDto customer) {
            InitializeComponent();
            _customer = customer;
            labelCustomer.Text = $"{_customer.Name} {_customer.Surname}'s Transactions (Card Number: {_customer.CardNumber})";
            client = new HttpClient();
            ConnectionUri connectionUri = new ConnectionUri();
            client.BaseAddress = new Uri(connectionUri.GetUri());
        }

        private async void TransactionsForm_Load(object sender, EventArgs e) {
            await SetTransactionsControlProperties();
        }

        private async Task SetTransactionsControlProperties() {

            //var transactions = await GetTransactions();
            var transactions = await GetTransactions(_customer.Id);
            if (transactions != null) {
                bsTransactions.DataSource = transactions;

                bsTransactionLines.DataSource = bsTransactions;
                bsTransactionLines.DataMember = "TransactionLines";

                grdTransactions.DataSource = bsTransactions;
                grdTransactionLines.DataSource = bsTransactionLines;

                // Look up edit EMPLOYEES
                var employees = await GetEmployees();
                bsEmployees.DataSource = employees
                    .Where(employee => (employee.EmployeeType == EmployeeType.Manager || employee.EmployeeType == EmployeeType.Cashier) && employee.HireDateEnd == null);
                repEmployees.DataSource = bsEmployees;
                repEmployees.DisplayMember = "Surname";
                repEmployees.ValueMember = "Id";

                _items = await GetItems();
                bsItems.DataSource = _items;
                repItemTree.DataSource = bsItems;
                repItemTree.DisplayMember = "Description";
                repItemTree.ValueMember = "Id";

                if (_items != null) SetListBoxProperties();
            }
        }

        // SET COMBOBOXES OF ITEMS
        private void SetListBoxProperties() {
            if (_items != null) {
                repItemTree.DataSource = _items;
                repItemTree.DisplayMember = "Description";
                repItemTree.ValueMember = "Id";

                List<ItemType> itemTypeList = Enum.GetValues(typeof(ItemType)).Cast<ItemType>().ToList();

                bsItemTypes.DataSource = itemTypeList;
                comboItems.DataSource = bsItemTypes;
                comboItems.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        // SET LISTBOX WHEN CHANGE COMBO VALUE
        private void comboItems_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboItems.SelectedItem != null) {
                listItems.DataSource = null;
                var selectedItemType = (ItemType)comboItems.SelectedItem;

                if (_items != null) {
                    var itemList = _items.Where(item => item != null && item.ItemType == selectedItemType).ToList();
                    listItems.DataSource = itemList;
                    listItems.DisplayMember = "Description";
                    listItems.ValueMember = "Id";
                }
            }
        }

        // ROW DELETING
        private async void gridView5_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {
            GridView? view = sender as GridView;
            if (view != null && view.GetFocusedRow != null) {//nullable warning
                TransactionListDto? transaction = view.GetFocusedRow() as TransactionListDto;
                if (transaction != null) {
                    await DeleteTransaction(transaction.Id);
                }
            }
        }


        public string MessageGet(string message, string title) {
            string userInput = Microsoft.VisualBasic.Interaction.InputBox(message, title);
            return userInput;
        }

        // ADD NEW TRANSACTION LINE
        private void AddNewTransactionLine(int qty) {
            ItemListDto? item = listItems.SelectedItem as ItemListDto;

            if (item.ItemType != ItemType.Fuel || !SecondFuelExist()) {

                GridView? gridView = grdTransactions.FocusedView as GridView;
                if (gridView != null) {
                    if (item != null) {
                        TransactionLineEditDto newTempTL = new();
                        newTempTL.ItemId = item.Id;
                        newTempTL.Quantity = qty;
                        newTempTL.ItemPrice = item.Price;
                        newTempTL.NetValue = newTempTL.ItemPrice * newTempTL.Quantity;

                        if (item.ItemType == ItemType.Fuel && newTempTL.NetValue > 20) newTempTL.DiscountPercentage = 10;
                        else newTempTL.DiscountPercentage = 0;

                        newTempTL.DiscountValue = (newTempTL.NetValue * newTempTL.DiscountPercentage) / 100;
                        newTempTL.TotalValue = newTempTL.NetValue - newTempTL.DiscountValue;

                        var transaction = gridView.GetRow(gridView.FocusedRowHandle) as TransactionListDto;
                        if (transaction != null) newTempTL.TransactionId = transaction.Id;

                        newTempTL.Item = item;
                        bsTransactionLines.Add(newTempTL);
                        CalculateTotalValue();
                    }
                }
            } else {
                MessageBox.Show("Fuel type already exists.", "Error");
            }

        }

        // ADD NEW TRANSACTION
        private void AddNewTransaction() {
            TransactionListDto newTempTransaction = new();
            newTempTransaction.CustomerId = _customer.Id;
            newTempTransaction.TotalValue = 0;
            bsTransactions.Add(newTempTransaction);
            CalculateTotalValue();
        }

        //CHECKS IF UNSAVED TRANSACTION
        private bool IsNotPosted() {
            var isNotPosted = false;
            GridView? gridViewTransactions = grdTransactions.FocusedView as GridView;

            if (gridViewTransactions != null) {
                for (int i = 0; i < gridViewTransactions.RowCount; i++) {
                    var row = (TransactionListDto)gridViewTransactions.GetRow(i);
                    if (row.Id == 0) {

                        MessageBox.Show("An unsaved transaction already exists.", "Alert");
                        isNotPosted = true;
                    }
                }
            }
            return isNotPosted;
        }

        // CHECK DATASOURCE FOR SECOND FUEL
        private bool SecondFuelExist() {
            bool foundFuelItem = false;
            GridView? gridViewTL = grdTransactionLines.FocusedView as GridView;

            if (gridViewTL != null) {
                for (int i = 0; i < gridViewTL.RowCount; i++) {
                    TransactionLineEditDto? transactionLine = gridViewTL.GetRow(i) as TransactionLineEditDto;
                    if (transactionLine != null && transactionLine.Item.ItemType == ItemType.Fuel) {
                        foundFuelItem = true;
                        break;
                    }
                }
            }
            return foundFuelItem;
        }


        // DELETE TRANSACTIONSLINE METHOD
        private async Task TransactionLineDeleting() {
            if (gridView1.FocusedRowHandle >= 0) {
                TransactionLineEditDto transactionLine = (TransactionLineEditDto)gridView1.GetFocusedRow();

                if (transactionLine != null && transactionLine.Id > 0) {
                    try { await DeleteTransactionLine(transactionLine.Id); }
                    catch { MessageBox.Show("Error deleting.", "Error"); }
                    bsTransactionLines.Remove(transactionLine);
                    CalculateTotalValue();

                } else if (transactionLine != null && transactionLine.Id == 0) {
                    bsTransactionLines.Remove(transactionLine);
                    CalculateTotalValue();
                } else MessageBox.Show("Item not found. Try again", "Alert");
            }
        }

        // DELETE TRANSACTION METHOD
        private async void TransactionsDeleting() {
            if (gridView5.FocusedRowHandle >= 0) {
                TransactionListDto transaction = (TransactionListDto)gridView5.GetFocusedRow();

                if (transaction != null) {
                    if (transaction.Id > 0) {
                        try {
                            await DeleteTransaction(transaction.Id);
                            bsTransactions.Remove(transaction);
                        }
                        catch { MessageBox.Show("Error deleting Transaction.", "Error"); }

                    } else if (transaction.Id == 0) {
                        bsTransactions.Remove(transaction);
                    } else MessageBox.Show("Item not found. Try again", "Alert");
                    await SetTransactionsControlProperties();
                }
            }
        }

        // SAVE TRANSACTION METHOD
        private async Task TransactionsSaving() {
            if (gridView5.FocusedRowHandle >= 0) {
                TransactionListDto transaction = (TransactionListDto)gridView5.GetFocusedRow();

                if (transaction != null && transaction.EmployeeId != 0 && transaction.PaymentMethod != 0) {

                    if (transaction.Id > 0) {
                        await EditTransaction(transaction);
                        //await SaveTransactionLines(transaction.Id, transaction.TransactionLines);

                    } else if (transaction.Id == 0) {
                        await NewTransaction(transaction);
                    }
                    await SetTransactionsControlProperties();
                } else {
                    MessageBox.Show("Please check entries.", "Alert");
                }
            }
        }

        // SAVE TRANSACTION LINES
        public async Task SaveTransactionLines(int Id, List<TransactionLineEditDto> transactionLines) {
            if (transactionLines != null) {
                foreach (var transactionLine in transactionLines) {
                    if (transactionLine != null) {
                        transactionLine.TransactionId = Id;
                        if (transactionLine.Id == 0) {
                            await NewTransactionLine(transactionLine);
                        } else {
                            await EditTransactionLine(transactionLine);
                        }
                    }
                }
            }
        }

        // CALCULATE TOTAL VALUE FOR TRANSACTION
        public void CalculateTotalValue() {
            GridView? gridViewTL = grdTransactionLines.FocusedView as GridView;
            decimal totalValue = 0;
            if (gridViewTL != null) {
                for (int i = 0; i < gridViewTL.RowCount; i++) {
                    TransactionLineEditDto? transactionLine = gridViewTL.GetRow(i) as TransactionLineEditDto;
                    totalValue += transactionLine?.TotalValue ?? 0;
                }
            }
            var gridView = grdTransactions.FocusedView as GridView;
            if (gridView != null) {
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "TotalValue", totalValue);
                if (totalValue > 50) gridView.SetRowCellValue(gridView.FocusedRowHandle, "PaymentMethod", PaymentMethod.Cash);
            }
        }

        // CELL VALUE CHANGE IF TOTAL VALUE IS 50 OR MORE 
        private void gridView5_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
            if (e.Column.FieldName == "PaymentMethod") {
                string? selectedPaymentMethod = Convert.ToString(e.Value);
                decimal totalValue = Convert.ToDecimal(gridView5.GetRowCellValue(e.RowHandle, "TotalValue"));

                if (totalValue > 50 && selectedPaymentMethod != "Cash") {
                    MessageBox.Show("TotalValue is above 50, only Cash payment is accepted.", "Alert");
                    gridView5.SetRowCellValue(e.RowHandle, "PaymentMethod", "Cash");
                }
            }
        }

        //          BUTTONS

        // DELETE TRANSACTION LINE
        private async void btnDeleteTransactionLines_Click(object sender, EventArgs e) {
            var dialogResult = MessageBox.Show("Are you sure to delete this item? You can not change it.", "Delete item", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) await TransactionLineDeleting();
        }

        // ADD TRANSACTION
        private void btnAddTransaction_Click(object sender, EventArgs e) {
            if (!IsNotPosted()) {
                AddNewTransaction();
            }
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Close();
        }

        // ADD ITEM TO TRANSACTION LINE
        private void btnAdd_Click(object sender, EventArgs e) {
            int qty = 0;
            string userInput = MessageGet("Enter item quantity:", "Quantity");
            if (!Int32.TryParse(userInput, out qty)) MessageBox.Show("Error, try again with number.", "Error");
            else if (qty <= 0) MessageBox.Show("Error, try again with number above 0.", "Error");
            else AddNewTransactionLine(qty);
        }

        // DELETE TRANSACTION
        private void btnDeleteTransaction_Click(object sender, EventArgs e) {
            var dialogResult = MessageBox.Show("Are you sure to delete this Transaction? All Transaction Lines will be deleted.", "Delete item", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) TransactionsDeleting();
        }

        // SAVE TRANSACTION
        private async void btnSave_Click(object sender, EventArgs e) {
            var dialogResult = MessageBox.Show("Are you sure you want to save this Transaction? Any other unsaved transactions will be lost.", "Save item", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) await TransactionsSaving();
        }




        //          REQUESTS
        // GET REQUEST TRANSACTIONS
        private async Task<List<TransactionListDto>> GetTransactions(int id) {
            var response = await client.GetAsync($"transaction/customer/{id}");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<TransactionListDto>>(content);
            }
            return null;
        }

        // GET CUSTOMER'S TRANSACTIONS
        private async Task<List<TransactionListDto>> GetCustomersTransaction(int id) {
            var response = await client.GetAsync($"customer/{id}");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<TransactionListDto>>(content);
            }
            return null;
        }

        // POST ADD TRANSACTION
        private async Task NewTransaction(TransactionListDto? transaction) {
            var response = await client.PostAsJsonAsync("transaction", transaction);
            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Transaction saved!", "Success Message");
            } else {
                MessageBox.Show("Could not save transaction! Try again.", "Error Message");
            }
        }

        // POST ADD TRANSACTIONLINE
        private async Task NewTransactionLine(TransactionLineEditDto? transactionline) {
            var response = await client.PostAsJsonAsync("transactionline", transactionline);
            if (!response.IsSuccessStatusCode)
                MessageBox.Show("Error! Try again.", "Alert Message");
        }

        // PUT REQUEST EDIT TRANSACTION
        private async Task EditTransaction(TransactionListDto? transaction) {
            var response = await client.PutAsJsonAsync("transaction", transaction);

            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Transaction saved!", "Success Message");
            } else {
                MessageBox.Show("Could not save transaction! Try again.", "Error Message");
            }
        }

        // PUT REQUEST EDIT TRANSACTIONLINE
        private async Task EditTransactionLine(TransactionLineEditDto? transactionline) {
            var response = await client.PutAsJsonAsync("transactionline", transactionline);

            if (!response.IsSuccessStatusCode)
                MessageBox.Show("Error! Try again.", "Alert Message");
        }

        // DELETE REQUEST DELETE TRANSACTION
        private async Task DeleteTransaction(int id) {
            var response = await client.DeleteAsync($"transaction/{id}");
            if (!response.IsSuccessStatusCode)
                MessageBox.Show("Transaction could not be deleted.", "Alert Message");
        }

        // DELETE REQUEST DELETE TRANSACTIONLine
        private async Task DeleteTransactionLine(int id) {

            var response = await client.DeleteAsync($"transactionline/{id}");
            if (!response.IsSuccessStatusCode)
                MessageBox.Show("Transaction line could not be deleted.", "Alert Message");
        }

        // GET REQUEST EMPLOYEES
        private async Task<List<EmployeeListDto?>> GetEmployees() {
            var response = await client.GetAsync("employee");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<EmployeeListDto?>>(content);
            }
            return null;
        }

        // GET REQUEST ITEMS
        private async Task<List<ItemListDto?>> GetItems() {
            var response = await client.GetAsync("item");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ItemListDto?>>(content);
            }
            return null;
        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
}
