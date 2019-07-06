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
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
            string sql = "update student set name='"+textBox2.Text+"',gender='"+textBox4.Text+"',class_id='"+textBox3.Text+"'where scode='"+textBox1.Text+"'";
            SqlCommand sqlcmd = new SqlCommand(sql, sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            if (Convert.ToInt32(sqlcmd.ExecuteNonQuery()) > 0)
            {
                label1.Text = " 修改成功！";
            }
            else
            {
                label1.Text = " 修改失败！";
            }
        }
    }
}
