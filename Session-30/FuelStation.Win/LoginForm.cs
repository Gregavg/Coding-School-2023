using FuelStation.Model.Enums;
using System.Net.Http;
using FuelStation.Win.Authentication;
using FuelStation.Web.Shared;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Authorization;

namespace FuelStation.Win {
    public partial class LoginForm : Form {
        private EmployeeType? _userLogin;
        private readonly HttpClient client;
        //private AuthenticationStateProvider _authProvider;
        private LoginRequest loginRequest;

        public LoginForm(/*AuthenticationStateProvider authProvider*/) {
            loginRequest = new LoginRequest();
            client = new HttpClient();
            //_authProvider = authProvider;
            InitializeComponent();
            ConnectionUri connectionUri = new ConnectionUri();
            client.BaseAddress = new Uri(connectionUri.GetUri());
        }

        private void LoginForm_Load(object sender, EventArgs e) {
            buttonLogin.Enabled = true;
        }

        private void btnManager_Click(object sender, EventArgs e) {
            OpenManager();

        }

        private void btnCashier_Click(object sender, EventArgs e) {

            OpenCashier();
        }

        private void btnStaff_Click(object sender, EventArgs e) {
            OpenStaff();
        }

        private void OpenForm(EmployeeType? user, int x, int y) {
            this.Hide();

            FormMenu formMenu = new FormMenu(user);

            formMenu.FormClosed += (s, args) => this.Show();
            formMenu.Size = new Size(x, y);
            formMenu.ShowDialog();
        }

        private async void button1_Click(object sender, EventArgs e) {
            buttonLogin.Enabled = false;
            string username = textUsername.Text;
            string password = textPassword.Text;
            await Login(username, password);
        }

        private async Task Login(string username, string password) {


            loginRequest.UserName = username;
            loginRequest.Password = password;
            var loginResponse = await client.PostAsJsonAsync("/api/Account/Login", loginRequest);

            if (loginResponse.IsSuccessStatusCode) {
                MessageBox.Show("Login Success!");

                if (username == "manager" || username == "Manager") {
                    OpenManager();
                } else if (username == "cashier" || username == "Cashier") {
                    OpenCashier();
                } else if (username == "staff" || username == "Staff") {
                    OpenStaff();
                }
                buttonLogin.Enabled = true;
            } else {
                MessageBox.Show("Invalid username or password.");
                buttonLogin.Enabled = true;
            }
        }


        private void OpenManager() {
            _userLogin = EmployeeType.Manager;
            OpenForm(_userLogin, 583, 448);
        }
        private void OpenCashier() {
            _userLogin = EmployeeType.Cashier;
            OpenForm(_userLogin, 425, 405);
        }
        private void OpenStaff() {
            _userLogin = EmployeeType.Staff;
            OpenForm(_userLogin, 286, 361);
        }


        private void textPassword_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                button1_Click(sender, e);
            }
        }
    }
}
