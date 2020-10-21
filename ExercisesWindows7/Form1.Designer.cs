namespace ExercisesWindows7
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
            this.Colores = new System.Windows.Forms.ComboBox();
            this.Seleccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Colores
            // 
            this.Colores.FormattingEnabled = true;
            this.Colores.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "White",
            "Black"});
            this.Colores.Location = new System.Drawing.Point(319, 99);
            this.Colores.Name = "Colores";
            this.Colores.Size = new System.Drawing.Size(121, 24);
            this.Colores.TabIndex = 0;
            this.Colores.SelectedIndexChanged += new System.EventHandler(this.Colores_SelectedIndexChanged);
            // 
            // Seleccion
            // 
            this.Seleccion.Location = new System.Drawing.Point(252, 270);
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Size = new System.Drawing.Size(266, 22);
            this.Seleccion.TabIndex = 1;
            this.Seleccion.TextChanged += new System.EventHandler(this.Seleccion_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Seleccion);
            this.Controls.Add(this.Colores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Colores;
        private System.Windows.Forms.TextBox Seleccion;
    }
}

