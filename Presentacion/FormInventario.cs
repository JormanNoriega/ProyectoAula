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
        private BLL_Services servicio = new BLL_Services();
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
            MostrarProcutos();
        }

        public void MostrarProcutos()
        {
            BLL_Services  vistaTabla= new BLL_Services();
            dgvInventario.DataSource = vistaTabla.MostrarProductos();
        }


        
    }
}
