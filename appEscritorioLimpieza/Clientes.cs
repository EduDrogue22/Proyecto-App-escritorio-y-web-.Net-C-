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
    public partial class Clientes : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public Clientes()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        #region HELPER
        private void Refrescar()
        {
            try
            {
                var query = from cli in db.Cliente
                            select new
                            {
                                cli.ID_cliente,
                                cli.primer_nombre,
                                cli.primer_apellido,
                                cli.dni_cliente,
                                cli.celular,
                                cli.email
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
            Presentacion.FormCliente formTabla = new Presentacion.FormCliente();
            formTabla.ShowDialog();

            Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Presentacion.FormEliminarCliente formEliminar = new Presentacion.FormEliminarCliente();
            formEliminar.ShowDialog();

            Refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Presentacion.FormEditCliente formEdit = new Presentacion.FormEditCliente();
            formEdit.ShowDialog();

            Refrescar();
        }
    }
}
