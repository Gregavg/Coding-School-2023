using System.Net.Http;
using Newtonsoft.Json;
using FuelStation.Web.Shared;
using FuelStation.Win;
using DevExpress.XtraGrid.Views.Grid;
using FuelStation.Model;

namespace FuelStation.Win {
    public partial class ItemsForm : Form {
        private readonly HttpClient client;

        public ItemsForm() {
            InitializeComponent();
            client = new HttpClient();
            ConnectionUri connectionUri = new ConnectionUri();
            client.BaseAddress = new Uri(connectionUri.GetUri());
        }

        private async void ItemsForm_Load(object sender, EventArgs e) {
            await SetControlProperties();
        }


        private async Task SetControlProperties() {
            var items = await GetItems();
            if (items != null) {
                bsItems.DataSource = items;
                grdItems.DataSource = bsItems;
            }
        }

        //ROW VALIDATE
        private async void gridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {
            GridView? view = sender as GridView;
            if (view.GetFocusedRow != null) {
                ItemListDto? item = view.GetFocusedRow() as ItemListDto;
                if (item.Id == 0) {
                    await NewItem(item);
                } else {
                    await EditItem(item);
                }
            }
        }

        //ROW DELETING
        private async void gridView2_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {
            GridView? view = sender as GridView;
            if (view.GetFocusedRow != null) {
                ItemListDto? item = view.GetFocusedRow() as ItemListDto;
                await DeleteItem(item.Id);
            }
        }

        //GET REQUEST
        private async Task<List<ItemListDto?>> GetItems() {
            var response = await client.GetAsync("item");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ItemListDto?>>(content);
            }
            return null;
        }

        //POST REQUEST
        private async Task NewItem(ItemListDto? item) {
            var response = await client.PostAsJsonAsync("item", item);
            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Success!", "Success Message");
            } else {
                MessageBox.Show("Error! Try again.", "Alert Message");
                await SetControlProperties();
            }
        }

        //PUT REQUEST
        private async Task EditItem(ItemListDto? item) {

            var response = await client.PutAsJsonAsync("item", item);

            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Success!", "Success Message");
            } else {
                MessageBox.Show("Item could not be updated.", "Alert Message");
                await SetControlProperties();
            }
        }

        //DELETE REQUEST
        private async Task DeleteItem(int id) {
            var response = await client.DeleteAsync($"item/{id}");
            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Success!", "Success Message");
            } else {
                MessageBox.Show("Transactioncould not be deleted. It exists in Transactions", "Alert Message");
                await SetControlProperties();
            }
        }


        private void btnBack_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
