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

namespace PorraGirona.PresentationLayer
{
    public partial class Proves : Form
    {
        public Proves()
        {
            InitializeComponent();
        }

        private void BotoProvaIntegralEntity_Click(object sender, EventArgs e)
        {
            GestioEntity.CalculaPuntuacionsEntity();
            CarregaDataGridView();
        }        
        private void CarregaDataGridView()
        {
            puntuacionsBindingSource.DataSource = GestioEntity.DataSourceBindingSourcePuntuacions();
            if (GestioEntity.ErrorMessage != "")
            {
                MessageBox.Show(GestioEntity.ErrorMessage);
                Application.Exit();
            }
        }
    }
}
