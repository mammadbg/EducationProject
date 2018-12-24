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
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'educationalProjectDataSet2.Task' table. You can move, or remove it, as needed.
            this.taskTableAdapter.Fill(this.educationalProjectDataSet2.Task);

        }

       
    }
}
