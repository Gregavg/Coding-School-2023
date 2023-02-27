using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Session_16.Model;
using Session_16.ORM.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_16 {
    public partial class FormEmployees : DevExpress.XtraEditors.XtraForm {
        public FormEmployees() {
            InitializeComponent();
        }

        private void FormEmployees_Load(object sender, EventArgs e) {
            SetControlPropertiesDB();
        }

        private void SetControlPropertiesDB() {

            EmployeeRepo employeeRepo = new EmployeeRepo();
            ////Customers binding Source
            bsEmployeesDX.DataSource = employeeRepo.GetAll();
            grvEmployees.DataSource = bsEmployeesDX;

        }

        private void btnBack_Click(object sender, EventArgs e) {
            //go back
            this.Close();
        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {
            try {

                GridView view = sender as GridView;
                Employee employee = view.GetFocusedRow() as Employee;
                EmployeeRepo employeeRepo = new EmployeeRepo();
                employeeRepo.Delete(employee.ID);
            }
            catch {
                System.Windows.MessageBox.Show("Try again with a correct entry!");
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {
            GridView view = sender as GridView;
            Employee employee = view.GetFocusedRow() as Employee;
            EmployeeRepo employeeRepo = new EmployeeRepo();
            try {
                employeeRepo.Add(employee);
            }
            catch {
                employeeRepo.Update(employee.ID, employee);
            }

        }
    }
}