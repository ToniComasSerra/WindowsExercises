namespace ExercisesWindows8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Classroom = new System.Windows.Forms.ListBox();
            this.buttonClass1 = new System.Windows.Forms.Button();
            this.buttonClass2 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Classroom
            // 
            this.Classroom.FormattingEnabled = true;
            this.Classroom.ItemHeight = 16;
            this.Classroom.Location = new System.Drawing.Point(39, 34);
            this.Classroom.Name = "Classroom";
            this.Classroom.Size = new System.Drawing.Size(120, 148);
            this.Classroom.TabIndex = 0;
            this.Classroom.SelectedIndexChanged += new System.EventHandler(this.Classroom_SelectedIndexChanged);
            // 
            // buttonClass1
            // 
            this.buttonClass1.Location = new System.Drawing.Point(39, 231);
            this.buttonClass1.Name = "buttonClass1";
            this.buttonClass1.Size = new System.Drawing.Size(120, 23);
            this.buttonClass1.TabIndex = 1;
            this.buttonClass1.Text = "Classroom 1";
            this.buttonClass1.UseVisualStyleBackColor = true;
            this.buttonClass1.Click += new System.EventHandler(this.buttonClass1_Click);
            // 
            // buttonClass2
            // 
            this.buttonClass2.Location = new System.Drawing.Point(39, 274);
            this.buttonClass2.Name = "buttonClass2";
            this.buttonClass2.Size = new System.Drawing.Size(120, 23);
            this.buttonClass2.TabIndex = 2;
            this.buttonClass2.Text = "Classroom 2";
            this.buttonClass2.UseVisualStyleBackColor = true;
            this.buttonClass2.Click += new System.EventHandler(this.buttonClass2_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(59, 342);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Student
            // 
            this.Student.Location = new System.Drawing.Point(264, 101);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(235, 22);
            this.Student.TabIndex = 4;
            this.Student.TextChanged += new System.EventHandler(this.Student_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClass2);
            this.Controls.Add(this.buttonClass1);
            this.Controls.Add(this.Classroom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Classroom;
        private System.Windows.Forms.Button buttonClass1;
        private System.Windows.Forms.Button buttonClass2;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox Student;
    }
}

