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
    public partial class FormTeacher : Form
    {
        private string tcode;
        
        public FormTeacher(string tcode)
        {
            InitializeComponent();
            this.tcode = tcode;
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            SqlDataReader sqlData = DBHelper.GetDataReader("select * from teacher where tcode='" + this.tcode + "';");
            sqlData.Read();
            // MessageBox.Show(Application.StartupPath);
            string s = Application.StartupPath.Replace("\\bin\\Debug", "") + sqlData["photo"].ToString().Replace("\\", "/").Replace("~", "");
            pictureBox1.Image = Image.FromFile(s);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            label1.Text = sqlData["name"].ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormSelectstudent selectstudent = new FormSelectstudent();
            selectstudent.Show();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormScan scan = new FormScan();
            scan.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FormScore score = new FormScore(label1.Text.ToString());
            score.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain returns = new FrmMain();
            returns.Show();
        }
    }
}
