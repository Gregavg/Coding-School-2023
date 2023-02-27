namespace Session_11 {
    partial class Form2 {
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
            this.tabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabEmployees = new DevExpress.XtraTab.XtraTabPage();
            this.grvEmployees = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeePost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvEmployeeSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabCustomers = new DevExpress.XtraTab.XtraTabPage();
            this.grvCustomers = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerTin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPets = new DevExpress.XtraTab.XtraTabPage();
            this.grvPets = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPetSold = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetBreed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetHealthStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPetFoods = new DevExpress.XtraTab.XtraTabPage();
            this.grvPetFood = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPetAnimalType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetFoodPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetFoodCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetFoodQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabTransactions = new DevExpress.XtraTab.XtraTabPage();
            this.grvTransactions = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsPetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsPetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsPetFoodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsPetFoodQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsPetFoodPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabMonthlyLedger = new DevExpress.XtraTab.XtraTabPage();
            this.grvMonthlyLedger = new DevExpress.XtraGrid.GridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMonthlyLedgerYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthlyLedgerMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthlyLedgerIncome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthlyLedgerExpenses = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthlyLedgerTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPetReport = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPetReportAnimalType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetReportMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetReportYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetReportTotalSold = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtnPetReportUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtnPetReportDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsEmployeesDX = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsCustomersDX = new System.Windows.Forms.BindingSource(this.components);
            this.bsPetsDX = new System.Windows.Forms.BindingSource(this.components);
            this.bsPetFoodDX = new System.Windows.Forms.BindingSource(this.components);
            this.bsTransactionsDX = new System.Windows.Forms.BindingSource(this.components);
            this.bsMonthlyLedgerDX = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlMain)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.xtraTabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPetFoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.xtraTabTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.xtraTabMonthlyLedger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonthlyLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.xtraTabPetReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployeesDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomersDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetsDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetFoodDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionsDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonthlyLedgerDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Location = new System.Drawing.Point(59, 80);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedTabPage = this.xtraTabEmployees;
            this.tabControlMain.Size = new System.Drawing.Size(861, 468);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabEmployees,
            this.xtraTabCustomers,
            this.xtraTabPets,
            this.xtraTabPetFoods,
            this.xtraTabTransactions,
            this.xtraTabMonthlyLedger,
            this.xtraTabPetReport});
            // 
            // xtraTabEmployees
            // 
            this.xtraTabEmployees.Controls.Add(this.grvEmployees);
            this.xtraTabEmployees.Name = "xtraTabEmployees";
            this.xtraTabEmployees.Size = new System.Drawing.Size(859, 443);
            this.xtraTabEmployees.Text = "Employees";
            // 
            // grvEmployees
            // 
            this.grvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvEmployees.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grvEmployees.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.grvEmployees.Location = new System.Drawing.Point(0, 0);
            this.grvEmployees.MainView = this.gridView1;
            this.grvEmployees.Name = "grvEmployees";
            this.grvEmployees.Size = new System.Drawing.Size(859, 443);
            this.grvEmployees.TabIndex = 1;
            this.grvEmployees.UseEmbeddedNavigator = true;
            this.grvEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grvEmployees.Click += new System.EventHandler(this.grvEmployees_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeName,
            this.colEmployeeSurname,
            this.colEmployeePost,
            this.colvEmployeeSalary});
            this.gridView1.GridControl = this.grvEmployees;
            this.gridView1.Name = "gridView1";
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.Caption = "Name";
            this.colEmployeeName.FieldName = "Name";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 0;
            // 
            // colEmployeeSurname
            // 
            this.colEmployeeSurname.Caption = "Surname";
            this.colEmployeeSurname.FieldName = "Surname";
            this.colEmployeeSurname.Name = "colEmployeeSurname";
            this.colEmployeeSurname.Visible = true;
            this.colEmployeeSurname.VisibleIndex = 1;
            // 
            // colEmployeePost
            // 
            this.colEmployeePost.Caption = "Employee Post";
            this.colEmployeePost.FieldName = "EmpType";
            this.colEmployeePost.Name = "colEmployeePost";
            this.colEmployeePost.Visible = true;
            this.colEmployeePost.VisibleIndex = 2;
            // 
            // colvEmployeeSalary
            // 
            this.colvEmployeeSalary.Caption = "Salary";
            this.colvEmployeeSalary.FieldName = "SalaryPerMonth";
            this.colvEmployeeSalary.Name = "colvEmployeeSalary";
            this.colvEmployeeSalary.Visible = true;
            this.colvEmployeeSalary.VisibleIndex = 3;
            // 
            // xtraTabCustomers
            // 
            this.xtraTabCustomers.Controls.Add(this.grvCustomers);
            this.xtraTabCustomers.Name = "xtraTabCustomers";
            this.xtraTabCustomers.Size = new System.Drawing.Size(859, 443);
            this.xtraTabCustomers.Text = "Customers";
            // 
            // grvCustomers
            // 
            this.grvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvCustomers.Location = new System.Drawing.Point(0, 0);
            this.grvCustomers.MainView = this.gridView2;
            this.grvCustomers.Name = "grvCustomers";
            this.grvCustomers.Size = new System.Drawing.Size(859, 443);
            this.grvCustomers.TabIndex = 0;
            this.grvCustomers.UseEmbeddedNavigator = true;
            this.grvCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colCustomerSurname,
            this.colCustomerPhone,
            this.colCustomerTin});
            this.gridView2.CustomizationFormBounds = new System.Drawing.Rectangle(679, 381, 264, 272);
            this.gridView2.GridControl = this.grvCustomers;
            this.gridView2.Name = "gridView2";
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Name";
            this.colCustomerName.FieldName = "Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            // 
            // colCustomerSurname
            // 
            this.colCustomerSurname.Caption = "Surname";
            this.colCustomerSurname.FieldName = "Surname";
            this.colCustomerSurname.Name = "colCustomerSurname";
            this.colCustomerSurname.Visible = true;
            this.colCustomerSurname.VisibleIndex = 0;
            // 
            // colCustomerPhone
            // 
            this.colCustomerPhone.Caption = "Phone";
            this.colCustomerPhone.FieldName = "Phone";
            this.colCustomerPhone.Name = "colCustomerPhone";
            this.colCustomerPhone.Visible = true;
            this.colCustomerPhone.VisibleIndex = 2;
            // 
            // colCustomerTin
            // 
            this.colCustomerTin.Caption = "TIN";
            this.colCustomerTin.FieldName = "TIN";
            this.colCustomerTin.Name = "colCustomerTin";
            this.colCustomerTin.Visible = true;
            this.colCustomerTin.VisibleIndex = 3;
            // 
            // xtraTabPets
            // 
            this.xtraTabPets.Controls.Add(this.grvPets);
            this.xtraTabPets.Name = "xtraTabPets";
            this.xtraTabPets.Size = new System.Drawing.Size(859, 443);
            this.xtraTabPets.Text = "Pets";
            // 
            // grvPets
            // 
            this.grvPets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvPets.Location = new System.Drawing.Point(0, 0);
            this.grvPets.MainView = this.gridView3;
            this.grvPets.Name = "grvPets";
            this.grvPets.Size = new System.Drawing.Size(859, 443);
            this.grvPets.TabIndex = 0;
            this.grvPets.UseEmbeddedNavigator = true;
            this.grvPets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPetSold,
            this.colPetType,
            this.colPetBreed,
            this.colPetHealthStatus,
            this.colPetCost,
            this.colPetPrice,
            this.colPetDate});
            this.gridView3.GridControl = this.grvPets;
            this.gridView3.Name = "gridView3";
            // 
            // colPetSold
            // 
            this.colPetSold.Caption = "Available";
            this.colPetSold.CustomizationCaption = "Transaction ID";
            this.colPetSold.FieldName = "TransactionID";
            this.colPetSold.Name = "colPetSold";
            this.colPetSold.OptionsColumn.AllowEdit = false;
            this.colPetSold.Visible = true;
            this.colPetSold.VisibleIndex = 0;
            // 
            // colPetType
            // 
            this.colPetType.Caption = "Type";
            this.colPetType.FieldName = "Animaltype";
            this.colPetType.Name = "colPetType";
            this.colPetType.Visible = true;
            this.colPetType.VisibleIndex = 2;
            // 
            // colPetBreed
            // 
            this.colPetBreed.Caption = "Breed";
            this.colPetBreed.FieldName = "Breed";
            this.colPetBreed.Name = "colPetBreed";
            this.colPetBreed.Visible = true;
            this.colPetBreed.VisibleIndex = 3;
            // 
            // colPetHealthStatus
            // 
            this.colPetHealthStatus.Caption = "Health Status";
            this.colPetHealthStatus.FieldName = "Petstatus";
            this.colPetHealthStatus.Name = "colPetHealthStatus";
            this.colPetHealthStatus.Visible = true;
            this.colPetHealthStatus.VisibleIndex = 4;
            // 
            // colPetCost
            // 
            this.colPetCost.Caption = "Cost";
            this.colPetCost.FieldName = "Cost";
            this.colPetCost.Name = "colPetCost";
            this.colPetCost.Visible = true;
            this.colPetCost.VisibleIndex = 5;
            // 
            // colPetPrice
            // 
            this.colPetPrice.Caption = "Price";
            this.colPetPrice.FieldName = "Price";
            this.colPetPrice.Name = "colPetPrice";
            this.colPetPrice.Visible = true;
            this.colPetPrice.VisibleIndex = 6;
            // 
            // colPetDate
            // 
            this.colPetDate.Caption = "Date Received";
            this.colPetDate.FieldName = "Bought";
            this.colPetDate.Name = "colPetDate";
            this.colPetDate.Visible = true;
            this.colPetDate.VisibleIndex = 1;
            // 
            // xtraTabPetFoods
            // 
            this.xtraTabPetFoods.Controls.Add(this.grvPetFood);
            this.xtraTabPetFoods.Name = "xtraTabPetFoods";
            this.xtraTabPetFoods.Size = new System.Drawing.Size(859, 443);
            this.xtraTabPetFoods.Text = "Pet Food";
            // 
            // grvPetFood
            // 
            this.grvPetFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvPetFood.Location = new System.Drawing.Point(0, 0);
            this.grvPetFood.MainView = this.gridView4;
            this.grvPetFood.Name = "grvPetFood";
            this.grvPetFood.Size = new System.Drawing.Size(859, 443);
            this.grvPetFood.TabIndex = 0;
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
            this.colPetFoodQty.Visible = true;
            this.colPetFoodQty.VisibleIndex = 3;
            // 
            // xtraTabTransactions
            // 
            this.xtraTabTransactions.Controls.Add(this.grvTransactions);
            this.xtraTabTransactions.Name = "xtraTabTransactions";
            this.xtraTabTransactions.Size = new System.Drawing.Size(859, 443);
            this.xtraTabTransactions.Text = "Transactions";
            // 
            // grvTransactions
            // 
            this.grvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvTransactions.Location = new System.Drawing.Point(0, 0);
            this.grvTransactions.MainView = this.gridView5;
            this.grvTransactions.Name = "grvTransactions";
            this.grvTransactions.Size = new System.Drawing.Size(859, 443);
            this.grvTransactions.TabIndex = 0;
            this.grvTransactions.UseEmbeddedNavigator = true;
            this.grvTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionsID,
            this.colTransactionsDate,
            this.colTransactionsCustomerID,
            this.colTransactionsEmployeeID,
            this.colTransactionsPetID,
            this.colTransactionsPetPrice,
            this.colTransactionsPetFoodID,
            this.colTransactionsPetFoodQty,
            this.colTransactionsPetFoodPrice,
            this.colTransactionsTotalPrice});
            this.gridView5.GridControl = this.grvTransactions;
            this.gridView5.Name = "gridView5";
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
            // colTransactionsCustomerID
            // 
            this.colTransactionsCustomerID.Caption = "Customer ID";
            this.colTransactionsCustomerID.FieldName = "CustomerID";
            this.colTransactionsCustomerID.Name = "colTransactionsCustomerID";
            this.colTransactionsCustomerID.Visible = true;
            this.colTransactionsCustomerID.VisibleIndex = 2;
            // 
            // colTransactionsEmployeeID
            // 
            this.colTransactionsEmployeeID.Caption = "Employee ID";
            this.colTransactionsEmployeeID.FieldName = "ID";
            this.colTransactionsEmployeeID.Name = "colTransactionsEmployeeID";
            this.colTransactionsEmployeeID.Visible = true;
            this.colTransactionsEmployeeID.VisibleIndex = 3;
            // 
            // colTransactionsPetID
            // 
            this.colTransactionsPetID.Caption = "Pet ID";
            this.colTransactionsPetID.FieldName = "PetID";
            this.colTransactionsPetID.Name = "colTransactionsPetID";
            this.colTransactionsPetID.Visible = true;
            this.colTransactionsPetID.VisibleIndex = 4;
            // 
            // colTransactionsPetPrice
            // 
            this.colTransactionsPetPrice.Caption = "Pet Price";
            this.colTransactionsPetPrice.FieldName = "PetPrice";
            this.colTransactionsPetPrice.Name = "colTransactionsPetPrice";
            this.colTransactionsPetPrice.Visible = true;
            this.colTransactionsPetPrice.VisibleIndex = 5;
            // 
            // colTransactionsPetFoodID
            // 
            this.colTransactionsPetFoodID.Caption = "Pet Food ID";
            this.colTransactionsPetFoodID.FieldName = "PetFoodID";
            this.colTransactionsPetFoodID.Name = "colTransactionsPetFoodID";
            this.colTransactionsPetFoodID.Visible = true;
            this.colTransactionsPetFoodID.VisibleIndex = 6;
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
            // xtraTabMonthlyLedger
            // 
            this.xtraTabMonthlyLedger.Controls.Add(this.grvMonthlyLedger);
            this.xtraTabMonthlyLedger.Name = "xtraTabMonthlyLedger";
            this.xtraTabMonthlyLedger.Size = new System.Drawing.Size(859, 443);
            this.xtraTabMonthlyLedger.Text = "Monthly Ledger";
            // 
            // grvMonthlyLedger
            // 
            this.grvMonthlyLedger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvMonthlyLedger.Location = new System.Drawing.Point(0, 0);
            this.grvMonthlyLedger.MainView = this.gridView6;
            this.grvMonthlyLedger.Name = "grvMonthlyLedger";
            this.grvMonthlyLedger.Size = new System.Drawing.Size(859, 443);
            this.grvMonthlyLedger.TabIndex = 0;
            this.grvMonthlyLedger.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMonthlyLedgerYear,
            this.colMonthlyLedgerMonth,
            this.colMonthlyLedgerIncome,
            this.colMonthlyLedgerExpenses,
            this.colMonthlyLedgerTotal});
            this.gridView6.GridControl = this.grvMonthlyLedger;
            this.gridView6.Name = "gridView6";
            // 
            // colMonthlyLedgerYear
            // 
            this.colMonthlyLedgerYear.Caption = "Year";
            this.colMonthlyLedgerYear.FieldName = "Year";
            this.colMonthlyLedgerYear.Name = "colMonthlyLedgerYear";
            this.colMonthlyLedgerYear.Visible = true;
            this.colMonthlyLedgerYear.VisibleIndex = 0;
            // 
            // colMonthlyLedgerMonth
            // 
            this.colMonthlyLedgerMonth.Caption = "Month";
            this.colMonthlyLedgerMonth.FieldName = "Month";
            this.colMonthlyLedgerMonth.Name = "colMonthlyLedgerMonth";
            this.colMonthlyLedgerMonth.Visible = true;
            this.colMonthlyLedgerMonth.VisibleIndex = 1;
            // 
            // colMonthlyLedgerIncome
            // 
            this.colMonthlyLedgerIncome.Caption = "Income";
            this.colMonthlyLedgerIncome.FieldName = "Income";
            this.colMonthlyLedgerIncome.Name = "colMonthlyLedgerIncome";
            this.colMonthlyLedgerIncome.Visible = true;
            this.colMonthlyLedgerIncome.VisibleIndex = 2;
            // 
            // colMonthlyLedgerExpenses
            // 
            this.colMonthlyLedgerExpenses.Caption = "Expenses";
            this.colMonthlyLedgerExpenses.FieldName = "Expenses";
            this.colMonthlyLedgerExpenses.Name = "colMonthlyLedgerExpenses";
            this.colMonthlyLedgerExpenses.Visible = true;
            this.colMonthlyLedgerExpenses.VisibleIndex = 3;
            // 
            // colMonthlyLedgerTotal
            // 
            this.colMonthlyLedgerTotal.Caption = "Profit";
            this.colMonthlyLedgerTotal.FieldName = "Total";
            this.colMonthlyLedgerTotal.Name = "colMonthlyLedgerTotal";
            this.colMonthlyLedgerTotal.Visible = true;
            this.colMonthlyLedgerTotal.VisibleIndex = 4;
            // 
            // xtraTabPetReport
            // 
            this.xtraTabPetReport.Controls.Add(this.gridControl4);
            this.xtraTabPetReport.Name = "xtraTabPetReport";
            this.xtraTabPetReport.Size = new System.Drawing.Size(859, 443);
            this.xtraTabPetReport.Text = "Pet Report";
            // 
            // gridControl4
            // 
            this.gridControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl4.Location = new System.Drawing.Point(0, 0);
            this.gridControl4.MainView = this.gridView7;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(859, 443);
            this.gridControl4.TabIndex = 1;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView7});
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPetReportAnimalType,
            this.colPetReportMonth,
            this.colPetReportYear,
            this.colPetReportTotalSold,
            this.colBtnPetReportUpdate,
            this.colBtnPetReportDelete});
            this.gridView7.GridControl = this.gridControl4;
            this.gridView7.Name = "gridView7";
            // 
            // colPetReportAnimalType
            // 
            this.colPetReportAnimalType.Caption = "Animal Type";
            this.colPetReportAnimalType.Name = "colPetReportAnimalType";
            this.colPetReportAnimalType.Visible = true;
            this.colPetReportAnimalType.VisibleIndex = 0;
            // 
            // colPetReportMonth
            // 
            this.colPetReportMonth.Caption = "Month";
            this.colPetReportMonth.Name = "colPetReportMonth";
            this.colPetReportMonth.Visible = true;
            this.colPetReportMonth.VisibleIndex = 1;
            // 
            // colPetReportYear
            // 
            this.colPetReportYear.Caption = "Year";
            this.colPetReportYear.Name = "colPetReportYear";
            this.colPetReportYear.Visible = true;
            this.colPetReportYear.VisibleIndex = 2;
            // 
            // colPetReportTotalSold
            // 
            this.colPetReportTotalSold.Caption = "Total Sold";
            this.colPetReportTotalSold.Name = "colPetReportTotalSold";
            this.colPetReportTotalSold.Visible = true;
            this.colPetReportTotalSold.VisibleIndex = 3;
            // 
            // colBtnPetReportUpdate
            // 
            this.colBtnPetReportUpdate.Caption = "Update";
            this.colBtnPetReportUpdate.Name = "colBtnPetReportUpdate";
            this.colBtnPetReportUpdate.Visible = true;
            this.colBtnPetReportUpdate.VisibleIndex = 4;
            // 
            // colBtnPetReportDelete
            // 
            this.colBtnPetReportDelete.Caption = "Delete";
            this.colBtnPetReportDelete.Name = "colBtnPetReportDelete";
            this.colBtnPetReportDelete.Visible = true;
            this.colBtnPetReportDelete.VisibleIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(59, 547);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 50);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "SAVE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(165, 547);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(100, 50);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "LOAD";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(713, 547);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(100, 50);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "ADD ";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Location = new System.Drawing.Point(819, 547);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(100, 50);
            this.simpleButton4.TabIndex = 4;
            this.simpleButton4.Text = "DELETE";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 655);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form2";
            this.Text = "My Pet Shop";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlMain)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.xtraTabEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPetFoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvPetFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.xtraTabTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.xtraTabMonthlyLedger.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvMonthlyLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.xtraTabPetReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployeesDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomersDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetsDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetFoodDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionsDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonthlyLedgerDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabEmployees;
        private DevExpress.XtraTab.XtraTabPage xtraTabCustomers;
        private DevExpress.XtraTab.XtraTabPage xtraTabPets;
        private DevExpress.XtraTab.XtraTabPage xtraTabPetFoods;
        private DevExpress.XtraTab.XtraTabPage xtraTabTransactions;
        private DevExpress.XtraTab.XtraTabPage xtraTabMonthlyLedger;
        private DevExpress.XtraTab.XtraTabPage xtraTabPetReport;
        private DevExpress.XtraGrid.GridControl grvEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeePost;
        private DevExpress.XtraGrid.Columns.GridColumn colvEmployeeSalary;
        private DevExpress.XtraGrid.GridControl grvCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grvPets;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colPetDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPetType;
        private DevExpress.XtraGrid.Columns.GridColumn colPetBreed;
        private DevExpress.XtraGrid.Columns.GridColumn colPetHealthStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colPetCost;
        private DevExpress.XtraGrid.Columns.GridColumn colPetPrice;
        private DevExpress.XtraGrid.GridControl grvPetFood;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colPetAnimalType;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodCost;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodQty;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn colPetReportAnimalType;
        private DevExpress.XtraGrid.Columns.GridColumn colPetReportMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colPetReportYear;
        private DevExpress.XtraGrid.Columns.GridColumn colPetReportTotalSold;
        private DevExpress.XtraGrid.Columns.GridColumn colBtnPetReportUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colBtnPetReportDelete;
        private BindingSource bsEmployeesDX;
        private BindingSource bindingSource1;
        private BindingSource bsCustomersDX;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerTin;
        private BindingSource bsPetsDX;
        private BindingSource bsPetFoodDX;
        private BindingSource bsTransactionsDX;
        private BindingSource bsMonthlyLedgerDX;
        private BindingSource bindingSource6;
        private DevExpress.XtraGrid.Columns.GridColumn colPetSold;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraGrid.GridControl grvTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsID;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsPetID;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsPetPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsPetFoodID;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsPetFoodQty;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsPetFoodPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsTotalPrice;
        private DevExpress.XtraGrid.GridControl grvMonthlyLedger;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyLedgerYear;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyLedgerMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyLedgerIncome;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyLedgerExpenses;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyLedgerTotal;
    }
}