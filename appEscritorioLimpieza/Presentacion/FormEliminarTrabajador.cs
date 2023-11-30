﻿using Conexion.Models;
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
    public partial class FormEliminarTrabajador : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public FormEliminarTrabajador()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Trabajador traba = new Trabajador()
            {
                ID_trabajador = (int)numId.Value
            };

            Trabajador trab = db.Trabajador.Find(traba.ID_trabajador);

            if (trab != null)
            {
                db.Trabajador.Remove(trab);
                db.SaveChanges();
                MessageBox.Show("Trabajador eliminado");
            }
            else
            {
                MessageBox.Show("Trabajador no eliminado");
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
