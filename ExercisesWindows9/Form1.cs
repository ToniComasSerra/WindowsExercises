using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercisesWindows9
{
    public partial class Form1 : Form
    {
        int controlEvens = 0;
        int controlOdds = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void EvenButton_Click(object sender, EventArgs e)
        {
            if (controlEvens <= 10)
            {
                NumberList.Items.Add(controlEvens);
                controlEvens = controlEvens + 2;
            }
        }

        private void OddButton_Click(object sender, EventArgs e)
        {
            if (controlOdds <= 10)
            {
                NumberList.Items.Add(controlOdds);
                controlOdds = controlOdds + 2;
            }
        }

        private void NumberList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Numbers.Text = NumberList.SelectedItem.ToString();
        }

        private void Numbers_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
