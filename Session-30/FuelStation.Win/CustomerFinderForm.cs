using DevExpress.Pdf.Native.BouncyCastle.Asn1.X509;
using DevExpress.XtraGrid.Views.Grid;
using FuelStation.Web.Shared;
using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;

namespace FuelStation.Win {
    public partial class CustomerFinderForm : Form {
        private readonly HttpClient client;

        public CustomerFinderForm() {
            InitializeComponent();
            client = new HttpClient();
            ConnectionUri connectionUri = new();
            client.BaseAddress = new Uri(connectionUri.GetUri());
        }



        private void button1_Click(object sender, EventArgs e) {
            button1.Enabled = false;
            string inputText = boxCustomerFind.Text;

            _ = FormFinderController(inputText);
        }

        private async Task FormFinderController(string input) {
            var customer = await CustomerDetails(input);
            if (customer != null) {
                OpenTransactionsForm(customer);
            } else {
                OpenCustomersForm();
            }
        }

        private void OpenTransactionsForm(CustomerListDto item) {
            this.Hide();

            TransactionsForm TransForm = new TransactionsForm(item);

            TransForm.FormClosed += (s, args) => this.Close();
            TransForm.ShowDialog();
        }

        private void OpenCustomersForm() {
            MessageBox.Show("Customer not found! Please insert new customer.", "Message");
            this.Hide();
            CustomersForm CustForm = new CustomersForm();
            CustForm.FormClosed += (s, args) => this.Close();
            CustForm.ShowDialog();
        }

        private async Task<CustomerListDto?> CustomerDetails(string cardnumber) {

            var response = await client.GetAsync($"customer/cardnumber/{cardnumber}");
            if (response.IsSuccessStatusCode) {
                return await response.Content.ReadAsAsync<CustomerListDto>();
            }
            return null;
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void CustomerFinderForm_Load(object sender, EventArgs e) {
                
        }

        private void boxCustomerFind_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                button1_Click(sender, e);
            }
        }
    }
}

