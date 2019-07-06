using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 课程管理系统
{
    public partial class 
        
           FrmStudentLogin : Form
    {
        private string scode;
        public FrmStudentLogin(string scode)
        {
            InitializeComponent();
            this.scode = scode;
        }
        public FrmStudentLogin()
        {
            InitializeComponent();
        }
        private void FrmStudentLogin_Load(object sender, EventArgs e)
        {
            photoinit();
           
        }
       
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void photoinit()
        {
            SqlDataReader sqlData = DBHelper.GetDataReader("select * from student where scode='" + this.scode + "';");
            sqlData.Read();
            // MessageBox.Show(Application.StartupPath);
            string s = Application.StartupPath.Replace("\\bin\\Debug", "") + sqlData["photo"].ToString();
            pictureBox1.Image = Image.FromFile(s);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            labelName.Text = sqlData["name"].ToString();
           
        }

        private void Buttonselect_Click(object sender, EventArgs e)
        {
           
            FormSelectcourse select = new FormSelectcourse(scode);
            select.Show();

        }

        private void Buttonreturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain returns = new FrmMain();
            returns.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonPrimary_Click(object sender, EventArgs e)
        {
            Form预选 form = new Form预选(this.scode, labelName.Text);
            form.Show();
        }

        private void ButtonSelectstudent_Click(object sender, EventArgs e)
        {
            FormSelectstudent formSelectstudent = new FormSelectstudent();
            formSelectstudent.Show();
        }

        private void ButtonSelectteacher_Click(object sender, EventArgs e)
        {
            FormScan selectteacher = new FormScan();
            selectteacher.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            FormSelectAchievement achievement = new FormSelectAchievement(scode);
            achievement.Show();
        }
    }
}
