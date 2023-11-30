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
    public partial class Trabajadores : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public Trabajadores()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }
        private void Trabajadores_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        #region HELPER
        private void Refrescar()
        {
            try
            {
                var query = from tra in db.Trabajador
                            select new
                            {
                                tra.ID_trabajador,
                                tra.primer_nombre,
                                tra.primer_apellido,
                                tra.dni_trabajador,
                                tra.celular,
                                tra.contacto_de_emergencia,
                                tra.disponible
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
            Presentacion.FormTrabajador formTabla = new Presentacion.FormTrabajador();
            formTabla.ShowDialog();

            Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Presentacion.FormEliminarTrabajador formEliminar = new Presentacion.FormEliminarTrabajador();
            formEliminar.ShowDialog();

            Refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Presentacion.FormEditTrabajador formEdit = new Presentacion.FormEditTrabajador();
            formEdit.ShowDialog();

            Refrescar();
        }
    }
}
