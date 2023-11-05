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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FormRegistro : Form
    {

        CategoriaService categoriaService = new CategoriaService();
        LaboratorioService laboratorioService = new LaboratorioService();
        LoteService loteService = new LoteService();
        ProductoService productoService = new ProductoService();
        ProveedorService proveedorService = new ProveedorService();

        public FormRegistro()
        {
            InitializeComponent();
            ConfigureRoundedCorners(panelDatosProductos, 20);
            ConfigureRoundedCorners(panelDatosLotes, 20);
            ConfigureRoundedCorners(panelDatosCategorias, 20);
            ConfigureRoundedCorners(panelDatosLaboratorios, 20);
            ConfigureRoundedCorners(panelDatosProveedores, 20);

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
        private void FormRegistro_Load(object sender, EventArgs e)
        {
            ListarCategorias();
            ListarProveedores();
            ListarLaboratorios();
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor proveedorSeleccionado = (Proveedor)cboxProveedor.SelectedItem;
                Categoria categoriaSeleccionada = (Categoria)cboxCategoria.SelectedItem;
                Laboratorio laboratorioSeleccionado = (Laboratorio)cboxLaboratorio.SelectedItem;
                
                if (proveedorSeleccionado != null && categoriaSeleccionada != null && laboratorioSeleccionado != null && txtCodigoProducto != null 
                    && txtNombreProducto != null && txtDescripcion != null)
                {
                    var existe = productoService.Existe(Convert.ToDecimal(txtCodigoProducto.Text));
                    if (existe == true)
                    {
                        MessageBox.Show("Codigo de Producto Existente...");
                    }
                    else
                    {
                        Producto producto = new Producto
                        {
                            cod_producto = Convert.ToDecimal(txtCodigoProducto.Text),
                            nomb_producto = txtNombreProducto.Text,
                            proveedor = proveedorSeleccionado,
                            categoria = categoriaSeleccionada,
                            laboratorio = laboratorioSeleccionado,
                            descripcion = txtDescripcion.Text,
                        };
                        var msg = productoService.InsertarDatos(producto);
                        MessageBox.Show(msg);
                        limpiarTxt();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese los Datos de todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el produto" + ex.Message);
            }
        }

        private void btnCrearLote_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaSeleccionada = dtpVencimiento.Value;
                Producto productoSeleccionado = loteService.productoSeleccionado(Convert.ToDecimal(txtCodProductoLote.Text)); 
                Lote lote = new Lote
                {
                    cod_lote=txtCodLote.Text,
                    producto=productoSeleccionado,
                    vencimiento= fechaSeleccionada,
                    cantidad=Convert.ToDecimal(txtCantidad.Text),
                    precio_compra=Convert.ToDecimal(txtPrecioCompra.Text),
                    precio_venta=Convert.ToDecimal(txtPrecioVenta.Text),
                };
                var msg = loteService.InsertarDatos(lote);
                MessageBox.Show(msg);
                limpiarTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el Lote" + ex);
            }
        }
        private void btnRegistarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNombreProveedor != null && txtNitProveedor != null)
                {
                    Proveedor proveedor = new Proveedor
                    {
                        nit_proveedor = Convert.ToDecimal(txtNitProveedor.Text),
                        nomb_proveedor = txtNombreProveedor.Text
                    };
                    var msg = proveedorService.InsertarDatos(proveedor);
                    MessageBox.Show(msg);
                    ListarProveedores();
                    limpiarTxt();
                }
                else
                {
                    MessageBox.Show("Ingrese los Datos de todos los campos");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el proveedor" + ex.Message);
            }
        }
        private void btnRegistarLaboratorio_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreLaboratorio != null)
                {
                    Laboratorio laboratorio = new Laboratorio
                    {
                        nomb_laboratorio = txtNombreLaboratorio.Text
                    };
                    var msg = laboratorioService.InsertarDatos(laboratorio);
                    MessageBox.Show(msg);
                    ListarLaboratorios();
                    limpiarTxt();
                }
                else
                {
                    MessageBox.Show("Ingrese los Datos de todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el Laboratorio" + ex.Message);
            }

        }
        private void btnRegistarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNombreCategoria != null)
                {
                    Categoria categoria = new Categoria
                    {
                        nomb_categoria = txtNombreCategoria.Text
                    };
                    var msg = categoriaService.InsertarDatos(categoria);
                    MessageBox.Show(msg);
                    ListarCategorias();
                    limpiarTxt();
                }
                else
                {
                    MessageBox.Show("Ingrese los Datos de todos los campos");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la categoria" + ex);
            }

        }

        private void ListarCategorias()
        {
            dgvCategorias.DataSource = categoriaService.MostrarDatos();
            cboxCategoria.DataSource = categoriaService.MostrarDatos();
            cboxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxCategoria.DisplayMember = "Nomb_Categoria";
            cboxCategoria.ValueMember = "Id_Categoria";
            cboxCategoria.SelectedIndex = -1;
        }

        private void ListarProveedores()
        {
            dgvProveedores.DataSource = proveedorService.MostrarDatos();
            cboxProveedor.DataSource = proveedorService.MostrarDatos();
            cboxProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxProveedor.DisplayMember = "nomb_proveedor";
            cboxProveedor.ValueMember = "nit_proveedor";
            cboxProveedor.SelectedIndex = -1;
        }

        private void ListarLaboratorios()
        {
            dgvLaboratorios.DataSource = laboratorioService.MostrarDatos();
            cboxLaboratorio.DataSource = laboratorioService.MostrarDatos();
            cboxLaboratorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxLaboratorio.DisplayMember = "nomb_laboratorio";
            cboxLaboratorio.ValueMember = "id_laboratorio";
            cboxLaboratorio.SelectedIndex = -1;
        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            string codProducto = txtCodigoProducto.Text;


        }

        private void limpiarTxt()
        {
            //Limpiar Producto
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            cboxProveedor.SelectedIndex = -1;
            cboxCategoria.SelectedIndex = -1;
            cboxLaboratorio.SelectedIndex = -1;
            txtDescripcion.Clear();
            //Limpiar Lote

            //Limpiar Proveedor
            txtNombreProveedor.Clear();
            txtNitProveedor.Clear();
            //Limpiar Laboratorio
            txtNombreLaboratorio.Clear();
            //Limpiar Categoria
            txtNombreCategoria.Clear();
        }

    }
}
