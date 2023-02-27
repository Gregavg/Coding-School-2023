namespace FuelStation.Win {
    partial class TransactionsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsForm));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grdTransactions = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionsDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colTransactionsEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEmployees = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTransactionsTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.grdTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coTLId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coTLTransactionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coTLItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemTree = new DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit();
            this.repositoryItemTreeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.coTLQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.coTLItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coTLNetValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coTLDiscountPercentage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coTLDiscountValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coTLTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
            this.labelCustomer = new DevExpress.XtraEditors.LabelControl();
            this.comboItems = new System.Windows.Forms.ComboBox();
            this.bsTransactionLines = new System.Windows.Forms.BindingSource(this.components);
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            this.listItems = new System.Windows.Forms.ListBox();
            this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
            this.bsItemTypes = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteTransactionLines = new System.Windows.Forms.Button();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemTypes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(239, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(122, 24);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "Transactions";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.grdTransactions);
            this.panelControl1.Location = new System.Drawing.Point(234, 69);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(888, 197);
            this.panelControl1.TabIndex = 28;
            // 
            // grdTransactions
            // 
            this.grdTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTransactions.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grdTransactions.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.grdTransactions.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grdTransactions.Location = new System.Drawing.Point(2, 2);
            this.grdTransactions.MainView = this.gridView5;
            this.grdTransactions.Name = "grdTransactions";
            this.grdTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEmployees,
            this.repositoryItemDateEdit1});
            this.grdTransactions.Size = new System.Drawing.Size(884, 193);
            this.grdTransactions.TabIndex = 1;
            this.grdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionsDate,
            this.colTransactionsEmployee,
            this.colTransactionsTotalValue,
            this.colTransactionsPaymentMethod,
            this.colTransactionsID,
            this.colTransactionsCustomerId});
            this.gridView5.GridControl = this.grdTransactions;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsDetail.EnableMasterViewMode = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView5_CellValueChanged);
            this.gridView5.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView5_RowDeleting);
            // 
            // colTransactionsDate
            // 
            this.colTransactionsDate.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colTransactionsDate.AppearanceCell.Options.UseFont = true;
            this.colTransactionsDate.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colTransactionsDate.AppearanceHeader.Options.UseFont = true;
            this.colTransactionsDate.Caption = "Date";
            this.colTransactionsDate.ColumnEdit = this.repositoryItemDateEdit1;
            this.colTransactionsDate.FieldName = "Date";
            this.colTransactionsDate.Name = "colTransactionsDate";
            this.colTransactionsDate.Visible = true;
            this.colTransactionsDate.VisibleIndex = 0;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colTransactionsEmployee
            // 
            this.colTransactionsEmployee.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colTransactionsEmployee.AppearanceCell.Options.UseFont = true;
            this.colTransactionsEmployee.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colTransactionsEmployee.AppearanceHeader.Options.UseFont = true;
            this.colTransactionsEmployee.Caption = "Employee";
            this.colTransactionsEmployee.ColumnEdit = this.repEmployees;
            this.colTransactionsEmployee.FieldName = "EmployeeId";
            this.colTransactionsEmployee.Name = "colTransactionsEmployee";
            this.colTransactionsEmployee.Visible = true;
            this.colTransactionsEmployee.VisibleIndex = 1;
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
            // colTransactionsTotalValue
            // 
            this.colTransactionsTotalValue.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colTransactionsTotalValue.AppearanceCell.Options.UseFont = true;
            this.colTransactionsTotalValue.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colTransactionsTotalValue.AppearanceHeader.Options.UseFont = true;
            this.colTransactionsTotalValue.Caption = "Total Value";
            this.colTransactionsTotalValue.FieldName = "TotalValue";
            this.colTransactionsTotalValue.Name = "colTransactionsTotalValue";
            this.colTransactionsTotalValue.OptionsColumn.AllowEdit = false;
            this.colTransactionsTotalValue.Visible = true;
            this.colTransactionsTotalValue.VisibleIndex = 2;
            // 
            // colTransactionsPaymentMethod
            // 
            this.colTransactionsPaymentMethod.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colTransactionsPaymentMethod.AppearanceCell.Options.UseFont = true;
            this.colTransactionsPaymentMethod.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colTransactionsPaymentMethod.AppearanceHeader.Options.UseFont = true;
            this.colTransactionsPaymentMethod.Caption = "Payment Method";
            this.colTransactionsPaymentMethod.FieldName = "PaymentMethod";
            this.colTransactionsPaymentMethod.Name = "colTransactionsPaymentMethod";
            this.colTransactionsPaymentMethod.Visible = true;
            this.colTransactionsPaymentMethod.VisibleIndex = 3;
            // 
            // colTransactionsID
            // 
            this.colTransactionsID.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colTransactionsID.AppearanceCell.Options.UseFont = true;
            this.colTransactionsID.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colTransactionsID.AppearanceHeader.Options.UseFont = true;
            this.colTransactionsID.Caption = "Id";
            this.colTransactionsID.FieldName = "Id";
            this.colTransactionsID.Name = "colTransactionsID";
            this.colTransactionsID.OptionsColumn.AllowEdit = false;
            // 
            // colTransactionsCustomerId
            // 
            this.colTransactionsCustomerId.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colTransactionsCustomerId.AppearanceCell.Options.UseFont = true;
            this.colTransactionsCustomerId.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colTransactionsCustomerId.AppearanceHeader.Options.UseFont = true;
            this.colTransactionsCustomerId.Caption = "CustomerId";
            this.colTransactionsCustomerId.FieldName = "CustomerId";
            this.colTransactionsCustomerId.Name = "colTransactionsCustomerId";
            this.colTransactionsCustomerId.OptionsColumn.AllowEdit = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(234, 307);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(183, 24);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Transactions Items";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.grdTransactionLines);
            this.panelControl2.Location = new System.Drawing.Point(234, 334);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(690, 220);
            this.panelControl2.TabIndex = 30;
            // 
            // grdTransactionLines
            // 
            this.grdTransactionLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTransactionLines.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grdTransactionLines.Location = new System.Drawing.Point(2, 2);
            this.grdTransactionLines.MainView = this.gridView1;
            this.grdTransactionLines.Name = "grdTransactionLines";
            this.grdTransactionLines.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemTree,
            this.repositoryItemSpinEdit1});
            this.grdTransactionLines.Size = new System.Drawing.Size(686, 216);
            this.grdTransactionLines.TabIndex = 1;
            this.grdTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coTLId,
            this.coTLTransactionId,
            this.coTLItemId,
            this.coTLQuantity,
            this.coTLItemPrice,
            this.coTLNetValue,
            this.coTLDiscountPercentage,
            this.coTLDiscountValue,
            this.coTLTotalValue});
            this.gridView1.GridControl = this.grdTransactionLines;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // coTLId
            // 
            this.coTLId.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLId.AppearanceCell.Options.UseFont = true;
            this.coTLId.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLId.AppearanceHeader.Options.UseFont = true;
            this.coTLId.Caption = "Id";
            this.coTLId.FieldName = "Id";
            this.coTLId.Name = "coTLId";
            // 
            // coTLTransactionId
            // 
            this.coTLTransactionId.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLTransactionId.AppearanceCell.Options.UseFont = true;
            this.coTLTransactionId.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLTransactionId.AppearanceHeader.Options.UseFont = true;
            this.coTLTransactionId.Caption = "TransactionId";
            this.coTLTransactionId.FieldName = "TransactionId";
            this.coTLTransactionId.Name = "coTLTransactionId";
            // 
            // coTLItemId
            // 
            this.coTLItemId.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLItemId.AppearanceCell.Options.UseFont = true;
            this.coTLItemId.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLItemId.AppearanceHeader.Options.UseFont = true;
            this.coTLItemId.Caption = "Item";
            this.coTLItemId.ColumnEdit = this.repItemTree;
            this.coTLItemId.FieldName = "ItemId";
            this.coTLItemId.Name = "coTLItemId";
            this.coTLItemId.OptionsColumn.AllowEdit = false;
            this.coTLItemId.Visible = true;
            this.coTLItemId.VisibleIndex = 0;
            // 
            // repItemTree
            // 
            this.repItemTree.AutoHeight = false;
            this.repItemTree.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemTree.Name = "repItemTree";
            this.repItemTree.TreeList = this.repositoryItemTreeListLookUpEdit1TreeList;
            // 
            // repositoryItemTreeListLookUpEdit1TreeList
            // 
            this.repositoryItemTreeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.repositoryItemTreeListLookUpEdit1TreeList.Name = "repositoryItemTreeListLookUpEdit1TreeList";
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.repositoryItemTreeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // coTLQuantity
            // 
            this.coTLQuantity.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLQuantity.AppearanceCell.Options.UseFont = true;
            this.coTLQuantity.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLQuantity.AppearanceHeader.Options.UseFont = true;
            this.coTLQuantity.Caption = "Quantity";
            this.coTLQuantity.ColumnEdit = this.repositoryItemSpinEdit1;
            this.coTLQuantity.FieldName = "Quantity";
            this.coTLQuantity.Name = "coTLQuantity";
            this.coTLQuantity.OptionsColumn.AllowEdit = false;
            this.coTLQuantity.Visible = true;
            this.coTLQuantity.VisibleIndex = 2;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // coTLItemPrice
            // 
            this.coTLItemPrice.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLItemPrice.AppearanceCell.Options.UseFont = true;
            this.coTLItemPrice.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLItemPrice.AppearanceHeader.Options.UseFont = true;
            this.coTLItemPrice.Caption = "Item Price";
            this.coTLItemPrice.FieldName = "ItemPrice";
            this.coTLItemPrice.Name = "coTLItemPrice";
            this.coTLItemPrice.OptionsColumn.AllowEdit = false;
            this.coTLItemPrice.Visible = true;
            this.coTLItemPrice.VisibleIndex = 1;
            // 
            // coTLNetValue
            // 
            this.coTLNetValue.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLNetValue.AppearanceCell.Options.UseFont = true;
            this.coTLNetValue.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLNetValue.AppearanceHeader.Options.UseFont = true;
            this.coTLNetValue.Caption = "Net Value";
            this.coTLNetValue.FieldName = "NetValue";
            this.coTLNetValue.Name = "coTLNetValue";
            this.coTLNetValue.OptionsColumn.AllowEdit = false;
            this.coTLNetValue.Visible = true;
            this.coTLNetValue.VisibleIndex = 3;
            // 
            // coTLDiscountPercentage
            // 
            this.coTLDiscountPercentage.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLDiscountPercentage.AppearanceCell.Options.UseFont = true;
            this.coTLDiscountPercentage.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLDiscountPercentage.AppearanceHeader.Options.UseFont = true;
            this.coTLDiscountPercentage.Caption = "Discount Percentage";
            this.coTLDiscountPercentage.FieldName = "DiscountPercentage";
            this.coTLDiscountPercentage.Name = "coTLDiscountPercentage";
            this.coTLDiscountPercentage.OptionsColumn.AllowEdit = false;
            this.coTLDiscountPercentage.Visible = true;
            this.coTLDiscountPercentage.VisibleIndex = 4;
            // 
            // coTLDiscountValue
            // 
            this.coTLDiscountValue.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLDiscountValue.AppearanceCell.Options.UseFont = true;
            this.coTLDiscountValue.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLDiscountValue.AppearanceHeader.Options.UseFont = true;
            this.coTLDiscountValue.Caption = "Discount Value";
            this.coTLDiscountValue.FieldName = "DiscountValue";
            this.coTLDiscountValue.Name = "coTLDiscountValue";
            this.coTLDiscountValue.OptionsColumn.AllowEdit = false;
            this.coTLDiscountValue.Visible = true;
            this.coTLDiscountValue.VisibleIndex = 5;
            // 
            // coTLTotalValue
            // 
            this.coTLTotalValue.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLTotalValue.AppearanceCell.Options.UseFont = true;
            this.coTLTotalValue.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coTLTotalValue.AppearanceHeader.Options.UseFont = true;
            this.coTLTotalValue.Caption = "Total Value";
            this.coTLTotalValue.FieldName = "TotalValue";
            this.coTLTotalValue.Name = "coTLTotalValue";
            this.coTLTotalValue.OptionsColumn.AllowEdit = false;
            this.coTLTotalValue.Visible = true;
            this.coTLTotalValue.VisibleIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(3, 658);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(227, 29);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelCustomer
            // 
            this.labelCustomer.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelCustomer.Appearance.Options.UseFont = true;
            this.labelCustomer.Location = new System.Drawing.Point(234, 12);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(245, 24);
            this.labelCustomer.TabIndex = 33;
            this.labelCustomer.Text = "Customer\'s Transactions:";
            // 
            // comboItems
            // 
            this.comboItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboItems.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboItems.FormattingEnabled = true;
            this.comboItems.Location = new System.Drawing.Point(945, 334);
            this.comboItems.Name = "comboItems";
            this.comboItems.Size = new System.Drawing.Size(175, 25);
            this.comboItems.TabIndex = 34;
            this.comboItems.SelectedIndexChanged += new System.EventHandler(this.comboItems_SelectedIndexChanged);
            // 
            // listItems
            // 
            this.listItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listItems.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listItems.FormattingEnabled = true;
            this.listItems.ItemHeight = 17;
            this.listItems.Location = new System.Drawing.Point(945, 363);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(175, 191);
            this.listItems.TabIndex = 36;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(945, 307);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 24);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "Items:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(1047, 560);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(0, 623);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 29);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save Transaction";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteTransactionLines
            // 
            this.btnDeleteTransactionLines.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteTransactionLines.Location = new System.Drawing.Point(3, 240);
            this.btnDeleteTransactionLines.Name = "btnDeleteTransactionLines";
            this.btnDeleteTransactionLines.Size = new System.Drawing.Size(228, 27);
            this.btnDeleteTransactionLines.TabIndex = 40;
            this.btnDeleteTransactionLines.Text = "Delete Item";
            this.btnDeleteTransactionLines.UseVisualStyleBackColor = true;
            this.btnDeleteTransactionLines.Click += new System.EventHandler(this.btnDeleteTransactionLines_Click);
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteTransaction.Location = new System.Drawing.Point(3, 207);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(228, 27);
            this.btnDeleteTransaction.TabIndex = 41;
            this.btnDeleteTransaction.Text = "Delete Transaction";
            this.btnDeleteTransaction.UseVisualStyleBackColor = true;
            this.btnDeleteTransaction.Click += new System.EventHandler(this.btnDeleteTransaction_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTransaction.Location = new System.Drawing.Point(3, 174);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(228, 27);
            this.btnAddTransaction.TabIndex = 42;
            this.btnAddTransaction.Text = "New Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnDeleteTransaction);
            this.panel1.Controls.Add(this.btnAddTransaction);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDeleteTransactionLines);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 701);
            this.panel1.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1116, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 74);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1185, 696);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.listItems);
            this.Controls.Add(this.comboItems);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shark Fuel Station";
            this.Load += new System.EventHandler(this.TransactionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemTypes)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsID;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsEmployee;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repEmployees;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsTotalValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsPaymentMethod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private Button btnBack;
        private BindingSource bsTransactions;
        private DevExpress.XtraEditors.LabelControl labelCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsCustomerId;
        private DevExpress.XtraGrid.GridControl grdTransactions;
        private BindingSource bsTransactionLines;
        private BindingSource bsItems;
        private ComboBox comboItems;
        private ListBox listItems;
        private BindingSource bsEmployees;
        private BindingSource bsItemTypes;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Button btnAdd;
        private Button btnSave;
        private Button btnDeleteTransactionLines;
        private Button btnDeleteTransaction;
        private Button btnAddTransaction;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.GridControl grdTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coTLId;
        private DevExpress.XtraGrid.Columns.GridColumn coTLTransactionId;
        private DevExpress.XtraGrid.Columns.GridColumn coTLItemId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit repItemTree;
        private DevExpress.XtraTreeList.TreeList repositoryItemTreeListLookUpEdit1TreeList;
        private DevExpress.XtraGrid.Columns.GridColumn coTLQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn coTLItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn coTLNetValue;
        private DevExpress.XtraGrid.Columns.GridColumn coTLDiscountPercentage;
        private DevExpress.XtraGrid.Columns.GridColumn coTLDiscountValue;
        private DevExpress.XtraGrid.Columns.GridColumn coTLTotalValue;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}