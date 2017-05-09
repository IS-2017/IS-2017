namespace crm
{
    partial class frm_NuevoCaso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NuevoCaso));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbo_perem = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.cmb_responsable = new System.Windows.Forms.ComboBox();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.cmb_ente = new System.Windows.Forms.ComboBox();
            this.btn_actualizar_emp = new DevExpress.XtraEditors.SimpleButton();
            this.btn_actualizar_ente = new DevExpress.XtraEditors.SimpleButton();
            this.dtp_fecha_cierre = new DevExpress.XtraEditors.DateEdit();
            this.btn_nuevo_ente = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_nuevo_emp = new DevExpress.XtraEditors.SimpleButton();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_actualizar_cat = new DevExpress.XtraEditors.SimpleButton();
            this.txt_descripcion = new System.Windows.Forms.RichTextBox();
            this.btn_nueva_categoria = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fecha_cierre.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fecha_cierre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.cbo_perem);
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Controls.Add(this.cmb_responsable);
            this.groupControl1.Controls.Add(this.cmb_categoria);
            this.groupControl1.Controls.Add(this.cmb_ente);
            this.groupControl1.Controls.Add(this.btn_actualizar_emp);
            this.groupControl1.Controls.Add(this.btn_actualizar_ente);
            this.groupControl1.Controls.Add(this.dtp_fecha_cierre);
            this.groupControl1.Controls.Add(this.btn_nuevo_ente);
            this.groupControl1.Controls.Add(this.lbl_titulo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btn_nuevo_emp);
            this.groupControl1.Controls.Add(this.txt_titulo);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.btn_actualizar_cat);
            this.groupControl1.Controls.Add(this.txt_descripcion);
            this.groupControl1.Controls.Add(this.btn_nueva_categoria);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1021, 649);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "Datos del Caso:";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // cbo_perem
            // 
            this.cbo_perem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_perem.FormattingEnabled = true;
            this.cbo_perem.Location = new System.Drawing.Point(296, 212);
            this.cbo_perem.Name = "cbo_perem";
            this.cbo_perem.Size = new System.Drawing.Size(267, 21);
            this.cbo_perem.TabIndex = 188;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_reporte);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_ultimo);
            this.panel1.Controls.Add(this.btn_actualizar);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.btn_primero);
            this.panel1.Controls.Add(this.btn_anterior);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_siguiente);
            this.panel1.Location = new System.Drawing.Point(105, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 77);
            this.panel1.TabIndex = 184;
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackgroundImage = global::crm.Properties.Resources.imprimir1;
            this.btn_reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reporte.FlatAppearance.BorderSize = 0;
            this.btn_reporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_reporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.Location = new System.Drawing.Point(541, 4);
            this.btn_reporte.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(56, 59);
            this.btn_reporte.TabIndex = 182;
            this.btn_reporte.UseVisualStyleBackColor = true;
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
            this.btn_nuevo.Location = new System.Drawing.Point(29, 4);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(58, 59);
            this.btn_nuevo.TabIndex = 171;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
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
            this.btn_cancelar.Location = new System.Drawing.Point(334, 4);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(56, 59);
            this.btn_cancelar.TabIndex = 176;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            this.btn_ultimo.Location = new System.Drawing.Point(503, 37);
            this.btn_ultimo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(30, 26);
            this.btn_ultimo.TabIndex = 181;
            this.btn_ultimo.UseVisualStyleBackColor = true;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
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
            this.btn_actualizar.Location = new System.Drawing.Point(391, 4);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(56, 59);
            this.btn_actualizar.TabIndex = 177;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
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
            this.btn_guardar.Location = new System.Drawing.Point(98, 4);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(58, 59);
            this.btn_guardar.TabIndex = 172;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
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
            this.btn_buscar.Location = new System.Drawing.Point(275, 4);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(58, 59);
            this.btn_buscar.TabIndex = 175;
            this.btn_buscar.UseVisualStyleBackColor = true;
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
            this.btn_primero.Location = new System.Drawing.Point(465, 37);
            this.btn_primero.Margin = new System.Windows.Forms.Padding(4);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(30, 26);
            this.btn_primero.TabIndex = 180;
            this.btn_primero.UseVisualStyleBackColor = true;
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
            this.btn_anterior.Location = new System.Drawing.Point(465, 4);
            this.btn_anterior.Margin = new System.Windows.Forms.Padding(4);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(30, 26);
            this.btn_anterior.TabIndex = 178;
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
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
            this.btn_editar.Location = new System.Drawing.Point(157, 4);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(58, 59);
            this.btn_editar.TabIndex = 173;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
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
            this.btn_eliminar.Location = new System.Drawing.Point(216, 4);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(58, 59);
            this.btn_eliminar.TabIndex = 174;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
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
            this.btn_siguiente.Location = new System.Drawing.Point(503, 3);
            this.btn_siguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(30, 26);
            this.btn_siguiente.TabIndex = 179;
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // cmb_responsable
            // 
            this.cmb_responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_responsable.FormattingEnabled = true;
            this.cmb_responsable.Location = new System.Drawing.Point(176, 416);
            this.cmb_responsable.Name = "cmb_responsable";
            this.cmb_responsable.Size = new System.Drawing.Size(387, 21);
            this.cmb_responsable.TabIndex = 35;
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(176, 340);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(386, 21);
            this.cmb_categoria.TabIndex = 34;
            // 
            // cmb_ente
            // 
            this.cmb_ente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ente.FormattingEnabled = true;
            this.cmb_ente.Items.AddRange(new object[] {
            "Persona",
            "Empresa"});
            this.cmb_ente.Location = new System.Drawing.Point(176, 212);
            this.cmb_ente.Name = "cmb_ente";
            this.cmb_ente.Size = new System.Drawing.Size(114, 21);
            this.cmb_ente.TabIndex = 30;
            this.cmb_ente.SelectedIndexChanged += new System.EventHandler(this.cmb_ente_SelectedIndexChanged);
            // 
            // btn_actualizar_emp
            // 
            this.btn_actualizar_emp.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar_emp.Image")));
            this.btn_actualizar_emp.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_actualizar_emp.Location = new System.Drawing.Point(636, 415);
            this.btn_actualizar_emp.Name = "btn_actualizar_emp";
            this.btn_actualizar_emp.Size = new System.Drawing.Size(61, 23);
            this.btn_actualizar_emp.TabIndex = 19;
            this.btn_actualizar_emp.ToolTip = "Actualizar";
            this.btn_actualizar_emp.Click += new System.EventHandler(this.btn_actualizar_emp_Click);
            // 
            // btn_actualizar_ente
            // 
            this.btn_actualizar_ente.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar_ente.Image")));
            this.btn_actualizar_ente.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_actualizar_ente.Location = new System.Drawing.Point(636, 210);
            this.btn_actualizar_ente.Name = "btn_actualizar_ente";
            this.btn_actualizar_ente.Size = new System.Drawing.Size(61, 23);
            this.btn_actualizar_ente.TabIndex = 21;
            this.btn_actualizar_ente.ToolTip = "actualizar";
            this.btn_actualizar_ente.Click += new System.EventHandler(this.btn_actualizar_ente_Click);
            // 
            // dtp_fecha_cierre
            // 
            this.dtp_fecha_cierre.EditValue = null;
            this.dtp_fecha_cierre.Location = new System.Drawing.Point(176, 380);
            this.dtp_fecha_cierre.Name = "dtp_fecha_cierre";
            this.dtp_fecha_cierre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_fecha_cierre.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_fecha_cierre.Size = new System.Drawing.Size(521, 20);
            this.dtp_fecha_cierre.TabIndex = 0;
            // 
            // btn_nuevo_ente
            // 
            this.btn_nuevo_ente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_ente.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo_ente.Image")));
            this.btn_nuevo_ente.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_nuevo_ente.Location = new System.Drawing.Point(569, 210);
            this.btn_nuevo_ente.Name = "btn_nuevo_ente";
            this.btn_nuevo_ente.Size = new System.Drawing.Size(61, 23);
            this.btn_nuevo_ente.TabIndex = 20;
            this.btn_nuevo_ente.ToolTip = "Nueva persona/empresa";
            this.btn_nuevo_ente.Click += new System.EventHandler(this.btn_nuevo_ente_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(102, 176);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(33, 13);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Titulo";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 220);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = " ¿Con quién es el caso?";
            // 
            // btn_nuevo_emp
            // 
            this.btn_nuevo_emp.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo_emp.Image")));
            this.btn_nuevo_emp.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_nuevo_emp.Location = new System.Drawing.Point(569, 416);
            this.btn_nuevo_emp.Name = "btn_nuevo_emp";
            this.btn_nuevo_emp.Size = new System.Drawing.Size(61, 23);
            this.btn_nuevo_emp.TabIndex = 18;
            this.btn_nuevo_emp.ToolTip = "Nuevo empleado";
            this.btn_nuevo_emp.Click += new System.EventHandler(this.btn_nuevo_emp_Click);
            // 
            // txt_titulo
            // 
            this.txt_titulo.ForeColor = System.Drawing.Color.Gray;
            this.txt_titulo.Location = new System.Drawing.Point(176, 168);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(519, 21);
            this.txt_titulo.TabIndex = 3;
            this.txt_titulo.Text = "Ingrese un titulo para el caso...";
            this.txt_titulo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_titulo_MouseClick);
            this.txt_titulo.TextChanged += new System.EventHandler(this.txt_titulo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Empleado responsable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha estimada de cierre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripción";
            // 
            // btn_actualizar_cat
            // 
            this.btn_actualizar_cat.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar_cat.Image")));
            this.btn_actualizar_cat.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_actualizar_cat.Location = new System.Drawing.Point(636, 338);
            this.btn_actualizar_cat.Name = "btn_actualizar_cat";
            this.btn_actualizar_cat.Size = new System.Drawing.Size(61, 23);
            this.btn_actualizar_cat.TabIndex = 14;
            this.btn_actualizar_cat.ToolTip = "Actualizar";
            this.btn_actualizar_cat.Click += new System.EventHandler(this.btn_actualizar_cat_Click);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.ForeColor = System.Drawing.Color.Gray;
            this.txt_descripcion.Location = new System.Drawing.Point(176, 256);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(519, 60);
            this.txt_descripcion.TabIndex = 7;
            this.txt_descripcion.Text = "Asigne una descripción al caso...";
            this.txt_descripcion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_descripcion_MouseClick);
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
            // 
            // btn_nueva_categoria
            // 
            this.btn_nueva_categoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nueva_categoria.Image = ((System.Drawing.Image)(resources.GetObject("btn_nueva_categoria.Image")));
            this.btn_nueva_categoria.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_nueva_categoria.Location = new System.Drawing.Point(569, 338);
            this.btn_nueva_categoria.Name = "btn_nueva_categoria";
            this.btn_nueva_categoria.Size = new System.Drawing.Size(61, 23);
            this.btn_nueva_categoria.TabIndex = 13;
            this.btn_nueva_categoria.ToolTip = "Nueva categoria";
            this.btn_nueva_categoria.Click += new System.EventHandler(this.btn_nueva_categoria_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Categoría";
            // 
            // frm_NuevoCaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 649);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_NuevoCaso";
            this.Text = "Nuevo Caso";
            this.Load += new System.EventHandler(this.frm_NuevoCaso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fecha_cierre.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fecha_cierre.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_responsable;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.ComboBox cmb_ente;
        private DevExpress.XtraEditors.SimpleButton btn_actualizar_emp;
        private DevExpress.XtraEditors.SimpleButton btn_actualizar_ente;
        private DevExpress.XtraEditors.DateEdit dtp_fecha_cierre;
        private DevExpress.XtraEditors.SimpleButton btn_nuevo_ente;
        private System.Windows.Forms.Label lbl_titulo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_nuevo_emp;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_actualizar_cat;
        private System.Windows.Forms.RichTextBox txt_descripcion;
        private DevExpress.XtraEditors.SimpleButton btn_nueva_categoria;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.ComboBox cbo_perem;
    }
}