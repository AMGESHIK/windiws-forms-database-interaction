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
    public partial class Zadacha2v2 : Form
    {
        public Zadacha2v2()
        {
            InitializeComponent();
        }

        private void Zadacha2v2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.dataSet1.delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.accounting". При необходимости она может быть перемещена или удалена.
            this.accountingTableAdapter.Fill(this.dataSet1.accounting);
            QueryZapr2();

        }

        private void QueryZapr2()
        {


            int code = int.Parse(txtCode.Text);
            dataSet1.Zadacha2.Clear();
            foreach (DataSet1.accountingRow aRow in dataSet1.accounting.Rows)
            {
                foreach (DataSet1.deliveryRow dRow in dataSet1.delivery.Rows)
                {
                    if (aRow.code_of_material == dRow.code_of_material && aRow.code_of_material == code && aRow.number_of_contract == dRow.number_of_contract)
                    {
                        DataSet1.Zadacha2Row zRow = dataSet1.Zadacha2.NewZadacha2Row();
                        zRow.number_of_contract = dRow.number_of_contract;
                        zRow.plan = dRow.plan;
                        zRow.date_of_end = dRow.date_of_end;
                        zRow.count = aRow.count;
                        dataSet1.Zadacha2.Rows.Add(zRow);
                        break;
                    }


                }

            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            QueryZapr2();

        }
    }
}
