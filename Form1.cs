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
using System.Data.SqlClient;

namespace 课程管理系统
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = Application.StartupPath + @"\MP10.ssk";
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == "管理员")
            {
                string sql = "select * from admin where id='" + textBox1.Text + "' and password='" + textBox2.Text + "';";
                SqlDataReader sqlData = DBHelper.GetDataReader(sql);
                if (sqlData.HasRows)
                {
                    MessageBox.Show("管理员登录成功");
                    this.Hide();
                    Form4 managment = new Form4();
                    managment.Show();
                }
                else
                {
                    MessageBox.Show("用户名不存在或密码错误");
                }
              
            }

                if (comboBox1.SelectedItem.ToString() == "学生")
                {
                    string sql = "select * from student where scode='" + textBox1.Text + "' and password='" + textBox2.Text + "';";
                    SqlDataReader sqlData = DBHelper.GetDataReader(sql);
                if (sqlData.HasRows)
                {
                    MessageBox.Show("学生登录成功");
                    
                    this.Hide();
                    FrmStudentLogin student = new FrmStudentLogin(textBox1.Text);
                    student.Show();
                }
                else
                {
                    MessageBox.Show("用户名不存在或密码错误");
                }
            }
                if (comboBox1.SelectedItem.ToString() == "教师")
                {
                string sql = "select * from teacher where tcode='" + textBox1.Text + "' and password='" + textBox2.Text + "';";
                SqlDataReader sqlData = DBHelper.GetDataReader(sql);
                if (sqlData.HasRows)
                {
                    MessageBox.Show("教师登录成功");
                    this.Hide();
                    FormTeacher teacher = new FormTeacher(textBox1.Text);
                    teacher.Show();
                }
                else
                {
                    MessageBox.Show("用户名不存在或密码错误");
                }
            }
            
            

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
