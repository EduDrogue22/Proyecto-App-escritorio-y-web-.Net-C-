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
    public partial class Servicios : Form
    {
        private Conexion.Models.SERVICIO_LIMPIEZAEntities db;
        public Servicios()
        {
            InitializeComponent();
            db = new Conexion.Models.SERVICIO_LIMPIEZAEntities();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        #region HELPER
        private void Refrescar()
        {
            try
            {
                var query = from ser in db.Servicio
                            join sol in db.Solicitud on ser.ID_solicitud equals sol.ID_solicitud
                            join dir in db.Direccion on ser.ID_direccion equals dir.ID_direccion
                            join tra in db.Trabajador on ser.ID_trabajador equals tra.ID_trabajador
                            select new
                            {
                                ser.ID_servicio,
                                ser.fecha_del_servicio,
                                ser.numero_de_horas,
                                ser.hora_de_inicio,
                                ser.hora_de_fin,
                                ser.comision_empresa,
                                ser.pago_a_trabajador,
                                ser.precio_de_servicio,
                                sol.ID_solicitud,
                                dir.direccion1,
                                tra.primer_nombre
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
            Presentacion.FormServicios formServi = new Presentacion.FormServicios();
            formServi.ShowDialog();
            Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Presentacion.FormEliminarServicio formEliminar = new Presentacion.FormEliminarServicio();
            formEliminar.ShowDialog();
            Refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Presentacion.FormEditServicio formEdit = new Presentacion.FormEditServicio();
            formEdit.ShowDialog();
            Refrescar();
        }
    }
}
