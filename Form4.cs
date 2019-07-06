using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 课程管理系统
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void ButtonInsect_Click(object sender, EventArgs e)
        {
            FormInsect formInsect = new FormInsect();
            formInsect.Show();
            this.Hide();
        }

        private void Buttonreturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain returns = new FrmMain();
            returns.Show();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            FormDelete delete = new FormDelete();
            delete.Show();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            FormUpdate update = new FormUpdate();
            update.Show();
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            FormSelectstudent selectstudent = new FormSelectstudent();
            selectstudent.Show();

        }

        private void ButtonSchedule_Click(object sender, EventArgs e)
        {
            Form开班 form = new Form开班();
            form.Show();
        }
    }
}
