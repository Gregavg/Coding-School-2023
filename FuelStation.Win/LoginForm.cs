using FuelStation.Model.Enums;
using FuelStation.Web.Shared;
using Microsoft.JSInterop;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net;
using Microsoft.AspNetCore.Components.Authorization;

namespace FuelStation.Win {
    public partial class LoginForm : Form {
        private EmployeeType? _userLogin;
        private readonly HttpClient client;

        public LoginForm() {

            InitializeComponent();
            client = new HttpClient();
            ConnectionUri connectionUri = new ConnectionUri();
            client.BaseAddress = new Uri(connectionUri.GetUri());
        }

        private void LoginForm_Load(object sender, EventArgs e) {
            buttonLogin.Enabled = true;
        }

        private void btnManager_Click(object sender, EventArgs e) {
            _userLogin = EmployeeType.Manager;
            OpenForm(_userLogin, 583, 448);
        }

        private void btnCashier_Click(object sender, EventArgs e) {
            _userLogin = EmployeeType.Cashier;
            OpenForm(_userLogin, 425, 405);

        }

        private void btnStaff_Click(object sender, EventArgs e) {
            _userLogin = EmployeeType.Staff;
            OpenForm(_userLogin, 286, 361);
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
            await Authenticate(username, password);
        }

        private async Task Authenticate(string username, string password) {

            //LoginRequest loginRequest = new ();
            //var loginResponse = await client.PostAsJsonAsync<LoginRequest>("/api/Account/Login", loginRequest);

            //if (loginResponse.IsSuccessStatusCode) {
            //    var userSession = await loginResponse.Content.ReadFromJsonAsync<UserSession>();
            //    var customAuthStateProvider = (CustomAuthenticationStateProvider)authStateProvider;
            //    await customAuthStateProvider.UpdateAuthenticationState(userSession);

            //    FormMenu formMenu = new FormMenu(user);
            //} else if (loginResponse.StatusCode == HttpStatusCode.Unauthorized) {
            //    await jsRuntime.InvokeVoidAsync("alert", "Invalid User Name or Password");
            //    return;
            //}
        }
    }
}
