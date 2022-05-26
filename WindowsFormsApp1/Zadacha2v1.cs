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
    public partial class Zadacha2v1 : Form
    {
        public Zadacha2v1()
        {
            InitializeComponent();
        }

        private void fillData()
        {
            try
            {
                int code = int.Parse(txtCode.Text);
                this.zadacha2TableAdapter.Fill(dataSet1.Zadacha2, code);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            fillData();
        }
    }
}
