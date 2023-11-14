using System;
using BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace Presentacion
{
    public partial class FormVenta : Form
    {
        private Producto productoActual;
        private Lote loteActual;
        private decimal total;

        LoteService loteService = new LoteService();
        ProductoService productoService = new ProductoService();
        public FormVenta()
        {
            InitializeComponent();
            Redondear(panelDatos, 20);
            Redondear(panelDgvVentasRealizadas, 20);
            Redondear(panelDatos2, 20);
            Redondear(panelDgvVentas, 20);
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            dgvVenta.CellFormatting += dgvVenta_CellFormatting;
        }

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

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            BuscarProductoYlote();
        }

        private void txtLoteDeVenta_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLoteDeVenta.Text))
            {
                // Desactivar el CheckBox
                checkBoxLoteRecomendado.Checked = false;
                // Buscar el lote
                loteActual = loteService.BuscarLotePorCodigo(txtLoteDeVenta.Text, productoActual.cod_producto);
                if (loteActual != null)
                {
                    // Mostrar datos del lote encontrado
                    txtPrecioCompra.Text = loteActual.precio_compra.ToString("C");
                    txtPrecioVenta.Text = loteActual.precio_venta.ToString("C");
                    txtStock.Text = loteActual.cantidad.ToString();
                }
            }
        }

        private void MostrarDatosProducto(Producto producto)
        {
            txtCodigoProducto.Text = producto.cod_producto.ToString();
            txtNombreProducto.Text = producto.nomb_producto.ToString();

            loteActual = loteService.loteSugerido(producto.cod_producto);
            if (loteActual != null)
            {
                checkBoxLoteRecomendado.Checked = true;
                txtStock.Text = loteActual.cantidad.ToString();
                txtLoteSugerido.Text = loteActual.cod_lote.ToString();
                txtPrecioCompra.Text = loteActual.precio_compra.ToString("C");
                txtPrecioVenta.Text = loteActual.precio_venta.ToString("C");
            }
            else
            {
                MessageBox.Show("No hay lotes sugeridos para este Producto");
                LimpiarDatosProducto();
            }
        }

        private void BuscarProductoYlote()
        {
            if (!string.IsNullOrWhiteSpace(txtCodigoProducto.Text))
            {
                productoActual = productoService.BuscarProducto(txtCodigoProducto.Text);
                if (productoActual != null)
                {
                    MostrarDatosProducto(productoActual);
                }
                else
                {
                    LimpiarDatosProducto();
                }
            }
            else
            {
                LimpiarDatosProducto();
            }
        }

        private void CalcularTotal()
        {
            total = 0;
            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                // Asegúrate de que la celda no esté vacía antes de intentar convertirla
                if (fila.Cells["Valor"].Value != null && decimal.TryParse(fila.Cells["Valor"].Value.ToString(), out decimal precio))
                {
                    total += precio;
                }
            }
            // Muestra la suma de precios en un TextBox (supongamos que tienes un TextBox llamado txtSumaPrecios)
            txtTotal.Text = total.ToString("C"); // "C" formatea como moneda
        }

        private void LimpiarDatosProducto()
        {
            checkBoxLoteRecomendado.Checked = false;
            //txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtStock.Clear();
            txtLoteSugerido.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            numCantidad.Value = 0;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (productoActual != null)
            {
                Lote lote = checkBoxLoteRecomendado.Checked
                    ? loteService.BuscarLotePorCodigo(txtLoteSugerido.Text, productoActual.cod_producto)
                    : loteService.BuscarLotePorCodigo(txtLoteDeVenta.Text, productoActual.cod_producto);

                if (lote != null)
                {
                    txtPrecioCompra.Text = lote.precio_compra.ToString();
                    txtPrecioVenta.Text = lote.precio_venta.ToString();
                    var Valor = lote.precio_venta * numCantidad.Value;
                    if (numCantidad.Value > 0)
                    {
                        dgvVenta.Rows.Add(productoActual.cod_producto, productoActual.nomb_producto, numCantidad.Value, lote.cod_lote, Valor);
                        CalcularTotal();
                        LimpiarDatosProducto();
                        txtCodigoProducto.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una Cantidad");
                    }
                }
                else
                {
                    MessageBox.Show("Este Lote no existe");
                }
            }
            else
            {
                MessageBox.Show("No hay un producto seleccionado");
            }
        }

        private void dgvVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvVenta.Columns["Valor"].Index && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal valor))
                {
                    e.Value = valor.ToString("C"); // Formatear como moneda
                    e.FormattingApplied = true;

                }
            }
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPago.Text, out decimal pagado))
            {
                if (pagado >= total)
                {
                    decimal cambio = pagado - total;
                    txtCambio.Text = cambio.ToString("C");
                }
                else
                {
                    txtCambio.Text = "Insuficiente";
                }
            }
            else
            {
                txtCambio.Text = string.Empty; // O algún otro valor predeterminado
            }
        }

        private void RegistrarVenta()
        {
            List<ProductoVendido> detalleVenta = ProductosAVender();
            Venta venta = new Venta
            {
                fecha_venta = DateTime.Now,
                total_venta = total,
            };

        }

        private List<ProductoVendido> ProductosAVender()
        {
            List<ProductoVendido> productosAVender = new List<ProductoVendido>();
            foreach (DataGridViewRow row in dgvVenta.Rows)
            {
                if (!row.IsNewRow) // Ignorar la fila nueva si está presente
                {
                    productosAVender.Add(new ProductoVendido
                    {
                        cod_producto = Convert.ToDecimal(row.Cells["cod_producto"].Value),
                        nomb_producto = row.Cells["nomb_producto"].Value.ToString(),
                        cantidad = Convert.ToDecimal(row.Cells["cantidad"].Value),
                        cod_lote = row.Cells["cod_lote"].Value.ToString(),
                        valor = Convert.ToDecimal(row.Cells["valor"].Value)
                    });
                }
            }
            return productosAVender;
        }








            //private DataTable ProductosAVender()
            //{
            //    DataTable productosAVender = new DataTable();
            //    productosAVender.Columns.Add("cod_producto", typeof(decimal));
            //    productosAVender.Columns.Add("nomb_producto", typeof(string));
            //    productosAVender.Columns.Add("cantidad", typeof(decimal));
            //    productosAVender.Columns.Add("cod_lote", typeof(string));
            //    productosAVender.Columns.Add("valor", typeof(decimal));

            //    foreach (DataGridViewRow row in dgvVenta.Rows)
            //    {
            //        if (!row.IsNewRow) // Ignorar la fila nueva si está presente
            //        {
            //            productosAVender.Rows.Add(new object[]
            //            {
            //                Convert.ToDecimal(row.Cells["cod_producto"].Value),
            //                row.Cells["nomb_producto"].Value.ToString(),
            //                Convert.ToDecimal(row.Cells["cantidad"].Value),
            //                row.Cells["cod_lote"].Value.ToString(),
            //                Convert.ToDecimal(row.Cells["valor"].Value)
            //            });
            //        }
            //    }
            //    return productosAVender;
            //}
        }
    }
