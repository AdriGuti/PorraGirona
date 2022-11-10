
namespace PorraGirona
{
    partial class LoginEntity
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextUsuari = new System.Windows.Forms.TextBox();
            this.TextContrasenya = new System.Windows.Forms.TextBox();
            this.BotonIngressar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contrasenya";
            // 
            // TextUsuari
            // 
            this.TextUsuari.Location = new System.Drawing.Point(129, 80);
            this.TextUsuari.Name = "TextUsuari";
            this.TextUsuari.Size = new System.Drawing.Size(100, 20);
            this.TextUsuari.TabIndex = 2;
            // 
            // TextContrasenya
            // 
            this.TextContrasenya.Location = new System.Drawing.Point(129, 128);
            this.TextContrasenya.Name = "TextContrasenya";
            this.TextContrasenya.Size = new System.Drawing.Size(100, 20);
            this.TextContrasenya.TabIndex = 3;
            // 
            // BotonIngressar
            // 
            this.BotonIngressar.Location = new System.Drawing.Point(154, 190);
            this.BotonIngressar.Name = "BotonIngressar";
            this.BotonIngressar.Size = new System.Drawing.Size(75, 23);
            this.BotonIngressar.TabIndex = 4;
            this.BotonIngressar.Text = "Ingressar";
            this.BotonIngressar.UseVisualStyleBackColor = true;
            this.BotonIngressar.Click += new System.EventHandler(this.BotonIngressar_Click);
            // 
            // LoginEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 271);
            this.Controls.Add(this.BotonIngressar);
            this.Controls.Add(this.TextContrasenya);
            this.Controls.Add(this.TextUsuari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginEntity";
            this.Text = "LoginEntity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextUsuari;
        private System.Windows.Forms.TextBox TextContrasenya;
        private System.Windows.Forms.Button BotonIngressar;
    }
}