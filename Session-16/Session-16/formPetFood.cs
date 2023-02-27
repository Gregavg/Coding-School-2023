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
    public partial class FormPetFood : DevExpress.XtraEditors.XtraForm {
        public FormPetFood() {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FormPetFood_Load(object sender, EventArgs e) {
            SetControlPropertiesDB();
        }

        private void SetControlPropertiesDB() {

            PetFoodRepo petFoodRepo = new PetFoodRepo();

            ////Pet Food binding Source
            bsPetFoodDX.DataSource = petFoodRepo.GetAll();
            grvPetFood.DataSource = bsPetFoodDX;


        }

        private void gridView4_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {
            GridView view = sender as GridView;
            PetFood petFood = view.GetFocusedRow() as PetFood;
            PetFoodRepo petFoodRepo = new PetFoodRepo();
            try {
                petFoodRepo.Add(petFood);
            }
            catch {
                petFoodRepo.Update(petFood.ID, petFood);
            }
        }
    }
}