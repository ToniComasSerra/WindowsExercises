namespace ExercisesWindows5
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
            this.checkMouse = new System.Windows.Forms.CheckBox();
            this.checkCat = new System.Windows.Forms.CheckBox();
            this.checkDog = new System.Windows.Forms.CheckBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkMouse
            // 
            this.checkMouse.AutoSize = true;
            this.checkMouse.Location = new System.Drawing.Point(98, 109);
            this.checkMouse.Name = "checkMouse";
            this.checkMouse.Size = new System.Drawing.Size(72, 21);
            this.checkMouse.TabIndex = 0;
            this.checkMouse.Text = "Mouse";
            this.checkMouse.UseVisualStyleBackColor = true;
            this.checkMouse.CheckedChanged += new System.EventHandler(this.checkMouse_CheckedChanged);
            // 
            // checkCat
            // 
            this.checkCat.AutoSize = true;
            this.checkCat.Location = new System.Drawing.Point(98, 164);
            this.checkCat.Name = "checkCat";
            this.checkCat.Size = new System.Drawing.Size(51, 21);
            this.checkCat.TabIndex = 1;
            this.checkCat.Text = "Cat";
            this.checkCat.UseVisualStyleBackColor = true;
            this.checkCat.CheckedChanged += new System.EventHandler(this.checkCat_CheckedChanged);
            // 
            // checkDog
            // 
            this.checkDog.AutoSize = true;
            this.checkDog.Location = new System.Drawing.Point(98, 216);
            this.checkDog.Name = "checkDog";
            this.checkDog.Size = new System.Drawing.Size(56, 21);
            this.checkDog.TabIndex = 2;
            this.checkDog.Text = "Dog";
            this.checkDog.UseVisualStyleBackColor = true;
            this.checkDog.CheckedChanged += new System.EventHandler(this.checkDog_CheckedChanged);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(98, 281);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 3;
            this.Confirm.Text = "OK";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(98, 355);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(469, 22);
            this.Result.TabIndex = 4;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.checkDog);
            this.Controls.Add(this.checkCat);
            this.Controls.Add(this.checkMouse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkMouse;
        private System.Windows.Forms.CheckBox checkCat;
        private System.Windows.Forms.CheckBox checkDog;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.TextBox Result;
    }
}

