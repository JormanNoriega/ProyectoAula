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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVenta_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<FormVenta>();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormRegistro>();
        }

        private void btnInventario_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<FormInventario>();
        }
        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAnalisis>();
        }
    

        //METODO PARA ABRIR EL FORMULARIO DENTRO DE UN PANEL
        private void AbrirFormulario<MiForm>()where MiForm : Form,new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//busca el formulario
            if(formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel=false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            { 
                formulario.BringToFront();
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
