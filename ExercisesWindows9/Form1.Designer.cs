namespace ExercisesWindows9
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
            this.NumberList = new System.Windows.Forms.ComboBox();
            this.EvenButton = new System.Windows.Forms.Button();
            this.OddButton = new System.Windows.Forms.Button();
            this.Numbers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumberList
            // 
            this.NumberList.FormattingEnabled = true;
            this.NumberList.Location = new System.Drawing.Point(115, 119);
            this.NumberList.Name = "NumberList";
            this.NumberList.Size = new System.Drawing.Size(121, 24);
            this.NumberList.TabIndex = 0;
            this.NumberList.SelectedIndexChanged += new System.EventHandler(this.NumberList_SelectedIndexChanged);
            // 
            // EvenButton
            // 
            this.EvenButton.Location = new System.Drawing.Point(401, 119);
            this.EvenButton.Name = "EvenButton";
            this.EvenButton.Size = new System.Drawing.Size(75, 23);
            this.EvenButton.TabIndex = 1;
            this.EvenButton.Text = "Even";
            this.EvenButton.UseVisualStyleBackColor = true;
            this.EvenButton.Click += new System.EventHandler(this.EvenButton_Click);
            // 
            // OddButton
            // 
            this.OddButton.Location = new System.Drawing.Point(519, 119);
            this.OddButton.Name = "OddButton";
            this.OddButton.Size = new System.Drawing.Size(75, 23);
            this.OddButton.TabIndex = 2;
            this.OddButton.Text = "Odd";
            this.OddButton.UseVisualStyleBackColor = true;
            this.OddButton.Click += new System.EventHandler(this.OddButton_Click);
            // 
            // Numbers
            // 
            this.Numbers.Location = new System.Drawing.Point(115, 283);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(479, 22);
            this.Numbers.TabIndex = 3;
            this.Numbers.TextChanged += new System.EventHandler(this.Numbers_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numbers);
            this.Controls.Add(this.OddButton);
            this.Controls.Add(this.EvenButton);
            this.Controls.Add(this.NumberList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NumberList;
        private System.Windows.Forms.Button EvenButton;
        private System.Windows.Forms.Button OddButton;
        private System.Windows.Forms.TextBox Numbers;
    }
}

