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
    public partial class Zadacha3v2 : Form
    {
        public Zadacha3v2()
        {
            InitializeComponent();
        }

        private void QueryZapr3()
        {
            int plan = int.Parse(txtPlan.Text);
            int count = int.Parse(txtCount.Text);
            dataSet1.Zadacha3.Clear();
            foreach(DataSet1.availabilityRow avRow in dataSet1.availability.Rows)
            {
                foreach(DataSet1.deliveryRow dRow in dataSet1.delivery.Rows)
                {
                    if (dRow.plan <= plan || avRow.code_of_material != dRow.code_of_material)
                        continue;
                    bool bDel = false;
                    foreach (DataSet1.accountingRow aRow in dataSet1.accounting.Rows)
                    {
                        if (aRow.count > count && aRow.code_of_material == dRow.code_of_material && aRow.number_of_contract == dRow.number_of_contract && aRow.number_of_warehouse == avRow.number_of_warehouse)
                        {
                            bDel = true;
                        }
                        if (bDel)
                        {
                            break;
                        }
                    }
                    if (bDel)
                    {
                        DataSet1.Zadacha3Row zRow = dataSet1.Zadacha3.NewZadacha3Row();
                        zRow.code_of_material = avRow.code_of_material;
                        zRow.quantity = avRow.quantity;
                        dataSet1.Zadacha3.Rows.Add(zRow);
                        break;
                    } 
                    
                }
            }
            
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            QueryZapr3(); 
        }

        private void Zadacha3v2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.dataSet1.delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.availability". При необходимости она может быть перемещена или удалена.
            this.availabilityTableAdapter.Fill(this.dataSet1.availability);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.accounting". При необходимости она может быть перемещена или удалена.
            this.accountingTableAdapter.Fill(this.dataSet1.accounting);
            QueryZapr3();
        }
    }
}
