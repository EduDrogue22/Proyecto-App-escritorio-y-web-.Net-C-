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
    public partial class FormUsuario : Form
    {   
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormUsuario()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
          
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Criptografia.Encriptacion encrip = new Criptografia.Encriptacion();
            try
            {
                if(string.IsNullOrWhiteSpace(txtName.Text) && string.IsNullOrWhiteSpace(txtPass.Text) && string.IsNullOrWhiteSpace(txtPass2.Text))
                {
                    MessageBox.Show("Debe rellenar todos los campos.");
                }
                else
                {
                    if (txtPass.Text == txtPass2.Text)
                    {
                        String passRaw = txtPass.Text;
                        String password = encrip.HashMD5(passRaw);

                        USUARIO usuario = new USUARIO()
                        {
                            ID_USER= db.USUARIO.Max(d => d.ID_USER) + 1,
                            NOMBRE_USER = txtName.Text,
                            PASS = encrip.HashMD5(passRaw),
                        
                        };

                        db.USUARIO.Add(usuario);
                        int registro = db.SaveChanges();

                        if (registro > 0)
                            MessageBox.Show(registro + " registro guardado");
                        else
                            MessageBox.Show("Sin registro");

                        this.Close();
                    
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexion");
                throw;
            }

        }

        private void FormUsuario_Load(object sender, EventArgs e)
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

        private void FormUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BarraMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
