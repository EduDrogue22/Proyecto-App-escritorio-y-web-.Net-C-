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
    public partial class FormTrabajador : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormTrabajador()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean validatore = false;
                
                if(string.IsNullOrWhiteSpace(txtNombre.Text) && string.IsNullOrWhiteSpace(txtAprellido.Text) && string.IsNullOrWhiteSpace(txtEmegerncia.Text))
                {
                    MessageBox.Show("Debe rellenar todos los campos.");
                }
                else
                {
                    if (txtDisponible.Checked == true)
                    {
                        validatore = true;
                    };
                    if(txtDNI.Value > 99999999 || txtDNI.Value <= 9999999 || txtCelular.Value > 999999999 || txtCelular.Value <= 99999999)
                    {
                        MessageBox.Show("DNI o Celular no valido");
                    }
                    else
                    {
                        Trabajador tra = new Trabajador()
                        {
                            ID_trabajador = db.Trabajador.Max(d => d.ID_trabajador) + 1,
                            primer_nombre = txtNombre.Text,
                            primer_apellido = txtAprellido.Text,
                            dni_trabajador = txtDNI.Text,
                            celular = txtCelular.Text,
                            contacto_de_emergencia = txtEmegerncia.Text,
                            disponible = validatore

                        };

                        db.Trabajador.Add(tra);
                        int registro = db.SaveChanges();

                        if (registro > 0)
                            MessageBox.Show(registro + " registro guardado");
                        else
                            MessageBox.Show("Sin registro");

                        this.Close();
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error de conexion");
                throw;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

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

        private void FormTrabajador_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
