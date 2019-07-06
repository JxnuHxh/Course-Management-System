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
    public partial class FormSelectstudent : Form
    {
        public FormSelectstudent()
        {
            InitializeComponent();
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {

            //SqlDataReader sqlData = DBHelper.GetDataReader("select * from student where scode='" + textBox1.Text + "';");
            //sqlData.Read();
            //// MessageBox.Show(Application.StartupPath);
            //string s = Application.StartupPath.Replace("\\bin\\Debug", "") + sqlData["photo"].ToString().Replace("\\", "/").Replace("~", "");
            //pictureBox1.Image = Image.FromFile(s);
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // SqlDataReader sqlData = DBHelper.GetDataReader("select* from student,class where scode='" + textBox2.Text + "'or name='" + textBox1.Text + "';");
           
            SqlDataReader sqlData = DBHelper.GetDataReader
                (" select scode,name,photo,gender,cname from student,class where scode='"+textBox2.Text+"'and name='"+textBox1.Text+"' and student.class_id =class.id");
              sqlData.Read();
            string s = Application.StartupPath.Replace("\\bin\\Debug", "") + sqlData["photo"].ToString();
            pictureBox1.Image = Image.FromFile(s);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            richTextBox1.Text = "姓名:"+sqlData["name"].ToString() + "\n"
                + "学号:" + sqlData["scode"].ToString() + "\n"
                + "性别:" + sqlData["gender"].ToString()+"\n"
                + "班级:" + sqlData["cname"].ToString() ;
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormSelectstudent_Load(object sender, EventArgs e)
        {

        }
    }
}
