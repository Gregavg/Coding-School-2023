using FuelStation.Model.Enums;
using System.Windows.Forms;

namespace FuelStation.Win {
    public partial class LoginForm : Form {
        private EmployeeType? _userLogin;

        public LoginForm() {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) {
            
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
    }
}
