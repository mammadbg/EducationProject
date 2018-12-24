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
    public partial class TeacherInfo : Form
    {
        public TeacherInfo()
        {
            InitializeComponent();
        }

        EducationalProjectEntities context = new EducationalProjectEntities();

        private void cmbxTeacherList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in context.Teachers.ToList())
            {
                if (cmbxTeacherList.SelectedItem.ToString() == item.TeacherName)
                {
                    var form = new FakeForm();

                    form.Show();
                }
            }
            
        }

        private void TeacherInfo_Load(object sender, EventArgs e)
        {
            foreach (var item in context.Teachers.ToList())
            {
                cmbxTeacherList.Items.Add(item.TeacherName);
            }
        }
    }
}
