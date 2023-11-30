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
    public partial class Solicitud : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public Solicitud()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }

        private void Solicitud_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        #region HELPER
        private void Refrescar()
        {
            try
            {
                var query = from sol in db.Solicitud
                            join cli in db.Cliente on sol.ID_cliente equals cli.ID_cliente
                            select new
                            {
                                sol.ID_solicitud,
                                sol.fecha_y_hora_de_solicitud,
                                cli.primer_nombre
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
            Presentacion.FormSolicitud formTabla = new Presentacion.FormSolicitud();
            formTabla.ShowDialog();

            Refrescar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Presentacion.FormEliminarSolicitud formEliminar = new Presentacion.FormEliminarSolicitud();
            formEliminar.ShowDialog();

            Refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Presentacion.FormEditSolicitud formEditar = new Presentacion.FormEditSolicitud();
            formEditar.ShowDialog();

            Refrescar();
        }
    }
}
