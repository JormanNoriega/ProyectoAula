﻿using BLL;
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
                //servicio.InsertarProductos(txtCodigoProducto.Text, txtNombreProducto.Text, Convert.ToInt32(cboxProveedor.SelectedValue), Convert.ToInt32(cboxCategoria.SelectedValue), Convert.ToInt32(cboxLaboratorio.SelectedValue), txtDescripcion.Text);
                MessageBox.Show("Se agrego el producto correctamente");
                limpiarTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el produto" + ex);
            }
        }

        private void btnCrearLote_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaSeleccionada = dtpVencimiento.Value;
                //servicio.InsertarLote(txtCodLote.Text, txtCodigoProducto.Text, fechaSeleccionada, txtCantidad.Text, txtPrecioCompra.Text, txtPrecioVenta.Text);
                MessageBox.Show("Se agrego el Lote correctamente");
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
                Proveedor proveedor = new Proveedor
                {
                    nit_proveedor = Convert.ToDecimal(txtNitProveedor.Text),
                    nomb_proveedor = txtNombreProveedor.Text
                };
                proveedorService.InsertarDatos(proveedor);
                MessageBox.Show("Se agrego el Proveedor correctamente");
                ListarProveedores();
                limpiarTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el proveedor" + ex); 
            }
        }
        private void btnRegistarLaboratorio_Click(object sender, EventArgs e)
        {
            try
            {
                Laboratorio laboratorio = new Laboratorio
                {
                    nomb_laboratorio = txtNombreLaboratorio.Text
                };
                laboratorioService.InsertarDatos(laboratorio);
                MessageBox.Show("Se agrego el Laboratorio correctamente");
                ListarLaboratorios();
                limpiarTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el Laboratorio" + ex);
            }

        }
        private void btnRegistarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria = new Categoria
                {
                    nomb_categoria = txtNombreCategoria.Text
                };
                categoriaService.InsertarDatos(categoria);
                MessageBox.Show("Se agrego la categoria correctamente");
                ListarCategorias();
                limpiarTxt();
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
            cboxCategoria.DisplayMember = "Nomb_Categoria";
            cboxCategoria.ValueMember = "Id_Categoria";
            cboxCategoria.SelectedIndex = -1;
        }

        private void ListarProveedores()
        {
            dgvProveedores.DataSource = proveedorService.MostrarDatos();
            cboxProveedor.DataSource = proveedorService.MostrarDatos();
            cboxProveedor.DisplayMember = "nomb_proveedor";
            cboxProveedor.ValueMember = "nit_proveedor";
            cboxProveedor.SelectedIndex = -1;
        }

        private void ListarLaboratorios()
        {
            dgvLaboratorios.DataSource = laboratorioService.MostrarDatos();
            cboxLaboratorio.DataSource = laboratorioService.MostrarDatos();
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
            cboxLaboratorio.SelectedIndex = -1;
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
