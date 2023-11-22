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
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    public partial class FormAnalisis : Form
    {
        private VentaService ventaService = new VentaService();
        public FormAnalisis()
        {
            InitializeComponent();
            ConfigurarChart();
            CargarDatosEnChart();
        }

        private void FormAnalisis_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.Value=dtpFechaInicio.Value.AddDays(-7);
            Redondear(panelBase, 20);
            Redondear(panelGrafica, 20);
            //Redondear(panelTotalVendido, 20);
            //Redondear(panelVentasTotales, 20);
            var totalVendido = ventaService.totalVendido();
            lbTotalVendido.Text = totalVendido.ToString("C");
            var ventasTotales = ventaService.ventasTotales();
            lbVentasTotales.Text = ventasTotales.ToString(); 
      
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

        private void ConfigurarChart()
        {
            chartVentas.Titles.Add("Ventas por Día");
            // Eventos para manejar cambios en los DateTimePicker
            dtpFechaInicio.ValueChanged += (sender, e) => CargarDatosEnChart();
            dtpFechaFin.ValueChanged += (sender, e) => CargarDatosEnChart();
        }

        private void CargarDatosEnChart()
        {
            // Obtener las fechas seleccionadas
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;

            // Obtener las ventas agrupadas por día en el rango seleccionado
            var ventasPorDia = ventaService.ObtenerVentasAgrupadasPorDia(fechaInicio, fechaFin);

            // Limpiar los puntos existentes en la serie
            chartVentas.Series[0].Points.Clear();

            // Agregar los puntos al chart
            foreach (var ventaPorDia in ventasPorDia)
            {
                chartVentas.Series[0].Points.AddXY(ventaPorDia.Fecha, ventaPorDia.TotalVentasPorDia);
            }
        }
    }
}
