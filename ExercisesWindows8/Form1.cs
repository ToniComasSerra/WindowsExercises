using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercisesWindows8
{
    public partial class Form1 : Form
    {
        string[] classroom1 = { "Toni", "Emilio", "Xesc", "Carlos" };
        string[] classroom2 = { "Jaume", "Maik", "Billy", "Andy" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Classroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student.Text = Classroom.SelectedItem.ToString();
        }

        private void buttonClass1_Click(object sender, EventArgs e)
        {
            Classroom.Items.Clear();
            Classroom.Items.AddRange(classroom1);
        }

        private void buttonClass2_Click(object sender, EventArgs e)
        {
            Classroom.Items.Clear();
            Classroom.Items.AddRange(classroom2);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Classroom.Items.Clear();
            Student.Text = "";
        }

        private void Student_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
