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
    public partial class Zadacha3v1 : Form
    {
        public Zadacha3v1()
        {
            InitializeComponent();
            
        }
        private void fillData()
        {
            try
            {
                int plan = int.Parse(txtPlan.Text);
                int count = int.Parse(txtCount.Text);
                this.zadacha3TableAdapter.Fill(dataSet1.Zadacha3, plan, count);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Zadacha3v1_Load(object sender, EventArgs e)
        {
            
            fillData();

        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            fillData();
        }
    }
}
