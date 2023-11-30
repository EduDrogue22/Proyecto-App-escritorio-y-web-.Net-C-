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

namespace appEscritorioLimpieza
{
    public partial class Usuarios : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public Usuarios()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }


        private void Usuarios_Load(object sender, EventArgs e)
        {

            Refrescar();
        }

        #region HELPER
        private void Refrescar()
        {
            try
            {
                var query = from usua in db.USUARIO
                            select new
                            {
                                usua.ID_USER,
                                usua.NOMBRE_USER,
                                usua.PASS,
                            };
                dataGridView1.DataSource = query.ToList();

            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexion");
                throw;
            }
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
                throw;
            } 
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Presentacion.FormUsuario formTablaUser = new Presentacion.FormUsuario();
            formTablaUser.ShowDialog();

            Refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Presentacion.FormEditUser formEditUser = new Presentacion.FormEditUser();
            formEditUser.ShowDialog();

            Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Presentacion.FormEliminarUsuario formEliminar = new Presentacion.FormEliminarUsuario();
            formEliminar.ShowDialog();

            Refrescar();
        }
    }
}
