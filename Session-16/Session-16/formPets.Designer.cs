namespace Session_16 {
    partial class FormPets {
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
            this.grvPets = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPetType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetBreed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetHealthStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetTransaction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.bsPetsDX = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetsDX)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.grvPets);
            this.panelControl1.Location = new System.Drawing.Point(80, 46);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(751, 199);
            this.panelControl1.TabIndex = 1;
            // 
            // grvPets
            // 
            this.grvPets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvPets.Location = new System.Drawing.Point(2, 2);
            this.grvPets.MainView = this.gridView3;
            this.grvPets.Name = "grvPets";
            this.grvPets.Size = new System.Drawing.Size(747, 195);
            this.grvPets.TabIndex = 1;
            this.grvPets.UseEmbeddedNavigator = true;
            this.grvPets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPetType,
            this.colPetBreed,
            this.colPetHealthStatus,
            this.colPetCost,
            this.colPetPrice,
            this.colPetDate,
            this.colPetTransaction});
            this.gridView3.GridControl = this.grvPets;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView3_ValidateRow);
            // 
            // colPetType
            // 
            this.colPetType.Caption = "Type";
            this.colPetType.FieldName = "Animaltype";
            this.colPetType.Name = "colPetType";
            this.colPetType.Visible = true;
            this.colPetType.VisibleIndex = 1;
            // 
            // colPetBreed
            // 
            this.colPetBreed.Caption = "Breed";
            this.colPetBreed.FieldName = "Breed";
            this.colPetBreed.Name = "colPetBreed";
            this.colPetBreed.Visible = true;
            this.colPetBreed.VisibleIndex = 2;
            // 
            // colPetHealthStatus
            // 
            this.colPetHealthStatus.Caption = "Health Status";
            this.colPetHealthStatus.FieldName = "Petstatus";
            this.colPetHealthStatus.Name = "colPetHealthStatus";
            this.colPetHealthStatus.Visible = true;
            this.colPetHealthStatus.VisibleIndex = 3;
            // 
            // colPetCost
            // 
            this.colPetCost.Caption = "Cost";
            this.colPetCost.FieldName = "Cost";
            this.colPetCost.Name = "colPetCost";
            this.colPetCost.Visible = true;
            this.colPetCost.VisibleIndex = 4;
            // 
            // colPetPrice
            // 
            this.colPetPrice.Caption = "Price";
            this.colPetPrice.FieldName = "Price";
            this.colPetPrice.Name = "colPetPrice";
            this.colPetPrice.Visible = true;
            this.colPetPrice.VisibleIndex = 5;
            // 
            // colPetDate
            // 
            this.colPetDate.Caption = "Date Received";
            this.colPetDate.FieldName = "Bought";
            this.colPetDate.Name = "colPetDate";
            this.colPetDate.Visible = true;
            this.colPetDate.VisibleIndex = 0;
            // 
            // colPetTransaction
            // 
            this.colPetTransaction.Caption = "PetTransaction";
            this.colPetTransaction.FieldName = "Transaction";
            this.colPetTransaction.Name = "colPetTransaction";
            this.colPetTransaction.Visible = true;
            this.colPetTransaction.VisibleIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(82, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 25);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Pets";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Location = new System.Drawing.Point(858, 593);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "BACK";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 655);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormPets";
            this.Text = "My Pet Shop";
            this.Load += new System.EventHandler(this.FormPets_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetsDX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grvPets;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colPetType;
        private DevExpress.XtraGrid.Columns.GridColumn colPetBreed;
        private DevExpress.XtraGrid.Columns.GridColumn colPetHealthStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colPetCost;
        private DevExpress.XtraGrid.Columns.GridColumn colPetPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPetDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private BindingSource bsPetsDX;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraGrid.Columns.GridColumn colPetTransaction;
    }
}