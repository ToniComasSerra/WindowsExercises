namespace ExercisesWindows4b
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
            this.ResetButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.operation = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.operator2 = new System.Windows.Forms.TextBox();
            this.operator1 = new System.Windows.Forms.TextBox();
            this.Choice = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(515, 277);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(147, 277);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(90, 23);
            this.CalculateButton.TabIndex = 14;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // operation
            // 
            this.operation.Location = new System.Drawing.Point(362, 277);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(47, 22);
            this.operation.TabIndex = 11;
            this.operation.TextChanged += new System.EventHandler(this.operation_TextChanged);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(515, 136);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 22);
            this.result.TabIndex = 10;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // operator2
            // 
            this.operator2.Location = new System.Drawing.Point(137, 163);
            this.operator2.Name = "operator2";
            this.operator2.Size = new System.Drawing.Size(100, 22);
            this.operator2.TabIndex = 9;
            this.operator2.TextChanged += new System.EventHandler(this.operator2_TextChanged);
            // 
            // operator1
            // 
            this.operator1.Location = new System.Drawing.Point(137, 105);
            this.operator1.Name = "operator1";
            this.operator1.Size = new System.Drawing.Size(100, 22);
            this.operator1.TabIndex = 8;
            this.operator1.TextChanged += new System.EventHandler(this.operator1_TextChanged);
            // 
            // Choice
            // 
            this.Choice.FormattingEnabled = true;
            this.Choice.ItemHeight = 16;
            this.Choice.Items.AddRange(new object[] {
            "+",
            "-"});
            this.Choice.Location = new System.Drawing.Point(362, 106);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(31, 52);
            this.Choice.TabIndex = 16;
            this.Choice.SelectedIndexChanged += new System.EventHandler(this.Choice_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Choice);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.result);
            this.Controls.Add(this.operator2);
            this.Controls.Add(this.operator1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox operation;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox operator2;
        private System.Windows.Forms.TextBox operator1;
        private System.Windows.Forms.ListBox Choice;
    }
}

