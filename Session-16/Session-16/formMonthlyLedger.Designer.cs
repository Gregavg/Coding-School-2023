namespace Session_16 {
    partial class formMonthlyLedger {
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grvMonthlyLedger = new DevExpress.XtraGrid.GridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMonthlyLedgerYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthlyLedgerMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthlyLedgerIncome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthlyLedgerExpenses = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthlyLedgerTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonthlyLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.grvMonthlyLedger);
            this.panelControl1.Location = new System.Drawing.Point(91, 31);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(781, 210);
            this.panelControl1.TabIndex = 27;
            // 
            // grvMonthlyLedger
            // 
            this.grvMonthlyLedger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvMonthlyLedger.Location = new System.Drawing.Point(2, 2);
            this.grvMonthlyLedger.MainView = this.gridView6;
            this.grvMonthlyLedger.Name = "grvMonthlyLedger";
            this.grvMonthlyLedger.Size = new System.Drawing.Size(777, 206);
            this.grvMonthlyLedger.TabIndex = 1;
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
            // formMonthlyLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 655);
            this.Controls.Add(this.panelControl1);
            this.Name = "formMonthlyLedger";
            this.Text = "My Pet Shop";
            this.Load += new System.EventHandler(this.formMonthlyLedger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvMonthlyLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grvMonthlyLedger;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyLedgerYear;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyLedgerMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyLedgerIncome;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyLedgerExpenses;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyLedgerTotal;
    }
}