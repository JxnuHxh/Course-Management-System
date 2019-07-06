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
    public partial class FormSelectAchievement : Form
    {
        private string scode;
        public FormSelectAchievement(string scode)
        {
            InitializeComponent();
            this.scode = scode;
        }

        private void FormSelectAchievement_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True");
            SqlDataAdapter sqlcmd = new SqlDataAdapter("select * from c_student where scode='"+this.scode+"' ", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            { sqlcon.Open(); }
            DataSet mds = new DataSet();
            sqlcmd.Fill(mds);
            dataGridView1.DataSource = mds.Tables[0];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
               dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
