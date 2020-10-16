using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercisesWindows6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            String option = " ";
            if (Red.Checked == true)
            {
                option = "Red";
            }
            else if (Blue.Checked == true)
            {
                option = "Blue";
            }
            else if (Yellow.Checked == true)
            {
                option = "Yellow";
            }
            Result.Text = "The selected color is: " + option;
        }

        private void Red_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Blue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Yellow_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
