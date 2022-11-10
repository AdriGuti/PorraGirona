
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PorraGirona.BussinesLayer;

namespace PorraGirona
{
    public partial class PrincipalSQL : Form
    {
        public PrincipalSQL()
        {
            InitializeComponent();
        }

        private void BotoAfegirImatge_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }
        private void BotoSuprimirImatge_Click(object sender, EventArgs e)
        {
            pictureBox1.Image=Properties.Resources.user;
        }
        private void BotoAfegir_Click(object sender, EventArgs e)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            //Utilitzem la funcio InserirUsuari per agafar totes les dades i pujarles la bbdd
            if (TextNom.Text != "")
            {
                //Codi per guardar la imatge en un array
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] pic_array = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(pic_array, 0, pic_array.Length);
                if (GestioSQL.InserirUsuari(TextNom.Text, TextCognoms.Text, TextNif.Text, TextNumSoci.Text,
                                          comboBox1.Text, TextAlias.Text,
                                          dateTimePicker1.Value, TextPassword.Text, pic_array))
                {
                    s.Stop();
                    toolStripStatusLabel1.Text = s.ElapsedMilliseconds.ToString();
                    MessageBox.Show("Penyista Introduit Correctament");
                    TextNom.Text = "";
                    TextCognoms.Text = "";
                    TextNif.Text = "";
                    TextNumSoci.Text = "";
                    TextAlias.Text = "";
                    TextPassword.Text = "";
                    //pictureBox1.Image = Properties.Resources.user;
                }
                else
                {
                    MessageBox.Show("Error al afegir penyista" +
                        "\n" + GestioSQL.ErrorMessage);
                }
            }
            //Carreguem el datagridview
            DataTable table = GestioSQL.LoadDataOnDataTable();
            dataGridViewPenyistes.DataSource = table;
            dataGridViewPenyistes.AllowUserToAddRows = false;
            dataGridViewPenyistes.AllowUserToDeleteRows = false;
            dataGridViewPenyistes.ReadOnly = true;
            dataGridViewPenyistes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPenyistes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            GestioSQL.DesconectarBD();
            Application.Exit();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            GestioSQL.DesconectarBD();
            if (!GestioSQL.ConectarBD())
            {
                MessageBox.Show("No ha sigut possible conectarse a la base de dades\n" +
                                GestioSQL.ErrorMessage);
                Application.Exit();
            }
        }
    }
}
