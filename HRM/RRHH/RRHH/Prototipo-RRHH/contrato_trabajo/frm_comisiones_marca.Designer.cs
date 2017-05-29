namespace contrato_trabajo
{
    partial class frm_comisiones_marca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_comisiones_marca));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.gpb_com_ven = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_id_puesto_lb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_fecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txt_mar_co = new System.Windows.Forms.TextBox();
            this.txt_fechasz = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_fechasx = new System.Windows.Forms.TextBox();
            this.txt_tv = new System.Windows.Forms.TextBox();
            this.txt_proc_com = new System.Windows.Forms.TextBox();
            this.txt_fac_emp = new System.Windows.Forms.TextBox();
            this.txt_emps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_empres = new System.Windows.Forms.ComboBox();
            this.lbl_ved = new System.Windows.Forms.Label();
            this.cbo_empleado = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_venta = new System.Windows.Forms.TextBox();
            this.lbl_total_com = new System.Windows.Forms.Label();
            this.txt_total_com = new System.Windows.Forms.TextBox();
            this.lbl_nom_ved = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gpb_com_ven.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(536, 36);
            this.label3.TabIndex = 170;
            this.label3.Text = "Comisiones de Vendedor Por Marca";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_reporte);
            this.groupBox1.Controls.Add(this.btn_nuevo);
            this.groupBox1.Controls.Add(this.btn_ultimo);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.btn_primero);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.btn_siguiente);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_anterior);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.btn_actualizar);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(90, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 100);
            this.groupBox1.TabIndex = 168;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegador";
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
            this.btn_reporte.Location = new System.Drawing.Point(610, 17);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(79, 77);
            this.btn_reporte.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btn_reporte, "Reporte de la asistencia");
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
            this.btn_nuevo.Location = new System.Drawing.Point(17, 19);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_nuevo, "Creacion de la comision");
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
            this.btn_ultimo.Location = new System.Drawing.Point(565, 53);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(33, 33);
            this.btn_ultimo.TabIndex = 10;
            this.btn_ultimo.UseVisualStyleBackColor = true;
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
            this.btn_guardar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar comision");
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
            this.btn_primero.Location = new System.Drawing.Point(529, 53);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(33, 33);
            this.btn_primero.TabIndex = 9;
            this.btn_primero.UseVisualStyleBackColor = true;
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
            this.btn_editar.TabIndex = 2;
            this.btn_editar.UseVisualStyleBackColor = true;
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
            this.btn_siguiente.Location = new System.Drawing.Point(565, 18);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(33, 33);
            this.btn_siguiente.TabIndex = 8;
            this.btn_siguiente.UseVisualStyleBackColor = true;
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
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.UseVisualStyleBackColor = true;
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
            this.btn_anterior.Location = new System.Drawing.Point(529, 18);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(33, 33);
            this.btn_anterior.TabIndex = 7;
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
            this.btn_buscar.Location = new System.Drawing.Point(301, 19);
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
            this.btn_actualizar.Location = new System.Drawing.Point(443, 19);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(65, 65);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.UseVisualStyleBackColor = true;
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
            this.btn_cancelar.Location = new System.Drawing.Point(372, 18);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 65);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // gpb_com_ven
            // 
            this.gpb_com_ven.Controls.Add(this.button1);
            this.gpb_com_ven.Controls.Add(this.dataGridView1);
            this.gpb_com_ven.Controls.Add(this.txt_id_puesto_lb);
            this.gpb_com_ven.Controls.Add(this.label5);
            this.gpb_com_ven.Controls.Add(this.label4);
            this.gpb_com_ven.Controls.Add(this.dtp_fecha2);
            this.gpb_com_ven.Controls.Add(this.dtp_fecha1);
            this.gpb_com_ven.Controls.Add(this.radioButton1);
            this.gpb_com_ven.Controls.Add(this.txt_mar_co);
            this.gpb_com_ven.Controls.Add(this.txt_fechasz);
            this.gpb_com_ven.Controls.Add(this.textBox7);
            this.gpb_com_ven.Controls.Add(this.txt_tc);
            this.gpb_com_ven.Controls.Add(this.txt_fechasx);
            this.gpb_com_ven.Controls.Add(this.txt_tv);
            this.gpb_com_ven.Controls.Add(this.txt_proc_com);
            this.gpb_com_ven.Controls.Add(this.txt_fac_emp);
            this.gpb_com_ven.Controls.Add(this.txt_emps);
            this.gpb_com_ven.Controls.Add(this.label1);
            this.gpb_com_ven.Controls.Add(this.cbo_empres);
            this.gpb_com_ven.Controls.Add(this.lbl_ved);
            this.gpb_com_ven.Controls.Add(this.cbo_empleado);
            this.gpb_com_ven.Controls.Add(this.dateTimePicker1);
            this.gpb_com_ven.Controls.Add(this.label2);
            this.gpb_com_ven.Controls.Add(this.txt_venta);
            this.gpb_com_ven.Controls.Add(this.lbl_total_com);
            this.gpb_com_ven.Controls.Add(this.txt_total_com);
            this.gpb_com_ven.Controls.Add(this.lbl_nom_ved);
            this.gpb_com_ven.Controls.Add(this.btn_generar);
            this.gpb_com_ven.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_com_ven.Location = new System.Drawing.Point(7, 158);
            this.gpb_com_ven.Name = "gpb_com_ven";
            this.gpb_com_ven.Size = new System.Drawing.Size(859, 339);
            this.gpb_com_ven.TabIndex = 169;
            this.gpb_com_ven.TabStop = false;
            this.gpb_com_ven.Text = "Datos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 150);
            this.dataGridView1.TabIndex = 220;
            // 
            // txt_id_puesto_lb
            // 
            this.txt_id_puesto_lb.Location = new System.Drawing.Point(489, 55);
            this.txt_id_puesto_lb.Name = "txt_id_puesto_lb";
            this.txt_id_puesto_lb.Size = new System.Drawing.Size(10, 27);
            this.txt_id_puesto_lb.TabIndex = 219;
            this.txt_id_puesto_lb.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 202;
            this.label5.Text = "HASTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 201;
            this.label4.Text = "DE";
            // 
            // dtp_fecha2
            // 
            this.dtp_fecha2.Location = new System.Drawing.Point(626, 85);
            this.dtp_fecha2.Name = "dtp_fecha2";
            this.dtp_fecha2.Size = new System.Drawing.Size(200, 27);
            this.dtp_fecha2.TabIndex = 200;
            // 
            // dtp_fecha1
            // 
            this.dtp_fecha1.Location = new System.Drawing.Point(626, 49);
            this.dtp_fecha1.Name = "dtp_fecha1";
            this.dtp_fecha1.Size = new System.Drawing.Size(200, 27);
            this.dtp_fecha1.TabIndex = 199;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(640, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(159, 25);
            this.radioButton1.TabIndex = 198;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fechas  Facturas";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txt_mar_co
            // 
            this.txt_mar_co.Location = new System.Drawing.Point(6, 257);
            this.txt_mar_co.Name = "txt_mar_co";
            this.txt_mar_co.Size = new System.Drawing.Size(10, 27);
            this.txt_mar_co.TabIndex = 197;
            this.txt_mar_co.Tag = "marca_comision";
            this.txt_mar_co.Visible = false;
            // 
            // txt_fechasz
            // 
            this.txt_fechasz.Location = new System.Drawing.Point(388, 21);
            this.txt_fechasz.Name = "txt_fechasz";
            this.txt_fechasz.Size = new System.Drawing.Size(10, 27);
            this.txt_fechasz.TabIndex = 195;
            this.txt_fechasz.Tag = "id_com_venta_pk";
            this.txt_fechasz.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(348, 55);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(10, 27);
            this.textBox7.TabIndex = 194;
            this.textBox7.Tag = "id_empleado_pk";
            this.textBox7.Visible = false;
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(6, 224);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(10, 27);
            this.txt_tc.TabIndex = 193;
            this.txt_tc.Tag = "total_comision";
            this.txt_tc.Visible = false;
            // 
            // txt_fechasx
            // 
            this.txt_fechasx.Location = new System.Drawing.Point(112, 21);
            this.txt_fechasx.Name = "txt_fechasx";
            this.txt_fechasx.Size = new System.Drawing.Size(10, 27);
            this.txt_fechasx.TabIndex = 192;
            this.txt_fechasx.Tag = "fecha";
            this.txt_fechasx.Visible = false;
            // 
            // txt_tv
            // 
            this.txt_tv.Location = new System.Drawing.Point(6, 191);
            this.txt_tv.Name = "txt_tv";
            this.txt_tv.Size = new System.Drawing.Size(10, 27);
            this.txt_tv.TabIndex = 191;
            this.txt_tv.Tag = "total_venta";
            this.txt_tv.Visible = false;
            // 
            // txt_proc_com
            // 
            this.txt_proc_com.Location = new System.Drawing.Point(6, 158);
            this.txt_proc_com.Name = "txt_proc_com";
            this.txt_proc_com.Size = new System.Drawing.Size(10, 27);
            this.txt_proc_com.TabIndex = 190;
            this.txt_proc_com.Tag = "porsentaje_comision";
            this.txt_proc_com.Visible = false;
            // 
            // txt_fac_emp
            // 
            this.txt_fac_emp.Location = new System.Drawing.Point(6, 125);
            this.txt_fac_emp.Name = "txt_fac_emp";
            this.txt_fac_emp.Size = new System.Drawing.Size(10, 27);
            this.txt_fac_emp.TabIndex = 189;
            this.txt_fac_emp.Tag = "id_fac_empresa_pk";
            this.txt_fac_emp.Visible = false;
            // 
            // txt_emps
            // 
            this.txt_emps.Location = new System.Drawing.Point(112, 52);
            this.txt_emps.Name = "txt_emps";
            this.txt_emps.Size = new System.Drawing.Size(10, 27);
            this.txt_emps.TabIndex = 188;
            this.txt_emps.Tag = "id_empresa_pk";
            this.txt_emps.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 186;
            this.label1.Text = "Empresa";
            // 
            // cbo_empres
            // 
            this.cbo_empres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empres.FormattingEnabled = true;
            this.cbo_empres.Location = new System.Drawing.Point(127, 52);
            this.cbo_empres.Name = "cbo_empres";
            this.cbo_empres.Size = new System.Drawing.Size(121, 29);
            this.cbo_empres.TabIndex = 185;
            this.cbo_empres.SelectedIndexChanged += new System.EventHandler(this.cbo_empres_SelectedIndexChanged);
            // 
            // lbl_ved
            // 
            this.lbl_ved.AutoSize = true;
            this.lbl_ved.Location = new System.Drawing.Point(254, 55);
            this.lbl_ved.Name = "lbl_ved";
            this.lbl_ved.Size = new System.Drawing.Size(88, 21);
            this.lbl_ved.TabIndex = 184;
            this.lbl_ved.Text = "Vendedor";
            // 
            // cbo_empleado
            // 
            this.cbo_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empleado.FormattingEnabled = true;
            this.cbo_empleado.Location = new System.Drawing.Point(362, 52);
            this.cbo_empleado.Name = "cbo_empleado";
            this.cbo_empleado.Size = new System.Drawing.Size(121, 29);
            this.cbo_empleado.TabIndex = 183;
            this.cbo_empleado.SelectedIndexChanged += new System.EventHandler(this.cbo_empleado_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker1.TabIndex = 182;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 181;
            this.label2.Text = "Fecha:";
            // 
            // txt_venta
            // 
            this.txt_venta.Location = new System.Drawing.Point(146, 87);
            this.txt_venta.Name = "txt_venta";
            this.txt_venta.ReadOnly = true;
            this.txt_venta.Size = new System.Drawing.Size(70, 27);
            this.txt_venta.TabIndex = 180;
            this.txt_venta.Tag = "total_venta";
            // 
            // lbl_total_com
            // 
            this.lbl_total_com.AutoSize = true;
            this.lbl_total_com.Location = new System.Drawing.Point(222, 94);
            this.lbl_total_com.Name = "lbl_total_com";
            this.lbl_total_com.Size = new System.Drawing.Size(144, 21);
            this.lbl_total_com.TabIndex = 179;
            this.lbl_total_com.Text = "Total comisiones: ";
            // 
            // txt_total_com
            // 
            this.txt_total_com.Location = new System.Drawing.Point(372, 87);
            this.txt_total_com.Name = "txt_total_com";
            this.txt_total_com.ReadOnly = true;
            this.txt_total_com.Size = new System.Drawing.Size(97, 27);
            this.txt_total_com.TabIndex = 178;
            this.txt_total_com.Tag = "comision";
            // 
            // lbl_nom_ved
            // 
            this.lbl_nom_ved.AutoSize = true;
            this.lbl_nom_ved.Location = new System.Drawing.Point(29, 94);
            this.lbl_nom_ved.Name = "lbl_nom_ved";
            this.lbl_nom_ved.Size = new System.Drawing.Size(111, 21);
            this.lbl_nom_ved.TabIndex = 177;
            this.lbl_nom_ved.Text = "Total ventas:";
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(506, 293);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(114, 29);
            this.btn_generar.TabIndex = 175;
            this.btn_generar.Text = "GENERAR";
            this.toolTip1.SetToolTip(this.btn_generar, "Generar comision");
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 221;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frm_comisiones_marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpb_com_ven);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_comisiones_marca";
            this.Text = "Comision por Marca";
            this.Load += new System.EventHandler(this.frm_comisiones_marca_Load);
            this.groupBox1.ResumeLayout(false);
            this.gpb_com_ven.ResumeLayout(false);
            this.gpb_com_ven.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox gpb_com_ven;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_fecha2;
        private System.Windows.Forms.DateTimePicker dtp_fecha1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txt_mar_co;
        private System.Windows.Forms.TextBox txt_fechasz;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_fechasx;
        private System.Windows.Forms.TextBox txt_tv;
        private System.Windows.Forms.TextBox txt_proc_com;
        private System.Windows.Forms.TextBox txt_fac_emp;
        private System.Windows.Forms.TextBox txt_emps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_empres;
        private System.Windows.Forms.Label lbl_ved;
        private System.Windows.Forms.ComboBox cbo_empleado;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_venta;
        private System.Windows.Forms.Label lbl_total_com;
        private System.Windows.Forms.TextBox txt_total_com;
        private System.Windows.Forms.Label lbl_nom_ved;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.TextBox txt_id_puesto_lb;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}