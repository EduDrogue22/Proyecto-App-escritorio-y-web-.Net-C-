using Conexion.Models;
using Criptografia;
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

namespace appEscritorioLimpieza
{
    public partial class Form1 : Form
    {
        private SERVICIO_LIMPIEZAEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new SERVICIO_LIMPIEZAEntities();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Encriptacion encrip = new Encriptacion();

                String user = txtNombe.Text;
                String passTome = txtPass.Text;
                String pass = encrip.HashMD5(passTome);

                bool usuarioValido = db.USUARIO.Any(U => U.NOMBRE_USER == user && U.PASS == pass);


                if (usuarioValido)
                {
                    MessageBox.Show("Bienvenido 😎 " + user);
                    Menu menuForm = new Menu();
                    menuForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error usuario / contraseña 💀");
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
            Application.Exit();
        }

        private void BarraMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

}
