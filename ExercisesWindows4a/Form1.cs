using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercisesWindows4a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            operation.Text = "+";
        }

        private void SubsButton_Click(object sender, EventArgs e)
        {
            operation.Text = "-";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(operator1.Text);
            int y = Convert.ToInt32(operator2.Text);
            if (operation.Text == "+")
            {
                int solution = x + y;
                result.Text = solution.ToString();
            }
            else if (operation.Text == "-")
            {
                int solution = x - y;
                result.Text = solution.ToString();
            }
            else
            {
                MessageBox.Show("You went too far");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            operator1.Clear();
            operator2.Clear();
            result.Clear();
            operation.Clear();
        }

        private void operator1_TextChanged(object sender, EventArgs e)
        {

        }

        private void operator2_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void operation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
