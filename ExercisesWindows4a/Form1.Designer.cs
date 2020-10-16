namespace ExercisesWindows4a
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
            this.operator1 = new System.Windows.Forms.TextBox();
            this.operator2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.operation = new System.Windows.Forms.TextBox();
            this.SumButton = new System.Windows.Forms.Button();
            this.SubsButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // operator1
            // 
            this.operator1.Location = new System.Drawing.Point(104, 120);
            this.operator1.Name = "operator1";
            this.operator1.Size = new System.Drawing.Size(100, 22);
            this.operator1.TabIndex = 0;
            this.operator1.TextChanged += new System.EventHandler(this.operator1_TextChanged);
            // 
            // operator2
            // 
            this.operator2.Location = new System.Drawing.Point(104, 178);
            this.operator2.Name = "operator2";
            this.operator2.Size = new System.Drawing.Size(100, 22);
            this.operator2.TabIndex = 1;
            this.operator2.TextChanged += new System.EventHandler(this.operator2_TextChanged);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(482, 151);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 22);
            this.result.TabIndex = 2;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // operation
            // 
            this.operation.Location = new System.Drawing.Point(329, 292);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(47, 22);
            this.operation.TabIndex = 3;
            this.operation.TextChanged += new System.EventHandler(this.operation_TextChanged);
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(312, 120);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(75, 23);
            this.SumButton.TabIndex = 4;
            this.SumButton.Text = "Add";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // SubsButton
            // 
            this.SubsButton.Location = new System.Drawing.Point(312, 178);
            this.SubsButton.Name = "SubsButton";
            this.SubsButton.Size = new System.Drawing.Size(75, 23);
            this.SubsButton.TabIndex = 5;
            this.SubsButton.Text = "Subs";
            this.SubsButton.UseVisualStyleBackColor = true;
            this.SubsButton.Click += new System.EventHandler(this.SubsButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(114, 292);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(90, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(482, 292);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SubsButton);
            this.Controls.Add(this.SumButton);
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

        private System.Windows.Forms.TextBox operator1;
        private System.Windows.Forms.TextBox operator2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox operation;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button SubsButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

