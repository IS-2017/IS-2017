namespace contrato_trabajo
{
    partial class frm_estadistica_Pagos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_estadistica_pagos = new System.Windows.Forms.Label();
            this.lbl_est_pag_emp = new System.Windows.Forms.Label();
            this.cbo_est_pag_emp = new System.Windows.Forms.ComboBox();
            this.gpb_datos_est_pag = new System.Windows.Forms.GroupBox();
            this.btn_est_pag_generar = new System.Windows.Forms.Button();
            this.dtp_est_pag_fec_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_est_pag_fec_inicio = new System.Windows.Forms.DateTimePicker();
            this.lbl_est_pag_fec_fin = new System.Windows.Forms.Label();
            this.lbl_fec_inicio = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gpb_datos_est_pag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_estadistica_pagos
            // 
            this.lbl_estadistica_pagos.AutoSize = true;
            this.lbl_estadistica_pagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadistica_pagos.Location = new System.Drawing.Point(203, 9);
            this.lbl_estadistica_pagos.Name = "lbl_estadistica_pagos";
            this.lbl_estadistica_pagos.Size = new System.Drawing.Size(281, 32);
            this.lbl_estadistica_pagos.TabIndex = 0;
            this.lbl_estadistica_pagos.Text = "Estadistica de Pagos";
            // 
            // lbl_est_pag_emp
            // 
            this.lbl_est_pag_emp.AutoSize = true;
            this.lbl_est_pag_emp.Location = new System.Drawing.Point(18, 31);
            this.lbl_est_pag_emp.Name = "lbl_est_pag_emp";
            this.lbl_est_pag_emp.Size = new System.Drawing.Size(79, 18);
            this.lbl_est_pag_emp.TabIndex = 1;
            this.lbl_est_pag_emp.Text = "Empleado:";
            // 
            // cbo_est_pag_emp
            // 
            this.cbo_est_pag_emp.FormattingEnabled = true;
            this.cbo_est_pag_emp.Location = new System.Drawing.Point(99, 28);
            this.cbo_est_pag_emp.Name = "cbo_est_pag_emp";
            this.cbo_est_pag_emp.Size = new System.Drawing.Size(200, 26);
            this.cbo_est_pag_emp.TabIndex = 2;
            // 
            // gpb_datos_est_pag
            // 
            this.gpb_datos_est_pag.Controls.Add(this.btn_est_pag_generar);
            this.gpb_datos_est_pag.Controls.Add(this.dtp_est_pag_fec_fin);
            this.gpb_datos_est_pag.Controls.Add(this.dtp_est_pag_fec_inicio);
            this.gpb_datos_est_pag.Controls.Add(this.lbl_est_pag_fec_fin);
            this.gpb_datos_est_pag.Controls.Add(this.lbl_fec_inicio);
            this.gpb_datos_est_pag.Controls.Add(this.cbo_est_pag_emp);
            this.gpb_datos_est_pag.Controls.Add(this.lbl_est_pag_emp);
            this.gpb_datos_est_pag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_est_pag.Location = new System.Drawing.Point(33, 44);
            this.gpb_datos_est_pag.Name = "gpb_datos_est_pag";
            this.gpb_datos_est_pag.Size = new System.Drawing.Size(631, 157);
            this.gpb_datos_est_pag.TabIndex = 3;
            this.gpb_datos_est_pag.TabStop = false;
            this.gpb_datos_est_pag.Text = "Datos Pagos";
            // 
            // btn_est_pag_generar
            // 
            this.btn_est_pag_generar.Location = new System.Drawing.Point(442, 49);
            this.btn_est_pag_generar.Name = "btn_est_pag_generar";
            this.btn_est_pag_generar.Size = new System.Drawing.Size(133, 65);
            this.btn_est_pag_generar.TabIndex = 7;
            this.btn_est_pag_generar.Text = "Generar Grafica:";
            this.btn_est_pag_generar.UseVisualStyleBackColor = true;
            // 
            // dtp_est_pag_fec_fin
            // 
            this.dtp_est_pag_fec_fin.Location = new System.Drawing.Point(99, 105);
            this.dtp_est_pag_fec_fin.Name = "dtp_est_pag_fec_fin";
            this.dtp_est_pag_fec_fin.Size = new System.Drawing.Size(200, 24);
            this.dtp_est_pag_fec_fin.TabIndex = 6;
            // 
            // dtp_est_pag_fec_inicio
            // 
            this.dtp_est_pag_fec_inicio.Location = new System.Drawing.Point(99, 67);
            this.dtp_est_pag_fec_inicio.Name = "dtp_est_pag_fec_inicio";
            this.dtp_est_pag_fec_inicio.Size = new System.Drawing.Size(200, 24);
            this.dtp_est_pag_fec_inicio.TabIndex = 5;
            // 
            // lbl_est_pag_fec_fin
            // 
            this.lbl_est_pag_fec_fin.AutoSize = true;
            this.lbl_est_pag_fec_fin.Location = new System.Drawing.Point(18, 110);
            this.lbl_est_pag_fec_fin.Name = "lbl_est_pag_fec_fin";
            this.lbl_est_pag_fec_fin.Size = new System.Drawing.Size(77, 18);
            this.lbl_est_pag_fec_fin.TabIndex = 4;
            this.lbl_est_pag_fec_fin.Text = "Fecha Fin:";
            // 
            // lbl_fec_inicio
            // 
            this.lbl_fec_inicio.AutoSize = true;
            this.lbl_fec_inicio.Location = new System.Drawing.Point(6, 72);
            this.lbl_fec_inicio.Name = "lbl_fec_inicio";
            this.lbl_fec_inicio.Size = new System.Drawing.Size(91, 18);
            this.lbl_fec_inicio.TabIndex = 3;
            this.lbl_fec_inicio.Text = "Fecha Inicio:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(33, 231);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(631, 214);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // Estadistica_Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(686, 494);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.gpb_datos_est_pag);
            this.Controls.Add(this.lbl_estadistica_pagos);
            this.Name = "Estadistica_Pagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica de pagos";
            this.gpb_datos_est_pag.ResumeLayout(false);
            this.gpb_datos_est_pag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_estadistica_pagos;
        private System.Windows.Forms.Label lbl_est_pag_emp;
        private System.Windows.Forms.ComboBox cbo_est_pag_emp;
        private System.Windows.Forms.GroupBox gpb_datos_est_pag;
        private System.Windows.Forms.Button btn_est_pag_generar;
        private System.Windows.Forms.DateTimePicker dtp_est_pag_fec_fin;
        private System.Windows.Forms.DateTimePicker dtp_est_pag_fec_inicio;
        private System.Windows.Forms.Label lbl_est_pag_fec_fin;
        private System.Windows.Forms.Label lbl_fec_inicio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}