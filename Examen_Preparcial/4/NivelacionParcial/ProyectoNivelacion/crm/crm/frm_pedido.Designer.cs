namespace crm
{
    partial class frm_pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pedido));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_encabezado = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_encargado = new System.Windows.Forms.TextBox();
            this.dgv_detalle_bd = new System.Windows.Forms.DataGridView();
            this.CategoriaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaPrimaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedidaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProcesoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas_hombreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_producto = new System.Windows.Forms.ComboBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.dgv_detalle_usuario = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_proveedor = new System.Windows.Forms.ComboBox();
            this.prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telprov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_ultimo);
            this.panel1.Controls.Add(this.btn_actualizar);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.btn_primero);
            this.panel1.Controls.Add(this.btn_anterior);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_siguiente);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(102, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 98);
            this.panel1.TabIndex = 206;
            // 
            // lbl_encabezado
            // 
            this.lbl_encabezado.AutoSize = true;
            this.lbl_encabezado.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_encabezado.Location = new System.Drawing.Point(702, 20);
            this.lbl_encabezado.Name = "lbl_encabezado";
            this.lbl_encabezado.Size = new System.Drawing.Size(47, 16);
            this.lbl_encabezado.TabIndex = 205;
            this.lbl_encabezado.Text = "label12";
            this.lbl_encabezado.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(580, 20);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(96, 16);
            this.lbl_id.TabIndex = 204;
            this.lbl_id.Text = "id_encabezado";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(17, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(13, 16);
            this.button1.TabIndex = 202;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_quitar
            // 
            this.btn_quitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quitar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_quitar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar.Location = new System.Drawing.Point(430, 245);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(56, 46);
            this.btn_quitar.TabIndex = 193;
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 201;
            this.label7.Text = "Encargado:";
            // 
            // txt_encargado
            // 
            this.txt_encargado.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_encargado.Location = new System.Drawing.Point(253, 164);
            this.txt_encargado.Name = "txt_encargado";
            this.txt_encargado.Size = new System.Drawing.Size(100, 20);
            this.txt_encargado.TabIndex = 185;
            // 
            // dgv_detalle_bd
            // 
            this.dgv_detalle_bd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle_bd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoriaID,
            this.MateriaPrimaID,
            this.CantidadID,
            this.MedidaID,
            this.TipoProcesoID,
            this.horas_hombreID,
            this.CostoID});
            this.dgv_detalle_bd.Location = new System.Drawing.Point(797, 24);
            this.dgv_detalle_bd.Name = "dgv_detalle_bd";
            this.dgv_detalle_bd.Size = new System.Drawing.Size(10, 12);
            this.dgv_detalle_bd.TabIndex = 200;
            this.dgv_detalle_bd.Visible = false;
            // 
            // CategoriaID
            // 
            this.CategoriaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CategoriaID.HeaderText = "Categoria";
            this.CategoriaID.Name = "CategoriaID";
            this.CategoriaID.Width = 77;
            // 
            // MateriaPrimaID
            // 
            this.MateriaPrimaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MateriaPrimaID.HeaderText = "Materia Prima";
            this.MateriaPrimaID.Name = "MateriaPrimaID";
            this.MateriaPrimaID.Width = 96;
            // 
            // CantidadID
            // 
            this.CantidadID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CantidadID.HeaderText = "Cantidad";
            this.CantidadID.Name = "CantidadID";
            this.CantidadID.Width = 74;
            // 
            // MedidaID
            // 
            this.MedidaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MedidaID.HeaderText = "Medida";
            this.MedidaID.Name = "MedidaID";
            this.MedidaID.Width = 67;
            // 
            // TipoProcesoID
            // 
            this.TipoProcesoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TipoProcesoID.HeaderText = "Tipo de Proceso";
            this.TipoProcesoID.Name = "TipoProcesoID";
            this.TipoProcesoID.Width = 101;
            // 
            // horas_hombreID
            // 
            this.horas_hombreID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.horas_hombreID.HeaderText = "Horas Hombre";
            this.horas_hombreID.Name = "horas_hombreID";
            this.horas_hombreID.Width = 92;
            // 
            // CostoID
            // 
            this.CostoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CostoID.HeaderText = "Costo";
            this.CostoID.Name = "CostoID";
            this.CostoID.Width = 59;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(387, 454);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 195;
            this.btn_aceptar.Text = "Aceptar\r\n";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 28);
            this.label5.TabIndex = 197;
            this.label5.Text = "Nuevo Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 199;
            this.label3.Text = "Producto:";
            // 
            // cmb_producto
            // 
            this.cmb_producto.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_producto.FormattingEnabled = true;
            this.cmb_producto.Location = new System.Drawing.Point(572, 156);
            this.cmb_producto.Name = "cmb_producto";
            this.cmb_producto.Size = new System.Drawing.Size(121, 23);
            this.cmb_producto.TabIndex = 187;
            this.cmb_producto.Tag = "Categoria";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(283, 208);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(70, 20);
            this.txt_cantidad.TabIndex = 189;
            this.txt_cantidad.Tag = "Cantidad";
            // 
            // dgv_detalle_usuario
            // 
            this.dgv_detalle_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoria,
            this.MateriaPrima,
            this.Cantidad,
            this.prov,
            this.telprov});
            this.dgv_detalle_usuario.Location = new System.Drawing.Point(217, 311);
            this.dgv_detalle_usuario.Name = "dgv_detalle_usuario";
            this.dgv_detalle_usuario.Size = new System.Drawing.Size(459, 137);
            this.dgv_detalle_usuario.TabIndex = 194;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(356, 245);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(49, 46);
            this.btn_agregar.TabIndex = 192;
            this.btn_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 186;
            this.label2.Text = "Cantidad: ";
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
            this.btn_nuevo.Location = new System.Drawing.Point(27, 21);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(65, 69);
            this.btn_nuevo.TabIndex = 171;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(399, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 69);
            this.button2.TabIndex = 176;
            this.button2.UseVisualStyleBackColor = true;
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
            this.btn_ultimo.Location = new System.Drawing.Point(592, 54);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(33, 36);
            this.btn_ultimo.TabIndex = 181;
            this.btn_ultimo.UseVisualStyleBackColor = true;
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
            this.btn_actualizar.Location = new System.Drawing.Point(470, 18);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(65, 69);
            this.btn_actualizar.TabIndex = 177;
            this.btn_actualizar.UseVisualStyleBackColor = true;
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
            this.btn_guardar.Location = new System.Drawing.Point(115, 18);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 69);
            this.btn_guardar.TabIndex = 172;
            this.btn_guardar.UseVisualStyleBackColor = true;
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
            this.btn_buscar.Location = new System.Drawing.Point(328, 18);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(65, 69);
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
            this.btn_primero.Location = new System.Drawing.Point(556, 54);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(33, 36);
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
            this.btn_anterior.Location = new System.Drawing.Point(556, 17);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(33, 36);
            this.btn_anterior.TabIndex = 178;
            this.btn_anterior.UseVisualStyleBackColor = true;
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
            this.btn_editar.Location = new System.Drawing.Point(186, 18);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(65, 69);
            this.btn_editar.TabIndex = 173;
            this.btn_editar.UseVisualStyleBackColor = true;
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
            this.btn_eliminar.Location = new System.Drawing.Point(257, 18);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(65, 69);
            this.btn_eliminar.TabIndex = 174;
            this.btn_eliminar.UseVisualStyleBackColor = true;
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
            this.btn_siguiente.Location = new System.Drawing.Point(592, 17);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(33, 36);
            this.btn_siguiente.TabIndex = 179;
            this.btn_siguiente.UseVisualStyleBackColor = true;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Categoria.HeaderText = "Cantidad";
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 74;
            // 
            // MateriaPrima
            // 
            this.MateriaPrima.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MateriaPrima.HeaderText = "Producto";
            this.MateriaPrima.Name = "MateriaPrima";
            this.MateriaPrima.Width = 75;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad.HeaderText = "Precio";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 208;
            this.label1.Text = "Proveedor:";
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_proveedor.FormattingEnabled = true;
            this.cmb_proveedor.Location = new System.Drawing.Point(572, 205);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Size = new System.Drawing.Size(121, 23);
            this.cmb_proveedor.TabIndex = 207;
            this.cmb_proveedor.Tag = "Categoria";
            // 
            // prov
            // 
            this.prov.HeaderText = "Proveedor";
            this.prov.Name = "prov";
            // 
            // telprov
            // 
            this.telprov.HeaderText = "Telefono de proveedor";
            this.telprov.Name = "telprov";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(737, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(113, 87);
            this.dataGridView1.TabIndex = 209;
            // 
            // frm_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 507);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_proveedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_encabezado);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_encargado);
            this.Controls.Add(this.dgv_detalle_bd);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_producto);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.dgv_detalle_usuario);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label2);
            this.Name = "frm_pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.frm_pedido_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Label lbl_encabezado;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_encargado;
        private System.Windows.Forms.DataGridView dgv_detalle_bd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaPrimaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedidaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProcesoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas_hombreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoID;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.DataGridView dgv_detalle_usuario;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn telprov;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}