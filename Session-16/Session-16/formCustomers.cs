using DevExpress.Emf;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.EntityFrameworkCore;
using Session_16.Model;
using Session_16.ORM.Repositories;
using System.Windows.Controls;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;

namespace Session_16 {
    public partial class FormCustomers : DevExpress.XtraEditors.XtraForm {
        public FormCustomers() {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e) {
            SetControlPropertiesDB();
        }

        public void loadFromDB() {

        }


        private void SetControlPropertiesDB() {

            //Customers binding Source
            CustomerRepo customerRepo = new CustomerRepo();
            bsCustomersDX.DataSource = customerRepo.GetAll();
            grvCustomers.DataSource = bsCustomersDX;

        }



        private void btnBack_Click(object sender, EventArgs e) {
            //go back
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e) {

        }

        private void grvCustomers_Click(object sender, EventArgs e) {

        }

        void gridView1_RowUpdated(object sender, RowObjectEventArgs e) {
            SetControlPropertiesDB();
        }


        private void gridView2_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {
            try {

                GridView view = sender as GridView;
                Customer customer = view.GetFocusedRow() as Customer;
                CustomerRepo customerRepo = new CustomerRepo();
                customerRepo.Delete(customer.ID);
            }
            catch {
                System.Windows.MessageBox.Show("Try again with a correct entry!");
            }
        }

        private void gridView2_ValidateRow(object sender, ValidateRowEventArgs e) {

            GridView view = sender as GridView;
            Customer customer = view.GetFocusedRow() as Customer;
            CustomerRepo customerRepo = new CustomerRepo();

            try {

                customerRepo.Add(customer);
                
                
            }
            catch {
                customerRepo.Update(customer.ID, customer);
            }

        }


    }
}