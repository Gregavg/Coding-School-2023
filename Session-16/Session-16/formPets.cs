using DevExpress.XtraEditors;
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
    public partial class FormPets : DevExpress.XtraEditors.XtraForm {
        public FormPets() {
            InitializeComponent();
        }



        private void FormPets_Load_1(object sender, EventArgs e) {
            SetControlPropertiesDB();
        }

        private void SetControlPropertiesDB() {

            PetRepo petRepo = new PetRepo();
            ////Pet binding Source
            bsPetsDX.DataSource = petRepo.GetAll(); ;
            grvPets.DataSource = bsPetsDX;


        }

        private void btnDelete_Click(object sender, EventArgs e) {

        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void gridView3_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {
            GridView view = sender as GridView;
            Pet pet = view.GetFocusedRow() as Pet;
            PetRepo petRepo = new PetRepo();
            
            try {
                petRepo.Add(pet);
            }
            catch {
                petRepo.Update(pet.ID,pet);
                System.Windows.MessageBox.Show("Try again with a correct entry!");
            }
        }
    }
}