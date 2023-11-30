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
    public partial class FormSolicitud : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormSolicitud()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }
        private void FormSolicitud_Load(object sender, EventArgs e)
        {
            List<Cliente> cli = db.Cliente.ToList();

            comboClient.DataSource = cli;

            comboClient.DisplayMember = "primer_nombre";
            comboClient.ValueMember = "ID_cliente";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Models.Solicitud sol = new Conexion.Models.Solicitud
                {
                    ID_solicitud = db.Solicitud.Max(d => d.ID_solicitud) + 1,
                    fecha_y_hora_de_solicitud = txtFecha.Value,
                    
                    ID_cliente = (int)comboClient.SelectedValue
                };

                db.Solicitud.Add(sol);
                int registro = db.SaveChanges();

                if (registro > 0)
                    MessageBox.Show(registro + " registro guardado");
                else
                    MessageBox.Show("Sin registro");

                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexion");
                throw;
            }
        }

        private void comboClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
