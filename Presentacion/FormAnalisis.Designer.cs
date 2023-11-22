namespace Presentacion
{
    partial class FormAnalisis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelBase = new System.Windows.Forms.Panel();
            this.panelGrafica = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panelTotalVendido = new System.Windows.Forms.Panel();
            this.panelVentasTotales = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbVentasTotales = new System.Windows.Forms.Label();
            this.lbTotalVendido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
            this.panelBase.SuspendLayout();
            this.panelGrafica.SuspendLayout();
            this.panelTotalVendido.SuspendLayout();
            this.panelVentasTotales.SuspendLayout();
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
            this.label2.Size = new System.Drawing.Size(353, 123);
            this.label2.TabIndex = 2;
            this.label2.Text = "ANÁLISIS";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(63, 204);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 31);
            this.dtpFechaInicio.TabIndex = 3;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaFin.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(290, 204);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 31);
            this.dtpFechaFin.TabIndex = 4;
            // 
            // chartVentas
            // 
            this.chartVentas.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartVentas.BorderlineWidth = 5;
            chartArea11.Area3DStyle.Enable3D = true;
            chartArea11.Area3DStyle.Inclination = 15;
            chartArea11.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea11.Area3DStyle.Rotation = 20;
            chartArea11.Area3DStyle.WallWidth = 5;
            chartArea11.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea11.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea11.BackColor = System.Drawing.Color.White;
            chartArea11.BorderColor = System.Drawing.Color.Transparent;
            chartArea11.Name = "ChartArea1";
            this.chartVentas.ChartAreas.Add(chartArea11);
            this.chartVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            legend11.Alignment = System.Drawing.StringAlignment.Center;
            legend11.Enabled = false;
            legend11.Name = "Legend1";
            this.chartVentas.Legends.Add(legend11);
            this.chartVentas.Location = new System.Drawing.Point(0, 0);
            this.chartVentas.Name = "chartVentas";
            series11.ChartArea = "ChartArea1";
            series11.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chartVentas.Series.Add(series11);
            this.chartVentas.Size = new System.Drawing.Size(804, 467);
            this.chartVentas.TabIndex = 5;
            this.chartVentas.Text = "chart1";
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.panelBase.Controls.Add(this.panelVentasTotales);
            this.panelBase.Controls.Add(this.panelTotalVendido);
            this.panelBase.Controls.Add(this.panelGrafica);
            this.panelBase.Controls.Add(this.label1);
            this.panelBase.Controls.Add(this.label24);
            this.panelBase.Controls.Add(this.dtpFechaFin);
            this.panelBase.Controls.Add(this.dtpFechaInicio);
            this.panelBase.ForeColor = System.Drawing.Color.White;
            this.panelBase.Location = new System.Drawing.Point(90, 151);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(1438, 795);
            this.panelBase.TabIndex = 6;
            // 
            // panelGrafica
            // 
            this.panelGrafica.Controls.Add(this.chartVentas);
            this.panelGrafica.Location = new System.Drawing.Point(63, 270);
            this.panelGrafica.Name = "panelGrafica";
            this.panelGrafica.Size = new System.Drawing.Size(804, 467);
            this.panelGrafica.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Fecha de Inicio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(286, 169);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(136, 23);
            this.label24.TabIndex = 24;
            this.label24.Text = "Fecha de Fin";
            this.label24.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelTotalVendido
            // 
            this.panelTotalVendido.BackColor = System.Drawing.Color.Transparent;
            this.panelTotalVendido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalVendido.Controls.Add(this.lbTotalVendido);
            this.panelTotalVendido.Controls.Add(this.label3);
            this.panelTotalVendido.Location = new System.Drawing.Point(63, 33);
            this.panelTotalVendido.Name = "panelTotalVendido";
            this.panelTotalVendido.Size = new System.Drawing.Size(218, 100);
            this.panelTotalVendido.TabIndex = 27;
            // 
            // panelVentasTotales
            // 
            this.panelVentasTotales.BackColor = System.Drawing.Color.Transparent;
            this.panelVentasTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVentasTotales.Controls.Add(this.lbVentasTotales);
            this.panelVentasTotales.Controls.Add(this.label4);
            this.panelVentasTotales.Location = new System.Drawing.Point(310, 33);
            this.panelVentasTotales.Name = "panelVentasTotales";
            this.panelVentasTotales.Size = new System.Drawing.Size(218, 100);
            this.panelVentasTotales.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Total Vendido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ventas Totales";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbVentasTotales
            // 
            this.lbVentasTotales.AutoSize = true;
            this.lbVentasTotales.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lbVentasTotales.ForeColor = System.Drawing.Color.White;
            this.lbVentasTotales.Location = new System.Drawing.Point(19, 48);
            this.lbVentasTotales.Name = "lbVentasTotales";
            this.lbVentasTotales.Size = new System.Drawing.Size(88, 23);
            this.lbVentasTotales.TabIndex = 31;
            this.lbVentasTotales.Text = "Numero";
            this.lbVentasTotales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbTotalVendido
            // 
            this.lbTotalVendido.AutoSize = true;
            this.lbTotalVendido.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lbTotalVendido.ForeColor = System.Drawing.Color.White;
            this.lbTotalVendido.Location = new System.Drawing.Point(18, 48);
            this.lbTotalVendido.Name = "lbTotalVendido";
            this.lbTotalVendido.Size = new System.Drawing.Size(88, 23);
            this.lbTotalVendido.TabIndex = 32;
            this.lbTotalVendido.Text = "Numero";
            this.lbTotalVendido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FormAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1635, 1002);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.label2);
            this.Name = "FormAnalisis";
            this.Text = "FormAnalisis";
            this.Load += new System.EventHandler(this.FormAnalisis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
            this.panelBase.ResumeLayout(false);
            this.panelBase.PerformLayout();
            this.panelGrafica.ResumeLayout(false);
            this.panelTotalVendido.ResumeLayout(false);
            this.panelTotalVendido.PerformLayout();
            this.panelVentasTotales.ResumeLayout(false);
            this.panelVentasTotales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panelGrafica;
        private System.Windows.Forms.Panel panelTotalVendido;
        private System.Windows.Forms.Panel panelVentasTotales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbVentasTotales;
        private System.Windows.Forms.Label lbTotalVendido;
    }
}