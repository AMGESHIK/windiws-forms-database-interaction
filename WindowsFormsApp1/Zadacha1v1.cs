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
    public partial class Zadacha1v1 : Form
    {
        public Zadacha1v1()
        {
            InitializeComponent();
        }
        private void fillData() 
        {
            try
            {
                int number = int.Parse(txtNumber.Text);
                this.zadacha1TableAdapter.Fill(dataSet1.Zadacha1, number);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Zadacha1v1_Load(object sender, EventArgs e)
        {
            fillData();


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            fillData();
        }
    }
}
