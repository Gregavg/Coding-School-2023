namespace Session_16 {
    partial class FormPetFood {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grvPetFood = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPetAnimalType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetFoodPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetFoodCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetFoodQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.bsPetFoodDX = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetFoodDX)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.grvPetFood);
            this.panelControl1.Location = new System.Drawing.Point(84, 24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(751, 199);
            this.panelControl1.TabIndex = 18;
            // 
            // grvPetFood
            // 
            this.grvPetFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvPetFood.Location = new System.Drawing.Point(2, 2);
            this.grvPetFood.MainView = this.gridView4;
            this.grvPetFood.Name = "grvPetFood";
            this.grvPetFood.Size = new System.Drawing.Size(747, 195);
            this.grvPetFood.TabIndex = 1;
            this.grvPetFood.UseEmbeddedNavigator = true;
            this.grvPetFood.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPetAnimalType,
            this.colPetFoodPrice,
            this.colPetFoodCost,
            this.colPetFoodQty});
            this.gridView4.GridControl = this.grvPetFood;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView4_ValidateRow);
            // 
            // colPetAnimalType
            // 
            this.colPetAnimalType.Caption = "Animal Type";
            this.colPetAnimalType.FieldName = "Animaltype";
            this.colPetAnimalType.Name = "colPetAnimalType";
            this.colPetAnimalType.Visible = true;
            this.colPetAnimalType.VisibleIndex = 0;
            // 
            // colPetFoodPrice
            // 
            this.colPetFoodPrice.Caption = "Price";
            this.colPetFoodPrice.FieldName = "Price";
            this.colPetFoodPrice.Name = "colPetFoodPrice";
            this.colPetFoodPrice.Visible = true;
            this.colPetFoodPrice.VisibleIndex = 1;
            // 
            // colPetFoodCost
            // 
            this.colPetFoodCost.Caption = "Cost";
            this.colPetFoodCost.FieldName = "Cost";
            this.colPetFoodCost.Name = "colPetFoodCost";
            this.colPetFoodCost.Visible = true;
            this.colPetFoodCost.VisibleIndex = 2;
            // 
            // colPetFoodQty
            // 
            this.colPetFoodQty.Caption = "Quantity";
            this.colPetFoodQty.FieldName = "Qty";
            this.colPetFoodQty.Name = "colPetFoodQty";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(86, -5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 25);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Pet Food";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Location = new System.Drawing.Point(858, 593);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "BACK";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormPetFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 655);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormPetFood";
            this.Text = "My Pet Shop";
            this.Load += new System.EventHandler(this.FormPetFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvPetFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetFoodDX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grvPetFood;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colPetAnimalType;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodCost;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodQty;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private BindingSource bsPetFoodDX;
    }
}