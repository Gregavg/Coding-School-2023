namespace Session_16 {
    partial class formPetReport {
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
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPetReportAnimalType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetReportMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetReportYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetReportTotalSold = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtnPetReportUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtnPetReportDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl4);
            this.panelControl1.Location = new System.Drawing.Point(90, 55);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(751, 199);
            this.panelControl1.TabIndex = 19;
            // 
            // gridControl4
            // 
            this.gridControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl4.Location = new System.Drawing.Point(2, 2);
            this.gridControl4.MainView = this.gridView7;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(747, 195);
            this.gridControl4.TabIndex = 2;
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
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(92, 297);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(749, 234);
            this.gridControl1.TabIndex = 27;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "CUSTOMER NAME";
            this.gridColumn1.FieldName = "Surname";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // formPetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 655);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "formPetReport";
            this.Text = "My Pet Shop";
            this.Load += new System.EventHandler(this.formPetReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn colPetReportAnimalType;
        private DevExpress.XtraGrid.Columns.GridColumn colPetReportMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colPetReportYear;
        private DevExpress.XtraGrid.Columns.GridColumn colPetReportTotalSold;
        private DevExpress.XtraGrid.Columns.GridColumn colBtnPetReportUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colBtnPetReportDelete;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private BindingSource bindingSource1;
    }
}