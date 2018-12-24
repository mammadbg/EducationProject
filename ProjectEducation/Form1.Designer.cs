namespace ProjectEducation
{
    partial class Form1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.showTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignTasjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkSpecifiedStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseGroupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeAMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.writeAMessageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toMentorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toGroupMateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workMatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addResourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteResourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showResoruceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationalProjectDataSet = new ProjectEducation.EducationalProjectDataSet();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new ProjectEducation.EducationalProjectDataSetTableAdapters.TeacherTableAdapter();
            this.transcriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transcriptIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.educationalProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherToolStripMenuItem,
            this.tasjToolStripMenuItem,
            this.assignTasjToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mentorInfoToolStripMenuItem,
            this.messagesToolStripMenuItem,
            this.workMatesToolStripMenuItem,
            this.libraryToolStripMenuItem,
            this.transcriptToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(752, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInfoToolStripMenuItem,
            this.editToolStripMenuItem});
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.teacherToolStripMenuItem.Text = "Personal Info";
            // 
            // personalInfoToolStripMenuItem
            // 
            this.personalInfoToolStripMenuItem.Name = "personalInfoToolStripMenuItem";
            this.personalInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.personalInfoToolStripMenuItem.Text = "Personal Info";
            this.personalInfoToolStripMenuItem.Click += new System.EventHandler(this.personalInfoToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // tasjToolStripMenuItem
            // 
            this.tasjToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.showTaskToolStripMenuItem});
            this.tasjToolStripMenuItem.Name = "tasjToolStripMenuItem";
            this.tasjToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.tasjToolStripMenuItem.Text = "Task";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "Add Task";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // showTaskToolStripMenuItem
            // 
            this.showTaskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskListToolStripMenuItem,
            this.toolStripMenuItem4,
            this.updateTaskToolStripMenuItem});
            this.showTaskToolStripMenuItem.Name = "showTaskToolStripMenuItem";
            this.showTaskToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showTaskToolStripMenuItem.Text = "Show Task";
            // 
            // taskListToolStripMenuItem
            // 
            this.taskListToolStripMenuItem.Name = "taskListToolStripMenuItem";
            this.taskListToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.taskListToolStripMenuItem.Text = "Task List";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem4.Text = "Delete Task";
            // 
            // updateTaskToolStripMenuItem
            // 
            this.updateTaskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateFormToolStripMenuItem});
            this.updateTaskToolStripMenuItem.Name = "updateTaskToolStripMenuItem";
            this.updateTaskToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.updateTaskToolStripMenuItem.Text = "Update Task";
            // 
            // updateFormToolStripMenuItem
            // 
            this.updateFormToolStripMenuItem.Name = "updateFormToolStripMenuItem";
            this.updateFormToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.updateFormToolStripMenuItem.Text = "Update Form";
            // 
            // assignTasjToolStripMenuItem
            // 
            this.assignTasjToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseGroupToolStripMenuItem,
            this.chooseTaskToolStripMenuItem,
            this.studentListToolStripMenuItem,
            this.checkSpecifiedStudentsToolStripMenuItem,
            this.assignTaskToolStripMenuItem});
            this.assignTasjToolStripMenuItem.Name = "assignTasjToolStripMenuItem";
            this.assignTasjToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.assignTasjToolStripMenuItem.Text = "Assign Task";
            // 
            // chooseGroupToolStripMenuItem
            // 
            this.chooseGroupToolStripMenuItem.Name = "chooseGroupToolStripMenuItem";
            this.chooseGroupToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.chooseGroupToolStripMenuItem.Text = "Choose Group";
            // 
            // chooseTaskToolStripMenuItem
            // 
            this.chooseTaskToolStripMenuItem.Name = "chooseTaskToolStripMenuItem";
            this.chooseTaskToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.chooseTaskToolStripMenuItem.Text = "Choose Task";
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.studentListToolStripMenuItem.Text = "Student List";
            // 
            // checkSpecifiedStudentsToolStripMenuItem
            // 
            this.checkSpecifiedStudentsToolStripMenuItem.Name = "checkSpecifiedStudentsToolStripMenuItem";
            this.checkSpecifiedStudentsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.checkSpecifiedStudentsToolStripMenuItem.Text = "Check Specified Students";
            // 
            // assignTaskToolStripMenuItem
            // 
            this.assignTaskToolStripMenuItem.Name = "assignTaskToolStripMenuItem";
            this.assignTaskToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.assignTaskToolStripMenuItem.Text = "Assign Task";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseGroupToolStripMenuItem1,
            this.studentListToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "Groups";
            // 
            // chooseGroupToolStripMenuItem1
            // 
            this.chooseGroupToolStripMenuItem1.Name = "chooseGroupToolStripMenuItem1";
            this.chooseGroupToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.chooseGroupToolStripMenuItem1.Text = "Choose Group";
            // 
            // studentListToolStripMenuItem1
            // 
            this.studentListToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem,
            this.taskInfoToolStripMenuItem});
            this.studentListToolStripMenuItem1.Name = "studentListToolStripMenuItem1";
            this.studentListToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.studentListToolStripMenuItem1.Text = "Student List";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sToolStripMenuItem.Text = "Student Info";
            // 
            // taskInfoToolStripMenuItem
            // 
            this.taskInfoToolStripMenuItem.Name = "taskInfoToolStripMenuItem";
            this.taskInfoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.taskInfoToolStripMenuItem.Text = "Task Info";
            // 
            // mentorInfoToolStripMenuItem
            // 
            this.mentorInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeAMessageToolStripMenuItem});
            this.mentorInfoToolStripMenuItem.Name = "mentorInfoToolStripMenuItem";
            this.mentorInfoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.mentorInfoToolStripMenuItem.Text = "Mentor Info";
            // 
            // writeAMessageToolStripMenuItem
            // 
            this.writeAMessageToolStripMenuItem.Name = "writeAMessageToolStripMenuItem";
            this.writeAMessageToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.writeAMessageToolStripMenuItem.Text = "Write a Message";
            // 
            // messagesToolStripMenuItem
            // 
            this.messagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sentToolStripMenuItem,
            this.sentToolStripMenuItem1,
            this.writeAMessageToolStripMenuItem1});
            this.messagesToolStripMenuItem.Name = "messagesToolStripMenuItem";
            this.messagesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.messagesToolStripMenuItem.Text = "Messages";
            // 
            // sentToolStripMenuItem
            // 
            this.sentToolStripMenuItem.Name = "sentToolStripMenuItem";
            this.sentToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sentToolStripMenuItem.Text = "Inbox";
            // 
            // sentToolStripMenuItem1
            // 
            this.sentToolStripMenuItem1.Name = "sentToolStripMenuItem1";
            this.sentToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.sentToolStripMenuItem1.Text = "Sent";
            // 
            // writeAMessageToolStripMenuItem1
            // 
            this.writeAMessageToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toTeacherToolStripMenuItem,
            this.toMentorToolStripMenuItem,
            this.toGroupMateToolStripMenuItem});
            this.writeAMessageToolStripMenuItem1.Name = "writeAMessageToolStripMenuItem1";
            this.writeAMessageToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.writeAMessageToolStripMenuItem1.Text = "Write a message";
            // 
            // toTeacherToolStripMenuItem
            // 
            this.toTeacherToolStripMenuItem.Name = "toTeacherToolStripMenuItem";
            this.toTeacherToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.toTeacherToolStripMenuItem.Text = "To Teacher";
            // 
            // toMentorToolStripMenuItem
            // 
            this.toMentorToolStripMenuItem.Name = "toMentorToolStripMenuItem";
            this.toMentorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.toMentorToolStripMenuItem.Text = "To Mentor";
            // 
            // toGroupMateToolStripMenuItem
            // 
            this.toGroupMateToolStripMenuItem.Name = "toGroupMateToolStripMenuItem";
            this.toGroupMateToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.toGroupMateToolStripMenuItem.Text = "To Group Mate";
            // 
            // workMatesToolStripMenuItem
            // 
            this.workMatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherInfoToolStripMenuItem});
            this.workMatesToolStripMenuItem.Name = "workMatesToolStripMenuItem";
            this.workMatesToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.workMatesToolStripMenuItem.Text = "Work Mates";
            // 
            // teacherInfoToolStripMenuItem
            // 
            this.teacherInfoToolStripMenuItem.Name = "teacherInfoToolStripMenuItem";
            this.teacherInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.teacherInfoToolStripMenuItem.Text = "Teacher Info";
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addResourceToolStripMenuItem,
            this.deleteResourceToolStripMenuItem,
            this.showResoruceToolStripMenuItem});
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.libraryToolStripMenuItem.Text = "Library";
            // 
            // addResourceToolStripMenuItem
            // 
            this.addResourceToolStripMenuItem.Name = "addResourceToolStripMenuItem";
            this.addResourceToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addResourceToolStripMenuItem.Text = "Add Resource";
            // 
            // deleteResourceToolStripMenuItem
            // 
            this.deleteResourceToolStripMenuItem.Name = "deleteResourceToolStripMenuItem";
            this.deleteResourceToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteResourceToolStripMenuItem.Text = "Delete Resource";
            // 
            // showResoruceToolStripMenuItem
            // 
            this.showResoruceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resourcesLinkToolStripMenuItem,
            this.downloadFileToolStripMenuItem});
            this.showResoruceToolStripMenuItem.Name = "showResoruceToolStripMenuItem";
            this.showResoruceToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.showResoruceToolStripMenuItem.Text = "Show Resoruce";
            // 
            // resourcesLinkToolStripMenuItem
            // 
            this.resourcesLinkToolStripMenuItem.Name = "resourcesLinkToolStripMenuItem";
            this.resourcesLinkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resourcesLinkToolStripMenuItem.Text = "Resources Link";
            // 
            // downloadFileToolStripMenuItem
            // 
            this.downloadFileToolStripMenuItem.Name = "downloadFileToolStripMenuItem";
            this.downloadFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.downloadFileToolStripMenuItem.Text = "Download File";
            // 
            // educationalProjectDataSet
            // 
            this.educationalProjectDataSet.DataSetName = "EducationalProjectDataSet";
            this.educationalProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.educationalProjectDataSet;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // transcriptToolStripMenuItem
            // 
            this.transcriptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transcriptIdToolStripMenuItem,
            this.taskNameToolStripMenuItem,
            this.taskPointToolStripMenuItem});
            this.transcriptToolStripMenuItem.Name = "transcriptToolStripMenuItem";
            this.transcriptToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.transcriptToolStripMenuItem.Text = "Transcript";
            this.transcriptToolStripMenuItem.Click += new System.EventHandler(this.transcriptToolStripMenuItem_Click);
            // 
            // transcriptIdToolStripMenuItem
            // 
            this.transcriptIdToolStripMenuItem.Name = "transcriptIdToolStripMenuItem";
            this.transcriptIdToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.transcriptIdToolStripMenuItem.Text = "TranscriptId";
            //this.transcriptIdToolStripMenuItem.Click += new System.EventHandler(this.transcriptIdToolStripMenuItem_Click);
            // 
            // taskPointToolStripMenuItem
            // 
            this.taskPointToolStripMenuItem.Name = "taskPointToolStripMenuItem";
            this.taskPointToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.taskPointToolStripMenuItem.Text = "TaskPoint";
            // 
            // taskNameToolStripMenuItem
            // 
            this.taskNameToolStripMenuItem.Name = "taskNameToolStripMenuItem";
            this.taskNameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.taskNameToolStripMenuItem.Text = "TaskName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.educationalProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem showTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem updateTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignTasjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkSpecifiedStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chooseGroupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentorInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeAMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem writeAMessageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toMentorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toGroupMateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workMatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addResourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteResourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showResoruceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourcesLinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadFileToolStripMenuItem;
        private EducationalProjectDataSet educationalProjectDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private EducationalProjectDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem transcriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transcriptIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskPointToolStripMenuItem;
    }
}

