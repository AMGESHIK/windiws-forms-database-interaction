using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Zadacha1v5 : Form
    {
        int count;
        public Zadacha1v5()
        {
            InitializeComponent();
            FillByDataReader();
        }

        private void FillByDataReader()
        {
            string conStr = String.Format("Username=postgres; Password=qwerty; Host=localhost; Persist Security Info=True; Database=postgres");
            NpgsqlConnection con = new NpgsqlConnection(conStr);
            con.Open();
            string str = "SELECT kursach.accounting.\"code of material\", kursach.accounting.\"number of reception document\", kursach.accounting.\"receipt date\", kursach.accounting.\"count\", kursach.delivery.\"number of contract\", kursach.delivery.plan, kursach.delivery.\"date of end\"" + 
    "FROM kursach.accounting INNER JOIN kursach.delivery ON kursach.accounting.\"number of contract\" = kursach.delivery.\"number of contract\"" +
"WHERE kursach.accounting.\"number of warehouse\" = " + count;
            NpgsqlCommand cmd = new NpgsqlCommand(str, con);
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(rdr);
            con.Close();
            BindingSource bs = new BindingSource();
            bs.DataSource = dataTable;
            zadacha1DataGridView.DataSource = bs;
            zadacha1BindingNavigator.BindingSource = bs;
            zadacha1DataGridView.Refresh();




        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            count = int.Parse(txtNumber.Text);

            FillByDataReader();
        }

        private void Zadacha1v5_Load(object sender, EventArgs e)
        {
            
            FillByDataReader();
        }
    }
}
