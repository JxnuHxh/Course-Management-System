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
    public partial class FormScan : Form
    {
        public FormScan()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
            SqlDataAdapter sqlcmd = new SqlDataAdapter("select * from teacher where tcode='" + textBox1.Text + "'or name='" + textBox2.Text + "'", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            DataSet mds = new DataSet();
            sqlcmd.Fill(mds);
            string s = Application.StartupPath.Replace("\\bin\\Debug", "") + mds.Tables[0].Rows[0][8].ToString();
            pictureBox1.Image = Image.FromFile(s);
            richTextBox1.Text = "姓名:" + mds.Tables[0].Rows[0][2].ToString() + "\n"
                + "教工号:" + mds.Tables[0].Rows[0][1].ToString() + "\n"
                + "性别:" + mds.Tables[0].Rows[0][4].ToString() + "\n"
                + "学位:" + mds.Tables[0].Rows[0][5].ToString() + "\n"
                + "职称:" + mds.Tables[0].Rows[0][6].ToString() + "\n"
                + mds.Tables[0].Rows[0][7].ToString();
        }

        private void FormScan_Load(object sender, EventArgs e)
        {

        }
    }
}
