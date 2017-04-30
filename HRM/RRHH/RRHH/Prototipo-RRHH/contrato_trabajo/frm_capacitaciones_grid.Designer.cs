namespace contrato_trabajo
{
    partial class frm_capacitaciones_grid
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_capacitaciones_grid));
            this.gpb_navegador = new System.Windows.Forms.GroupBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.lbl_form_emp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.btn_emps = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_fechahasta = new System.Windows.Forms.DateTimePicker();
            this.cbo_empres = new System.Windows.Forms.ComboBox();
            this.dtp_fechade = new System.Windows.Forms.DateTimePicker();
            this.dgv_capacitacion = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gpb_navegador.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_capacitacion)).BeginInit();
            this.SuspendLayout();
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
            this.gpb_navegador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_navegador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpb_navegador.Location = new System.Drawing.Point(12, 44);
            this.gpb_navegador.Name = "gpb_navegador";
            this.gpb_navegador.Size = new System.Drawing.Size(333, 100);
            this.gpb_navegador.TabIndex = 182;
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
            this.btn_nuevo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_nuevo, "Para agregar nueva capacitacion");
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
            this.btn_ultimo.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btn_ultimo, "Movimiento hasta el ultmo de la lista");
            this.btn_ultimo.UseVisualStyleBackColor = true;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
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
            this.btn_primero.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_primero, "Movimiento hasta el primer dato en la lista");
            this.btn_primero.UseVisualStyleBackColor = true;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
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
            this.btn_siguiente.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn_siguiente, "Movimiento siguiente en la lista");
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
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
            this.btn_anterior.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_anterior, "Movimiento anterior en la lista");
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
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
            this.btn_buscar.TabIndex = 4;
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
            this.btn_actualizar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_actualizar, "Actualizar la lista de capacitacion");
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // lbl_form_emp
            // 
            this.lbl_form_emp.AutoSize = true;
            this.lbl_form_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form_emp.Location = new System.Drawing.Point(278, 9);
            this.lbl_form_emp.Name = "lbl_form_emp";
            this.lbl_form_emp.Size = new System.Drawing.Size(318, 32);
            this.lbl_form_emp.TabIndex = 183;
            this.lbl_form_emp.Text = "Lista de Capacitaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_filtrar);
            this.groupBox1.Controls.Add(this.btn_emps);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_fechahasta);
            this.groupBox1.Controls.Add(this.cbo_empres);
            this.groupBox1.Controls.Add(this.dtp_fechade);
            this.groupBox1.Controls.Add(this.dgv_capacitacion);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 149);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(851, 395);
            this.groupBox1.TabIndex = 184;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capacitaciones";
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(56, 225);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(82, 26);
            this.btn_filtrar.TabIndex = 205;
            this.btn_filtrar.Text = "Filtrar";
            this.toolTip1.SetToolTip(this.btn_filtrar, "Para filtrar con los datos puesto");
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_emps
            // 
            this.btn_emps.BackgroundImage = global::contrato_trabajo.Properties.Resources.Button_Reload_icon;
            this.btn_emps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_emps.Location = new System.Drawing.Point(148, 59);
            this.btn_emps.Name = "btn_emps";
            this.btn_emps.Size = new System.Drawing.Size(30, 28);
            this.btn_emps.TabIndex = 204;
            this.toolTip1.SetToolTip(this.btn_emps, "Actualiar con la empresa la lista de capacitaciones");
            this.btn_emps.UseVisualStyleBackColor = true;
            this.btn_emps.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 203;
            this.label5.Text = "HASTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 19);
            this.label4.TabIndex = 202;
            this.label4.Text = "DE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 188;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 187;
            this.label1.Text = "Empresa";
            // 
            // dtp_fechahasta
            // 
            this.dtp_fechahasta.Location = new System.Drawing.Point(1, 199);
            this.dtp_fechahasta.Name = "dtp_fechahasta";
            this.dtp_fechahasta.Size = new System.Drawing.Size(190, 24);
            this.dtp_fechahasta.TabIndex = 34;
            this.toolTip1.SetToolTip(this.dtp_fechahasta, "Segunda fecha para el rango");
            // 
            // cbo_empres
            // 
            this.cbo_empres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empres.FormattingEnabled = true;
            this.cbo_empres.Location = new System.Drawing.Point(5, 59);
            this.cbo_empres.Name = "cbo_empres";
            this.cbo_empres.Size = new System.Drawing.Size(137, 25);
            this.cbo_empres.TabIndex = 33;
            this.toolTip1.SetToolTip(this.cbo_empres, "Elegir la empresa para capacitar");
            // 
            // dtp_fechade
            // 
            this.dtp_fechade.Location = new System.Drawing.Point(5, 142);
            this.dtp_fechade.Name = "dtp_fechade";
            this.dtp_fechade.Size = new System.Drawing.Size(190, 24);
            this.dtp_fechade.TabIndex = 32;
            this.toolTip1.SetToolTip(this.dtp_fechade, "Primera fecha para el rango");
            // 
            // dgv_capacitacion
            // 
            this.dgv_capacitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_capacitacion.Location = new System.Drawing.Point(201, 17);
            this.dgv_capacitacion.Name = "dgv_capacitacion";
            this.dgv_capacitacion.Size = new System.Drawing.Size(634, 359);
            this.dgv_capacitacion.TabIndex = 31;
            this.toolTip1.SetToolTip(this.dgv_capacitacion, "Lista de capacitaciones");
            this.dgv_capacitacion.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // frm_capacitaciones_grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_form_emp);
            this.Controls.Add(this.gpb_navegador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_capacitaciones_grid";
            this.Text = "Capacitaciones";
            this.Load += new System.EventHandler(this.frm_capacitaciones_grid_Load);
            this.gpb_navegador.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_capacitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_navegador;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Label lbl_form_emp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_capacitacion;
        private System.Windows.Forms.DateTimePicker dtp_fechahasta;
        private System.Windows.Forms.ComboBox cbo_empres;
        private System.Windows.Forms.DateTimePicker dtp_fechade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.Button btn_emps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}