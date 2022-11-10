using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PorraGirona.BussinesLayer;

namespace PorraGirona
{
    public partial class LoginEntity : Form
    {
        public LoginEntity()
        {
            InitializeComponent();
        }

        private void BotonIngressar_Click(object sender, EventArgs e)
        {
            if (GestioEntity.LoginPenyista(TextUsuari.Text, TextContrasenya.Text))
            {
                Principal principal = new Principal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(GestioEntity.ErrorMessage);
            }
        }
    }
}
