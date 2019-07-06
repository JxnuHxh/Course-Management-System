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
    public partial class FormScore : Form
    {
        private string tname;
        private int score;
        public FormScore(string anme)
        {
            InitializeComponent();
            this.tname = anme;
        }

        private void FormScore_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
            SqlDataAdapter qlcmd = new SqlDataAdapter
                ("select* from course_selected where tname='" + this.tname + "'", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            DataSet mdes = new DataSet();
            qlcmd.Fill(mdes);
            dataGridView1.DataSource = mdes.Tables[0];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int intID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
                SqlDataAdapter sqlcmd = new SqlDataAdapter("select * from course_selected where id='" + intID + "'", sqlcon);
                DataSet mds = new DataSet();
                sqlcmd.Fill(mds);
                if (mds.Tables[0].Rows.Count > 0)
                {
                    textBox1.Text = mds.Tables[0].Rows[0][1].ToString();
                    textBox2.Text = mds.Tables[0].Rows[0][2].ToString();
                    textBox3.Text = mds.Tables[0].Rows[0][3].ToString();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            score = Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text);
            textBox7.Text = score.ToString();
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
            SqlCommand sele = new SqlCommand
                ("insert into c_student(scode,sname,cname,gpa_score,paper_score,practice_score,score) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"');", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            if (Convert.ToInt32(sele.ExecuteNonQuery()) > 0)
            {
                MessageBox.Show("评定成功");

            }
            else
            {
                MessageBox.Show("评定失败");
            }
            
        }
    }
}
