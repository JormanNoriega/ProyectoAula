namespace Presentacion
{
    partial class FormRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodLote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPublicoDirigido = new System.Windows.Forms.TextBox();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txrNombreProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(70, 30, 30, 30);
            this.label2.Size = new System.Drawing.Size(372, 123);
            this.label2.TabIndex = 0;
            this.label2.Text = "REGISTRO";
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.panelDatos.Controls.Add(this.cboxCategoria);
            this.panelDatos.Controls.Add(this.label11);
            this.panelDatos.Controls.Add(this.label10);
            this.panelDatos.Controls.Add(this.groupBox1);
            this.panelDatos.Controls.Add(this.txtPublicoDirigido);
            this.panelDatos.Controls.Add(this.txtLaboratorio);
            this.panelDatos.Controls.Add(this.label9);
            this.panelDatos.Controls.Add(this.txrNombreProducto);
            this.panelDatos.Controls.Add(this.label6);
            this.panelDatos.Controls.Add(this.label5);
            this.panelDatos.Controls.Add(this.label4);
            this.panelDatos.Controls.Add(this.txtCodigoProducto);
            this.panelDatos.Controls.Add(this.label3);
            this.panelDatos.Location = new System.Drawing.Point(90, 151);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1433, 795);
            this.panelDatos.TabIndex = 1;
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Items.AddRange(new object[] {
            "Tableta",
            "Jarabe"});
            this.cboxCategoria.Location = new System.Drawing.Point(106, 365);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(546, 30);
            this.cboxCategoria.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(732, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(305, 47);
            this.label11.TabIndex = 15;
            this.label11.Text = "REGISTRO LOTE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(109, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(430, 47);
            this.label10.TabIndex = 2;
            this.label10.Text = "REGISTRO PRODUCTO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecioVenta);
            this.groupBox1.Controls.Add(this.txtPrecioCompra);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtCodLote);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFechaVencimiento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Location = new System.Drawing.Point(740, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 589);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(27, 351);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(544, 31);
            this.txtPrecioVenta.TabIndex = 20;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Location = new System.Drawing.Point(27, 270);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(544, 31);
            this.txtPrecioCompra.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(25, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 23);
            this.label13.TabIndex = 18;
            this.label13.Text = "PRECIO VENTA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(25, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 23);
            this.label12.TabIndex = 17;
            this.label12.Text = "PRECIO COMPRA";
            // 
            // txtCodLote
            // 
            this.txtCodLote.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodLote.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodLote.Location = new System.Drawing.Point(29, 62);
            this.txtCodLote.Name = "txtCodLote";
            this.txtCodLote.Size = new System.Drawing.Size(546, 31);
            this.txtCodLote.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "CODIGO DE LOTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaVencimiento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaVencimiento.Location = new System.Drawing.Point(27, 131);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(546, 31);
            this.txtFechaVencimiento.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "FECHA DE VENCIMIENTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "CANTIDAD";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Control;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(27, 198);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(544, 31);
            this.txtCantidad.TabIndex = 12;
            // 
            // txtPublicoDirigido
            // 
            this.txtPublicoDirigido.BackColor = System.Drawing.SystemColors.Control;
            this.txtPublicoDirigido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublicoDirigido.Location = new System.Drawing.Point(106, 539);
            this.txtPublicoDirigido.Name = "txtPublicoDirigido";
            this.txtPublicoDirigido.Size = new System.Drawing.Size(546, 31);
            this.txtPublicoDirigido.TabIndex = 13;
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.BackColor = System.Drawing.SystemColors.Control;
            this.txtLaboratorio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLaboratorio.Location = new System.Drawing.Point(106, 456);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(546, 31);
            this.txtLaboratorio.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(102, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "PUBLICO DIRIGIDO";
            // 
            // txrNombreProducto
            // 
            this.txrNombreProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txrNombreProducto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txrNombreProducto.Location = new System.Drawing.Point(106, 284);
            this.txrNombreProducto.Name = "txrNombreProducto";
            this.txrNombreProducto.Size = new System.Drawing.Size(546, 31);
            this.txrNombreProducto.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(104, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "LABORATORIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(104, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "NOMBRE DEL PRODUCTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(104, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "CATEGORIA";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(108, 201);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(546, 31);
            this.txtCodigoProducto.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(102, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "CODIGO DE PRODUCTO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FormRegistro
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1635, 1002);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.label2);
            this.Name = "FormRegistro";
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtPublicoDirigido;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.TextBox txrNombreProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodLote;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboxCategoria;
    }
}