namespace FormPasarDatos
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
            this.btnRecibir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRecibir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRecibir
            // 
            this.btnRecibir.Location = new System.Drawing.Point(214, 41);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(150, 63);
            this.btnRecibir.TabIndex = 0;
            this.btnRecibir.Text = "Recibir Datos";
            this.btnRecibir.UseVisualStyleBackColor = true;
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dato recibido";
            // 
            // lbRecibir
            // 
            this.lbRecibir.AutoSize = true;
            this.lbRecibir.Location = new System.Drawing.Point(263, 173);
            this.lbRecibir.Name = "lbRecibir";
            this.lbRecibir.Size = new System.Drawing.Size(51, 20);
            this.lbRecibir.TabIndex = 1;
            this.lbRecibir.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 335);
            this.Controls.Add(this.lbRecibir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecibir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecibir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRecibir;
    }
}

