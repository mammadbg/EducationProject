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
    public partial class FakeForm : Form
    {
        public FakeForm()
        {
            InitializeComponent();
        }

        EducationalProjectEntities context = new EducationalProjectEntities();

       

     

        private void FakeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'educationalProjectDataSet1.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.educationalProjectDataSet1.Student);

          

            foreach (var item in context.Programings)
            {
                var result = item.Teachers.Where(x => x.ProgramId == Convert.ToInt32(cbxChooseGroup.SelectedItem.ToString()));
            }


          
           

            foreach (var item in context.Programings)
            {
                cbxChooseGroup.Items.Add(item.ProgramId);
            }

            //using (febfebfe)
            //{
            //    context.Teachers.Where(x => x.TeacherId == _id).ToList();
            //}

          

            //foreach (var item in context.Groups)
            //{

            //    if (item.TeacherId )
            //    {
            //        dataGridView1.DataSource =
            //    }
            //}


        }
    }
}
