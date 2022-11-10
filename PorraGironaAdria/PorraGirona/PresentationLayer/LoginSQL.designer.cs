
namespace PorraGirona
{
    partial class LoginSQL
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
            this.BotoIngressar = new System.Windows.Forms.Button();
            this.CuadreTextUsuari = new System.Windows.Forms.TextBox();
            this.CuadreTextPassword = new System.Windows.Forms.TextBox();
            this.EtiquetaUsuari = new System.Windows.Forms.Label();
            this.EtiquetaPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotoIngressar
            // 
            this.BotoIngressar.Location = new System.Drawing.Point(189, 173);
            this.BotoIngressar.Name = "BotoIngressar";
            this.BotoIngressar.Size = new System.Drawing.Size(75, 23);
            this.BotoIngressar.TabIndex = 0;
            this.BotoIngressar.Text = "Ingressar";
            this.BotoIngressar.UseVisualStyleBackColor = true;
            this.BotoIngressar.Click += new System.EventHandler(this.BotoIngressar_Click);
            // 
            // CuadreTextUsuari
            // 
            this.CuadreTextUsuari.Location = new System.Drawing.Point(120, 49);
            this.CuadreTextUsuari.Name = "CuadreTextUsuari";
            this.CuadreTextUsuari.Size = new System.Drawing.Size(144, 20);
            this.CuadreTextUsuari.TabIndex = 1;
            // 
            // CuadreTextPassword
            // 
            this.CuadreTextPassword.Location = new System.Drawing.Point(120, 128);
            this.CuadreTextPassword.Name = "CuadreTextPassword";
            this.CuadreTextPassword.Size = new System.Drawing.Size(144, 20);
            this.CuadreTextPassword.TabIndex = 2;
            // 
            // EtiquetaUsuari
            // 
            this.EtiquetaUsuari.AutoSize = true;
            this.EtiquetaUsuari.Location = new System.Drawing.Point(64, 52);
            this.EtiquetaUsuari.Name = "EtiquetaUsuari";
            this.EtiquetaUsuari.Size = new System.Drawing.Size(37, 13);
            this.EtiquetaUsuari.TabIndex = 3;
            this.EtiquetaUsuari.Text = "Usuari";
            // 
            // EtiquetaPassword
            // 
            this.EtiquetaPassword.AutoSize = true;
            this.EtiquetaPassword.Location = new System.Drawing.Point(64, 131);
            this.EtiquetaPassword.Name = "EtiquetaPassword";
            this.EtiquetaPassword.Size = new System.Drawing.Size(53, 13);
            this.EtiquetaPassword.TabIndex = 4;
            this.EtiquetaPassword.Text = "Password";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 233);
            this.Controls.Add(this.EtiquetaPassword);
            this.Controls.Add(this.EtiquetaUsuari);
            this.Controls.Add(this.CuadreTextPassword);
            this.Controls.Add(this.CuadreTextUsuari);
            this.Controls.Add(this.BotoIngressar);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotoIngressar;
        private System.Windows.Forms.TextBox CuadreTextUsuari;
        private System.Windows.Forms.TextBox CuadreTextPassword;
        private System.Windows.Forms.Label EtiquetaUsuari;
        private System.Windows.Forms.Label EtiquetaPassword;
    }
}

