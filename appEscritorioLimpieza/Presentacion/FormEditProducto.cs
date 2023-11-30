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
    public partial class FormEditProducto : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormEditProducto()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Producto produ = new Producto()
            {
                ID_producto = (int)numId.Value,
                nombre = txtNombre.Text,
                presentacion = txtPresnt.Text
            };

            Producto produc = db.Producto.Find(produ.ID_producto);

            if(produc != null)
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) && string.IsNullOrWhiteSpace(txtPresnt.Text))
                {
                    MessageBox.Show("Debe rellenar los campos.");
                }
                else
                {
                    produc.nombre = txtNombre.Text;
                    produc.presentacion = txtPresnt.Text;

                    db.SaveChanges();

                    MessageBox.Show("Producto actualizado");
                }
            }
            else
            {
                MessageBox.Show("Producto no actualizado");
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
