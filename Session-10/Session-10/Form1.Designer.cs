namespace Session_10 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.grvStudents = new System.Windows.Forms.DataGridView();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUndergraduate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colShowID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bsStudents = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.labelStudents = new System.Windows.Forms.Label();
            this.grvCourses = new System.Windows.Forms.DataGridView();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCourses = new System.Windows.Forms.Label();
            this.bsCourses = new System.Windows.Forms.BindingSource(this.components);
            this.labelGrades = new System.Windows.Forms.Label();
            this.labelScheduleCourses = new System.Windows.Forms.Label();
            this.grvGrades = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsGrades = new System.Windows.Forms.BindingSource(this.components);
            this.bsSchedule = new System.Windows.Forms.BindingSource(this.components);
            this.grvScheldule = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.labelUni = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvScheldule)).BeginInit();
            this.SuspendLayout();
            // 
            // grvStudents
            // 
            this.grvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvStudents.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colAge,
            this.colUndergraduate,
            this.colGender,
            this.colShowID});
            this.grvStudents.Location = new System.Drawing.Point(12, 62);
            this.grvStudents.Name = "grvStudents";
            this.grvStudents.RowTemplate.Height = 25;
            this.grvStudents.Size = new System.Drawing.Size(724, 126);
            this.grvStudents.TabIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.FillWeight = 123.348F;
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.Name = "colFirstName";
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.FillWeight = 162.298F;
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            // 
            // colAge
            // 
            this.colAge.DataPropertyName = "Age";
            this.colAge.FillWeight = 49.66901F;
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            // 
            // colUndergraduate
            // 
            this.colUndergraduate.DataPropertyName = "Undergraduate";
            this.colUndergraduate.FillWeight = 91.67365F;
            this.colUndergraduate.HeaderText = "Undergraduate";
            this.colUndergraduate.Name = "colUndergraduate";
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.FillWeight = 77.66428F;
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colShowID
            // 
            this.colShowID.FillWeight = 88.51378F;
            this.colShowID.HeaderText = "Show ID";
            this.colShowID.Name = "colShowID";
            this.colShowID.Text = "Show ID";
            this.colShowID.ToolTipText = "+";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(651, 462);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Create File";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStudents.Location = new System.Drawing.Point(12, 38);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(81, 21);
            this.labelStudents.TabIndex = 3;
            this.labelStudents.Text = "Students:";
            // 
            // grvCourses
            // 
            this.grvCourses.AllowDrop = true;
            this.grvCourses.AllowUserToAddRows = false;
            this.grvCourses.AllowUserToDeleteRows = false;
            this.grvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject});
            this.grvCourses.Location = new System.Drawing.Point(12, 215);
            this.grvCourses.Name = "grvCourses";
            this.grvCourses.ReadOnly = true;
            this.grvCourses.RowTemplate.Height = 25;
            this.grvCourses.Size = new System.Drawing.Size(162, 111);
            this.grvCourses.TabIndex = 4;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // labelCourses
            // 
            this.labelCourses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCourses.Location = new System.Drawing.Point(12, 191);
            this.labelCourses.Name = "labelCourses";
            this.labelCourses.Size = new System.Drawing.Size(73, 21);
            this.labelCourses.TabIndex = 5;
            this.labelCourses.Text = "Courses:";
            // 
            // labelGrades
            // 
            this.labelGrades.AutoSize = true;
            this.labelGrades.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGrades.Location = new System.Drawing.Point(251, 191);
            this.labelGrades.Name = "labelGrades";
            this.labelGrades.Size = new System.Drawing.Size(66, 21);
            this.labelGrades.TabIndex = 6;
            this.labelGrades.Text = "Grades:";
            // 
            // labelScheduleCourses
            // 
            this.labelScheduleCourses.AutoSize = true;
            this.labelScheduleCourses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelScheduleCourses.Location = new System.Drawing.Point(12, 340);
            this.labelScheduleCourses.Name = "labelScheduleCourses";
            this.labelScheduleCourses.Size = new System.Drawing.Size(162, 21);
            this.labelScheduleCourses.TabIndex = 7;
            this.labelScheduleCourses.Text = "Schelduled Courses:";
            // 
            // grvGrades
            // 
            this.grvGrades.AllowUserToAddRows = false;
            this.grvGrades.AllowUserToDeleteRows = false;
            this.grvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Course,
            this.GradeValue});
            this.grvGrades.Location = new System.Drawing.Point(251, 215);
            this.grvGrades.Name = "grvGrades";
            this.grvGrades.ReadOnly = true;
            this.grvGrades.RowTemplate.Height = 25;
            this.grvGrades.Size = new System.Drawing.Size(485, 111);
            this.grvGrades.TabIndex = 8;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Course
            // 
            this.Course.DataPropertyName = "Subject";
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // GradeValue
            // 
            this.GradeValue.DataPropertyName = "GradeValue";
            this.GradeValue.HeaderText = "Grade";
            this.GradeValue.Name = "GradeValue";
            this.GradeValue.ReadOnly = true;
            // 
            // grvScheldule
            // 
            this.grvScheldule.AllowUserToAddRows = false;
            this.grvScheldule.AllowUserToDeleteRows = false;
            this.grvScheldule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvScheldule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvScheldule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grvScheldule.Location = new System.Drawing.Point(12, 364);
            this.grvScheldule.Name = "grvScheldule";
            this.grvScheldule.ReadOnly = true;
            this.grvScheldule.RowTemplate.Height = 25;
            this.grvScheldule.Size = new System.Drawing.Size(724, 92);
            this.grvScheldule.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Subject";
            this.Column1.HeaderText = "Subject";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FirstName";
            this.Column2.HeaderText = "First Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LastName";
            this.Column3.HeaderText = "Last Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Calendar";
            this.Column4.HeaderText = "Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Load file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelUni
            // 
            this.labelUni.AutoSize = true;
            this.labelUni.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUni.Location = new System.Drawing.Point(281, 9);
            this.labelUni.Name = "labelUni";
            this.labelUni.Size = new System.Drawing.Size(199, 25);
            this.labelUni.TabIndex = 11;
            this.labelUni.Text = "No University loaded";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 462);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 536);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelUni);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grvScheldule);
            this.Controls.Add(this.grvGrades);
            this.Controls.Add(this.labelScheduleCourses);
            this.Controls.Add(this.labelGrades);
            this.Controls.Add(this.labelCourses);
            this.Controls.Add(this.grvCourses);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grvStudents);
            this.Name = "Form1";
            this.Text = "University";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvScheldule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grvStudents;
        private Button btnRefresh;
        private BindingSource bsStudents;
        private Label labelStudents;
        private DataGridView grvCourses;
        private Label labelCourses;
        private BindingSource bsCourses;
        private Label labelGrades;
        private Label labelScheduleCourses;
        private DataGridView grvGrades;
        private DataGridViewTextBoxColumn Subject;
        private BindingSource bsGrades;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn GradeValue;
        private BindingSource bsSchedule;
        private DataGridView grvScheldule;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewCheckBoxColumn colUndergraduate;
        private DataGridViewComboBoxColumn colGender;
        private DataGridViewButtonColumn colShowID;
        private Label labelUni;
        private Button buttonClear;
    }
}