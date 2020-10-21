namespace ExercisesWindows10
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
            this.ScrollBar = new System.Windows.Forms.HScrollBar();
            this.Percentage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ScrollBar
            // 
            this.ScrollBar.Location = new System.Drawing.Point(72, 130);
            this.ScrollBar.Maximum = 90;
            this.ScrollBar.Minimum = 50;
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.Size = new System.Drawing.Size(648, 21);
            this.ScrollBar.TabIndex = 0;
            this.ScrollBar.Value = 50;
            this.ScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll);
            // 
            // Percentage
            // 
            this.Percentage.Location = new System.Drawing.Point(201, 292);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(365, 22);
            this.Percentage.TabIndex = 1;
            this.Percentage.TextChanged += new System.EventHandler(this.Percentage_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.ScrollBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar ScrollBar;
        private System.Windows.Forms.TextBox Percentage;
    }
}

