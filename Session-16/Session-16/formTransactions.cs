using DevExpress.Map.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.BandedGrid;
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
    public partial class FormTransactions : DevExpress.XtraEditors.XtraForm {
        public FormTransactions() {
            InitializeComponent();
        }

        private void FormTransactions_Load(object sender, EventArgs e) {
            SetControlPropertiesDB();
        }


        private void SetControlPropertiesDB() {

            TransactionRepo transactionRepo = new TransactionRepo();

            bsTransactionsDX.DataSource = transactionRepo.GetAll();
            grvTransactions.DataSource = bsTransactionsDX;

            SetLookUpEdit();
        }


        public void SetLookUpEdit() {
            //look up edit CUSTOMERS
            CustomerRepo customerRepo = new CustomerRepo();
            repCustomers.DataSource = customerRepo.GetAll();
            repCustomers.DisplayMember = "Surname";
            repCustomers.ValueMember = "ID";

            //look up edit EMPLOYEES
            EmployeeRepo employeeRepo = new EmployeeRepo();
            repEmployees.DataSource = employeeRepo.GetAll();
            repEmployees.DisplayMember = "Surname";
            repEmployees.ValueMember = "ID";

            //look up edit Pets
            PetRepo petsRepo = new PetRepo();
            repPets.DataSource = petsRepo.GetAllAvailable();
            repPets.DisplayMember = "Breed";
            repPets.ValueMember = "ID";


            //look up edit PetFoods
            PetFoodRepo petFoodRepo = new PetFoodRepo();
            repPetFood.DataSource = petFoodRepo.GetAll();
            repPetFood.DisplayMember = "Animaltype";
            repPetFood.ValueMember = "ID";
        }





        private void btnBack_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void gridView5_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {
            try {
                GridView? view = sender as GridView;
                Transaction? transaction = view.GetFocusedRow() as Transaction;
                TransactionRepo transactionRepo = new TransactionRepo();
                Transaction? helper = transactionRepo.GetById(transaction.ID);
                
                if (helper == null) {
                    transactionRepo.Add(transaction);
                } else {
                    transactionRepo.Update(transaction.ID, transaction);
                }

                if (transaction.PetID != null) {
                    PetRepo petRepo = new PetRepo();
                    petRepo.UpdateTransactionId(transaction.ID, transaction.PetID);
                }

                SetLookUpEdit();
            }
            catch (NullReferenceException ex) {
                throw ex;
            }


        }

        private void gridView5_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
            GridView view = sender as GridView;
            if (view == null) return;
            if (e.Column.Caption != "PetFood" && e.Column.Caption != "Pet") return;


            switch (e.Column.Caption) {

                case "Pet Food":
                    Guid? cellValuePetFood = e.Value as Guid?;
                    break;
                case "Pet":
                    Guid? cellValuePet = e.Value as Guid?;
                    PetRepo petRepo = new PetRepo();
                    Pet newPet = petRepo.GetById(cellValuePet.Value);
                    
                    view.SetFocusedRowCellValue("PetPrice", newPet.Price);
                    //gridView5.SetFocusedRowCellValue("Pet Price", newPet.Price);
                    break;
                default:
                    // code block
                    break;
            }
            //SetLookUpEdit();

            //var cellValue = e.Value.ToString() + " " + view.GetRowCellValue(e.RowHandle, view.Columns["Pet"]).ToString();
            //view.SetRowCellValue(e.RowHandle, view.Columns["Price"], tester);
        }

        private void gridView5_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {
            try {

                GridView? view = sender as GridView;
                Transaction? transaction = view.GetFocusedRow() as Transaction;
                TransactionRepo transactionRepo = new TransactionRepo();
                transactionRepo.Delete(transaction.ID);

                //delete pet id
                if (transaction.PetID != null) {
                    PetRepo petRepo = new PetRepo();
                    petRepo.ClearTransaction(transaction.ID);
                }


                SetLookUpEdit();
            }
            catch {
                System.Windows.MessageBox.Show("Try again with a correct entry!");
            }
        }
    }
}