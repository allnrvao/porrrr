using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluarEdades
{
    public partial class Form1 : Form
    {
        int edad = 0;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out parsedAge))
            {
                edad = parsedAge;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(edad <= 13)
            {
                label3.Text = "Eres un niño";
            }
            else 
            {
                if (edad > 14 && edad < 20)
                {
                    label3.Text = "Eres un adolescente";
                }
                else {
                    if (edad > 19 && edad < 65)
                    {
                        label3.Text = "Eres un adulto";
                    }
                    else { label3.Text = "Eres un anciano"; }
                }

            
            }
        }
    }
}
