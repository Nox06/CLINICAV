namespace ClinicaVET
{
    partial class Datos_Mascota
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
            this.Lista = new System.Windows.Forms.ListView();
            this.TITULO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.HideSelection = false;
            this.Lista.Location = new System.Drawing.Point(28, 80);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(145, 224);
            this.Lista.TabIndex = 0;
            this.Lista.UseCompatibleStateImageBehavior = false;
            this.Lista.ItemActivate += new System.EventHandler(this.Lista_ItemActivate);
            // 
            // TITULO
            // 
            this.TITULO.AutoSize = true;
            this.TITULO.Location = new System.Drawing.Point(63, 26);
            this.TITULO.Name = "TITULO";
            this.TITULO.Size = new System.Drawing.Size(0, 13);
            this.TITULO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione la mascota";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Actualizar lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Datos_Mascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TITULO);
            this.Controls.Add(this.Lista);
            this.Name = "Datos_Mascota";
            this.Text = "Pruega";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Lista;
        private System.Windows.Forms.Label TITULO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}