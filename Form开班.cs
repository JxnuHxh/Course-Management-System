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
    public partial class Form开班 : Form
    {
        public Form开班()
        {
            InitializeComponent();
        }

        private void Form开班_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
            SqlDataAdapter sqlcmd = new SqlDataAdapter("select* from course_selected ", sqlcon);
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
                SqlDataAdapter sqlcmd = new SqlDataAdapter("select * from course_selected where id=" + intID + "", sqlcon);
                DataSet mds = new DataSet();
                sqlcmd.Fill(mds);
                if (mds.Tables[0].Rows.Count > 0)
                {
                    textBox1.Text = mds.Tables[0].Rows[0][3].ToString();
                    textBox2.Text = mds.Tables[0].Rows[0][4].ToString();
                }
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
            SqlCommand sele = new SqlCommand("insert classs(cname,cnode,tname) values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedItem.ToString() + "')", sqlcon);
            SqlCommand sle = new SqlCommand("update course_selected set tname = '" + comboBox1.SelectedItem.ToString() + "'where canme ='"+textBox1.Text+"'", sqlcon);          
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            sle.ExecuteNonQuery();
            if (Convert.ToInt32(sele.ExecuteNonQuery()) > 0)
            {
                MessageBox.Show("开班成功");
            }
            else
            {
                MessageBox.Show("开班失败");
            }
            SqlDataAdapter sqlcmd = new SqlDataAdapter("select* from classs ", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            DataSet mdes = new DataSet();
            sqlcmd.Fill(mdes);
            dataGridView2.DataSource = mdes.Tables[0];
            for (int i = 0; i < dataGridView2.ColumnCount; i++)
                dataGridView2.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow dgvRow in dataGridView2.Rows)
            {
                if (dgvRow.Index % 2 == 0)
                {
                    dataGridView2.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    dataGridView2.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
            dataGridView2.ReadOnly = true;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
        }

       

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int inI = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
                SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
                SqlDataAdapter sqlcmd = new SqlDataAdapter("select * from classs where id=" + inI + "", sqlcon);
                DataSet mds = new DataSet();
                sqlcmd.Fill(mds);
                if (mds.Tables[0].Rows.Count > 0)
                {
                    textBox3.Text = mds.Tables[0].Rows[0][1].ToString();
                    textBox4.Text = mds.Tables[0].Rows[0][3].ToString();
                }
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
            SqlCommand sele = new SqlCommand("delete  classs where cnode='" + textBox3.Text + "'and tname='"+textBox4.Text+"'", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            SqlCommand selec = new SqlCommand("update course_selected set tname=NULL where ccode='" + textBox3.Text + "'", sqlcon);
            selec.ExecuteNonQuery();
            if (Convert.ToInt32(sele.ExecuteNonQuery()) > 0)
            {
                MessageBox.Show("删除成功");

            }
            else
            {
                MessageBox.Show("删除失败");
            }
            SqlDataAdapter sqlcmd = new SqlDataAdapter("select * from classs ", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            DataSet mdes = new DataSet();
            sqlcmd.Fill(mdes);
            dataGridView2.DataSource = mdes.Tables[0];
            for (int i = 0; i < dataGridView2.ColumnCount; i++)
                dataGridView2.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow dgvRow in dataGridView2.Rows)
            {
                if (dgvRow.Index % 2 == 0)
                {
                    dataGridView2.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    dataGridView2.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
            dataGridView2.ReadOnly = true;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
        }

    }
}

