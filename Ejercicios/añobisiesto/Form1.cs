using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace añobisiesto
{
    public partial class Form1 : Form
    {
        int año = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            año = int.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (año % 4 == 0)
            {
                label3.Text = "El año es bisiesto";
            }
            else {
                label3.Text = "El año no es bisiesto";
            }

        }
    }
}
