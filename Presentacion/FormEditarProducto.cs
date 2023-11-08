using System;
using Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Presentacion
{
    public partial class FormEditarProducto : Form
    {
        private Producto productoSeleccionado;
        CategoriaService categoriaService = new CategoriaService();
        LaboratorioService laboratorioService = new LaboratorioService();
        ProveedorService proveedorService = new ProveedorService();
        ProductoService productoService = new ProductoService();

        public FormEditarProducto(Producto producto)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            productoSeleccionado= producto;
        }

        private void FormEditarProducto_Load(object sender, EventArgs e)
        {
            ListarCategorias();
            ListarLaboratorios();
            ListarProveedores();
            llenarDatos(productoSeleccionado);
        }

        private void llenarDatos(Producto producto)
        {
            txtCodigoProducto.Text = producto.cod_producto.ToString();
            txtCodigoProducto.ReadOnly = true;
            txtNombreProducto.Text = producto.nomb_producto.ToString();
            txtDescripcion.Text = producto.descripcion.ToString();
            Categoria categoriaProducto = producto.categoria;
            for (int i = 0; i < cboxCategoria.Items.Count; i++)
            {
                Categoria categoria = (Categoria)cboxCategoria.Items[i];
                if (categoria.id_categoria == categoriaProducto.id_categoria) 
                {
                    cboxCategoria.SelectedIndex = i; 
                    break;
                }
            }
            Proveedor proveedorProducto = producto.proveedor; 
            for (int i = 0; i < cboxProveedor.Items.Count; i++)
            {
                Proveedor proveedor = (Proveedor)cboxProveedor.Items[i];
                if (proveedor.nit_proveedor == proveedorProducto.nit_proveedor) 
                {
                    cboxProveedor.SelectedIndex = i; 
                    break;
                }
            }
            Laboratorio laboratorioProducto = producto.laboratorio;
            for (int i = 0; i < cboxLaboratorio.Items.Count; i++)
            {
                Laboratorio laboratorio = (Laboratorio)cboxLaboratorio.Items[i];
                if (laboratorio.id_laboratorio == laboratorioProducto.id_laboratorio) 
                {
                    cboxLaboratorio.SelectedIndex = i; 
                    break;
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void ListarCategorias()
        {
            cboxCategoria.DataSource = categoriaService.MostrarDatos();
            cboxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxCategoria.DisplayMember = "Nomb_Categoria";
            cboxCategoria.ValueMember = "Id_Categoria";
            cboxCategoria.SelectedIndex = -1;
        }

        private void ListarProveedores()
        {
            cboxProveedor.DataSource = proveedorService.MostrarDatos();
            cboxProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxProveedor.DisplayMember = "nomb_proveedor";
            cboxProveedor.ValueMember = "nit_proveedor";
            cboxProveedor.SelectedIndex = -1;
        }

        private void ListarLaboratorios()
        {
            cboxLaboratorio.DataSource = laboratorioService.MostrarDatos();
            cboxLaboratorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxLaboratorio.DisplayMember = "nomb_laboratorio";
            cboxLaboratorio.ValueMember = "id_laboratorio";
            cboxLaboratorio.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
