namespace contrato_trabajo
{
    partial class frm_vacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_vacaciones));
            this.datag_vaca = new System.Windows.Forms.DataGridView();
            this.txt_sal_mensual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_vacaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fecha_salida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cod_empleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gpb_navegador = new System.Windows.Forms.GroupBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.gpb_vacaciones = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_nom_empleado_vac = new System.Windows.Forms.ComboBox();
            this.Empresa = new System.Windows.Forms.Label();
            this.cbx_empresa_vac = new System.Windows.Forms.ComboBox();
            this.txt_dias = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_vacaciones = new System.Windows.Forms.Label();
            this.data_mostrar_calculo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datag_vaca)).BeginInit();
            this.gpb_navegador.SuspendLayout();
            this.gpb_vacaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_mostrar_calculo)).BeginInit();
            this.SuspendLayout();
            // 
            // datag_vaca
            // 
            this.datag_vaca.AllowUserToAddRows = false;
            this.datag_vaca.AllowUserToDeleteRows = false;
            this.datag_vaca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.datag_vaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datag_vaca.Location = new System.Drawing.Point(12, 373);
            this.datag_vaca.Name = "datag_vaca";
            this.datag_vaca.ReadOnly = true;
            this.datag_vaca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datag_vaca.Size = new System.Drawing.Size(566, 155);
            this.datag_vaca.TabIndex = 205;
            this.datag_vaca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datag_indem_CellContentClick);
            this.datag_vaca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datag_indem_CellDoubleClick);
            // 
            // txt_sal_mensual
            // 
            this.txt_sal_mensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sal_mensual.Location = new System.Drawing.Point(101, 84);
            this.txt_sal_mensual.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sal_mensual.Name = "txt_sal_mensual";
            this.txt_sal_mensual.ReadOnly = true;
            this.txt_sal_mensual.Size = new System.Drawing.Size(123, 21);
            this.txt_sal_mensual.TabIndex = 204;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 203;
            this.label4.Text = "Sal. Mensual";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(552, 156);
            this.btn_calcular.Margin = new System.Windows.Forms.Padding(2);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(144, 26);
            this.btn_calcular.TabIndex = 200;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_vacaciones
            // 
            this.txt_vacaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vacaciones.Location = new System.Drawing.Point(101, 119);
            this.txt_vacaciones.Margin = new System.Windows.Forms.Padding(2);
            this.txt_vacaciones.Name = "txt_vacaciones";
            this.txt_vacaciones.ReadOnly = true;
            this.txt_vacaciones.Size = new System.Drawing.Size(123, 21);
            this.txt_vacaciones.TabIndex = 199;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 198;
            this.label2.Text = "Cant. a Devengar";
            // 
            // dtp_fecha_salida
            // 
            this.dtp_fecha_salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_salida.Location = new System.Drawing.Point(450, 79);
            this.dtp_fecha_salida.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_fecha_salida.Name = "dtp_fecha_salida";
            this.dtp_fecha_salida.Size = new System.Drawing.Size(246, 21);
            this.dtp_fecha_salida.TabIndex = 197;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 196;
            this.label1.Text = "Fecha Salida";
            // 
            // txt_cod_empleado
            // 
            this.txt_cod_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_empleado.Location = new System.Drawing.Point(101, 54);
            this.txt_cod_empleado.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cod_empleado.Name = "txt_cod_empleado";
            this.txt_cod_empleado.ReadOnly = true;
            this.txt_cod_empleado.Size = new System.Drawing.Size(123, 21);
            this.txt_cod_empleado.TabIndex = 195;
            this.txt_cod_empleado.TextChanged += new System.EventHandler(this.txt_cod_empleado_TextChanged);
            this.txt_cod_empleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cod_empleado_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 194;
            this.label7.Text = "Cod. Empleado:";
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(450, 52);
            this.dtp_fecha_inicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(246, 21);
            this.dtp_fecha_inicio.TabIndex = 193;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 192;
            this.label6.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, -48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 25);
            this.label3.TabIndex = 191;
            this.label3.Text = "Cálculo de Indemnización";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(233, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 34);
            this.label5.TabIndex = 206;
            this.label5.Text = "Cálculo de Vacaciones";
            // 
            // gpb_navegador
            // 
            this.gpb_navegador.Controls.Add(this.txt_estado);
            this.gpb_navegador.Controls.Add(this.button1);
            this.gpb_navegador.Controls.Add(this.btn_nuevo);
            this.gpb_navegador.Controls.Add(this.btn_ultimo);
            this.gpb_navegador.Controls.Add(this.btn_guardar);
            this.gpb_navegador.Controls.Add(this.btn_primero);
            this.gpb_navegador.Controls.Add(this.btn_siguiente);
            this.gpb_navegador.Controls.Add(this.btn_eliminar);
            this.gpb_navegador.Controls.Add(this.btn_anterior);
            this.gpb_navegador.Controls.Add(this.btn_buscar);
            this.gpb_navegador.Controls.Add(this.btn_actualizar);
            this.gpb_navegador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_navegador.Location = new System.Drawing.Point(66, 74);
            this.gpb_navegador.Name = "gpb_navegador";
            this.gpb_navegador.Size = new System.Drawing.Size(680, 100);
            this.gpb_navegador.TabIndex = 207;
            this.gpb_navegador.TabStop = false;
            this.gpb_navegador.Text = "Navegador";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(660, 23);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(10, 24);
            this.txt_estado.TabIndex = 7;
            this.txt_estado.Tag = "estado";
            this.txt_estado.Text = "ACTIVO";
            this.txt_estado.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(426, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 171;
            this.button1.UseVisualStyleBackColor = true;
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
            this.btn_ultimo.Location = new System.Drawing.Point(546, 53);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(33, 33);
            this.btn_ultimo.TabIndex = 10;
            this.btn_ultimo.UseVisualStyleBackColor = true;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.BackgroundImage")));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(88, 18);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
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
            this.btn_primero.Location = new System.Drawing.Point(510, 53);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(33, 33);
            this.btn_primero.TabIndex = 9;
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
            this.btn_siguiente.Location = new System.Drawing.Point(546, 18);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(33, 33);
            this.btn_siguiente.TabIndex = 8;
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Location = new System.Drawing.Point(173, 21);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(65, 65);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
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
            this.btn_anterior.Location = new System.Drawing.Point(510, 18);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(33, 33);
            this.btn_anterior.TabIndex = 7;
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
            this.btn_buscar.Location = new System.Drawing.Point(252, 18);
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
            this.btn_actualizar.Location = new System.Drawing.Point(336, 18);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(65, 65);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // gpb_vacaciones
            // 
            this.gpb_vacaciones.Controls.Add(this.label9);
            this.gpb_vacaciones.Controls.Add(this.cbx_nom_empleado_vac);
            this.gpb_vacaciones.Controls.Add(this.Empresa);
            this.gpb_vacaciones.Controls.Add(this.cbx_empresa_vac);
            this.gpb_vacaciones.Controls.Add(this.txt_dias);
            this.gpb_vacaciones.Controls.Add(this.label8);
            this.gpb_vacaciones.Controls.Add(this.lbl_vacaciones);
            this.gpb_vacaciones.Controls.Add(this.txt_sal_mensual);
            this.gpb_vacaciones.Controls.Add(this.label4);
            this.gpb_vacaciones.Controls.Add(this.txt_vacaciones);
            this.gpb_vacaciones.Controls.Add(this.label2);
            this.gpb_vacaciones.Controls.Add(this.btn_calcular);
            this.gpb_vacaciones.Controls.Add(this.dtp_fecha_salida);
            this.gpb_vacaciones.Controls.Add(this.label1);
            this.gpb_vacaciones.Controls.Add(this.txt_cod_empleado);
            this.gpb_vacaciones.Controls.Add(this.label7);
            this.gpb_vacaciones.Controls.Add(this.dtp_fecha_inicio);
            this.gpb_vacaciones.Controls.Add(this.label6);
            this.gpb_vacaciones.Enabled = false;
            this.gpb_vacaciones.Location = new System.Drawing.Point(120, 180);
            this.gpb_vacaciones.Name = "gpb_vacaciones";
            this.gpb_vacaciones.Size = new System.Drawing.Size(716, 187);
            this.gpb_vacaciones.TabIndex = 208;
            this.gpb_vacaciones.TabStop = false;
            this.gpb_vacaciones.Text = "Vacaciones";
            this.gpb_vacaciones.Enter += new System.EventHandler(this.gpb_indemnizar_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 216;
            this.label9.Text = "Nombre Empleado";
            // 
            // cbx_nom_empleado_vac
            // 
            this.cbx_nom_empleado_vac.FormattingEnabled = true;
            this.cbx_nom_empleado_vac.Location = new System.Drawing.Point(475, 19);
            this.cbx_nom_empleado_vac.Name = "cbx_nom_empleado_vac";
            this.cbx_nom_empleado_vac.Size = new System.Drawing.Size(121, 21);
            this.cbx_nom_empleado_vac.TabIndex = 215;
            this.cbx_nom_empleado_vac.SelectedIndexChanged += new System.EventHandler(this.cbx_nom_empleado_SelectedIndexChanged);
            this.cbx_nom_empleado_vac.SelectedValueChanged += new System.EventHandler(this.cbx_nom_empleado_SelectedIndexChanged);
            // 
            // Empresa
            // 
            this.Empresa.AutoSize = true;
            this.Empresa.Location = new System.Drawing.Point(6, 27);
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(48, 13);
            this.Empresa.TabIndex = 214;
            this.Empresa.Text = "Empresa";
            // 
            // cbx_empresa_vac
            // 
            this.cbx_empresa_vac.FormattingEnabled = true;
            this.cbx_empresa_vac.Location = new System.Drawing.Point(101, 24);
            this.cbx_empresa_vac.Name = "cbx_empresa_vac";
            this.cbx_empresa_vac.Size = new System.Drawing.Size(121, 21);
            this.cbx_empresa_vac.TabIndex = 213;
            this.cbx_empresa_vac.SelectedIndexChanged += new System.EventHandler(this.cbx_empresa_vac_SelectedIndexChanged);
            // 
            // txt_dias
            // 
            this.txt_dias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dias.Location = new System.Drawing.Point(101, 151);
            this.txt_dias.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dias.Name = "txt_dias";
            this.txt_dias.Size = new System.Drawing.Size(123, 21);
            this.txt_dias.TabIndex = 207;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 206;
            this.label8.Text = "Dias a Pagar";
            // 
            // lbl_vacaciones
            // 
            this.lbl_vacaciones.AutoSize = true;
            this.lbl_vacaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vacaciones.Location = new System.Drawing.Point(304, 117);
            this.lbl_vacaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_vacaciones.Name = "lbl_vacaciones";
            this.lbl_vacaciones.Size = new System.Drawing.Size(92, 20);
            this.lbl_vacaciones.TabIndex = 205;
            this.lbl_vacaciones.Text = "Vacaciones";
            // 
            // data_mostrar_calculo
            // 
            this.data_mostrar_calculo.AllowUserToAddRows = false;
            this.data_mostrar_calculo.AllowUserToDeleteRows = false;
            this.data_mostrar_calculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.data_mostrar_calculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_mostrar_calculo.Location = new System.Drawing.Point(595, 373);
            this.data_mostrar_calculo.Name = "data_mostrar_calculo";
            this.data_mostrar_calculo.ReadOnly = true;
            this.data_mostrar_calculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_mostrar_calculo.Size = new System.Drawing.Size(359, 155);
            this.data_mostrar_calculo.TabIndex = 209;
            // 
            // frm_vacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(969, 536);
            this.Controls.Add(this.data_mostrar_calculo);
            this.Controls.Add(this.gpb_vacaciones);
            this.Controls.Add(this.gpb_navegador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datag_vaca);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_vacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_vacaciones";
            this.Load += new System.EventHandler(this.frm_vacaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datag_vaca)).EndInit();
            this.gpb_navegador.ResumeLayout(false);
            this.gpb_navegador.PerformLayout();
            this.gpb_vacaciones.ResumeLayout(false);
            this.gpb_vacaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_mostrar_calculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datag_vaca;
        private System.Windows.Forms.TextBox txt_sal_mensual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_vacaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fecha_salida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cod_empleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpb_navegador;
        private System.Windows.Forms.TextBox txt_estado;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_buscar;
        public System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.GroupBox gpb_vacaciones;
        private System.Windows.Forms.Label lbl_vacaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_dias;
        private System.Windows.Forms.DataGridView data_mostrar_calculo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx_nom_empleado_vac;
        private System.Windows.Forms.Label Empresa;
        private System.Windows.Forms.ComboBox cbx_empresa_vac;
    }
}