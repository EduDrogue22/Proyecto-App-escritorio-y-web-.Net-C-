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
    public partial class FormEliminarSolicitud : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormEliminarSolicitud()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion.Models.Solicitud soli = new Conexion.Models.Solicitud()
            {
                ID_solicitud = (int)numId.Value
            };

            Conexion.Models.Solicitud sol = db.Solicitud.Find(soli.ID_solicitud);

            if(sol != null)
            {
                db.Solicitud.Remove(sol);
                db.SaveChanges();
                MessageBox.Show("Solicitud eliminada");
            }
            else
            {
                MessageBox.Show("Solicitud no eliminada");
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

        private void BarraMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
