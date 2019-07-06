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
    public partial class FormSelectcourse : Form
    {
        private string scode;
        public FormSelectcourse(string scode)
        {
            InitializeComponent();
            this.scode = scode;
        }


        private void Buttonreturn_Click(object sender, EventArgs e)
        {

        }

        private void Formselectcourse_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
            SqlDataAdapter sqlcmd = new SqlDataAdapter("select* from classs", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            DataSet mdes = new DataSet();
            sqlcmd.Fill(mdes);
            dataGridView1.DataSource = mdes.Tables[0];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
            {
                if (dgvRow.Index % 2 == 0)
                {
                    dataGridView1.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    dataGridView1.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
            dataGridView1.ReadOnly = true;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int intID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
                SqlDataAdapter sqlcmd = new SqlDataAdapter("select * from classs where id=" + intID + "", sqlcon);
                DataSet mds = new DataSet();
                sqlcmd.Fill(mds);
                if (mds.Tables[0].Rows.Count > 0)
                {
                    textBox1.Text = mds.Tables[0].Rows[0][2].ToString();
                    textBox2.Text = mds.Tables[0].Rows[0][3].ToString();
                }
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
            SqlDataAdapter sqlcmd = new SqlDataAdapter("select* from course_selected where scode='"+this.scode+"'and canme='"+textBox1.Text+"' ", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            DataSet mdes = new DataSet();
            sqlcmd.Fill(mdes);
            dataGridView2.DataSource = mdes.Tables[0];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                dataGridView2.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dataGridView2.ReadOnly = true;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
        }
    }
}
