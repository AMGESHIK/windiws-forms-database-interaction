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
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void accountingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.dataSet1.delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.availability". При необходимости она может быть перемещена или удалена.
            this.availabilityTableAdapter.Fill(this.dataSet1.availability);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.accounting". При необходимости она может быть перемещена или удалена.
            this.accountingTableAdapter.Fill(this.dataSet1.accounting);

        }

        private void deliveryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAccounting_Click(object sender, EventArgs e)
        {
            accountingBindingNavigator.BindingSource = accountingBindingSource;
            lblTable.Text = "Учет";
            dgvAccounting.DataSource = accountingBindingSource;
        }

        private void dgvDelivery_Click(object sender, EventArgs e)
        {
            accountingBindingNavigator.BindingSource = deliveryBindingSource;
            lblTable.Text = "Доставка";
            dgvAccounting.DataSource = deliveryaccountingBindingSource;
        }

        private void dgvAvailability_Click(object sender, EventArgs e)
        {
            accountingBindingNavigator.BindingSource = availabilityBindingSource;
            lblTable.Text = "Наличие";
            dgvAccounting.DataSource = availabilityaccountingBindingSource;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                deliveryTableAdapter.Update(dataSet1.delivery);
                availabilityTableAdapter.Update(dataSet1.availability);
                accountingTableAdapter.Update(dataSet1.accounting);
                MessageBox.Show("Изменения сохранены!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка базы данных");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {   if (lblTable.Text == "Учет")
            {
                int col = dgvAccounting.CurrentCell.ColumnIndex;
                int row = dgvAccounting.CurrentCell.RowIndex;
                if (row < dgvAccounting.RowCount - 1)
                {
                    dgvAccounting.CurrentCell = dgvAccounting[col, row + 1];
                }
            }

            if (lblTable.Text == "Доставка")
            {
                int col = dgvDelivery.CurrentCell.ColumnIndex;
                int row = dgvDelivery.CurrentCell.RowIndex;
                if (row < dgvDelivery.RowCount - 1)
                {
                    dgvDelivery.CurrentCell = dgvDelivery[col, row + 1];
                }
            }

            if (lblTable.Text == "Наличие")
            {
                int col = dgvAvailability.CurrentCell.ColumnIndex;
                int row = dgvAvailability.CurrentCell.RowIndex;
                if (row < dgvAvailability.RowCount - 1)
                {
                    dgvAvailability.CurrentCell = dgvAvailability[col, row + 1];
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblProc_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            string conStr = String.Format("Username=postgres; Password=qwerty; Host=localhost; Persist Security Info=True; Database=postgres");
            lblProc.Visible = true;
            NpgsqlConnection con = new NpgsqlConnection(conStr);
            con.Open();
            string sql = @"CALL sum_quantity1(:warehouse, :number)";
            NpgsqlCommand command = new NpgsqlCommand(sql, con);
            command.Parameters.AddWithValue("warehouse", Convert.ToInt32(txtBoxWsrehouse.Text));
            command.Parameters.AddWithValue("number", 0);
            DataTable dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());
            DataRow[] data_rows = dataTable.Select();
            lblProc.Text = "Результат: " + data_rows[0][0].ToString();
            con.Close();
        }

        private void dgvAccounting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lblTable.Text == "Учет")
            {
                int col = dgvAccounting.CurrentCell.ColumnIndex;
                int row = dgvAccounting.CurrentCell.RowIndex;
                if (row > 0)
                {
                    dgvAccounting.CurrentCell = dgvAccounting[col, row - 1];
                }
            }

            if (lblTable.Text == "Доставка")
            {
                int col = dgvDelivery.CurrentCell.ColumnIndex;
                int row = dgvDelivery.CurrentCell.RowIndex;
                if (row > 0)
                {
                    dgvDelivery.CurrentCell = dgvDelivery[col, row - 1];
                }
            }

            if (lblTable.Text == "Наличие")
            {
                int col = dgvAvailability.CurrentCell.ColumnIndex;
                int row = dgvAvailability.CurrentCell.RowIndex;
                if (row > 0)
                {
                    dgvAvailability.CurrentCell = dgvAvailability[col, row - 1];
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.availabilityTableAdapter.Fill(this.dataSet1.availability);

            this.accountingTableAdapter.Fill(this.dataSet1.accounting);

            this.deliveryTableAdapter.Fill(this.dataSet1.delivery);

            MessageBox.Show("Данные обновлены");
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (lblTable.Text == "Учет")
            {
                int nCol = dgvAccounting.CurrentCell.ColumnIndex;
                dgvAccounting.CurrentCell = dgvAccounting[nCol, 0];
            }

            if (lblTable.Text == "Доставка")
            {
                int nCol = dgvDelivery.CurrentCell.ColumnIndex;
                dgvDelivery.CurrentCell = dgvDelivery[nCol, 0];
            }

            if (lblTable.Text == "Наличие")
            {
                int nCol = dgvAvailability.CurrentCell.ColumnIndex;
                dgvAvailability.CurrentCell = dgvAvailability[nCol, 0];
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {

            if (lblTable.Text == "Учет")
            {
                int nRow = dgvAccounting.RowCount;
                int nCol = dgvAccounting.CurrentCell.ColumnIndex;
                dgvAccounting.CurrentCell = dgvAccounting[nCol, nRow - 2];
            }

            if (lblTable.Text == "Доставка")
            {
                int nRow = dgvDelivery.RowCount;
                int nCol = dgvDelivery.CurrentCell.ColumnIndex;
                dgvDelivery.CurrentCell = dgvDelivery[nCol, nRow - 2];
            }

            if (lblTable.Text == "Наличие")
            {
                int nRow = dgvAvailability.RowCount;
                int nCol = dgvAvailability.CurrentCell.ColumnIndex;
                dgvAvailability.CurrentCell = dgvAvailability[nCol, nRow - 2];
            }
        }

        private void accountingBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void альтернативнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void формыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void вариант1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha1v1 z11 = new Zadacha1v1();
            z11.ShowDialog();
        }

        private void вариант2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha1v2 z12 = new Zadacha1v2();
            z12.ShowDialog();
        }

        private void вариант3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha1v3 z13 = new Zadacha1v3();
            z13.ShowDialog();
        }

        private void вариант4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha1v4 z14 = new Zadacha1v4();
            z14.ShowDialog();
        }

        private void вариант5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha1v5 z15 = new Zadacha1v5();
            z15.ShowDialog();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View vi = new View();
            vi.ShowDialog();
        }

        private void вариант1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Zadacha2v1 z21 = new Zadacha2v1();
            z21.ShowDialog();
        }

        private void вариант2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Zadacha2v2 z22 = new Zadacha2v2();
            z22.ShowDialog();
        }

        private void вариант1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Zadacha3v1 z31 = new Zadacha3v1();
            z31.Show();
        }

        private void вариант2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Zadacha3v2 z32 = new Zadacha3v2();
            z32.Show();
        }
    }
}
