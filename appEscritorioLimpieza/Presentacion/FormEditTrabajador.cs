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
    public partial class FormEditTrabajador : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormEditTrabajador()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtNombre.Text) && string.IsNullOrWhiteSpace(txtAprellido.Text) && string.IsNullOrWhiteSpace(txtEmergencia.Text))
                {
                    MessageBox.Show("Debe rellenar todos los campos.");
                }
                else
                {
                    Boolean validatore = false;

                if (txtDisponible.Checked == true)
                {
                    validatore = true;
                };
                if (txtDNI.Value > 99999999 || txtDNI.Value <= 9999999 || txtCelular.Value > 999999999 || txtCelular.Value <= 99999999)
                {
                    MessageBox.Show("DNI o Celular no valido");
                }
                else
                {
                    Trabajador traba = new Trabajador()
                    {
                        ID_trabajador = (int)numId.Value,
                        dni_trabajador = txtDNI.Text,
                        primer_nombre = txtNombre.Text,
                        primer_apellido = txtAprellido.Text,
                        celular = txtCelular.Text,
                        contacto_de_emergencia = txtEmergencia.Text,
                        disponible = validatore
                    };

                    Trabajador trabaja = db.Trabajador.Find(traba.ID_trabajador);

                    if (trabaja != null)
                    {
                        trabaja.dni_trabajador = txtDNI.Text;
                        trabaja.primer_nombre = txtNombre.Text;
                        trabaja.primer_apellido = txtAprellido.Text;
                        trabaja.celular = txtCelular.Text;
                        trabaja.contacto_de_emergencia = txtEmergencia.Text;
                        trabaja.disponible = validatore;

                        db.SaveChanges();

                        MessageBox.Show("Trabajador actualizado");
                    }
                    else
                    {
                        MessageBox.Show("Trabajador no actualizado");
                    };

                }
              }

            }

            catch (Exception)
            {
                MessageBox.Show("Error de conexion");
                throw;
            }

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
