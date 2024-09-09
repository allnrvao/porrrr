using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace suma
{
    public partial class suma : Form
    {
        int num1 = 0;
        int num2 = 0;

        public suma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        { 

        }

        private void TbNum1_TextChanged(object sender, EventArgs e)
        {
            int num1;
            bool esNumeroValido = int.TryParse(TbNum1.Text, out num1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void TbNum2_TextChanged(object sender, EventArgs e)
        {

            int num2;
            bool esNumeroValido = int.TryParse(TbNum2.Text, out num2);
        }

        private void BtmSumar_Click(object sender, EventArgs e)
        {
            int sumatotal = num1 + num2;
            MessageBox.Show("La suma es: " + sumatotal.ToString(), "Resultado de la Suma");
        }
    }
}
