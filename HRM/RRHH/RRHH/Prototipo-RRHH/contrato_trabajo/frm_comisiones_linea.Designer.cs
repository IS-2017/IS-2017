namespace contrato_trabajo
{
    partial class frm_comisiones_linea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_comisiones_linea));
            this.lbl_cvl = new System.Windows.Forms.Label();
            this.gpb_nav = new System.Windows.Forms.GroupBox();
            this.btn_impresion = new System.Windows.Forms.Button();
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
            this.txt_id_puesto_lb = new System.Windows.Forms.TextBox();
            this.txt_marc_fac = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_tv = new System.Windows.Forms.TextBox();
            this.txt_porcentaje = new System.Windows.Forms.TextBox();
            this.txt_id_fact_emp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_fecha_seg_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_fac_ini = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txt_dg = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txt_ven = new System.Windows.Forms.TextBox();
            this.txt_fechasx = new System.Windows.Forms.TextBox();
            this.txt_empc = new System.Windows.Forms.TextBox();
            this.lbl_empresa = new System.Windows.Forms.Label();
            this.cbo_empres = new System.Windows.Forms.ComboBox();
            this.lbl_ved = new System.Windows.Forms.Label();
            this.cbo_empleado = new System.Windows.Forms.ComboBox();
            this.dtp_fecha_act = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_venta = new System.Windows.Forms.TextBox();
            this.lbl_total_com = new System.Windows.Forms.Label();
            this.txt_total_com = new System.Windows.Forms.TextBox();
            this.lbl_nom_ved = new System.Windows.Forms.Label();
            this.dgv_vendedor_linea = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_MARCA_PK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PORCENTAJE_COMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_COMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_generar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gpb_nav.SuspendLayout();
            this.gpb_com_ven.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendedor_linea)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cvl
            // 
            this.lbl_cvl.AutoSize = true;
            this.lbl_cvl.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cvl.Location = new System.Drawing.Point(251, 116);
            this.lbl_cvl.Name = "lbl_cvl";
            this.lbl_cvl.Size = new System.Drawing.Size(516, 36);
            this.lbl_cvl.TabIndex = 173;
            this.lbl_cvl.Text = "Comisiones de Vendedor Por Linea";
            // 
            // gpb_nav
            // 
            this.gpb_nav.Controls.Add(this.btn_impresion);
            this.gpb_nav.Controls.Add(this.btn_nuevo);
            this.gpb_nav.Controls.Add(this.btn_ultimo);
            this.gpb_nav.Controls.Add(this.btn_guardar);
            this.gpb_nav.Controls.Add(this.btn_primero);
            this.gpb_nav.Controls.Add(this.btn_editar);
            this.gpb_nav.Controls.Add(this.btn_siguiente);
            this.gpb_nav.Controls.Add(this.btn_eliminar);
            this.gpb_nav.Controls.Add(this.btn_anterior);
            this.gpb_nav.Controls.Add(this.btn_buscar);
            this.gpb_nav.Controls.Add(this.btn_actualizar);
            this.gpb_nav.Controls.Add(this.btn_cancelar);
            this.gpb_nav.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_nav.Location = new System.Drawing.Point(162, 3);
            this.gpb_nav.Name = "gpb_nav";
            this.gpb_nav.Size = new System.Drawing.Size(697, 100);
            this.gpb_nav.TabIndex = 171;
            this.gpb_nav.TabStop = false;
            this.gpb_nav.Text = "Navegador";
            this.gpb_nav.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_impresion
            // 
            this.btn_impresion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_impresion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_impresion.FlatAppearance.BorderSize = 0;
            this.btn_impresion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_impresion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_impresion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_impresion.Image = global::contrato_trabajo.Properties.Resources.imprimir;
            this.btn_impresion.Location = new System.Drawing.Point(604, 12);
            this.btn_impresion.Name = "btn_impresion";
            this.btn_impresion.Size = new System.Drawing.Size(79, 77);
            this.btn_impresion.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btn_impresion, "Reporte de la asistencia");
            this.btn_impresion.UseVisualStyleBackColor = true;
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
            this.toolTip1.SetToolTip(this.btn_cancelar, "Cancelar comision");
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // gpb_com_ven
            // 
            this.gpb_com_ven.Controls.Add(this.txt_id_puesto_lb);
            this.gpb_com_ven.Controls.Add(this.txt_marc_fac);
            this.gpb_com_ven.Controls.Add(this.txt_tc);
            this.gpb_com_ven.Controls.Add(this.txt_tv);
            this.gpb_com_ven.Controls.Add(this.txt_porcentaje);
            this.gpb_com_ven.Controls.Add(this.txt_id_fact_emp);
            this.gpb_com_ven.Controls.Add(this.label5);
            this.gpb_com_ven.Controls.Add(this.label4);
            this.gpb_com_ven.Controls.Add(this.dtp_fecha_seg_fin);
            this.gpb_com_ven.Controls.Add(this.dtp_fecha_fac_ini);
            this.gpb_com_ven.Controls.Add(this.radioButton1);
            this.gpb_com_ven.Controls.Add(this.txt_dg);
            this.gpb_com_ven.Controls.Add(this.textBox8);
            this.gpb_com_ven.Controls.Add(this.txt_ven);
            this.gpb_com_ven.Controls.Add(this.txt_fechasx);
            this.gpb_com_ven.Controls.Add(this.txt_empc);
            this.gpb_com_ven.Controls.Add(this.lbl_empresa);
            this.gpb_com_ven.Controls.Add(this.cbo_empres);
            this.gpb_com_ven.Controls.Add(this.lbl_ved);
            this.gpb_com_ven.Controls.Add(this.cbo_empleado);
            this.gpb_com_ven.Controls.Add(this.dtp_fecha_act);
            this.gpb_com_ven.Controls.Add(this.lbl_fecha);
            this.gpb_com_ven.Controls.Add(this.txt_venta);
            this.gpb_com_ven.Controls.Add(this.lbl_total_com);
            this.gpb_com_ven.Controls.Add(this.txt_total_com);
            this.gpb_com_ven.Controls.Add(this.lbl_nom_ved);
            this.gpb_com_ven.Controls.Add(this.dgv_vendedor_linea);
            this.gpb_com_ven.Controls.Add(this.btn_generar);
            this.gpb_com_ven.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_com_ven.Location = new System.Drawing.Point(15, 176);
            this.gpb_com_ven.Name = "gpb_com_ven";
            this.gpb_com_ven.Size = new System.Drawing.Size(965, 328);
            this.gpb_com_ven.TabIndex = 172;
            this.gpb_com_ven.TabStop = false;
            this.gpb_com_ven.Text = "Datos";
            // 
            // txt_id_puesto_lb
            // 
            this.txt_id_puesto_lb.Location = new System.Drawing.Point(473, 55);
            this.txt_id_puesto_lb.Name = "txt_id_puesto_lb";
            this.txt_id_puesto_lb.Size = new System.Drawing.Size(10, 27);
            this.txt_id_puesto_lb.TabIndex = 228;
            this.txt_id_puesto_lb.Visible = false;
            // 
            // txt_marc_fac
            // 
            this.txt_marc_fac.Location = new System.Drawing.Point(6, 269);
            this.txt_marc_fac.Name = "txt_marc_fac";
            this.txt_marc_fac.Size = new System.Drawing.Size(10, 27);
            this.txt_marc_fac.TabIndex = 227;
            this.txt_marc_fac.Tag = "marca_comision";
            this.txt_marc_fac.Visible = false;
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(6, 236);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(10, 27);
            this.txt_tc.TabIndex = 226;
            this.txt_tc.Tag = "total_comision";
            this.txt_tc.Visible = false;
            // 
            // txt_tv
            // 
            this.txt_tv.Location = new System.Drawing.Point(6, 203);
            this.txt_tv.Name = "txt_tv";
            this.txt_tv.Size = new System.Drawing.Size(10, 27);
            this.txt_tv.TabIndex = 225;
            this.txt_tv.Tag = "total_venta";
            this.txt_tv.Visible = false;
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.Location = new System.Drawing.Point(6, 170);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(10, 27);
            this.txt_porcentaje.TabIndex = 224;
            this.txt_porcentaje.Tag = "porsentaje_comision";
            this.txt_porcentaje.Visible = false;
            // 
            // txt_id_fact_emp
            // 
            this.txt_id_fact_emp.Location = new System.Drawing.Point(6, 137);
            this.txt_id_fact_emp.Name = "txt_id_fact_emp";
            this.txt_id_fact_emp.Size = new System.Drawing.Size(10, 27);
            this.txt_id_fact_emp.TabIndex = 223;
            this.txt_id_fact_emp.Tag = "id_fac_empresa_pk";
            this.txt_id_fact_emp.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 222;
            this.label5.Text = "HASTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 221;
            this.label4.Text = "DE";
            // 
            // dtp_fecha_seg_fin
            // 
            this.dtp_fecha_seg_fin.Location = new System.Drawing.Point(610, 85);
            this.dtp_fecha_seg_fin.Name = "dtp_fecha_seg_fin";
            this.dtp_fecha_seg_fin.Size = new System.Drawing.Size(293, 27);
            this.dtp_fecha_seg_fin.TabIndex = 220;
            this.toolTip1.SetToolTip(this.dtp_fecha_seg_fin, "Fecha tiene que ser mayor a la primera");
            // 
            // dtp_fecha_fac_ini
            // 
            this.dtp_fecha_fac_ini.Location = new System.Drawing.Point(610, 49);
            this.dtp_fecha_fac_ini.Name = "dtp_fecha_fac_ini";
            this.dtp_fecha_fac_ini.Size = new System.Drawing.Size(293, 27);
            this.dtp_fecha_fac_ini.TabIndex = 219;
            this.dtp_fecha_fac_ini.Tag = "Primera fecha";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(624, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(159, 25);
            this.radioButton1.TabIndex = 218;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fechas  Facturas";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txt_dg
            // 
            this.txt_dg.Location = new System.Drawing.Point(388, 21);
            this.txt_dg.Name = "txt_dg";
            this.txt_dg.Size = new System.Drawing.Size(10, 27);
            this.txt_dg.TabIndex = 217;
            this.txt_dg.Tag = "id_devengos_pk";
            this.txt_dg.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(372, 21);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(10, 27);
            this.textBox8.TabIndex = 216;
            this.textBox8.Tag = "id_com_venta_pk";
            this.textBox8.Visible = false;
            // 
            // txt_ven
            // 
            this.txt_ven.Location = new System.Drawing.Point(332, 55);
            this.txt_ven.Name = "txt_ven";
            this.txt_ven.Size = new System.Drawing.Size(10, 27);
            this.txt_ven.TabIndex = 215;
            this.txt_ven.Tag = "id_empleado_pk";
            this.txt_ven.Visible = false;
            // 
            // txt_fechasx
            // 
            this.txt_fechasx.Location = new System.Drawing.Point(96, 21);
            this.txt_fechasx.Name = "txt_fechasx";
            this.txt_fechasx.Size = new System.Drawing.Size(10, 27);
            this.txt_fechasx.TabIndex = 214;
            this.txt_fechasx.Tag = "fecha";
            this.txt_fechasx.Visible = false;
            // 
            // txt_empc
            // 
            this.txt_empc.Location = new System.Drawing.Point(96, 52);
            this.txt_empc.Name = "txt_empc";
            this.txt_empc.Size = new System.Drawing.Size(10, 27);
            this.txt_empc.TabIndex = 213;
            this.txt_empc.Tag = "id_empresa_pk";
            this.txt_empc.Visible = false;
            // 
            // lbl_empresa
            // 
            this.lbl_empresa.AutoSize = true;
            this.lbl_empresa.Location = new System.Drawing.Point(13, 55);
            this.lbl_empresa.Name = "lbl_empresa";
            this.lbl_empresa.Size = new System.Drawing.Size(77, 21);
            this.lbl_empresa.TabIndex = 212;
            this.lbl_empresa.Text = "Empresa";
            // 
            // cbo_empres
            // 
            this.cbo_empres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empres.FormattingEnabled = true;
            this.cbo_empres.Location = new System.Drawing.Point(111, 52);
            this.cbo_empres.Name = "cbo_empres";
            this.cbo_empres.Size = new System.Drawing.Size(121, 29);
            this.cbo_empres.TabIndex = 211;
            this.cbo_empres.SelectedIndexChanged += new System.EventHandler(this.cbo_empres_SelectedIndexChanged);
            // 
            // lbl_ved
            // 
            this.lbl_ved.AutoSize = true;
            this.lbl_ved.Location = new System.Drawing.Point(238, 55);
            this.lbl_ved.Name = "lbl_ved";
            this.lbl_ved.Size = new System.Drawing.Size(88, 21);
            this.lbl_ved.TabIndex = 210;
            this.lbl_ved.Text = "Vendedor";
            // 
            // cbo_empleado
            // 
            this.cbo_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empleado.FormattingEnabled = true;
            this.cbo_empleado.Location = new System.Drawing.Point(346, 52);
            this.cbo_empleado.Name = "cbo_empleado";
            this.cbo_empleado.Size = new System.Drawing.Size(121, 29);
            this.cbo_empleado.TabIndex = 209;
            this.cbo_empleado.SelectedIndexChanged += new System.EventHandler(this.cbo_empleado_SelectedIndexChanged);
            // 
            // dtp_fecha_act
            // 
            this.dtp_fecha_act.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_act.Location = new System.Drawing.Point(111, 24);
            this.dtp_fecha_act.Name = "dtp_fecha_act";
            this.dtp_fecha_act.Size = new System.Drawing.Size(255, 22);
            this.dtp_fecha_act.TabIndex = 208;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(13, 23);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(63, 21);
            this.lbl_fecha.TabIndex = 207;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // txt_venta
            // 
            this.txt_venta.Location = new System.Drawing.Point(130, 87);
            this.txt_venta.Name = "txt_venta";
            this.txt_venta.ReadOnly = true;
            this.txt_venta.Size = new System.Drawing.Size(70, 27);
            this.txt_venta.TabIndex = 206;
            this.txt_venta.Tag = "total_venta";
            // 
            // lbl_total_com
            // 
            this.lbl_total_com.AutoSize = true;
            this.lbl_total_com.Location = new System.Drawing.Point(206, 94);
            this.lbl_total_com.Name = "lbl_total_com";
            this.lbl_total_com.Size = new System.Drawing.Size(144, 21);
            this.lbl_total_com.TabIndex = 205;
            this.lbl_total_com.Text = "Total comisiones: ";
            // 
            // txt_total_com
            // 
            this.txt_total_com.Location = new System.Drawing.Point(356, 91);
            this.txt_total_com.Name = "txt_total_com";
            this.txt_total_com.ReadOnly = true;
            this.txt_total_com.Size = new System.Drawing.Size(97, 27);
            this.txt_total_com.TabIndex = 204;
            this.txt_total_com.Tag = "comision";
            // 
            // lbl_nom_ved
            // 
            this.lbl_nom_ved.AutoSize = true;
            this.lbl_nom_ved.Location = new System.Drawing.Point(13, 94);
            this.lbl_nom_ved.Name = "lbl_nom_ved";
            this.lbl_nom_ved.Size = new System.Drawing.Size(111, 21);
            this.lbl_nom_ved.TabIndex = 203;
            this.lbl_nom_ved.Text = "Total ventas:";
            // 
            // dgv_vendedor_linea
            // 
            this.dgv_vendedor_linea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendedor_linea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.ID_MARCA_PK,
            this.NOMBRE_CATEGORIA,
            this.PORCENTAJE_COMISION,
            this.TOTAL_VENTA,
            this.TOTAL_COMISION});
            this.dgv_vendedor_linea.Location = new System.Drawing.Point(17, 137);
            this.dgv_vendedor_linea.Name = "dgv_vendedor_linea";
            this.dgv_vendedor_linea.Size = new System.Drawing.Size(932, 150);
            this.dgv_vendedor_linea.TabIndex = 187;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_FACTURA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "TOTAL_FACTURA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "DETALLE_FACTURA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 5;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "DESCRIPCION";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "PRECIO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "CANTIDAD";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "ID_BIEN";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 5;
            // 
            // ID_MARCA_PK
            // 
            this.ID_MARCA_PK.HeaderText = "ID_LINEA";
            this.ID_MARCA_PK.Name = "ID_MARCA_PK";
            this.ID_MARCA_PK.Width = 5;
            // 
            // NOMBRE_CATEGORIA
            // 
            this.NOMBRE_CATEGORIA.HeaderText = "LINEA";
            this.NOMBRE_CATEGORIA.Name = "NOMBRE_CATEGORIA";
            // 
            // PORCENTAJE_COMISION
            // 
            this.PORCENTAJE_COMISION.HeaderText = "PORCENTAJE";
            this.PORCENTAJE_COMISION.Name = "PORCENTAJE_COMISION";
            this.PORCENTAJE_COMISION.Width = 120;
            // 
            // TOTAL_VENTA
            // 
            this.TOTAL_VENTA.HeaderText = "TOTAL_VENTA";
            this.TOTAL_VENTA.Name = "TOTAL_VENTA";
            // 
            // TOTAL_COMISION
            // 
            this.TOTAL_COMISION.HeaderText = "COMISION";
            this.TOTAL_COMISION.Name = "TOTAL_COMISION";
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(470, 293);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(114, 29);
            this.btn_generar.TabIndex = 175;
            this.btn_generar.Text = "GENERAR";
            this.toolTip1.SetToolTip(this.btn_generar, "Generar la comisiones del respectivo vendedor");
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // frm_comisiones_linea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(994, 525);
            this.Controls.Add(this.lbl_cvl);
            this.Controls.Add(this.gpb_nav);
            this.Controls.Add(this.gpb_com_ven);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_comisiones_linea";
            this.Text = "Comisiones por Linea";
            this.Load += new System.EventHandler(this.frm_comisiones_linea_Load);
            this.gpb_nav.ResumeLayout(false);
            this.gpb_com_ven.ResumeLayout(false);
            this.gpb_com_ven.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendedor_linea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cvl;
        private System.Windows.Forms.GroupBox gpb_nav;
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
        private System.Windows.Forms.TextBox txt_marc_fac;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_tv;
        private System.Windows.Forms.TextBox txt_porcentaje;
        private System.Windows.Forms.TextBox txt_id_fact_emp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_fecha_seg_fin;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fac_ini;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txt_dg;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txt_ven;
        private System.Windows.Forms.TextBox txt_fechasx;
        private System.Windows.Forms.TextBox txt_empc;
        private System.Windows.Forms.Label lbl_empresa;
        private System.Windows.Forms.ComboBox cbo_empres;
        private System.Windows.Forms.Label lbl_ved;
        private System.Windows.Forms.ComboBox cbo_empleado;
        private System.Windows.Forms.DateTimePicker dtp_fecha_act;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TextBox txt_venta;
        private System.Windows.Forms.Label lbl_total_com;
        private System.Windows.Forms.TextBox txt_total_com;
        private System.Windows.Forms.Label lbl_nom_ved;
        private System.Windows.Forms.DataGridView dgv_vendedor_linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MARCA_PK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PORCENTAJE_COMISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_VENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_COMISION;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.TextBox txt_id_puesto_lb;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_impresion;
    }
}