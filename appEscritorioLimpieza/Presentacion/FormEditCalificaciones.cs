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
    public partial class FormEditCalificaciones : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormEditCalificaciones()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
            List<Servicio> servicios = db.Servicio.ToList();

            comboIdServ.DataSource = servicios;

            comboIdServ.DisplayMember = "ID_servicio";
            comboIdServ.ValueMember = "ID_servicio";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Calificacion_de_servicio calif = new Calificacion_de_servicio()
            {
                ID_calificacion = (int)numericUpDown1.Value,
                nivel_de_calificacion = (byte)(int)txtLevel.Value,
                ID_servicio = (int)comboIdServ.SelectedValue,
                comentario = txtComentario.Text
            };

            Calificacion_de_servicio cali = db.Calificacion_de_servicio.Find(calif.ID_calificacion);

            if(cali != null)
            {
                    if (txtLevel.Value > 5)
                    {
                        MessageBox.Show("La calificación no debe ser mayo a 5.");
                    }
                    else
                    {
                        cali.nivel_de_calificacion = (byte)(int)txtLevel.Value;
                        cali.ID_servicio = (int)comboIdServ.SelectedValue;
                        cali.comentario = txtComentario.Text;

                        db.SaveChanges();

                        MessageBox.Show("Calificación actualizada");
                }
            }
            else
            {
                MessageBox.Show("Calificaion no actualizada");
            };
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
