using PorraGirona.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PorraGirona.BussinesLayer;

namespace PorraGirona
{
    public partial class PrincipalEntity : Form
    {
        public PrincipalEntity()
        {
            InitializeComponent();
        }

        private void prueba_Load(object sender, EventArgs e)
        {
            CarregaDataGridView();
        }
        private void CarregaDataGridView()
        {
            penyistesBindingSource.DataSource = GestioEntity.DataSourceBindingSourcePenyistes();
            if (GestioEntity.ErrorMessage != "")
            {
                MessageBox.Show(GestioEntity.ErrorMessage);
                Application.Exit();
            }
        }
        private void BotoRefrescar_Click(object sender, EventArgs e)
        {
            CarregaDataGridView();
        }

        private void PrincipalEntity_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BotoAfegir_Click(object sender, EventArgs e)
        {

            Penyistes penyista;
            penyista = (Penyistes)penyistesBindingSource.Current;
            if(penyista==null) penyista= new Penyistes();
            try
            {
                GestioEntity.InsereixPenyista(penyista);
                CarregaDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BotoNouPenyista_Click(object sender, EventArgs e)
        {
            penyistesBindingSource.AddNew();
            pictureBoxImatgePenyista.Image = Properties.Resources.user;
        }
        private void BotoRefresca_Click(object sender, EventArgs e)
        {
            CarregaDataGridView();
        }

        private void BotoSuprimirPenyista_Click(object sender, EventArgs e)
        {
            GestioEntity.SuprimirUsuari((Penyistes)penyistesBindingSource.Current);
            CarregaDataGridView();
        }
        private void BotoAfegirImatge_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(open.FileName);
                Penyistes penyista;
                penyista = (Penyistes)penyistesBindingSource.Current;
                if (penyista == null) penyista = new Penyistes();
                penyista.Imatge = GestioMisc.ImageFromBitmapToMediumBlob(image);
                pictureBoxImatgePenyista.Image = image;
            }
        }
        private void BotoSuprimirImatge_Click(object sender, EventArgs e)
        {
            Penyistes penyista = (Penyistes)penyistesBindingSource.Current;
            penyista.Imatge = GestioMisc.ImageFromBitmapToMediumBlob(Properties.Resources.user);
            pictureBoxImatgePenyista.Image = Properties.Resources.user;
        }
    }
}
