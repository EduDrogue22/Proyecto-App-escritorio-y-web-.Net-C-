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
    public partial class FormEditCliente : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormEditCliente()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente()
            {
                ID_cliente = (int)numId.Value,
                dni_cliente = txtDNI.Text,
                primer_nombre = txtNombre.Text,
                primer_apellido = txtAprellido.Text,
                email = txtEmegerncia.Text,
                celular = txtCelular.Text
            };

            if(txtDNI.Value > 99999999 || txtDNI.Value <= 9999999 || txtCelular.Value > 999999999 || txtCelular.Value <= 99999999)
            {
                MessageBox.Show("DNI o Celular no valido");
            }
            else
            {
                Cliente clien = db.Cliente.Find(cli.ID_cliente);

                if (clien != null)
                {
                    if (string.IsNullOrWhiteSpace(txtNombre.Text) && string.IsNullOrWhiteSpace(txtAprellido.Text) && string.IsNullOrWhiteSpace(txtEmegerncia.Text))
                    {
                        MessageBox.Show("Debe rellenar los campos.");
                    }
                    else
                    {

                        clien.dni_cliente = txtDNI.Text;
                        clien.primer_nombre = txtNombre.Text;
                        clien.primer_apellido = txtAprellido.Text;
                        clien.email = txtEmegerncia.Text;
                        clien.celular = txtCelular.Text;

                        db.SaveChanges();

                        MessageBox.Show("Cliente actualizado");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente no actualizado");
                }

            };
        }

        private void FormEditCliente_Load(object sender, EventArgs e)
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
    }
}
