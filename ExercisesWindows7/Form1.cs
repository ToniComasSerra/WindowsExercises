using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercisesWindows7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Colores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Seleccion.Text = "The color choosen is: " + Colores.SelectedItem.ToString();
        }

        private void Seleccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
