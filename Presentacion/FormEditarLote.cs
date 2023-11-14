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
    public partial class FormEditarLote : Form
    {
        LoteService loteService = new LoteService();
        public Lote loteSeleccionado;
        public FormEditarLote(Lote lote)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            loteSeleccionado = lote;
        }

        private void FormEditarLote_Load(object sender, EventArgs e)
        {
            llenarDatos(loteSeleccionado);
        }

        private void llenarDatos(Lote lote)
        {
            txtCodProductoLote.Text = lote.producto.cod_producto.ToString();
            txtCodProductoLote.ReadOnly = true;
            txtCodLote.Text = lote.cod_lote.ToString();
            txtCodLote.ReadOnly = true;
            dtpVencimiento.Value = lote.vencimiento;
            txtCantidad.Text = lote.cantidad.ToString();
            txtPrecioCompra.Text = lote.precio_compra.ToString();
            txtPrecioVenta.Text = lote.precio_venta.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Actualizar los valores del lote con los datos del formulario
            loteSeleccionado.vencimiento = dtpVencimiento.Value;
            loteSeleccionado.cantidad = Convert.ToDecimal(txtCantidad.Text);
            loteSeleccionado.precio_compra = Convert.ToDecimal(txtPrecioCompra.Text);
            loteSeleccionado.precio_venta = Convert.ToDecimal(txtPrecioVenta.Text);
            
            // Llamar al método para actualizar el lote
            var msg = loteService.ActualizarDatos(loteSeleccionado);
            MessageBox.Show(msg);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
