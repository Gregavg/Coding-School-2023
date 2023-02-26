namespace FuelStation.Win {
    partial class CustomersForm {
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
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.grdCustomers = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnBack = new System.Windows.Forms.Button();
            this.bsCustomerDetails = new System.Windows.Forms.BindingSource(this.components);
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl4.Controls.Add(this.grdCustomers);
            this.panelControl4.Location = new System.Drawing.Point(12, 43);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(761, 326);
            this.panelControl4.TabIndex = 31;
            // 
            // grdCustomers
            // 
            this.grdCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCustomers.Location = new System.Drawing.Point(2, 2);
            this.grdCustomers.MainView = this.gridView4;
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(757, 322);
            this.grdCustomers.TabIndex = 3;
            this.grdCustomers.UseEmbeddedNavigator = true;
            this.grdCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerSurname,
            this.colCustomerName,
            this.colCustomerCardNumber,
            this.colCustomerId});
            this.gridView4.CustomizationFormBounds = new System.Drawing.Rectangle(679, 381, 264, 272);
            this.gridView4.GridControl = this.grdCustomers;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsDetail.EnableMasterViewMode = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView4_RowDeleting);
            this.gridView4.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView4_ValidateRow);
            // 
            // colCustomerSurname
            // 
            this.colCustomerSurname.Caption = "Surname";
            this.colCustomerSurname.FieldName = "Surname";
            this.colCustomerSurname.Name = "colCustomerSurname";
            this.colCustomerSurname.Visible = true;
            this.colCustomerSurname.VisibleIndex = 0;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Name";
            this.colCustomerName.FieldName = "Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            // 
            // colCustomerCardNumber
            // 
            this.colCustomerCardNumber.Caption = "Card Number";
            this.colCustomerCardNumber.FieldName = "CardNumber";
            this.colCustomerCardNumber.Name = "colCustomerCardNumber";
            this.colCustomerCardNumber.Visible = true;
            this.colCustomerCardNumber.VisibleIndex = 2;
            // 
            // colCustomerId
            // 
            this.colCustomerId.Caption = "Id";
            this.colCustomerId.FieldName = "Id";
            this.colCustomerId.Name = "colCustomerId";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(98, 25);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "Customers";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(14, 375);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 29);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 416);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.labelControl4);
            this.Name = "CustomersForm";
            this.Text = "Shark Fuel Station Login";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl grdCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCardNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Button btnBack;
        private BindingSource bsCustomerDetails;
        private BindingSource bsCustomers;
    }
}