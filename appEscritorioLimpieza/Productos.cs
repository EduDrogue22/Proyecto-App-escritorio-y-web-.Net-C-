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
    public partial class Productos : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public Productos()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        #region HELPER
        private void Refrescar()
        {
            try
            {
                var query = from pro in db.Producto
                            select new
                            {
                                pro.ID_producto,
                                pro.nombre,
                                pro.presentacion
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

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Presentacion.FromProducto formTabla = new Presentacion.FromProducto();
            formTabla.ShowDialog();
            Refrescar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Presentacion.FormEliminarProducto formEliminar = new Presentacion.FormEliminarProducto();
            formEliminar.ShowDialog();
            Refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Presentacion.FormEditProducto formEditar = new Presentacion.FormEditProducto();
            formEditar.ShowDialog();
            Refrescar();
        }
    }
}
