using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEducation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EducationProjectEntities context = new EducationProjectEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'educationalProjectDataSet.Teacher' table. You can move, or remove it, as needed.
            //this.teacherTableAdapter.Fill(this.educationalProjectDataSet.Teacher);

        }

        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherInfo teacherInfo = new TeacherInfo();

            teacherInfo.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var form2 = new TaskForm();

            form2.Show();
        }


        private void transcriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
