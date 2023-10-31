using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormInventario : Form
    {
        //private BLL_Services servicio = new BLL_Services();
        CategoriaService categoriaService = new CategoriaService();
        LaboratorioService laboratorioService = new LaboratorioService();
        LoteService loteService = new LoteService();
        ProductoService productoService = new ProductoService();
        ProveedorService proveedorService = new ProveedorService();


        private string idproducto;
        public FormInventario()
        {
            InitializeComponent();
            ConfigureRoundedCorners(panelDatos, 20);
        }
        //Funcion para aplicar bordes redondeados a paneles
        private void ConfigureRoundedCorners(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Esquina superior izquierda
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90); // Esquina superior derecha
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90); // Esquina inferior derecha
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90); // Esquina inferior izquierda
            path.CloseAllFigures();

            // Aplica la región con los bordes redondeados al control
            control.Region = new Region(path);
        }


        private void FormInventario_Load(object sender, EventArgs e)
        {
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            MostrarProcutos();
        }

        public void MostrarProcutos()
        {
            //BLL_Services  vistaTablaProductos= new BLL_Services();
            dgvInventario.DataSource = productoService.MostrarProductos();
        }

        private void btnVerLotes_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                idproducto = dgvInventario.CurrentRow.Cells["Codigo De Producto"].Value.ToString();
                dgvInventario.DataSource = loteService.MostrarLotes(idproducto);
                btnVerLotes.Visible = false;
                btnEditar.Visible = true;
                btnEliminar.Visible = true;
                label3.Visible = false;
                txtFiltro.Visible= false;

            }
            else
            {
                MessageBox.Show("Seleccione una Registro");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //CargarProductosFiltrado(txtFiltro.Text);
        }

        //private void CargarProductosFiltrado(string filtro)
        //{
        //    dgvInventario.DataSource = servicio.MostrarProductoFiltrado(filtro);
        //}

    }
}
