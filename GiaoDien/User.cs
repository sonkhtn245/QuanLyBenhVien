using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
namespace GiaoDien
{
    public partial class User : Form
    {
        string connectionString = "USER ID = PHUONG;Password=123;DATA SOURCE = localhost:1521/xe;";
        public User()
        {
            InitializeComponent();
        }

        private void buttom_in_User_Click(object sender, EventArgs e)
        {
            using (OracleConnection orcCont = new OracleConnection(connectionString))
            {
                orcCont.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from all_users ", orcCont);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv1.DataSource = dtbl;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
