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
    public partial class Calificaciones : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public Calificaciones()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }

        private void Calificaciones_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        #region HELPER
        private void Refrescar()
        {
            try
            {
                var query = from cala in db.Calificacion_de_servicio
                            join ser in db.Servicio on cala.ID_servicio equals ser.ID_servicio
                            select new
                            {
                                cala.ID_calificacion,
                                cala.nivel_de_calificacion,
                                cala.comentario,
                                ser.ID_servicio
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Presentacion.FormCalificaciones formTabla = new Presentacion.FormCalificaciones();
            formTabla.ShowDialog();

            Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Presentacion.FormEliminarClasificaion formEliminar = new Presentacion.FormEliminarClasificaion();
            formEliminar.ShowDialog();

            Refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Presentacion.FormEditCalificaciones formEdit = new Presentacion.FormEditCalificaciones();
            formEdit.ShowDialog();

            Refrescar();
        }
    }
}
