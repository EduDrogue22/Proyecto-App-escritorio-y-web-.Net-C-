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
    public partial class FromProducto : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FromProducto()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto()
                {
                    ID_producto = db.Producto.Max(d => d.ID_producto) + 1,
                    nombre = txtNombre.Text,
                    presentacion = txtPresnt.Text

                };

                if(string.IsNullOrWhiteSpace(txtNombre.Text) && string.IsNullOrWhiteSpace(txtPresnt.Text))
                {
                    MessageBox.Show("Debe rellenar todos los campos.");
                }
                else
                {
                    db.Producto.Add(producto);
                    int registro = db.SaveChanges();

                    if (registro > 0)
                        MessageBox.Show(registro + " registro guardado");
                    else
                        MessageBox.Show("Sin registro");

                    this.Close();
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

        private void BarraMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FromProducto_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
