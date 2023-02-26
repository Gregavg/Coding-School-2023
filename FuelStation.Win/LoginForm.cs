using FuelStation.Model.Enums;
using System.Net.Http;
using FuelStation.Win.Authentication;
using System.Security.Claims;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DevExpress.XtraBars.Docking;
using FuelStation.Web.Shared;
//inject AuthenticationStateProvider AuthenticationStateProvider

namespace FuelStation.Win {
    public partial class LoginForm : Form {
        private EmployeeType? _userLogin;
        private readonly HttpClient client;
        private readonly CustomAuthenticationStateProvider _authProvider;
        private LoginRequest loginRequest;

        public LoginForm(CustomAuthenticationStateProvider authProvider) {
            loginRequest = new LoginRequest();
            client = new HttpClient();
            _authProvider = authProvider;
            InitializeComponent();
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
            await Login(username, password);
        }

        private async Task Login(string username, string password) {


            loginRequest.UserName = username;
            loginRequest.Password = password;
            var response = await client.PostAsJsonAsync("/api/Account/Login", loginRequest);

            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Login Success!");
                //var user = new ClaimsPrincipal(new ClaimsIdentity(new[]
                //{
                //    new Claim(ClaimTypes.Name, loginModel.Username)
                //}, "apiauth"));

                //await _authProvider.MarkUserAsAuthenticated(user);

                //MessageBox.Show("Login successful!");
            } else {
                MessageBox.Show("Invalid username or password.");
                buttonLogin.Enabled = true;
            }
        }
    }
}
