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
    public partial class Zadacha1v3 : Form
    {
        public Zadacha1v3()
        {
            InitializeComponent();
        }

        private void Zadacha1v3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.dataSet1.delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.accounting". При необходимости она может быть перемещена или удалена.
            this.accountingTableAdapter.Fill(this.dataSet1.accounting);
            QueryZapr2();
        }
        private void QueryZapr2()
        {


            int count = int.Parse(txtNumber.Text);
            dataSet1.Zadacha1.Clear();
            foreach (DataSet1.accountingRow aRow in dataSet1.accounting.Rows)
            {
                
                if (aRow.number_of_warehouse == count)
                {
                    DataSet1.deliveryRow dRow = aRow.GetParentRow("delivery_accounting") as DataSet1.deliveryRow;
                    DataSet1.Zadacha1Row zRow = dataSet1.Zadacha1.NewZadacha1Row();
                    zRow.code_of_material = aRow.code_of_material;
                    zRow.number_of_reception_document = aRow.number_of_reception_document;
                    zRow.receipt_date = aRow.receipt_date;
                    zRow.count = aRow.count;
                    zRow.number_of_contract = dRow.number_of_contract;
                    zRow.plan = dRow.plan;
                    zRow.date_of_end = dRow.date_of_end;
                    dataSet1.Zadacha1.Rows.Add(zRow);
                }
                    
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            QueryZapr2();
        }
    }
}
