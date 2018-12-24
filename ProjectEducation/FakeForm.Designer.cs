namespace ProjectEducation
{
    partial class FakeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgwStudentList = new System.Windows.Forms.DataGridView();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentRegistrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPhotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationalProjectDataSet1 = new ProjectEducation.EducationalProjectDataSet1();
            this.studentTableAdapter = new ProjectEducation.EducationalProjectDataSet1TableAdapters.StudentTableAdapter();
            this.cbxChooseGroup = new System.Windows.Forms.ComboBox();
            this.lblChooseGroup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationalProjectDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwStudentList
            // 
            this.dgwStudentList.AutoGenerateColumns = false;
            this.dgwStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.groupIdDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.studentBirthDateDataGridViewTextBoxColumn,
            this.studentEmailDataGridViewTextBoxColumn,
            this.studentPhoneDataGridViewTextBoxColumn,
            this.studentRegistrationDateDataGridViewTextBoxColumn,
            this.studentPhotoDataGridViewTextBoxColumn});
            this.dgwStudentList.DataSource = this.studentBindingSource;
            this.dgwStudentList.Location = new System.Drawing.Point(4, 108);
            this.dgwStudentList.Name = "dgwStudentList";
            this.dgwStudentList.Size = new System.Drawing.Size(944, 167);
            this.dgwStudentList.TabIndex = 0;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // groupIdDataGridViewTextBoxColumn
            // 
            this.groupIdDataGridViewTextBoxColumn.DataPropertyName = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.HeaderText = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            // 
            // studentBirthDateDataGridViewTextBoxColumn
            // 
            this.studentBirthDateDataGridViewTextBoxColumn.DataPropertyName = "StudentBirthDate";
            this.studentBirthDateDataGridViewTextBoxColumn.HeaderText = "StudentBirthDate";
            this.studentBirthDateDataGridViewTextBoxColumn.Name = "studentBirthDateDataGridViewTextBoxColumn";
            // 
            // studentEmailDataGridViewTextBoxColumn
            // 
            this.studentEmailDataGridViewTextBoxColumn.DataPropertyName = "StudentEmail";
            this.studentEmailDataGridViewTextBoxColumn.HeaderText = "StudentEmail";
            this.studentEmailDataGridViewTextBoxColumn.Name = "studentEmailDataGridViewTextBoxColumn";
            // 
            // studentPhoneDataGridViewTextBoxColumn
            // 
            this.studentPhoneDataGridViewTextBoxColumn.DataPropertyName = "StudentPhone";
            this.studentPhoneDataGridViewTextBoxColumn.HeaderText = "StudentPhone";
            this.studentPhoneDataGridViewTextBoxColumn.Name = "studentPhoneDataGridViewTextBoxColumn";
            // 
            // studentRegistrationDateDataGridViewTextBoxColumn
            // 
            this.studentRegistrationDateDataGridViewTextBoxColumn.DataPropertyName = "StudentRegistrationDate";
            this.studentRegistrationDateDataGridViewTextBoxColumn.HeaderText = "StudentRegistrationDate";
            this.studentRegistrationDateDataGridViewTextBoxColumn.Name = "studentRegistrationDateDataGridViewTextBoxColumn";
            // 
            // studentPhotoDataGridViewTextBoxColumn
            // 
            this.studentPhotoDataGridViewTextBoxColumn.DataPropertyName = "StudentPhoto";
            this.studentPhotoDataGridViewTextBoxColumn.HeaderText = "StudentPhoto";
            this.studentPhotoDataGridViewTextBoxColumn.Name = "studentPhotoDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.educationalProjectDataSet1;
            // 
            // educationalProjectDataSet1
            // 
            this.educationalProjectDataSet1.DataSetName = "EducationalProjectDataSet1";
            this.educationalProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // cbxChooseGroup
            // 
            this.cbxChooseGroup.FormattingEnabled = true;
            this.cbxChooseGroup.Location = new System.Drawing.Point(96, 41);
            this.cbxChooseGroup.Name = "cbxChooseGroup";
            this.cbxChooseGroup.Size = new System.Drawing.Size(121, 21);
            this.cbxChooseGroup.TabIndex = 1;
            // 
            // lblChooseGroup
            // 
            this.lblChooseGroup.AutoSize = true;
            this.lblChooseGroup.Location = new System.Drawing.Point(12, 44);
            this.lblChooseGroup.Name = "lblChooseGroup";
            this.lblChooseGroup.Size = new System.Drawing.Size(78, 13);
            this.lblChooseGroup.TabIndex = 2;
            this.lblChooseGroup.Text = "Choose Group:";
            // 
            // FakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.lblChooseGroup);
            this.Controls.Add(this.cbxChooseGroup);
            this.Controls.Add(this.dgwStudentList);
            this.Name = "FakeForm";
            this.Text = "FakeForm";
            this.Load += new System.EventHandler(this.FakeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationalProjectDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStudentList;
        private EducationalProjectDataSet1 educationalProjectDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private EducationalProjectDataSet1TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentRegistrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPhotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxChooseGroup;
        private System.Windows.Forms.Label lblChooseGroup;
    }
}