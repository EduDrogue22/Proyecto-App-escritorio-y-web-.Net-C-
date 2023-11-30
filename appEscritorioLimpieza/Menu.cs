using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace appEscritorioLimpieza
{
    public partial class Menu : Form
    {
        public Menu()
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void AbrirForm(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirForm(new Productos());
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            Form1 FormLogin = new Form1();
            FormLogin.Show();
            this.Hide();
        }

        private void BarraMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            AbrirForm(new Servicios());

        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            AbrirForm(new Solicitud());

        }

        private void btnCalificacion_Click(object sender, EventArgs e)
        {
            AbrirForm(new Calificaciones());

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirForm(new Trabajadores());

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new Clientes());

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new Usuarios());

        }
    }
}
