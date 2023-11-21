namespace Presentacion
{
    partial class FormVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVentaRegistradas = new System.Windows.Forms.DataGridView();
            this.tabVenta = new System.Windows.Forms.TabControl();
            this.tabVentasRegistradas = new System.Windows.Forms.TabPage();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.panelDgvVentasRealizadas = new System.Windows.Forms.Panel();
            this.tabNuevaVenta = new System.Windows.Forms.TabPage();
            this.panelDatos2 = new System.Windows.Forms.Panel();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxLoteRecomendado = new System.Windows.Forms.CheckBox();
            this.txtLoteDeVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoteSugerido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.panelDgvVentas = new System.Windows.Forms.Panel();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.CodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerDetallesVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaRegistradas)).BeginInit();
            this.tabVenta.SuspendLayout();
            this.tabVentasRegistradas.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panelDgvVentasRealizadas.SuspendLayout();
            this.tabNuevaVenta.SuspendLayout();
            this.panelDatos2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.panelDgvVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(92, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(541, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "VENTAS REALIZADAS";
            // 
            // dgvVentaRegistradas
            // 
            this.dgvVentaRegistradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentaRegistradas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVentaRegistradas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVentaRegistradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentaRegistradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentaRegistradas.ColumnHeadersHeight = 35;
            this.dgvVentaRegistradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentaRegistradas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentaRegistradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentaRegistradas.EnableHeadersVisualStyles = false;
            this.dgvVentaRegistradas.Location = new System.Drawing.Point(0, 0);
            this.dgvVentaRegistradas.Name = "dgvVentaRegistradas";
            this.dgvVentaRegistradas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVentaRegistradas.Size = new System.Drawing.Size(1297, 514);
            this.dgvVentaRegistradas.TabIndex = 2;
            // 
            // tabVenta
            // 
            this.tabVenta.Controls.Add(this.tabVentasRegistradas);
            this.tabVenta.Controls.Add(this.tabNuevaVenta);
            this.tabVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVenta.ItemSize = new System.Drawing.Size(130, 30);
            this.tabVenta.Location = new System.Drawing.Point(0, 0);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Drawing.Point(15, 4);
            this.tabVenta.SelectedIndex = 0;
            this.tabVenta.Size = new System.Drawing.Size(1635, 1002);
            this.tabVenta.TabIndex = 3;
            // 
            // tabVentasRegistradas
            // 
            this.tabVentasRegistradas.Controls.Add(this.panelDatos);
            this.tabVentasRegistradas.Controls.Add(this.label2);
            this.tabVentasRegistradas.Location = new System.Drawing.Point(4, 34);
            this.tabVentasRegistradas.Name = "tabVentasRegistradas";
            this.tabVentasRegistradas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentasRegistradas.Size = new System.Drawing.Size(1627, 964);
            this.tabVentasRegistradas.TabIndex = 0;
            this.tabVentasRegistradas.Text = "Ventas Registradas";
            this.tabVentasRegistradas.UseVisualStyleBackColor = true;
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.panelDatos.Controls.Add(this.btnVerDetallesVenta);
            this.panelDatos.Controls.Add(this.panelDgvVentasRealizadas);
            this.panelDatos.Location = new System.Drawing.Point(103, 127);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1438, 795);
            this.panelDatos.TabIndex = 0;
            // 
            // panelDgvVentasRealizadas
            // 
            this.panelDgvVentasRealizadas.Controls.Add(this.dgvVentaRegistradas);
            this.panelDgvVentasRealizadas.Location = new System.Drawing.Point(72, 154);
            this.panelDgvVentasRealizadas.Name = "panelDgvVentasRealizadas";
            this.panelDgvVentasRealizadas.Size = new System.Drawing.Size(1297, 514);
            this.panelDgvVentasRealizadas.TabIndex = 3;
            // 
            // tabNuevaVenta
            // 
            this.tabNuevaVenta.Controls.Add(this.panelDatos2);
            this.tabNuevaVenta.Location = new System.Drawing.Point(4, 34);
            this.tabNuevaVenta.Name = "tabNuevaVenta";
            this.tabNuevaVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevaVenta.Size = new System.Drawing.Size(1627, 964);
            this.tabNuevaVenta.TabIndex = 1;
            this.tabNuevaVenta.Text = "Nueva Venta";
            this.tabNuevaVenta.UseVisualStyleBackColor = true;
            // 
            // panelDatos2
            // 
            this.panelDatos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.panelDatos2.Controls.Add(this.txtCambio);
            this.panelDatos2.Controls.Add(this.label13);
            this.panelDatos2.Controls.Add(this.txtPago);
            this.panelDatos2.Controls.Add(this.label11);
            this.panelDatos2.Controls.Add(this.txtTotal);
            this.panelDatos2.Controls.Add(this.label12);
            this.panelDatos2.Controls.Add(this.txtPrecioVenta);
            this.panelDatos2.Controls.Add(this.label9);
            this.panelDatos2.Controls.Add(this.txtPrecioCompra);
            this.panelDatos2.Controls.Add(this.label10);
            this.panelDatos2.Controls.Add(this.checkBoxLoteRecomendado);
            this.panelDatos2.Controls.Add(this.txtLoteDeVenta);
            this.panelDatos2.Controls.Add(this.label8);
            this.panelDatos2.Controls.Add(this.txtLoteSugerido);
            this.panelDatos2.Controls.Add(this.label7);
            this.panelDatos2.Controls.Add(this.btnCancelar);
            this.panelDatos2.Controls.Add(this.label6);
            this.panelDatos2.Controls.Add(this.btnVender);
            this.panelDatos2.Controls.Add(this.btnAgregarProducto);
            this.panelDatos2.Controls.Add(this.txtStock);
            this.panelDatos2.Controls.Add(this.label4);
            this.panelDatos2.Controls.Add(this.label1);
            this.panelDatos2.Controls.Add(this.numCantidad);
            this.panelDatos2.Controls.Add(this.txtNombreProducto);
            this.panelDatos2.Controls.Add(this.label5);
            this.panelDatos2.Controls.Add(this.label3);
            this.panelDatos2.Controls.Add(this.txtCodigoProducto);
            this.panelDatos2.Controls.Add(this.panelDgvVentas);
            this.panelDatos2.Location = new System.Drawing.Point(89, 92);
            this.panelDatos2.Name = "panelDatos2";
            this.panelDatos2.Size = new System.Drawing.Size(1438, 821);
            this.panelDatos2.TabIndex = 1;
            // 
            // txtCambio
            // 
            this.txtCambio.BackColor = System.Drawing.SystemColors.Control;
            this.txtCambio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(546, 766);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(166, 31);
            this.txtCambio.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(542, 739);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 23);
            this.label13.TabIndex = 35;
            this.label13.Text = "Cambio";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtPago
            // 
            this.txtPago.BackColor = System.Drawing.SystemColors.Control;
            this.txtPago.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(366, 766);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(166, 31);
            this.txtPago.TabIndex = 34;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(362, 739);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 23);
            this.label11.TabIndex = 33;
            this.label11.Text = "Pagado";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(72, 766);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(253, 31);
            this.txtTotal.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(68, 739);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 23);
            this.label12.TabIndex = 31;
            this.label12.Text = "Total";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(719, 121);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.ReadOnly = true;
            this.txtPrecioVenta.Size = new System.Drawing.Size(204, 31);
            this.txtPrecioVenta.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(715, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 23);
            this.label9.TabIndex = 29;
            this.label9.Text = "Precio Venta";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Location = new System.Drawing.Point(719, 58);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.ReadOnly = true;
            this.txtPrecioCompra.Size = new System.Drawing.Size(204, 31);
            this.txtPrecioCompra.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(715, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "Precio Compra";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // checkBoxLoteRecomendado
            // 
            this.checkBoxLoteRecomendado.AutoSize = true;
            this.checkBoxLoteRecomendado.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.checkBoxLoteRecomendado.ForeColor = System.Drawing.Color.White;
            this.checkBoxLoteRecomendado.Location = new System.Drawing.Point(1164, 58);
            this.checkBoxLoteRecomendado.Name = "checkBoxLoteRecomendado";
            this.checkBoxLoteRecomendado.Size = new System.Drawing.Size(274, 26);
            this.checkBoxLoteRecomendado.TabIndex = 26;
            this.checkBoxLoteRecomendado.Text = "Utilizar Lote Recomendado";
            this.checkBoxLoteRecomendado.UseVisualStyleBackColor = true;
            // 
            // txtLoteDeVenta
            // 
            this.txtLoteDeVenta.BackColor = System.Drawing.SystemColors.Control;
            this.txtLoteDeVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoteDeVenta.Location = new System.Drawing.Point(949, 121);
            this.txtLoteDeVenta.Name = "txtLoteDeVenta";
            this.txtLoteDeVenta.Size = new System.Drawing.Size(204, 31);
            this.txtLoteDeVenta.TabIndex = 25;
            this.txtLoteDeVenta.TextChanged += new System.EventHandler(this.txtLoteDeVenta_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(945, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Lote de Venta";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtLoteSugerido
            // 
            this.txtLoteSugerido.BackColor = System.Drawing.SystemColors.Control;
            this.txtLoteSugerido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoteSugerido.Location = new System.Drawing.Point(949, 58);
            this.txtLoteSugerido.Name = "txtLoteSugerido";
            this.txtLoteSugerido.ReadOnly = true;
            this.txtLoteSugerido.Size = new System.Drawing.Size(204, 31);
            this.txtLoteSugerido.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(945, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Lote Recomendado";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.btnCancelar.Location = new System.Drawing.Point(929, 739);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(209, 58);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(68, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Productos en esta venta:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnVender
            // 
            this.btnVender.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.btnVender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.btnVender.Location = new System.Drawing.Point(1160, 739);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(209, 58);
            this.btnVender.TabIndex = 19;
            this.btnVender.Text = "Realizar Venta";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.btnAgregarProducto.Location = new System.Drawing.Point(1209, 109);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(133, 49);
            this.btnAgregarProducto.TabIndex = 18;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.Control;
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(575, 58);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(120, 31);
            this.txtStock.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(571, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stock";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(571, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cantidad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.numCantidad.Location = new System.Drawing.Point(575, 121);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 31);
            this.numCantidad.TabIndex = 11;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreProducto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(72, 121);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(479, 31);
            this.txtNombreProducto.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo de Producto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(72, 58);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(479, 31);
            this.txtCodigoProducto.TabIndex = 4;
            this.txtCodigoProducto.TextChanged += new System.EventHandler(this.txtCodigoProducto_TextChanged);
            // 
            // panelDgvVentas
            // 
            this.panelDgvVentas.Controls.Add(this.dgvVenta);
            this.panelDgvVentas.Location = new System.Drawing.Point(72, 209);
            this.panelDgvVentas.Name = "panelDgvVentas";
            this.panelDgvVentas.Size = new System.Drawing.Size(1297, 514);
            this.panelDgvVentas.TabIndex = 3;
            // 
            // dgvVenta
            // 
            this.dgvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgvVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVenta.ColumnHeadersHeight = 35;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProducto,
            this.NombProducto,
            this.Cantidad,
            this.CodLote,
            this.Valor});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVenta.EnableHeadersVisualStyles = false;
            this.dgvVenta.Location = new System.Drawing.Point(0, 0);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVenta.Size = new System.Drawing.Size(1297, 514);
            this.dgvVenta.TabIndex = 2;
            this.dgvVenta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVenta_CellFormatting);
            // 
            // CodProducto
            // 
            this.CodProducto.HeaderText = "Codigo Producto";
            this.CodProducto.Name = "CodProducto";
            // 
            // NombProducto
            // 
            this.NombProducto.HeaderText = "Nombre Producto";
            this.NombProducto.Name = "NombProducto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // CodLote
            // 
            this.CodLote.HeaderText = "Codigo Lote";
            this.CodLote.Name = "CodLote";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // btnVerDetallesVenta
            // 
            this.btnVerDetallesVenta.Location = new System.Drawing.Point(72, 694);
            this.btnVerDetallesVenta.Name = "btnVerDetallesVenta";
            this.btnVerDetallesVenta.Size = new System.Drawing.Size(132, 39);
            this.btnVerDetallesVenta.TabIndex = 4;
            this.btnVerDetallesVenta.Text = "Ver Detalles de Venta";
            this.btnVerDetallesVenta.UseVisualStyleBackColor = true;
            this.btnVerDetallesVenta.Click += new System.EventHandler(this.btnVerDetallesVenta_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1635, 1002);
            this.Controls.Add(this.tabVenta);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaRegistradas)).EndInit();
            this.tabVenta.ResumeLayout(false);
            this.tabVentasRegistradas.ResumeLayout(false);
            this.tabVentasRegistradas.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDgvVentasRealizadas.ResumeLayout(false);
            this.tabNuevaVenta.ResumeLayout(false);
            this.panelDatos2.ResumeLayout(false);
            this.panelDatos2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.panelDgvVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvVentaRegistradas;
        private System.Windows.Forms.TabControl tabVenta;
        private System.Windows.Forms.TabPage tabVentasRegistradas;
        private System.Windows.Forms.TabPage tabNuevaVenta;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Panel panelDgvVentasRealizadas;
        private System.Windows.Forms.Panel panelDatos2;
        private System.Windows.Forms.Panel panelDgvVentas;
        public System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoteSugerido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLoteDeVenta;
        private System.Windows.Forms.CheckBox checkBoxLoteRecomendado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnVerDetallesVenta;
    }
}