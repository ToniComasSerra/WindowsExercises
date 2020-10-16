using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercisesWindows5
{
    public partial class Form1 : Form
    {
        String first, second, third = " ";

        private void checkMouse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkCat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkDog_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (checkMouse.Checked == true)
            {
                first = "Mouse";
            }
            else
            {
                first = " ";
            }
            if (checkCat.Checked == true)
            {
                second = "Cat";
            }
            else
            {
                second = " ";
            }
            if (checkDog.Checked == true)
            {
                third = "Dog";
            }
            else
            {
                third = " ";
            }
            Result.Text = "The animals you selected are: " + first + " " + second + " " + third;
        }
    }
}
