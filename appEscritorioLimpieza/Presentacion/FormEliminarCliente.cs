using Conexion.Models;
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

namespace appEscritorioLimpieza.Presentacion
{
    public partial class FormEliminarCliente : Form
    {
        public FormEliminarCliente()
        {
            InitializeComponent();
        }

        SERVICIO_LIMPIEZAEntities db = new SERVICIO_LIMPIEZAEntities();

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente clie = new Cliente()
            {
                ID_cliente = (int)numId.Value
            };

            Cliente cli = db.Cliente.Find(clie.ID_cliente);

            if (cli != null)
            {
                db.Cliente.Remove(cli);
                db.SaveChanges();
                MessageBox.Show("Cliente eliminado");
            }
            else
            {
                MessageBox.Show("Cliente no eliminado");
            };
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraMenu_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormEliminarCliente_Load(object sender, EventArgs e)
        {

        }

        private void FormEliminarCliente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BarraMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
