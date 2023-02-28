using FuelStation.Model.Enums;
using System.Windows.Forms;

namespace FuelStation.Win {
    public partial class FormMenu : Form {
        private EmployeeType? _userLogin;

        public FormMenu(EmployeeType? userLogin) {
            _userLogin = userLogin;
            InitializeComponent();
            HideButtonsForRestrictedUsers();

        }

        private void FormMenu_Load(object sender, EventArgs e) {

        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Close();
        }



        private void HideButtonsForRestrictedUsers() {

            btnCustomers.Visible = false;
            btnTransactions.Visible = false;
            btnItems.Visible = false;
            
            labelCustomers.Visible = false;
            labelTransactions.Visible = false;
            labelItems.Visible = false;
            labelItems.Location = new Point(399, 71);
            ;
            if (_userLogin == EmployeeType.Manager) {
                btnCustomers.Visible = true;
                btnTransactions.Visible = true;
                btnItems.Visible = true;

                labelCustomers.Visible = true;
                labelTransactions.Visible = true;
                labelItems.Visible = true;
            } else if (_userLogin == EmployeeType.Staff) {
                btnItems.Visible = true;
                labelItems.Visible = true;
                labelItems.Left = 100;
            } else if (_userLogin == EmployeeType.Cashier) {
                btnCustomers.Visible = true;
                btnTransactions.Visible = true;
                labelCustomers.Visible = true;
                labelTransactions.Visible = true;
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e) {
            CustomersForm custForm = new CustomersForm();
            custForm.ShowDialog();
        }

        private void btnItems_Click(object sender, EventArgs e) {

            ItemsForm itemForm = new ItemsForm();
            itemForm.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e) {
            this.Hide();
            CustomerFinderForm trForm = new CustomerFinderForm();

            trForm.FormClosed += (s, args) => this.Show();
            trForm.ShowDialog();
        }


    }
}
