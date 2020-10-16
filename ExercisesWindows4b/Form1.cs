using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercisesWindows4b
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

        private void Choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            String op = Choice.SelectedIndex.ToString();
            if (op == "+")
            {
                operation.Text = "+";
            }
            else if (op == "-")
            {
                operation.Text = "-";
            }
            
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(operator1.Text);
            int y = Convert.ToInt32(operator2.Text);
            String op = Choice.SelectedItem.ToString();

            if (op == "+")
            {
                int solution = x + y;
                result.Text = solution.ToString();
            }
            else if (op == "-")
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

        private void operation_TextChanged(object sender, EventArgs e)
        {

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
    }
}
