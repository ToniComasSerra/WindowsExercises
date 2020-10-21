using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercisesWindows10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Percentage.Text = "The percentage of the scrollbar is: " + ScrollBar.Value.ToString() + "%";
        }

        private void Percentage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
