using BLL;
using Entity;
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
        LoteService loteService = new LoteService();
        ProductoService productoService = new ProductoService();
        string codigoProducto;

        public FormInventario()
        {
            InitializeComponent();
            Redondear(panelDatos, 20);
            Redondear(PanelDgvInventario, 20);
            Redondear(txtFiltroProducto,10);
            Redondear(txtFiltroLote,10);
        }
        //Funcion para aplicar bordes redondeados a paneles
        private void Redondear(Control control, int radius)
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
            //btnEditar.Visible = true;
            //btnEliminar.Visible = false;
            txtFiltroLote.Visible = false;
            lbCodLote.Visible = false;
            MostrarProcutos();
        }

        public void MostrarProcutos()
        {
            dgvInventario.Rows.Clear();
            dgvInventario.Columns.Clear();
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

        public void MostrarLotes(string codigoProducto)
        {
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
        }

        private void btnVerLotes_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                codigoProducto = dgvInventario.SelectedRows[0].Cells["CodigoProducto"].Value.ToString();
                MostrarLotes(codigoProducto);
                lbCodProducto.Visible = false;
                txtFiltroProducto.Visible = false;
                txtFiltroLote.Visible = true;
                lbCodLote.Visible = true;
                btnVerLotes.Visible = false;

            }
            else
            {
                MessageBox.Show("Seleccione una Registro");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                // Verificar si se está mostrando información de productos o lotes
                if (dgvInventario.Columns.Contains("CodigoProducto"))
                {
                    // Seleccionar producto
                    string codp = dgvInventario.SelectedRows[0].Cells["CodigoProducto"].Value.ToString();
                    Producto producto = productoService.MostrarDatos().Find(p => p.cod_producto == Convert.ToDecimal(codp));
                    FormEditarProducto editarProducto = new FormEditarProducto(producto);
                    editarProducto.ShowDialog();
                    MostrarProcutos();
                }
                else if (dgvInventario.Columns.Contains("CodigoLote"))
                {
                    // Seleccionar lote
                    string codl = dgvInventario.SelectedRows[0].Cells["CodigoLote"].Value.ToString();
                    Lote lote = loteService.MostrarLotesPorProducto(Convert.ToDecimal(codigoProducto)).Find(l => l.cod_lote == codl);
                    FormEditarLote formEditarLote = new FormEditarLote(lote);
                    formEditarLote.ShowDialog();
                    MostrarLotes(codigoProducto);
                }
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                string message = "";
                string caption = "Confirmar eliminación";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                if (dgvInventario.Columns.Contains("CodigoProducto"))
                {
                    message = "¿Está seguro de que desea eliminar este producto?";
                }
                else if (dgvInventario.Columns.Contains("CodigoLote"))
                {
                    message = "¿Está seguro de que desea eliminar este lote?";
                }
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                // Verificar si se está mostrando información de productos o lotes
                if (result == DialogResult.Yes)
                {
                    if (dgvInventario.Columns.Contains("CodigoProducto"))
                    {
                        // Seleccionar producto
                        string codp = dgvInventario.SelectedRows[0].Cells["CodigoProducto"].Value.ToString();
                        Producto producto = productoService.MostrarDatos().Find(p => p.cod_producto == Convert.ToDecimal(codp));
                        var msg = productoService.EliminarDatos(producto);
                        MessageBox.Show(msg);
                        MostrarProcutos();
                    }
                    else if (dgvInventario.Columns.Contains("CodigoLote"))
                    {
                        // Seleccionar lote
                        string codl = dgvInventario.SelectedRows[0].Cells["CodigoLote"].Value.ToString();
                        Lote lote = loteService.MostrarLotesPorProducto(Convert.ToDecimal(codigoProducto)).Find(l => l.cod_lote == codl);
                        var msg = loteService.EliminarDatos(lote);
                        MessageBox.Show(msg);
                        MostrarLotes(codigoProducto);
                    }
                }
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarProductosFiltrado(txtFiltroProducto.Text);
        }
        private void txtFiltroLote_TextChanged(object sender, EventArgs e)
        {
            CargarLotesFiltrado(txtFiltroLote.Text);
        }

        private void CargarLotesFiltrado(string filtro)
        {
            var lotesFiltrados = loteService.MostrarLoteFiltrado(filtro,Convert.ToDecimal(codigoProducto));
            dgvInventario.Rows.Clear();
            foreach (var lote in lotesFiltrados)
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
        }

        private void CargarProductosFiltrado(string filtro)
        {
            var productosFiltrados = productoService.MostrarProductoFiltrado(filtro);
            dgvInventario.Rows.Clear();
            foreach (var producto in productosFiltrados)
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

    }
}
