using PorraGirona.PresentationLayer;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PorraGirona
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btninicio_Click(null, e);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BotoPenyistes_click(object sender, EventArgs e)
        {
            SubmenuPenyistes.Visible = true;
        }

        private void BotoSQL_click(object sender, EventArgs e)
        {
            SubmenuPenyistes.Visible = false;
            AbrirFormEnPanel(new PrincipalSQL());
        }

        private void BotoDataSet_Click(object sender, EventArgs e)
        {
            SubmenuPenyistes.Visible = false;
            MessageBox.Show("Gestio penyistes mitjançant DataSet no disponible");
        }

        private void BotoEntity_click(object sender, EventArgs e)
        {
            SubmenuPenyistes.Visible = false;
            AbrirFormEnPanel(new PrincipalEntity());
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            SubmenuPenyistes.Visible = true;
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
        }

        private void BotoProves_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Proves());
        }
    }
}
