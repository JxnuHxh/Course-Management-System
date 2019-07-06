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
    public partial class Form预选 : Form
    {
        SqlConnection sqlcon;
         SqlDataAdapter sqlcmd,sele;
        DataSet mds,mdes;
        private string scode, sname;
        public Form预选(string scode,string sname)
        {
            InitializeComponent();
            this.scode = scode;
            this.sname = sname;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        

        private void Form预选_Load(object sender, EventArgs e)
        {
            string sql = "select * from education_program";
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            sqlData.Read();
            label2.Text = "专业:" + sqlData["name"].ToString() 
                + " 目的:" + sqlData["objective"].ToString() + "\n"
                + " 学年:" + sqlData["duration"].ToString() 
                + " 学位:" + sqlData["degree"].ToString()
                 + " 最低学分:" + sqlData["min_credit"].ToString()
                  + " 发布年份:" + sqlData["publish_year"].ToString();
            sqlData.Close();

             sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
            sqlcmd = new SqlDataAdapter("select * from course", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            mds = new DataSet();
            sqlcmd.Fill(mds);
            dataGridView1.DataSource = mds.Tables[0];
            for(int i=0;i<dataGridView1.ColumnCount;i++)
            dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach(DataGridViewRow dgvRow in dataGridView1.Rows)
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
            sqlcon.Close();
        }

       

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                int intID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
                sqlcmd = new SqlDataAdapter("select * from course where id='"+intID+"'",sqlcon);
                mds = new DataSet();
                sqlcmd.Fill(mds);
                if(mds.Tables[0].Rows.Count>0)
                {
                    textBox1.Text = mds.Tables[0].Rows[0][1].ToString();
                    textBox2.Text = mds.Tables[0].Rows[0][2].ToString(); 
                }
            }
            sqlcon.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
            SqlCommand sele =new SqlCommand("insert course_selected(scode,sname,canme,ccode) values('"+this.scode+"','"+this.sname+"','"+textBox2.Text+"','"+textBox1.Text+"')", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            if (Convert.ToInt32(sele.ExecuteNonQuery()) > 0)
            {
                MessageBox.Show("增加成功");

            }
            else
            {
                MessageBox.Show("增加失败");
            }
            sqlcmd = new  SqlDataAdapter("select* from course_selected where scode='"+this.scode+"'" , sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            mdes = new DataSet();
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
            sqlcmd = new SqlDataAdapter("select* from course_selected where scode='" + this.scode + "'", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            mdes = new DataSet();
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
            if (e.RowIndex >= 0)
            {
                int intI = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
                sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
                sqlcmd = new SqlDataAdapter("select * from course_selected where id=" + intI + "", sqlcon);
                mds = new DataSet();
                sqlcmd.Fill(mds);
                if (mds.Tables[0].Rows.Count > 0)
                {
                    textBox3.Text = mds.Tables[0].Rows[0][4].ToString();
                    textBox4.Text = mds.Tables[0].Rows[0][3].ToString();
                    textBox5.Text = mds.Tables[0].Rows[0][0].ToString();
                }
            }
            sqlcon.Close();
            //if (e.RowIndex >= 0)
            //{
            //    String intI = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            //    sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
            //    SqlCommand sqlcmd = new SqlCommand("delete  from course_selected where ccode=" + intI + "", sqlcon);
            //    if (sqlcon.State == ConnectionState.Closed)
            //    { sqlcon.Open(); }
            //    if (Convert.ToInt32(sqlcmd.ExecuteNonQuery()) > 0)
            //    {
            //        MessageBox.Show("删除成功");

            //    }
            //    else
            //    {
            //        MessageBox.Show("删除失败");
            //    }
            //    sele = new SqlDataAdapter("select scode,sname,canme,ccode from course_selected where scode='" + intI + "'", sqlcon);
            //    if (sqlcon.State == ConnectionState.Closed)
            //    { sqlcon.Open(); }
            //    mdes = new DataSet();
            //    sele.Fill(mdes);
            //    dataGridView2.DataSource = mdes.Tables[0];
            //    for (int i = 0; i < dataGridView2.ColumnCount; i++)
            //        dataGridView2.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            //    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //    foreach (DataGridViewRow dgvRow in dataGridView2.Rows)
            //    {
            //        if (dgvRow.Index % 2 == 0)
            //        {
            //            dataGridView2.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
            //        }
            //        else
            //        {
            //            dataGridView2.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.LightPink;
            //        }
            //    }
            //    dataGridView2.ReadOnly = true;
            //    dataGridView2.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

            //}
            //sqlcon.Close();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
            SqlCommand sele = new SqlCommand("delete  from course_selected where id=" +textBox5.Text+ "", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            if (Convert.ToInt32(sele.ExecuteNonQuery())>0)
            {
                MessageBox.Show("删除成功");

            }
            else
            {
                MessageBox.Show("删除失败");
            }
            sqlcmd = new SqlDataAdapter("select scode,sname,canme,ccode from course_selected where scode='" + this.scode + "'", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            mdes = new DataSet();
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
