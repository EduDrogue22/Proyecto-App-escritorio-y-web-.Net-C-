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
    public partial class FormCliente : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormCliente()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDNI.Value > 99999999 || txtDNI.Value <= 9999999 || txtCelular.Value > 999999999 || txtCelular.Value <= 99999999)
                {
                    MessageBox.Show("DNI o Celular no valido");
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtNombre.Text) && string.IsNullOrWhiteSpace(txtAprellido.Text) && string.IsNullOrWhiteSpace(txtEmegerncia.Text))
                    {
                        MessageBox.Show("Debe rellenar los campos.");
                    }
                    else
                    {
                        Cliente cliente = new Cliente()
                        {
                            ID_cliente = db.Cliente.Max(d => d.ID_cliente) + 1,
                            primer_nombre = txtNombre.Text,
                            primer_apellido = txtAprellido.Text,
                            dni_cliente = txtDNI.Text,
                            celular = txtCelular.Text,
                            email = txtEmegerncia.Text


                        };

                        db.Cliente.Add(cliente);
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
