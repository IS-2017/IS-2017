namespace contrato_trabajo
{
    partial class frm_jornada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_jornada));
            this.gpb_jornadas = new System.Windows.Forms.GroupBox();
            this.cbo_tipo_jornada = new System.Windows.Forms.ComboBox();
            this.txt_nmup_hora_diario = new System.Windows.Forms.TextBox();
            this.nmup_hora_diario = new System.Windows.Forms.NumericUpDown();
            this.lbl_hora_diario = new System.Windows.Forms.Label();
            this.txt_nmup_dias_trabajo = new System.Windows.Forms.TextBox();
            this.nmup_dias_trabajo = new System.Windows.Forms.NumericUpDown();
            this.lbl_dias_trabajo = new System.Windows.Forms.Label();
            this.txt_cbo_forma_cobro = new System.Windows.Forms.TextBox();
            this.cbo_forma_cobro = new System.Windows.Forms.ComboBox();
            this.lbl_forma_cobro = new System.Windows.Forms.Label();
            this.txt_nmup_horas_trabajo = new System.Windows.Forms.TextBox();
            this.nmup_horas_trabajo = new System.Windows.Forms.NumericUpDown();
            this.txt_cbo_tipo_jornada = new System.Windows.Forms.TextBox();
            this.lbl_cantidad_activo = new System.Windows.Forms.Label();
            this.lbl_nombre_jornada = new System.Windows.Forms.Label();
            this.lbl_form_emp = new System.Windows.Forms.Label();
            this.gpb_navegador = new System.Windows.Forms.GroupBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip9 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip10 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip11 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip12 = new System.Windows.Forms.ToolTip(this.components);
            this.gpb_jornadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmup_hora_diario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmup_dias_trabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmup_horas_trabajo)).BeginInit();
            this.gpb_navegador.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_jornadas
            // 
            this.gpb_jornadas.Controls.Add(this.cbo_tipo_jornada);
            this.gpb_jornadas.Controls.Add(this.txt_nmup_hora_diario);
            this.gpb_jornadas.Controls.Add(this.nmup_hora_diario);
            this.gpb_jornadas.Controls.Add(this.lbl_hora_diario);
            this.gpb_jornadas.Controls.Add(this.txt_nmup_dias_trabajo);
            this.gpb_jornadas.Controls.Add(this.nmup_dias_trabajo);
            this.gpb_jornadas.Controls.Add(this.lbl_dias_trabajo);
            this.gpb_jornadas.Controls.Add(this.txt_cbo_forma_cobro);
            this.gpb_jornadas.Controls.Add(this.cbo_forma_cobro);
            this.gpb_jornadas.Controls.Add(this.lbl_forma_cobro);
            this.gpb_jornadas.Controls.Add(this.txt_nmup_horas_trabajo);
            this.gpb_jornadas.Controls.Add(this.nmup_horas_trabajo);
            this.gpb_jornadas.Controls.Add(this.txt_cbo_tipo_jornada);
            this.gpb_jornadas.Controls.Add(this.lbl_cantidad_activo);
            this.gpb_jornadas.Controls.Add(this.lbl_nombre_jornada);
            this.gpb_jornadas.Location = new System.Drawing.Point(12, 150);
            this.gpb_jornadas.Name = "gpb_jornadas";
            this.gpb_jornadas.Size = new System.Drawing.Size(709, 163);
            this.gpb_jornadas.TabIndex = 174;
            this.gpb_jornadas.TabStop = false;
            this.gpb_jornadas.Text = "Datos";
            // 
            // cbo_tipo_jornada
            // 
            this.cbo_tipo_jornada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_jornada.FormattingEnabled = true;
            this.cbo_tipo_jornada.Items.AddRange(new object[] {
            "matutina",
            "vespertina",
            "mixta"});
            this.cbo_tipo_jornada.Location = new System.Drawing.Point(164, 40);
            this.cbo_tipo_jornada.Name = "cbo_tipo_jornada";
            this.cbo_tipo_jornada.Size = new System.Drawing.Size(180, 21);
            this.cbo_tipo_jornada.TabIndex = 2;
            this.cbo_tipo_jornada.SelectedValueChanged += new System.EventHandler(this.cbo_tipo_jornada_SelectedValueChanged);
            // 
            // txt_nmup_hora_diario
            // 
            this.txt_nmup_hora_diario.Location = new System.Drawing.Point(290, 123);
            this.txt_nmup_hora_diario.Name = "txt_nmup_hora_diario";
            this.txt_nmup_hora_diario.Size = new System.Drawing.Size(76, 20);
            this.txt_nmup_hora_diario.TabIndex = 15;
            this.txt_nmup_hora_diario.Tag = "jhora_diario";
            this.txt_nmup_hora_diario.Text = " ";
            // 
            // nmup_hora_diario
            // 
            this.nmup_hora_diario.Enabled = false;
            this.nmup_hora_diario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmup_hora_diario.Location = new System.Drawing.Point(164, 123);
            this.nmup_hora_diario.Name = "nmup_hora_diario";
            this.nmup_hora_diario.Size = new System.Drawing.Size(120, 23);
            this.nmup_hora_diario.TabIndex = 5;
            this.nmup_hora_diario.ValueChanged += new System.EventHandler(this.nmup_hora_diario_ValueChanged);
            // 
            // lbl_hora_diario
            // 
            this.lbl_hora_diario.AutoSize = true;
            this.lbl_hora_diario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora_diario.Location = new System.Drawing.Point(6, 125);
            this.lbl_hora_diario.Name = "lbl_hora_diario";
            this.lbl_hora_diario.Size = new System.Drawing.Size(99, 17);
            this.lbl_hora_diario.TabIndex = 13;
            this.lbl_hora_diario.Text = "Horas Trabajo";
            // 
            // txt_nmup_dias_trabajo
            // 
            this.txt_nmup_dias_trabajo.Location = new System.Drawing.Point(290, 94);
            this.txt_nmup_dias_trabajo.Name = "txt_nmup_dias_trabajo";
            this.txt_nmup_dias_trabajo.Size = new System.Drawing.Size(76, 20);
            this.txt_nmup_dias_trabajo.TabIndex = 12;
            this.txt_nmup_dias_trabajo.Tag = "jdiaria_dias";
            this.txt_nmup_dias_trabajo.Text = " ";
            // 
            // nmup_dias_trabajo
            // 
            this.nmup_dias_trabajo.Enabled = false;
            this.nmup_dias_trabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmup_dias_trabajo.Location = new System.Drawing.Point(164, 94);
            this.nmup_dias_trabajo.Name = "nmup_dias_trabajo";
            this.nmup_dias_trabajo.Size = new System.Drawing.Size(120, 23);
            this.nmup_dias_trabajo.TabIndex = 4;
            this.nmup_dias_trabajo.ValueChanged += new System.EventHandler(this.nmup_dias_trabajo_ValueChanged);
            // 
            // lbl_dias_trabajo
            // 
            this.lbl_dias_trabajo.AutoSize = true;
            this.lbl_dias_trabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dias_trabajo.Location = new System.Drawing.Point(6, 96);
            this.lbl_dias_trabajo.Name = "lbl_dias_trabajo";
            this.lbl_dias_trabajo.Size = new System.Drawing.Size(93, 17);
            this.lbl_dias_trabajo.TabIndex = 10;
            this.lbl_dias_trabajo.Text = "Días Trabajo:";
            // 
            // txt_cbo_forma_cobro
            // 
            this.txt_cbo_forma_cobro.Location = new System.Drawing.Point(350, 13);
            this.txt_cbo_forma_cobro.Name = "txt_cbo_forma_cobro";
            this.txt_cbo_forma_cobro.Size = new System.Drawing.Size(102, 20);
            this.txt_cbo_forma_cobro.TabIndex = 9;
            this.txt_cbo_forma_cobro.Tag = "forma_cobro";
            // 
            // cbo_forma_cobro
            // 
            this.cbo_forma_cobro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_forma_cobro.FormattingEnabled = true;
            this.cbo_forma_cobro.Items.AddRange(new object[] {
            "MENSUAL",
            "QUINCENAL",
            "DIARIO",
            "HORA"});
            this.cbo_forma_cobro.Location = new System.Drawing.Point(164, 13);
            this.cbo_forma_cobro.Name = "cbo_forma_cobro";
            this.cbo_forma_cobro.Size = new System.Drawing.Size(180, 21);
            this.cbo_forma_cobro.TabIndex = 1;
            this.cbo_forma_cobro.SelectedIndexChanged += new System.EventHandler(this.cbo_forma_cobro_SelectedIndexChanged);
            // 
            // lbl_forma_cobro
            // 
            this.lbl_forma_cobro.AutoSize = true;
            this.lbl_forma_cobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forma_cobro.Location = new System.Drawing.Point(6, 16);
            this.lbl_forma_cobro.Name = "lbl_forma_cobro";
            this.lbl_forma_cobro.Size = new System.Drawing.Size(119, 17);
            this.lbl_forma_cobro.TabIndex = 7;
            this.lbl_forma_cobro.Text = "Forma de Cobrar:";
            // 
            // txt_nmup_horas_trabajo
            // 
            this.txt_nmup_horas_trabajo.Location = new System.Drawing.Point(290, 65);
            this.txt_nmup_horas_trabajo.Name = "txt_nmup_horas_trabajo";
            this.txt_nmup_horas_trabajo.Size = new System.Drawing.Size(76, 20);
            this.txt_nmup_horas_trabajo.TabIndex = 6;
            this.txt_nmup_horas_trabajo.Tag = "horas_trabajo";
            this.txt_nmup_horas_trabajo.Text = " ";
            // 
            // nmup_horas_trabajo
            // 
            this.nmup_horas_trabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmup_horas_trabajo.Location = new System.Drawing.Point(164, 65);
            this.nmup_horas_trabajo.Name = "nmup_horas_trabajo";
            this.nmup_horas_trabajo.Size = new System.Drawing.Size(120, 23);
            this.nmup_horas_trabajo.TabIndex = 3;
            this.nmup_horas_trabajo.ValueChanged += new System.EventHandler(this.nmup_horas_trabajo_ValueChanged);
            // 
            // txt_cbo_tipo_jornada
            // 
            this.txt_cbo_tipo_jornada.Location = new System.Drawing.Point(350, 39);
            this.txt_cbo_tipo_jornada.Name = "txt_cbo_tipo_jornada";
            this.txt_cbo_tipo_jornada.Size = new System.Drawing.Size(102, 20);
            this.txt_cbo_tipo_jornada.TabIndex = 3;
            this.txt_cbo_tipo_jornada.Tag = "nombre_jornada";
            // 
            // lbl_cantidad_activo
            // 
            this.lbl_cantidad_activo.AutoSize = true;
            this.lbl_cantidad_activo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad_activo.Location = new System.Drawing.Point(6, 67);
            this.lbl_cantidad_activo.Name = "lbl_cantidad_activo";
            this.lbl_cantidad_activo.Size = new System.Drawing.Size(123, 17);
            this.lbl_cantidad_activo.TabIndex = 1;
            this.lbl_cantidad_activo.Text = "Horas de Trabajo:";
            // 
            // lbl_nombre_jornada
            // 
            this.lbl_nombre_jornada.AutoSize = true;
            this.lbl_nombre_jornada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_jornada.Location = new System.Drawing.Point(6, 39);
            this.lbl_nombre_jornada.Name = "lbl_nombre_jornada";
            this.lbl_nombre_jornada.Size = new System.Drawing.Size(116, 17);
            this.lbl_nombre_jornada.TabIndex = 0;
            this.lbl_nombre_jornada.Text = "Tipo de Jornada:";
            // 
            // lbl_form_emp
            // 
            this.lbl_form_emp.AutoSize = true;
            this.lbl_form_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form_emp.Location = new System.Drawing.Point(191, 8);
            this.lbl_form_emp.Name = "lbl_form_emp";
            this.lbl_form_emp.Size = new System.Drawing.Size(300, 32);
            this.lbl_form_emp.TabIndex = 173;
            this.lbl_form_emp.Text = "Formulario de Jornada";
            // 
            // gpb_navegador
            // 
            this.gpb_navegador.Controls.Add(this.txt_estado);
            this.gpb_navegador.Controls.Add(this.button1);
            this.gpb_navegador.Controls.Add(this.btn_nuevo);
            this.gpb_navegador.Controls.Add(this.btn_ultimo);
            this.gpb_navegador.Controls.Add(this.btn_guardar);
            this.gpb_navegador.Controls.Add(this.btn_primero);
            this.gpb_navegador.Controls.Add(this.btn_editar);
            this.gpb_navegador.Controls.Add(this.btn_siguiente);
            this.gpb_navegador.Controls.Add(this.btn_eliminar);
            this.gpb_navegador.Controls.Add(this.btn_anterior);
            this.gpb_navegador.Controls.Add(this.btn_buscar);
            this.gpb_navegador.Controls.Add(this.btn_actualizar);
            this.gpb_navegador.Controls.Add(this.btn_cancelar);
            this.gpb_navegador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_navegador.Location = new System.Drawing.Point(12, 43);
            this.gpb_navegador.Name = "gpb_navegador";
            this.gpb_navegador.Size = new System.Drawing.Size(680, 100);
            this.gpb_navegador.TabIndex = 172;
            this.gpb_navegador.TabStop = false;
            this.gpb_navegador.Text = "Navegador";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(660, 23);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(20, 24);
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
            this.button1.Location = new System.Drawing.Point(514, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 171;
            this.toolTip5.SetToolTip(this.button1, "Imprimir");
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
            this.btn_nuevo.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_nuevo, "Nuevo");
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
            this.btn_ultimo.Location = new System.Drawing.Point(621, 53);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(33, 33);
            this.btn_ultimo.TabIndex = 10;
            this.toolTip9.SetToolTip(this.btn_ultimo, "Ultimo");
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
            this.btn_guardar.Location = new System.Drawing.Point(88, 19);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar.TabIndex = 7;
            this.toolTip10.SetToolTip(this.btn_guardar, "Guardar");
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
            this.btn_primero.Location = new System.Drawing.Point(585, 53);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(33, 33);
            this.btn_primero.TabIndex = 9;
            this.toolTip8.SetToolTip(this.btn_primero, "Primero");
            this.btn_primero.UseVisualStyleBackColor = true;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.BackgroundImage")));
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Location = new System.Drawing.Point(159, 19);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(65, 65);
            this.btn_editar.TabIndex = 8;
            this.toolTip11.SetToolTip(this.btn_editar, "Modificar");
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
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
            this.btn_siguiente.Location = new System.Drawing.Point(621, 18);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(33, 33);
            this.btn_siguiente.TabIndex = 8;
            this.toolTip7.SetToolTip(this.btn_siguiente, "Siguiente");
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
            this.btn_eliminar.Location = new System.Drawing.Point(230, 19);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(65, 65);
            this.btn_eliminar.TabIndex = 9;
            this.toolTip12.SetToolTip(this.btn_eliminar, "Eliminar");
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
            this.btn_anterior.Location = new System.Drawing.Point(585, 18);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(33, 33);
            this.btn_anterior.TabIndex = 7;
            this.toolTip6.SetToolTip(this.btn_anterior, "Anterior");
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.Enabled = false;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(301, 19);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar.TabIndex = 4;
            this.toolTip2.SetToolTip(this.btn_buscar, "Buscar");
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
            this.btn_actualizar.Location = new System.Drawing.Point(443, 19);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(65, 65);
            this.btn_actualizar.TabIndex = 6;
            this.toolTip4.SetToolTip(this.btn_actualizar, "Actualizar");
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(372, 19);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 65);
            this.btn_cancelar.TabIndex = 10;
            this.toolTip3.SetToolTip(this.btn_cancelar, "Cancelar");
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_jornada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(733, 323);
            this.Controls.Add(this.gpb_jornadas);
            this.Controls.Add(this.lbl_form_emp);
            this.Controls.Add(this.gpb_navegador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_jornada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jornada";
            this.Load += new System.EventHandler(this.frm_jornada_Load);
            this.gpb_jornadas.ResumeLayout(false);
            this.gpb_jornadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmup_hora_diario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmup_dias_trabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmup_horas_trabajo)).EndInit();
            this.gpb_navegador.ResumeLayout(false);
            this.gpb_navegador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_jornadas;
        private System.Windows.Forms.TextBox txt_nmup_horas_trabajo;
        private System.Windows.Forms.NumericUpDown nmup_horas_trabajo;
        private System.Windows.Forms.TextBox txt_cbo_tipo_jornada;
        private System.Windows.Forms.Label lbl_cantidad_activo;
        private System.Windows.Forms.Label lbl_nombre_jornada;
        private System.Windows.Forms.Label lbl_form_emp;
        private System.Windows.Forms.GroupBox gpb_navegador;
        private System.Windows.Forms.TextBox txt_estado;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_buscar;
        public System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_cbo_forma_cobro;
        private System.Windows.Forms.ComboBox cbo_forma_cobro;
        private System.Windows.Forms.Label lbl_forma_cobro;
        private System.Windows.Forms.TextBox txt_nmup_hora_diario;
        private System.Windows.Forms.NumericUpDown nmup_hora_diario;
        private System.Windows.Forms.Label lbl_hora_diario;
        private System.Windows.Forms.TextBox txt_nmup_dias_trabajo;
        private System.Windows.Forms.NumericUpDown nmup_dias_trabajo;
        private System.Windows.Forms.Label lbl_dias_trabajo;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip9;
        private System.Windows.Forms.ToolTip toolTip10;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip11;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip12;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ComboBox cbo_tipo_jornada;
    }
}