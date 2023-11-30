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
using Conexion.Models;

namespace appEscritorioLimpieza.Presentacion
{
    public partial class FormEliminarClasificaion : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormEliminarClasificaion()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Calificacion_de_servicio clasi = new Calificacion_de_servicio()
            {
                ID_calificacion = (int)numId.Value
            };

            Calificacion_de_servicio cla = db.Calificacion_de_servicio.Find(clasi.ID_calificacion);

            if (cla != null)
            {
                db.Calificacion_de_servicio.Remove(cla);
                db.SaveChanges();
                MessageBox.Show("Calificación eliminado");
            }
            else
            {
                MessageBox.Show("Calificación no eliminado");
            };
        }

        private void BarraMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
