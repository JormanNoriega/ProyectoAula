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
            if (dgvInventario.ColumnCount == 0)
            {
                dgvInventario.Columns.Add("CodigoProducto", "Código Producto");
                dgvInventario.Columns.Add("NombreProducto", "Nombre Producto");
                dgvInventario.Columns.Add("Proveedor", "Proveedor");
                dgvInventario.Columns.Add("Categoria", "Categoría");
                dgvInventario.Columns.Add("Laboratorio", "Laboratorio");
                dgvInventario.Columns.Add("Descripcion", "Descripción");
                dgvInventario.Columns.Add("CantidadTotal", "Cantidad Total");
            }
            var productos = productoService.MostrarDatos();
            foreach (var producto in productos)
            {
                dgvInventario.Rows.Add(
                    producto.cod_producto,
                    producto.nomb_producto,
                    producto.proveedor.nomb_proveedor,
                    producto.categoria.nomb_categoria,
                    producto.laboratorio.nomb_laboratorio,
                    producto.descripcion,
                    producto.cantidadTotal
                    );
            }
        }

        private void btnVerLotes_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                string codigoProducto = dgvInventario.SelectedRows[0].Cells["CodigoProducto"].Value.ToString();
                var lotes = loteService.MostrarLotesPorProducto(Convert.ToDecimal(codigoProducto));
                dgvInventario.Rows.Clear();
                dgvInventario.Columns.Clear();

                if (dgvInventario.ColumnCount == 0)
                {
                    dgvInventario.Columns.Add("CodigoLote", "Código Lote");
                    dgvInventario.Columns.Add("Producto", "Nombre Producto");
                    dgvInventario.Columns.Add("Vencimiento", "Vencimiento");
                    dgvInventario.Columns.Add("Cantidad", "Cantidad");
                    dgvInventario.Columns.Add("PrecioCompra", "Precio de Compra");
                    dgvInventario.Columns.Add("PrecioVenta", "Precio de Venta");
                }
                foreach (var lote in lotes)
                {
                    dgvInventario.Rows.Add(
                        lote.cod_lote,
                        lote.producto.nomb_producto,
                        lote.vencimiento.ToString("dd/MM/yyyy"),
                        lote.cantidad,
                        lote.precio_compra,
                        lote.precio_venta
                    );
                }
                btnVerLotes.Visible = false;
                btnEditar.Visible = true;
                btnEliminar.Visible = true;
                label3.Visible = false;
                txtFiltro.Visible = false;

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
