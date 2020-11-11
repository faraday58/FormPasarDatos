namespace FormPasarDatos
{
    partial class FormEnviar
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
            this.txtbEnviaDato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviaDato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbEnviaDato
            // 
            this.txtbEnviaDato.Location = new System.Drawing.Point(159, 80);
            this.txtbEnviaDato.Name = "txtbEnviaDato";
            this.txtbEnviaDato.Size = new System.Drawing.Size(257, 26);
            this.txtbEnviaDato.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa dato";
            // 
            // btnEnviaDato
            // 
            this.btnEnviaDato.Location = new System.Drawing.Point(212, 139);
            this.btnEnviaDato.Name = "btnEnviaDato";
            this.btnEnviaDato.Size = new System.Drawing.Size(152, 95);
            this.btnEnviaDato.TabIndex = 2;
            this.btnEnviaDato.Text = "Enviar Dato";
            this.btnEnviaDato.UseVisualStyleBackColor = true;
            this.btnEnviaDato.Click += new System.EventHandler(this.btnEnviaDato_Click);
            // 
            // FormEnviar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 354);
            this.Controls.Add(this.btnEnviaDato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbEnviaDato);
            this.Name = "FormEnviar";
            this.Text = "FormEnviar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbEnviaDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviaDato;
    }
}