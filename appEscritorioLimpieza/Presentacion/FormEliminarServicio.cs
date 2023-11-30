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
    public partial class FormEliminarServicio : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormEliminarServicio()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Servicio servi = new Servicio()
            {
                ID_servicio = (int)numId.Value
            };

            Servicio ser = db.Servicio.Find(servi.ID_servicio);

            if (ser != null)
            {
                db.Servicio.Remove(ser);
                db.SaveChanges();
                MessageBox.Show("Servicio eliminado");
            }
            else
            {
                MessageBox.Show("Servicio no eliminado");
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

        private void FormEliminarServicio_MouseDown(object sender, MouseEventArgs e)
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
