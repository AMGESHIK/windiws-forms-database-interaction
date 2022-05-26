using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void accountingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.accounting". При необходимости она может быть перемещена или удалена.
            this.accountingTableAdapter.Fill(this.dataSet1.accounting);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.dataSet1.delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.availability". При необходимости она может быть перемещена или удалена.
            this.availabilityTableAdapter.Fill(this.dataSet1.availability);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.dataSet1.delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.dataSet1.delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.accounting". При необходимости она может быть перемещена или удалена.
            this.accountingTableAdapter.Fill(this.dataSet1.accounting);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.availability". При необходимости она может быть перемещена или удалена.
            this.availabilityTableAdapter.Fill(this.dataSet1.availability);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.dataSet1.delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.dataSet1.delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.availability". При необходимости она может быть перемещена или удалена.
            this.availabilityTableAdapter.Fill(this.dataSet1.availability);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.accounting". При необходимости она может быть перемещена или удалена.
            this.accountingTableAdapter.Fill(this.dataSet1.accounting);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.accounting". При необходимости она может быть перемещена или удалена.
            this.accountingTableAdapter.Fill(this.dataSet1.accounting);

            dataGridView.AutoGenerateColumns = true;

        }

        private void accountingBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.accountingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void deliveryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.deliveryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void availabilityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.availabilityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void deliveryBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.deliveryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void availabilityBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.availabilityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            
                if (lblTableName.Text != "Наличие")
                {
                    dataGridView.Columns.Clear();
                    dataGridView.DataSource = availabilityBindingSource;
                    availabilityBindingNavigator.BindingSource = availabilityBindingSource;
                    lblTableName.Text = "Наличие";
                }
            
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {

            if (lblTableName.Text != "Доставка")
            {
                dataGridView.Columns.Clear();
                dataGridView.DataSource = deliveryBindingSource;
                availabilityBindingNavigator.BindingSource = deliveryBindingSource;
                lblTableName.Text = "Доставка";
            }
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {

            if (lblTableName.Text != "Учет")
            {
                dataGridView.Columns.Clear();
                dataGridView.DataSource = accountingBindingSource;
                availabilityBindingNavigator.BindingSource = accountingBindingSource;
                lblTableName.Text = "Учет";
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tableAdapterManager.UpdateAll(dataSet1);
            MessageBox.Show("Изменения сохранены");
        }
    }
}
