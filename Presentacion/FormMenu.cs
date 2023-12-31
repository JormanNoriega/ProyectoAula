﻿using System;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
                formulario.Close(); // Cierra el formulario existente
                formulario.Dispose(); // Libera recursos asociados al formulario existente
                formulario = new MiForm(); // Crea un nuevo formulario
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToString("dddd dd 'de' MMMM 'del' yyyy");
            lbHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Cerrar Seccion?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
