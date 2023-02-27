namespace Session_16 {
    partial class FormTransactions {
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
            this.grvTransactions = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCustomers = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTransactionsEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEmployees = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTransactionsPet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repPets = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTransactionsPetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsPetFood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repPetFood = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTransactionsPetFoodQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsPetFoodPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsTransactionsDX = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPetFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionsDX)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.grvTransactions);
            this.panelControl1.Location = new System.Drawing.Point(71, 39);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(794, 211);
            this.panelControl1.TabIndex = 2;
            // 
            // grvTransactions
            // 
            this.grvTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvTransactions.Location = new System.Drawing.Point(2, 2);
            this.grvTransactions.MainView = this.gridView5;
            this.grvTransactions.Name = "grvTransactions";
            this.grvTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCustomers,
            this.repEmployees,
            this.repPets,
            this.repPetFood});
            this.grvTransactions.Size = new System.Drawing.Size(790, 207);
            this.grvTransactions.TabIndex = 1;
            this.grvTransactions.UseEmbeddedNavigator = true;
            this.grvTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionsID,
            this.colTransactionsDate,
            this.colTransactionsCustomer,
            this.colTransactionsEmployee,
            this.colTransactionsPet,
            this.colTransactionsPetPrice,
            this.colTransactionsPetFood,
            this.colTransactionsPetFoodQty,
            this.colTransactionsPetFoodPrice,
            this.colTransactionsTotalPrice});
            this.gridView5.GridControl = this.grvTransactions;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView5_CellValueChanged);
            this.gridView5.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView5_RowDeleting);
            this.gridView5.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView5_ValidateRow);
            // 
            // colTransactionsID
            // 
            this.colTransactionsID.Caption = "ID";
            this.colTransactionsID.FieldName = "ID";
            this.colTransactionsID.Name = "colTransactionsID";
            this.colTransactionsID.Visible = true;
            this.colTransactionsID.VisibleIndex = 0;
            // 
            // colTransactionsDate
            // 
            this.colTransactionsDate.Caption = "Date";
            this.colTransactionsDate.FieldName = "Date";
            this.colTransactionsDate.Name = "colTransactionsDate";
            this.colTransactionsDate.Visible = true;
            this.colTransactionsDate.VisibleIndex = 1;
            // 
            // colTransactionsCustomer
            // 
            this.colTransactionsCustomer.Caption = "Customer";
            this.colTransactionsCustomer.ColumnEdit = this.repCustomers;
            this.colTransactionsCustomer.FieldName = "CustomerID";
            this.colTransactionsCustomer.Name = "colTransactionsCustomer";
            this.colTransactionsCustomer.Visible = true;
            this.colTransactionsCustomer.VisibleIndex = 2;
            // 
            // repCustomers
            // 
            this.repCustomers.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.repCustomers.AutoHeight = false;
            this.repCustomers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCustomers.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Phone", "Phone")});
            this.repCustomers.Name = "repCustomers";
            this.repCustomers.NullText = "";
            // 
            // colTransactionsEmployee
            // 
            this.colTransactionsEmployee.Caption = "Employee";
            this.colTransactionsEmployee.ColumnEdit = this.repEmployees;
            this.colTransactionsEmployee.FieldName = "EmployeeID";
            this.colTransactionsEmployee.Name = "colTransactionsEmployee";
            this.colTransactionsEmployee.Visible = true;
            this.colTransactionsEmployee.VisibleIndex = 3;
            // 
            // repEmployees
            // 
            this.repEmployees.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.repEmployees.AutoHeight = false;
            this.repEmployees.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repEmployees.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname")});
            this.repEmployees.Name = "repEmployees";
            this.repEmployees.NullText = "";
            // 
            // colTransactionsPet
            // 
            this.colTransactionsPet.Caption = "Pet";
            this.colTransactionsPet.ColumnEdit = this.repPets;
            this.colTransactionsPet.FieldName = "PetID";
            this.colTransactionsPet.Name = "colTransactionsPet";
            this.colTransactionsPet.Visible = true;
            this.colTransactionsPet.VisibleIndex = 4;
            // 
            // repPets
            // 
            this.repPets.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.repPets.AutoHeight = false;
            this.repPets.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repPets.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Animaltype", "Animal Type"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Breed", "Breed"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Petstatus", "Pet Status")});
            this.repPets.Name = "repPets";
            this.repPets.NullText = "";
            // 
            // colTransactionsPetPrice
            // 
            this.colTransactionsPetPrice.Caption = "Pet Price";
            this.colTransactionsPetPrice.FieldName = "PetPrice";
            this.colTransactionsPetPrice.Name = "colTransactionsPetPrice";
            this.colTransactionsPetPrice.Visible = true;
            this.colTransactionsPetPrice.VisibleIndex = 5;
            // 
            // colTransactionsPetFood
            // 
            this.colTransactionsPetFood.Caption = "Pet Food";
            this.colTransactionsPetFood.ColumnEdit = this.repPetFood;
            this.colTransactionsPetFood.FieldName = "PetFoodID";
            this.colTransactionsPetFood.Name = "colTransactionsPetFood";
            this.colTransactionsPetFood.Visible = true;
            this.colTransactionsPetFood.VisibleIndex = 6;
            // 
            // repPetFood
            // 
            this.repPetFood.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.repPetFood.AutoHeight = false;
            this.repPetFood.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repPetFood.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Animaltype", "Animal Type"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Qty", "Quantity")});
            this.repPetFood.Name = "repPetFood";
            this.repPetFood.NullText = "";
            // 
            // colTransactionsPetFoodQty
            // 
            this.colTransactionsPetFoodQty.Caption = "Pet Food Quantity";
            this.colTransactionsPetFoodQty.FieldName = "PetFoodQty";
            this.colTransactionsPetFoodQty.Name = "colTransactionsPetFoodQty";
            this.colTransactionsPetFoodQty.Visible = true;
            this.colTransactionsPetFoodQty.VisibleIndex = 7;
            // 
            // colTransactionsPetFoodPrice
            // 
            this.colTransactionsPetFoodPrice.Caption = "Pet Food Price";
            this.colTransactionsPetFoodPrice.FieldName = "PetFoodPrice";
            this.colTransactionsPetFoodPrice.Name = "colTransactionsPetFoodPrice";
            this.colTransactionsPetFoodPrice.Visible = true;
            this.colTransactionsPetFoodPrice.VisibleIndex = 8;
            // 
            // colTransactionsTotalPrice
            // 
            this.colTransactionsTotalPrice.Caption = "Total Price";
            this.colTransactionsTotalPrice.FieldName = "TotalPrice";
            this.colTransactionsTotalPrice.Name = "colTransactionsTotalPrice";
            this.colTransactionsTotalPrice.Visible = true;
            this.colTransactionsTotalPrice.VisibleIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Location = new System.Drawing.Point(858, 539);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "BACK";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(73, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(117, 25);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Transactions";
            // 
            // FormTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 601);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormTransactions";
            this.Text = "My Pet Shop";
            this.Load += new System.EventHandler(this.FormTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPetFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionsDX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grvTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsID;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsPet;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsPetPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsPetFood;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsPetFoodQty;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsPetFoodPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsTotalPrice;
        private BindingSource bsTransactionsDX;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCustomers;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repEmployees;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repPets;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repPetFood;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}