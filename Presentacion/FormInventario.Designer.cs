namespace Presentacion
{
    partial class FormInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.lbCodLote = new System.Windows.Forms.Label();
            this.txtFiltroLote = new System.Windows.Forms.TextBox();
            this.txtFiltroProducto = new System.Windows.Forms.TextBox();
            this.lbCodProducto = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVerLotes = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.PanelDgvInventario = new System.Windows.Forms.Panel();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.PanelDgvInventario.SuspendLayout();
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
            this.label2.Size = new System.Drawing.Size(437, 123);
            this.label2.TabIndex = 1;
            this.label2.Text = "INVENTARIO";
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.panelDatos.Controls.Add(this.PanelDgvInventario);
            this.panelDatos.Controls.Add(this.lbCodLote);
            this.panelDatos.Controls.Add(this.txtFiltroLote);
            this.panelDatos.Controls.Add(this.txtFiltroProducto);
            this.panelDatos.Controls.Add(this.lbCodProducto);
            this.panelDatos.Controls.Add(this.btnEditar);
            this.panelDatos.Controls.Add(this.btnEliminar);
            this.panelDatos.Controls.Add(this.btnVerLotes);
            this.panelDatos.Location = new System.Drawing.Point(90, 151);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1438, 795);
            this.panelDatos.TabIndex = 2;
            // 
            // lbCodLote
            // 
            this.lbCodLote.AutoSize = true;
            this.lbCodLote.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lbCodLote.ForeColor = System.Drawing.Color.White;
            this.lbCodLote.Location = new System.Drawing.Point(68, 91);
            this.lbCodLote.Name = "lbCodLote";
            this.lbCodLote.Size = new System.Drawing.Size(128, 23);
            this.lbCodLote.TabIndex = 8;
            this.lbCodLote.Text = "Buscar Lote ";
            this.lbCodLote.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtFiltroLote
            // 
            this.txtFiltroLote.BackColor = System.Drawing.SystemColors.Control;
            this.txtFiltroLote.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroLote.Location = new System.Drawing.Point(244, 83);
            this.txtFiltroLote.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtFiltroLote.Name = "txtFiltroLote";
            this.txtFiltroLote.Size = new System.Drawing.Size(546, 31);
            this.txtFiltroLote.TabIndex = 7;
            this.txtFiltroLote.TextChanged += new System.EventHandler(this.txtFiltroLote_TextChanged);
            // 
            // txtFiltroProducto
            // 
            this.txtFiltroProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txtFiltroProducto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroProducto.Location = new System.Drawing.Point(244, 83);
            this.txtFiltroProducto.Name = "txtFiltroProducto";
            this.txtFiltroProducto.Size = new System.Drawing.Size(546, 31);
            this.txtFiltroProducto.TabIndex = 6;
            this.txtFiltroProducto.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lbCodProducto
            // 
            this.lbCodProducto.AutoSize = true;
            this.lbCodProducto.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lbCodProducto.ForeColor = System.Drawing.Color.White;
            this.lbCodProducto.Location = new System.Drawing.Point(68, 91);
            this.lbCodProducto.Name = "lbCodProducto";
            this.lbCodProducto.Size = new System.Drawing.Size(170, 23);
            this.lbCodProducto.TabIndex = 5;
            this.lbCodProducto.Text = "Buscar Producto";
            this.lbCodProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1133, 690);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 39);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1254, 690);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 39);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVerLotes
            // 
            this.btnVerLotes.Location = new System.Drawing.Point(72, 690);
            this.btnVerLotes.Name = "btnVerLotes";
            this.btnVerLotes.Size = new System.Drawing.Size(115, 39);
            this.btnVerLotes.TabIndex = 1;
            this.btnVerLotes.Text = "Ver Lotes";
            this.btnVerLotes.UseVisualStyleBackColor = true;
            this.btnVerLotes.Click += new System.EventHandler(this.btnVerLotes_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInventario.ColumnHeadersHeight = 35;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.Location = new System.Drawing.Point(0, 0);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInventario.Size = new System.Drawing.Size(1297, 514);
            this.dgvInventario.TabIndex = 0;
            // 
            // PanelDgvInventario
            // 
            this.PanelDgvInventario.Controls.Add(this.dgvInventario);
            this.PanelDgvInventario.Location = new System.Drawing.Point(72, 154);
            this.PanelDgvInventario.Name = "PanelDgvInventario";
            this.PanelDgvInventario.Size = new System.Drawing.Size(1297, 514);
            this.PanelDgvInventario.TabIndex = 9;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1635, 1002);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.label2);
            this.Name = "FormInventario";
            this.Text = "FormInventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.PanelDgvInventario.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDatos;
        public System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnVerLotes;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lbCodProducto;
        private System.Windows.Forms.TextBox txtFiltroProducto;
        private System.Windows.Forms.Label lbCodLote;
        private System.Windows.Forms.TextBox txtFiltroLote;
        private System.Windows.Forms.Panel PanelDgvInventario;
    }
}