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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Runtime.InteropServices;


namespace appEscritorioLimpieza.Presentacion
{
    public partial class FormServicios : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormServicios()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();

            List<Conexion.Models.Solicitud> solicitudes = db.Solicitud.ToList();

            cbxSolicitud.DataSource = solicitudes;

            cbxSolicitud.DisplayMember = "fecha_y_hora_de_solicitud";
            cbxSolicitud.ValueMember = "ID_solicitud";

            List<Direccion> direcciones = db.Direccion.ToList();

            cbxDireccion.DataSource = direcciones;

            cbxDireccion.DisplayMember = "direccion1";
            cbxDireccion.ValueMember = "ID_direccion";

            List<Trabajador> trabajadores = db.Trabajador.ToList();

            cbxTrabajador.DataSource = trabajadores;

            cbxTrabajador.DisplayMember = "primer_apellido";
            cbxTrabajador.ValueMember = "ID_trabajador";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                Servicio servicio = new Servicio()
                {
                    ID_servicio = db.Servicio.Max(d => d.ID_servicio) + 1,
                    fecha_del_servicio = dtFecha.Value,
                    numero_de_horas = (int)numHoras.Value,
                    hora_de_inicio = dtHoraInicio.Value.TimeOfDay,
                    hora_de_fin = dtHoraFin.Value.TimeOfDay,
                    comision_empresa = (float)numComision.Value,
                    ID_solicitud = (int)cbxSolicitud.SelectedValue,
                    ID_direccion = (int)cbxDireccion.SelectedValue,
                    ID_trabajador = (int)cbxTrabajador.SelectedValue
                };

                if (servicio.comision_empresa > 0 && servicio.numero_de_horas > 0)
                {
                    db.Servicio.Add(servicio);
                    int registro = db.SaveChanges();

                    if (registro > 0)
                    {
                        MessageBox.Show(registro + " Registro guardado");
                    }
                    else
                    {
                        MessageBox.Show("Sin cambio");
                    };
                }
                else
                {
                    MessageBox.Show("La comisión de la empresa y el numero de horas debe ser mayor a 0.");
                };
        }


        private void FormServicios_Load(object sender, EventArgs e)
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
