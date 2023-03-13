namespace gameRandom
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnGenerarPregunta = new System.Windows.Forms.Button();
            this.rtbPregunta = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerarPregunta
            // 
            this.btnGenerarPregunta.Location = new System.Drawing.Point(52, 92);
            this.btnGenerarPregunta.Name = "btnGenerarPregunta";
            this.btnGenerarPregunta.Size = new System.Drawing.Size(115, 49);
            this.btnGenerarPregunta.TabIndex = 0;
            this.btnGenerarPregunta.Text = "Jugar";
            this.btnGenerarPregunta.UseVisualStyleBackColor = true;
            this.btnGenerarPregunta.Click += new System.EventHandler(this.btnGenerarPregunta_Click);
            // 
            // rtbPregunta
            // 
            this.rtbPregunta.Location = new System.Drawing.Point(173, 68);
            this.rtbPregunta.Name = "rtbPregunta";
            this.rtbPregunta.Size = new System.Drawing.Size(47, 73);
            this.rtbPregunta.TabIndex = 1;
            this.rtbPregunta.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BIENVENIDOS A ASKMANIA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 233);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbPregunta);
            this.Controls.Add(this.btnGenerarPregunta);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnGenerarPregunta;
        private System.Windows.Forms.RichTextBox rtbPregunta;
        private System.Windows.Forms.Label label1;
    }
}

