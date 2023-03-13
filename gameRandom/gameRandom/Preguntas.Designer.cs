namespace gameRandom
{
    partial class Preguntas
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txbPregunta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txbRespuesta = new System.Windows.Forms.TextBox();
            this.btnOpcion1 = new System.Windows.Forms.Button();
            this.btnOpcion2 = new System.Windows.Forms.Button();
            this.btnOpcion3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbPregunta
            // 
            this.txbPregunta.Location = new System.Drawing.Point(70, 55);
            this.txbPregunta.Name = "txbPregunta";
            this.txbPregunta.Size = new System.Drawing.Size(315, 20);
            this.txbPregunta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregunta";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(326, 305);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txbRespuesta
            // 
            this.txbRespuesta.Location = new System.Drawing.Point(139, 249);
            this.txbRespuesta.Name = "txbRespuesta";
            this.txbRespuesta.Size = new System.Drawing.Size(152, 20);
            this.txbRespuesta.TabIndex = 9;
            // 
            // btnOpcion1
            // 
            this.btnOpcion1.Location = new System.Drawing.Point(150, 100);
            this.btnOpcion1.Name = "btnOpcion1";
            this.btnOpcion1.Size = new System.Drawing.Size(150, 23);
            this.btnOpcion1.TabIndex = 10;
            this.btnOpcion1.Text = "button1";
            this.btnOpcion1.UseVisualStyleBackColor = true;
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.Location = new System.Drawing.Point(56, 155);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(130, 23);
            this.btnOpcion2.TabIndex = 11;
            this.btnOpcion2.Text = "button2";
            this.btnOpcion2.UseVisualStyleBackColor = true;
            // 
            // btnOpcion3
            // 
            this.btnOpcion3.Location = new System.Drawing.Point(257, 194);
            this.btnOpcion3.Name = "btnOpcion3";
            this.btnOpcion3.Size = new System.Drawing.Size(144, 23);
            this.btnOpcion3.TabIndex = 12;
            this.btnOpcion3.Text = "button3";
            this.btnOpcion3.UseVisualStyleBackColor = true;
            // 
            // Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 340);
            this.Controls.Add(this.btnOpcion3);
            this.Controls.Add(this.btnOpcion2);
            this.Controls.Add(this.btnOpcion1);
            this.Controls.Add(this.txbRespuesta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPregunta);
            this.Name = "Preguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preguntas";
            this.Load += new System.EventHandler(this.Preguntas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txbPregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txbRespuesta;
        private System.Windows.Forms.Button btnOpcion1;
        private System.Windows.Forms.Button btnOpcion2;
        private System.Windows.Forms.Button btnOpcion3;
    }
}