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
    public partial class FormEditSolicitud : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormEditSolicitud()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();

            List<Cliente> cli = db.Cliente.ToList();

            comboClient.DataSource = cli;

            comboClient.DisplayMember = "primer_nombre";
            comboClient.ValueMember = "ID_cliente";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Conexion.Models.Solicitud solici = new Conexion.Models.Solicitud()
            {
                ID_solicitud = (int)numId.Value,
                fecha_y_hora_de_solicitud = txtFecha.Value,
                ID_cliente = (int)comboClient.SelectedValue,
            };

            Conexion.Models.Solicitud soli = db.Solicitud.Find(solici.ID_solicitud);

            if (soli != null)
            {
                soli.fecha_y_hora_de_solicitud = txtFecha.Value;
                soli.ID_cliente = (int)comboClient.SelectedValue;

                db.SaveChanges();

                MessageBox.Show("Solicitud actualizada");
            }
            else
            {
                MessageBox.Show("Solicitud no actualizada");
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
