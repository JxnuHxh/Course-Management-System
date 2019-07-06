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
    public partial class FormInsect : Form
    {
        public FormInsect()
        {
            InitializeComponent();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
            
            string sql = "insert into student(scode,name,gender,password,class_id)" +
                "values('"+ textBoxScode.Text+"','"+textBoxName.Text+"','"+textBoxGender.Text+"','"+textBoxPassword.Text+"','"+textBoxClass.Text+"')";
           SqlCommand sqlcmd = new SqlCommand(sql, sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            if (Convert.ToInt32(sqlcmd.ExecuteNonQuery())>0)
            {
                MessageBox.Show("增加成功");
                
            }
            else
            {
                MessageBox.Show("增加失败");
            }
        }

        private void TextBoxScode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buttonreturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 returns = new Form4();
            returns.Show();
        }

        private void FormInsect_Load(object sender, EventArgs e)
        {

        }
    }
}
