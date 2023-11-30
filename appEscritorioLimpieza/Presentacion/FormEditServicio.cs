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
    public partial class FormEditServicio : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormEditServicio()
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Servicio servi = new Servicio()
            {
                ID_servicio = (int)numId.Value,
                fecha_del_servicio = dtFecha.Value,
                numero_de_horas = (int)numHoras.Value,
                hora_de_inicio = dtHoraInicio.Value.TimeOfDay,
                hora_de_fin = dtHoraFin.Value.TimeOfDay,
                comision_empresa = (float)numComision.Value,
                ID_solicitud = (int)cbxSolicitud.SelectedValue,
                ID_direccion = (int)cbxDireccion.SelectedValue,
                ID_trabajador = (int)cbxTrabajador.SelectedValue
            };

            Servicio ser = db.Servicio.Find(servi.ID_servicio);

            if(ser != null)
            {
                if (ser.comision_empresa > 0 && ser.numero_de_horas > 0)
                {
                    ser.fecha_del_servicio = dtFecha.Value;
                    ser.numero_de_horas = (int)numHoras.Value;
                    ser.hora_de_inicio = dtHoraInicio.Value.TimeOfDay;
                    ser.hora_de_fin = dtHoraFin.Value.TimeOfDay;
                    ser.comision_empresa = (float)numComision.Value;
                    ser.ID_solicitud = (int)cbxSolicitud.SelectedValue;
                    ser.ID_direccion = (int)cbxDireccion.SelectedValue;
                    ser.ID_trabajador = (int)cbxTrabajador.SelectedValue;

                    db.SaveChanges();

                    MessageBox.Show("Servicio actualizado");
                }
                else
                {
                    MessageBox.Show("La comisión de la empresa y el número de horas debe ser mayor a 0.");
                }
            }
            else
            {
                MessageBox.Show("Servicio no actualizado");
            };

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraMenu_Paint(object sender, PaintEventArgs e)
        {

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
