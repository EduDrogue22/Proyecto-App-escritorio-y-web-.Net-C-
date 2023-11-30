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
    public partial class FormCalificaciones : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormCalificaciones()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
            List<Servicio> cli = db.Servicio.ToList();

            comboIdServ.DataSource = cli;

            comboIdServ.DisplayMember = "ID_servicio";
            comboIdServ.ValueMember = "ID_servicio";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtLevel.Value > 5)
                {
                    MessageBox.Show("Error número de calificación no valido");

                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtComentario.Text))
                    {
                        MessageBox.Show("Debe rellenar los campos.");
                    }
                    else
                    {
                        Calificacion_de_servicio cal = new Calificacion_de_servicio()
                        {
                            ID_calificacion = db.Calificacion_de_servicio.Max(d => d.ID_calificacion) + 1,
                            nivel_de_calificacion = (byte)(int)txtLevel.Value,
                            comentario = txtComentario.Text,
                            ID_servicio = (int)comboIdServ.SelectedValue

                        };

                        db.Calificacion_de_servicio.Add(cal);
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
