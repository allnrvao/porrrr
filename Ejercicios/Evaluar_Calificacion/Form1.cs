using System;
using Evaluar_Calificacion.clases;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluar_Calificacion
{
    
    public partial class Form1 : Form
    {
        Estudiante estudiante = new Estudiante();
        public Form1()
        {
            InitializeComponent();
        }

        private void TbNombre_TextChanged(object sender, EventArgs e)
        {
            estudiante.nombre = TbNombre.ToString();
            
        }

        private void TbMateria_TextChanged(object sender, EventArgs e)
        {
            estudiante.materia = TbMateria.ToString();
        }

        private void Tbcalificacion_TextChanged(object sender, EventArgs e)
        {
            estudiante.nota = Convert.ToInt16(Tbcalificacion.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (estudiante.nota >= 90)
            {
                LbEvaluacion.Text = "A";
            }
            else
            {
                if (estudiante.nota >= 80 && estudiante.nota < 90)
                {
                    LbEvaluacion.Text = "B";
                }
                else
                {
                    LbEvaluacion.Text = "c";
                }
            }
        }
    }
}
