namespace contrato_trabajo
{
    partial class frm_reporte_activos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reporte_activos));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lbl_form_activos = new System.Windows.Forms.Label();
            this.cbo_reporte_empresa = new System.Windows.Forms.ComboBox();
            this.lbl_reporte_activo_empresa = new System.Windows.Forms.Label();
            this.gpb_reporte_activos = new System.Windows.Forms.GroupBox();
            this.gpb_navegador = new System.Windows.Forms.GroupBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.txt_cbo_reporte_empresa = new System.Windows.Forms.TextBox();
            this.dgv_reporte_activo = new System.Windows.Forms.DataGridView();
            this.gpb_reporte_activos.SuspendLayout();
            this.gpb_navegador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte_activo)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 50);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(931, 311);
            this.crystalReportViewer1.TabIndex = 13;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lbl_form_activos
            // 
            this.lbl_form_activos.AutoSize = true;
            this.lbl_form_activos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_form_activos.Location = new System.Drawing.Point(12, 9);
            this.lbl_form_activos.Name = "lbl_form_activos";
            this.lbl_form_activos.Size = new System.Drawing.Size(232, 28);
            this.lbl_form_activos.TabIndex = 193;
            this.lbl_form_activos.Text = "Reporte de Activos";
            // 
            // cbo_reporte_empresa
            // 
            this.cbo_reporte_empresa.FormattingEnabled = true;
            this.cbo_reporte_empresa.Location = new System.Drawing.Point(96, 19);
            this.cbo_reporte_empresa.Name = "cbo_reporte_empresa";
            this.cbo_reporte_empresa.Size = new System.Drawing.Size(191, 25);
            this.cbo_reporte_empresa.TabIndex = 194;
            // 
            // lbl_reporte_activo_empresa
            // 
            this.lbl_reporte_activo_empresa.AutoSize = true;
            this.lbl_reporte_activo_empresa.Location = new System.Drawing.Point(9, 19);
            this.lbl_reporte_activo_empresa.Name = "lbl_reporte_activo_empresa";
            this.lbl_reporte_activo_empresa.Size = new System.Drawing.Size(72, 19);
            this.lbl_reporte_activo_empresa.TabIndex = 195;
            this.lbl_reporte_activo_empresa.Text = "Empresa:";
            // 
            // gpb_reporte_activos
            // 
            this.gpb_reporte_activos.Controls.Add(this.txt_cbo_reporte_empresa);
            this.gpb_reporte_activos.Controls.Add(this.cbo_reporte_empresa);
            this.gpb_reporte_activos.Controls.Add(this.lbl_reporte_activo_empresa);
            this.gpb_reporte_activos.Controls.Add(this.crystalReportViewer1);
            this.gpb_reporte_activos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.gpb_reporte_activos.Location = new System.Drawing.Point(12, 150);
            this.gpb_reporte_activos.Name = "gpb_reporte_activos";
            this.gpb_reporte_activos.Size = new System.Drawing.Size(954, 367);
            this.gpb_reporte_activos.TabIndex = 196;
            this.gpb_reporte_activos.TabStop = false;
            this.gpb_reporte_activos.Text = "Activos";
            // 
            // gpb_navegador
            // 
            this.gpb_navegador.Controls.Add(this.btn_nuevo);
            this.gpb_navegador.Controls.Add(this.btn_ultimo);
            this.gpb_navegador.Controls.Add(this.btn_primero);
            this.gpb_navegador.Controls.Add(this.btn_siguiente);
            this.gpb_navegador.Controls.Add(this.btn_anterior);
            this.gpb_navegador.Controls.Add(this.btn_buscar);
            this.gpb_navegador.Controls.Add(this.btn_actualizar);
            this.gpb_navegador.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gpb_navegador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpb_navegador.Location = new System.Drawing.Point(18, 44);
            this.gpb_navegador.Name = "gpb_navegador";
            this.gpb_navegador.Size = new System.Drawing.Size(333, 100);
            this.gpb_navegador.TabIndex = 197;
            this.gpb_navegador.TabStop = false;
            this.gpb_navegador.Text = "Navegador";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.BackgroundImage")));
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Location = new System.Drawing.Point(17, 21);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo.TabIndex = 1;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ultimo.BackgroundImage")));
            this.btn_ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ultimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ultimo.FlatAppearance.BorderSize = 0;
            this.btn_ultimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ultimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ultimo.Location = new System.Drawing.Point(281, 55);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(33, 33);
            this.btn_ultimo.TabIndex = 7;
            this.btn_ultimo.UseVisualStyleBackColor = true;
            // 
            // btn_primero
            // 
            this.btn_primero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_primero.BackgroundImage")));
            this.btn_primero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_primero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_primero.FlatAppearance.BorderSize = 0;
            this.btn_primero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_primero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_primero.Location = new System.Drawing.Point(245, 55);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(33, 33);
            this.btn_primero.TabIndex = 6;
            this.btn_primero.UseVisualStyleBackColor = true;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_siguiente.BackgroundImage")));
            this.btn_siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_siguiente.FlatAppearance.BorderSize = 0;
            this.btn_siguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_siguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siguiente.Location = new System.Drawing.Point(281, 20);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(33, 33);
            this.btn_siguiente.TabIndex = 5;
            this.btn_siguiente.UseVisualStyleBackColor = true;
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_anterior.BackgroundImage")));
            this.btn_anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_anterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anterior.FlatAppearance.BorderSize = 0;
            this.btn_anterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_anterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.Location = new System.Drawing.Point(245, 20);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(33, 33);
            this.btn_anterior.TabIndex = 4;
            this.btn_anterior.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(88, 21);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.BackgroundImage")));
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Location = new System.Drawing.Point(159, 21);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(65, 65);
            this.btn_actualizar.TabIndex = 3;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // txt_cbo_reporte_empresa
            // 
            this.txt_cbo_reporte_empresa.Location = new System.Drawing.Point(294, 19);
            this.txt_cbo_reporte_empresa.Name = "txt_cbo_reporte_empresa";
            this.txt_cbo_reporte_empresa.Size = new System.Drawing.Size(11, 24);
            this.txt_cbo_reporte_empresa.TabIndex = 196;
            // 
            // dgv_reporte_activo
            // 
            this.dgv_reporte_activo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reporte_activo.Location = new System.Drawing.Point(357, 9);
            this.dgv_reporte_activo.Name = "dgv_reporte_activo";
            this.dgv_reporte_activo.Size = new System.Drawing.Size(601, 135);
            this.dgv_reporte_activo.TabIndex = 198;
            // 
            // frm_reporte_activos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 529);
            this.Controls.Add(this.dgv_reporte_activo);
            this.Controls.Add(this.gpb_navegador);
            this.Controls.Add(this.gpb_reporte_activos);
            this.Controls.Add(this.lbl_form_activos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_reporte_activos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Activos";
            this.gpb_reporte_activos.ResumeLayout(false);
            this.gpb_reporte_activos.PerformLayout();
            this.gpb_navegador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte_activo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label lbl_form_activos;
        private System.Windows.Forms.ComboBox cbo_reporte_empresa;
        private System.Windows.Forms.Label lbl_reporte_activo_empresa;
        private System.Windows.Forms.GroupBox gpb_reporte_activos;
        private System.Windows.Forms.GroupBox gpb_navegador;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.TextBox txt_cbo_reporte_empresa;
        private System.Windows.Forms.DataGridView dgv_reporte_activo;
    }
}