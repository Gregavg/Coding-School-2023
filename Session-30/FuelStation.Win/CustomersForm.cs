using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraScheduler.Outlook.Interop;
using FuelStation.Model;
using FuelStation.Web.Client.Pages.Customers;
using FuelStation.Web.Shared;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;

namespace FuelStation.Win {
    public partial class CustomersForm : Form {
        private readonly HttpClient client;

        public CustomersForm() {
            InitializeComponent();
            client = new HttpClient();
            ConnectionUri connectionUri = new();
            client.BaseAddress = new Uri(connectionUri.GetUri());
        }


        private async void CustomersForm_Load(object sender, EventArgs e) {
            await SetControlProperties();
        }

        private async Task SetControlProperties() {

            var customers = await GetCustomers();
            if (customers != null) {
                bsCustomers.DataSource = customers;
                grdCustomers.DataSource = bsCustomers;
            }
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Close();
        }

        //VALIDATE ROW
        private async void gridView4_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {
            GridView? view = sender as GridView;
            if (view.GetFocusedRow != null) {
                CustomerListDto? customer = view.GetFocusedRow() as CustomerListDto;
                if (customer.Id == 0) {
                    await NewCustomer(customer);
                } else {
                    await EditCustomer(customer);
                }
            }
        }

        //ROW DELETING
        private async void gridView4_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {
            GridView? view = sender as GridView;
            if (view.GetFocusedRow != null) {
                CustomerListDto? customer = view.GetFocusedRow() as CustomerListDto;
                await DeleteCustomer(customer.Id);
            }
        }

        //GET REQUEST
        private async Task<List<CustomerListDto?>> GetCustomers() {
            var response = await client.GetAsync("customer");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<CustomerListDto?>>(content);
            }
            return null;
        }

        //POST REQUEST
        private async Task NewCustomer(CustomerListDto? customer) {
            var response = await client.PostAsJsonAsync("customer", customer);
            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Success!", "Success Message");
            } else {
                MessageBox.Show("Error! Try again.", "Alert Message");
                _ = SetControlProperties();
            }
        }

        //PUT REQUEST
        private async Task EditCustomer(CustomerListDto? customer) {

            var response = await client.PutAsJsonAsync("customer", customer);

            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Success!", "Success Message");
            } else {
                MessageBox.Show("Error! Try again.", "Alert Message");
                _ = SetControlProperties();
            }
        }

        //DELETE REQUEST
        private async Task DeleteCustomer(int id) {
            var response = await client.DeleteAsync($"customer/{id}");
            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Success!", "Success Message");
            } else {
                MessageBox.Show("Error! Try again.", "Alert Message");
                _ = SetControlProperties();
            }
        }
    }
}
