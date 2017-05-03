namespace contrato_trabajo
{
    partial class frm_funcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_funcion));
            this.gpb_funciones = new System.Windows.Forms.GroupBox();
            this.cbo_perfil_reclutamiento_funcion = new System.Windows.Forms.ComboBox();
            this.txt_estado_funcion = new System.Windows.Forms.TextBox();
            this.txt_nombre_funcion = new System.Windows.Forms.TextBox();
            this.lbl_nombre_funcion = new System.Windows.Forms.Label();
            this.txt_descripcion_funcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion_funcion = new System.Windows.Forms.Label();
            this.txt_sueldo_funcion = new System.Windows.Forms.TextBox();
            this.txt_id_perfil_reclutamiento_pk_funcion = new System.Windows.Forms.TextBox();
            this.lbl_id_perfil_reclutamiento_pk_funcion = new System.Windows.Forms.Label();
            this.lbl_sueldo_funcion = new System.Windows.Forms.Label();
            this.lbl_funciones = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_reporte = new System.Windows.Forms.Button();
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
            this.gpb_funciones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_funciones
            // 
            this.gpb_funciones.Controls.Add(this.cbo_perfil_reclutamiento_funcion);
            this.gpb_funciones.Controls.Add(this.txt_estado_funcion);
            this.gpb_funciones.Controls.Add(this.txt_nombre_funcion);
            this.gpb_funciones.Controls.Add(this.lbl_nombre_funcion);
            this.gpb_funciones.Controls.Add(this.txt_descripcion_funcion);
            this.gpb_funciones.Controls.Add(this.lbl_descripcion_funcion);
            this.gpb_funciones.Controls.Add(this.txt_sueldo_funcion);
            this.gpb_funciones.Controls.Add(this.txt_id_perfil_reclutamiento_pk_funcion);
            this.gpb_funciones.Controls.Add(this.lbl_id_perfil_reclutamiento_pk_funcion);
            this.gpb_funciones.Controls.Add(this.lbl_sueldo_funcion);
            this.gpb_funciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_funciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpb_funciones.Location = new System.Drawing.Point(4, 160);
            this.gpb_funciones.Name = "gpb_funciones";
            this.gpb_funciones.Size = new System.Drawing.Size(747, 122);
            this.gpb_funciones.TabIndex = 55;
            this.gpb_funciones.TabStop = false;
            this.gpb_funciones.Text = "Datos generales";
            // 
            // cbo_perfil_reclutamiento_funcion
            // 
            this.cbo_perfil_reclutamiento_funcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_perfil_reclutamiento_funcion.FormattingEnabled = true;
            this.cbo_perfil_reclutamiento_funcion.Location = new System.Drawing.Point(221, 86);
            this.cbo_perfil_reclutamiento_funcion.Name = "cbo_perfil_reclutamiento_funcion";
            this.cbo_perfil_reclutamiento_funcion.Size = new System.Drawing.Size(192, 28);
            this.cbo_perfil_reclutamiento_funcion.TabIndex = 14;
            // 
            // txt_estado_funcion
            // 
            this.txt_estado_funcion.Location = new System.Drawing.Point(6, 88);
            this.txt_estado_funcion.Name = "txt_estado_funcion";
            this.txt_estado_funcion.Size = new System.Drawing.Size(29, 26);
            this.txt_estado_funcion.TabIndex = 19;
            this.txt_estado_funcion.TabStop = false;
            this.txt_estado_funcion.Tag = "estado";
            this.txt_estado_funcion.Text = "ACTIVO";
            this.txt_estado_funcion.Visible = false;
            // 
            // txt_nombre_funcion
            // 
            this.txt_nombre_funcion.Location = new System.Drawing.Point(125, 23);
            this.txt_nombre_funcion.MaxLength = 150;
            this.txt_nombre_funcion.Name = "txt_nombre_funcion";
            this.txt_nombre_funcion.Size = new System.Drawing.Size(288, 26);
            this.txt_nombre_funcion.TabIndex = 12;
            this.txt_nombre_funcion.Tag = "nombre_funcion";
            this.txt_nombre_funcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_funcion_KeyPress);
            // 
            // lbl_nombre_funcion
            // 
            this.lbl_nombre_funcion.AutoSize = true;
            this.lbl_nombre_funcion.Location = new System.Drawing.Point(56, 23);
            this.lbl_nombre_funcion.Name = "lbl_nombre_funcion";
            this.lbl_nombre_funcion.Size = new System.Drawing.Size(72, 20);
            this.lbl_nombre_funcion.TabIndex = 16;
            this.lbl_nombre_funcion.Text = "Nombre:";
            // 
            // txt_descripcion_funcion
            // 
            this.txt_descripcion_funcion.Location = new System.Drawing.Point(529, 23);
            this.txt_descripcion_funcion.MaxLength = 250;
            this.txt_descripcion_funcion.Multiline = true;
            this.txt_descripcion_funcion.Name = "txt_descripcion_funcion";
            this.txt_descripcion_funcion.Size = new System.Drawing.Size(203, 89);
            this.txt_descripcion_funcion.TabIndex = 15;
            this.txt_descripcion_funcion.Tag = "descripcion_funcion";
            this.txt_descripcion_funcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descripcion_funcion_KeyPress);
            // 
            // lbl_descripcion_funcion
            // 
            this.lbl_descripcion_funcion.AutoSize = true;
            this.lbl_descripcion_funcion.Location = new System.Drawing.Point(430, 26);
            this.lbl_descripcion_funcion.Name = "lbl_descripcion_funcion";
            this.lbl_descripcion_funcion.Size = new System.Drawing.Size(100, 20);
            this.lbl_descripcion_funcion.TabIndex = 10;
            this.lbl_descripcion_funcion.Text = "Descripcion:";
            // 
            // txt_sueldo_funcion
            // 
            this.txt_sueldo_funcion.Location = new System.Drawing.Point(125, 53);
            this.txt_sueldo_funcion.MaxLength = 150;
            this.txt_sueldo_funcion.Name = "txt_sueldo_funcion";
            this.txt_sueldo_funcion.Size = new System.Drawing.Size(288, 26);
            this.txt_sueldo_funcion.TabIndex = 13;
            this.txt_sueldo_funcion.Tag = "sueldo_funcion";
            this.txt_sueldo_funcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sueldo_funcion_KeyPress);
            // 
            // txt_id_perfil_reclutamiento_pk_funcion
            // 
            this.txt_id_perfil_reclutamiento_pk_funcion.Location = new System.Drawing.Point(425, 88);
            this.txt_id_perfil_reclutamiento_pk_funcion.MaxLength = 11;
            this.txt_id_perfil_reclutamiento_pk_funcion.Name = "txt_id_perfil_reclutamiento_pk_funcion";
            this.txt_id_perfil_reclutamiento_pk_funcion.Size = new System.Drawing.Size(43, 26);
            this.txt_id_perfil_reclutamiento_pk_funcion.TabIndex = 8;
            this.txt_id_perfil_reclutamiento_pk_funcion.TabStop = false;
            this.txt_id_perfil_reclutamiento_pk_funcion.Tag = "id_perfil_reclutamiento_pk";
            this.txt_id_perfil_reclutamiento_pk_funcion.Visible = false;
            // 
            // lbl_id_perfil_reclutamiento_pk_funcion
            // 
            this.lbl_id_perfil_reclutamiento_pk_funcion.AutoSize = true;
            this.lbl_id_perfil_reclutamiento_pk_funcion.Location = new System.Drawing.Point(41, 87);
            this.lbl_id_perfil_reclutamiento_pk_funcion.Name = "lbl_id_perfil_reclutamiento_pk_funcion";
            this.lbl_id_perfil_reclutamiento_pk_funcion.Size = new System.Drawing.Size(182, 20);
            this.lbl_id_perfil_reclutamiento_pk_funcion.TabIndex = 1;
            this.lbl_id_perfil_reclutamiento_pk_funcion.Text = "Perfil de Reclutamiento:";
            // 
            // lbl_sueldo_funcion
            // 
            this.lbl_sueldo_funcion.AutoSize = true;
            this.lbl_sueldo_funcion.Location = new System.Drawing.Point(64, 54);
            this.lbl_sueldo_funcion.Name = "lbl_sueldo_funcion";
            this.lbl_sueldo_funcion.Size = new System.Drawing.Size(62, 20);
            this.lbl_sueldo_funcion.TabIndex = 0;
            this.lbl_sueldo_funcion.Text = "Sueldo:";
            // 
            // lbl_funciones
            // 
            this.lbl_funciones.AutoSize = true;
            this.lbl_funciones.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_funciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_funciones.Location = new System.Drawing.Point(310, 8);
            this.lbl_funciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_funciones.Name = "lbl_funciones";
            this.lbl_funciones.Size = new System.Drawing.Size(152, 34);
            this.lbl_funciones.TabIndex = 54;
            this.lbl_funciones.Text = "Funciones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_reporte);
            this.groupBox2.Controls.Add(this.btn_nuevo);
            this.groupBox2.Controls.Add(this.btn_ultimo);
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Controls.Add(this.btn_primero);
            this.groupBox2.Controls.Add(this.btn_editar);
            this.groupBox2.Controls.Add(this.btn_siguiente);
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_anterior);
            this.groupBox2.Controls.Add(this.btn_buscar);
            this.groupBox2.Controls.Add(this.btn_actualizar);
            this.groupBox2.Controls.Add(this.btn_cancelar);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(41, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 106);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navegador";
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reporte.FlatAppearance.BorderSize = 0;
            this.btn_reporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_reporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.Image = global::contrato_trabajo.Properties.Resources.imprimir;
            this.btn_reporte.Location = new System.Drawing.Point(604, 10);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(86, 89);
            this.btn_reporte.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btn_reporte, "Reporte");
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
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
            this.btn_nuevo.Location = new System.Drawing.Point(17, 23);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(65, 69);
            this.btn_nuevo.TabIndex = 0;
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
            this.btn_ultimo.Location = new System.Drawing.Point(565, 56);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(33, 36);
            this.btn_ultimo.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btn_ultimo, "Ultimo");
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
            this.btn_guardar.Location = new System.Drawing.Point(88, 20);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 69);
            this.btn_guardar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar");
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
            this.btn_primero.Location = new System.Drawing.Point(529, 56);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(33, 36);
            this.btn_primero.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_primero, "Primero");
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
            this.btn_editar.Location = new System.Drawing.Point(159, 20);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(65, 69);
            this.btn_editar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_editar, "Modificar");
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
            this.btn_siguiente.Location = new System.Drawing.Point(565, 19);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(33, 36);
            this.btn_siguiente.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn_siguiente, "Siguiente");
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
            this.btn_eliminar.Location = new System.Drawing.Point(230, 20);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(65, 69);
            this.btn_eliminar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_eliminar, "Eliminar");
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
            this.btn_anterior.Location = new System.Drawing.Point(529, 19);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(33, 36);
            this.btn_anterior.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_anterior, "Anterior");
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
            this.btn_buscar.Location = new System.Drawing.Point(301, 20);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(65, 69);
            this.btn_buscar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_buscar, "Buscar");
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
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
            this.btn_actualizar.Location = new System.Drawing.Point(443, 20);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(65, 69);
            this.btn_actualizar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_actualizar, "Actualizar");
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
            this.btn_cancelar.Location = new System.Drawing.Point(372, 20);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 69);
            this.btn_cancelar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_cancelar, "Cancelar");
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_funcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 288);
            this.Controls.Add(this.gpb_funciones);
            this.Controls.Add(this.lbl_funciones);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_funcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funciones";
            this.Load += new System.EventHandler(this.frm_funcion_Load);
            this.gpb_funciones.ResumeLayout(false);
            this.gpb_funciones.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_funciones;
        private System.Windows.Forms.TextBox txt_estado_funcion;
        private System.Windows.Forms.TextBox txt_nombre_funcion;
        private System.Windows.Forms.Label lbl_nombre_funcion;
        private System.Windows.Forms.TextBox txt_descripcion_funcion;
        private System.Windows.Forms.Label lbl_descripcion_funcion;
        private System.Windows.Forms.TextBox txt_sueldo_funcion;
        private System.Windows.Forms.TextBox txt_id_perfil_reclutamiento_pk_funcion;
        private System.Windows.Forms.Label lbl_id_perfil_reclutamiento_pk_funcion;
        private System.Windows.Forms.Label lbl_sueldo_funcion;
        private System.Windows.Forms.Label lbl_funciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ComboBox cbo_perfil_reclutamiento_funcion;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}