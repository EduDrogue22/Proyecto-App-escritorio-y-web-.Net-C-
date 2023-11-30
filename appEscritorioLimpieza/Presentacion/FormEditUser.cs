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
    public partial class FormEditUser : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormEditUser()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Criptografia.Encriptacion encrip = new Criptografia.Encriptacion();
            USUARIO user = new USUARIO()
            {
                ID_USER = (int)numId.Value,
                NOMBRE_USER = txtName.Text,
                PASS = encrip.HashMD5(txtPass.Text)
            };

            USUARIO usua = db.USUARIO.Find(user.ID_USER);

            if(string.IsNullOrWhiteSpace(txtName.Text) && string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Debe rellenar los campos.");
            }
            else
            {
            if(usua != null)
            {
                usua.NOMBRE_USER = txtName.Text;
                usua.PASS = encrip.HashMD5(txtPass.Text);

                db.SaveChanges();

                MessageBox.Show("Usuario actualizado");
            }
            else
            {
                MessageBox.Show("Usuario no actualizado");
            };
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
