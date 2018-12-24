namespace ProjectEducation
{
    partial class TeacherInfo
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
            this.cmbxTeacherList = new System.Windows.Forms.ComboBox();
            this.cmbxGroupList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbxTeacherList
            // 
            this.cmbxTeacherList.FormattingEnabled = true;
            this.cmbxTeacherList.Location = new System.Drawing.Point(25, 35);
            this.cmbxTeacherList.Name = "cmbxTeacherList";
            this.cmbxTeacherList.Size = new System.Drawing.Size(121, 21);
            this.cmbxTeacherList.TabIndex = 0;
            this.cmbxTeacherList.SelectedIndexChanged += new System.EventHandler(this.cmbxTeacherList_SelectedIndexChanged);
            // 
            // cmbxGroupList
            // 
            this.cmbxGroupList.FormattingEnabled = true;
            this.cmbxGroupList.Location = new System.Drawing.Point(181, 35);
            this.cmbxGroupList.Name = "cmbxGroupList";
            this.cmbxGroupList.Size = new System.Drawing.Size(121, 21);
            this.cmbxGroupList.TabIndex = 1;
            // 
            // TeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbxGroupList);
            this.Controls.Add(this.cmbxTeacherList);
            this.Name = "TeacherInfo";
            this.Text = "TeacherInfo";
            this.Load += new System.EventHandler(this.TeacherInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxTeacherList;
        private System.Windows.Forms.ComboBox cmbxGroupList;
    }
}