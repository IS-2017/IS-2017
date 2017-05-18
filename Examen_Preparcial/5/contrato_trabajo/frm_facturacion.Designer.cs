namespace contrato_trabajo
{
    partial class frm_facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_facturacion));
            this.label5 = new System.Windows.Forms.Label();
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
            this.gpb_encabezado = new System.Windows.Forms.GroupBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_cliente = new System.Windows.Forms.ComboBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.gpb_detalle = new System.Windows.Forms.GroupBox();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_precio1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cantidad1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_producto = new System.Windows.Forms.ComboBox();
            this.dgv_detalle_factura = new System.Windows.Forms.DataGridView();
            this.cantidad_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_eltotal = new System.Windows.Forms.Label();
            this.lbl_tot = new System.Windows.Forms.Label();
            this.txt_producto2 = new System.Windows.Forms.TextBox();
            this.txt_cantidad2 = new System.Windows.Forms.TextBox();
            this.txt_precio2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.gpb_encabezado.SuspendLayout();
            this.gpb_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_factura)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 219;
            this.label5.Text = "Factura";
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
            this.groupBox2.Location = new System.Drawing.Point(43, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 106);
            this.groupBox2.TabIndex = 220;
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
            this.btn_nuevo.Location = new System.Drawing.Point(17, 23);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(65, 69);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.UseVisualStyleBackColor = true;
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
            this.btn_guardar.Location = new System.Drawing.Point(88, 20);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 69);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.UseVisualStyleBackColor = true;
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
            this.btn_editar.Location = new System.Drawing.Point(159, 20);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(65, 69);
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
            this.btn_siguiente.Location = new System.Drawing.Point(565, 19);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(33, 36);
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
            this.btn_eliminar.Location = new System.Drawing.Point(230, 20);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(65, 69);
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
            this.btn_anterior.Location = new System.Drawing.Point(529, 19);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(33, 36);
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
            this.btn_buscar.Location = new System.Drawing.Point(301, 20);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(65, 69);
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
            this.btn_actualizar.Location = new System.Drawing.Point(443, 20);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(65, 69);
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
            this.btn_cancelar.Location = new System.Drawing.Point(372, 20);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 69);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // gpb_encabezado
            // 
            this.gpb_encabezado.Controls.Add(this.txt_cliente);
            this.gpb_encabezado.Controls.Add(this.label4);
            this.gpb_encabezado.Controls.Add(this.cbo_cliente);
            this.gpb_encabezado.Controls.Add(this.txt_fecha);
            this.gpb_encabezado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_encabezado.Location = new System.Drawing.Point(43, 153);
            this.gpb_encabezado.Name = "gpb_encabezado";
            this.gpb_encabezado.Size = new System.Drawing.Size(695, 61);
            this.gpb_encabezado.TabIndex = 224;
            this.gpb_encabezado.TabStop = false;
            this.gpb_encabezado.Text = "Datos encabezado";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(565, 19);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(16, 26);
            this.txt_cliente.TabIndex = 236;
            this.txt_cliente.Tag = "fecha_enc_factura";
            this.txt_cliente.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 235;
            this.label4.Text = "Cliente:";
            // 
            // cbo_cliente
            // 
            this.cbo_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cliente.FormattingEnabled = true;
            this.cbo_cliente.Location = new System.Drawing.Point(88, 19);
            this.cbo_cliente.Name = "cbo_cliente";
            this.cbo_cliente.Size = new System.Drawing.Size(471, 28);
            this.cbo_cliente.TabIndex = 235;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(583, 20);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(106, 26);
            this.txt_fecha.TabIndex = 228;
            this.txt_fecha.Tag = "fecha_enc_factura";
            this.txt_fecha.Visible = false;
            // 
            // gpb_detalle
            // 
            this.gpb_detalle.Controls.Add(this.btn_quitar);
            this.gpb_detalle.Controls.Add(this.btn_agregar);
            this.gpb_detalle.Controls.Add(this.label3);
            this.gpb_detalle.Controls.Add(this.txt_precio1);
            this.gpb_detalle.Controls.Add(this.label2);
            this.gpb_detalle.Controls.Add(this.txt_cantidad1);
            this.gpb_detalle.Controls.Add(this.label1);
            this.gpb_detalle.Controls.Add(this.cbo_producto);
            this.gpb_detalle.Location = new System.Drawing.Point(43, 220);
            this.gpb_detalle.Name = "gpb_detalle";
            this.gpb_detalle.Size = new System.Drawing.Size(695, 72);
            this.gpb_detalle.TabIndex = 225;
            this.gpb_detalle.TabStop = false;
            this.gpb_detalle.Text = "Datos detalle";
            // 
            // btn_quitar
            // 
            this.btn_quitar.Location = new System.Drawing.Point(362, 45);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(75, 23);
            this.btn_quitar.TabIndex = 234;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(276, 45);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 233;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 232;
            this.label3.Text = "Precio:";
            // 
            // txt_precio1
            // 
            this.txt_precio1.Location = new System.Drawing.Point(565, 19);
            this.txt_precio1.Name = "txt_precio1";
            this.txt_precio1.ReadOnly = true;
            this.txt_precio1.Size = new System.Drawing.Size(106, 20);
            this.txt_precio1.TabIndex = 231;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 230;
            this.label2.Text = "Cantidad:";
            // 
            // txt_cantidad1
            // 
            this.txt_cantidad1.Location = new System.Drawing.Point(341, 19);
            this.txt_cantidad1.Name = "txt_cantidad1";
            this.txt_cantidad1.Size = new System.Drawing.Size(140, 20);
            this.txt_cantidad1.TabIndex = 229;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 229;
            this.label1.Text = "Producto:";
            // 
            // cbo_producto
            // 
            this.cbo_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_producto.FormattingEnabled = true;
            this.cbo_producto.Location = new System.Drawing.Point(72, 20);
            this.cbo_producto.Name = "cbo_producto";
            this.cbo_producto.Size = new System.Drawing.Size(195, 21);
            this.cbo_producto.TabIndex = 0;
            this.cbo_producto.SelectedIndexChanged += new System.EventHandler(this.cbo_producto_SelectedIndexChanged);
            // 
            // dgv_detalle_factura
            // 
            this.dgv_detalle_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle_factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidad_factura,
            this.id_producto,
            this.precio_factura});
            this.dgv_detalle_factura.Location = new System.Drawing.Point(44, 302);
            this.dgv_detalle_factura.Name = "dgv_detalle_factura";
            this.dgv_detalle_factura.Size = new System.Drawing.Size(690, 142);
            this.dgv_detalle_factura.TabIndex = 226;
            // 
            // cantidad_factura
            // 
            this.cantidad_factura.HeaderText = "Cantidad";
            this.cantidad_factura.Name = "cantidad_factura";
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "Producto";
            this.id_producto.Name = "id_producto";
            // 
            // precio_factura
            // 
            this.precio_factura.HeaderText = "Precio";
            this.precio_factura.Name = "precio_factura";
            // 
            // lbl_eltotal
            // 
            this.lbl_eltotal.AutoSize = true;
            this.lbl_eltotal.Location = new System.Drawing.Point(273, 455);
            this.lbl_eltotal.Name = "lbl_eltotal";
            this.lbl_eltotal.Size = new System.Drawing.Size(45, 13);
            this.lbl_eltotal.TabIndex = 227;
            this.lbl_eltotal.Text = "Total: Q";
            // 
            // lbl_tot
            // 
            this.lbl_tot.AutoSize = true;
            this.lbl_tot.Location = new System.Drawing.Point(319, 454);
            this.lbl_tot.Name = "lbl_tot";
            this.lbl_tot.Size = new System.Drawing.Size(0, 13);
            this.lbl_tot.TabIndex = 237;
            // 
            // txt_producto2
            // 
            this.txt_producto2.Location = new System.Drawing.Point(741, 313);
            this.txt_producto2.Name = "txt_producto2";
            this.txt_producto2.Size = new System.Drawing.Size(14, 20);
            this.txt_producto2.TabIndex = 238;
            this.txt_producto2.Tag = "id_producto";
            this.txt_producto2.Visible = false;
            // 
            // txt_cantidad2
            // 
            this.txt_cantidad2.Location = new System.Drawing.Point(741, 339);
            this.txt_cantidad2.Name = "txt_cantidad2";
            this.txt_cantidad2.Size = new System.Drawing.Size(14, 20);
            this.txt_cantidad2.TabIndex = 239;
            this.txt_cantidad2.Tag = "cantidad_factura";
            this.txt_cantidad2.Visible = false;
            // 
            // txt_precio2
            // 
            this.txt_precio2.Location = new System.Drawing.Point(741, 365);
            this.txt_precio2.Name = "txt_precio2";
            this.txt_precio2.Size = new System.Drawing.Size(14, 20);
            this.txt_precio2.TabIndex = 240;
            this.txt_precio2.Tag = "precio_factura";
            this.txt_precio2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 451);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(14, 20);
            this.textBox1.TabIndex = 241;
            this.textBox1.Tag = "total_enc_factura";
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(415, 451);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 20);
            this.textBox2.TabIndex = 242;
            this.textBox2.Tag = "estado";
            this.textBox2.Text = "ACTIVO";
            this.textBox2.Visible = false;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(496, 448);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 235;
            this.btn.Text = "Guardar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // frm_facturacion
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(772, 480);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_precio2);
            this.Controls.Add(this.txt_cantidad2);
            this.Controls.Add(this.txt_producto2);
            this.Controls.Add(this.lbl_tot);
            this.Controls.Add(this.lbl_eltotal);
            this.Controls.Add(this.dgv_detalle_factura);
            this.Controls.Add(this.gpb_detalle);
            this.Controls.Add(this.gpb_encabezado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.Name = "frm_facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.frm_facturacion_Load);
            this.groupBox2.ResumeLayout(false);
            this.gpb_encabezado.ResumeLayout(false);
            this.gpb_encabezado.PerformLayout();
            this.gpb_detalle.ResumeLayout(false);
            this.gpb_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_factura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.GroupBox gpb_encabezado;
        private System.Windows.Forms.GroupBox gpb_detalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cantidad1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_producto;
        private System.Windows.Forms.DataGridView dgv_detalle_factura;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label lbl_eltotal;
        private System.Windows.Forms.Label lbl_tot;
        private System.Windows.Forms.TextBox txt_producto2;
        private System.Windows.Forms.TextBox txt_cantidad2;
        private System.Windows.Forms.TextBox txt_precio2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_cliente;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_factura;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_precio1;
    }
}