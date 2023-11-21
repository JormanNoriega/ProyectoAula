using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        private void ConfigurarChart()
        {
            // Configurar el Chart según tus necesidades
            chartVentas.ChartAreas.Add(new ChartArea("Principal"));
            chartVentas.Series.Add(new Series("VentasPorDia"));

            // Puedes configurar el tipo de gráfico, colores, títulos, etc.
            chartVentas.Series["VentasPorDia"].ChartType = SeriesChartType.Column;
            chartVentas.Series["VentasPorDia"].Color = Color.Blue;
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
            chartVentas.Series["VentasPorDia"].Points.Clear();

            // Agregar los puntos al chart
            foreach (var ventaPorDia in ventasPorDia)
            {
                chartVentas.Series["VentasPorDia"].Points.AddXY(ventaPorDia.Fecha, ventaPorDia.TotalVentasPorDia);
            }
        }


    }
}
