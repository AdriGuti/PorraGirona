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
    public partial class LoginSQL : Form
    {
        public LoginSQL()
        {
            InitializeComponent();
        }

        private void BotoIngressar_Click(object sender, EventArgs e)
        {
            if (GestioSQL.DBExisteixUsuari(CuadreTextUsuari.Text, CuadreTextPassword.Text))
            {
                PrincipalSQL principal = new PrincipalSQL();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(GestioSQL.ErrorMessage);
            }
        }
        /// <summary>
        /// Funció que comprova si existeix un usuaro
        /// </summary>
        /// <param name="nom">camp de la base de dades</param>
        /// <param name="password">password de la base de dades</param>
        /// <returns>true o false</returns>

    }
}
