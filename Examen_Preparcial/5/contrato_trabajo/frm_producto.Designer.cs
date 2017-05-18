namespace contrato_trabajo
{
    partial class frm_producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_producto));
            this.gpb_proveedor = new System.Windows.Forms.GroupBox();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.cbo_proveedor = new System.Windows.Forms.ComboBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.gpb_proveedor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_proveedor
            // 
            this.gpb_proveedor.Controls.Add(this.lbl_proveedor);
            this.gpb_proveedor.Controls.Add(this.txt_proveedor);
            this.gpb_proveedor.Controls.Add(this.cbo_proveedor);
            this.gpb_proveedor.Controls.Add(this.txt_estado);
            this.gpb_proveedor.Controls.Add(this.txt_nombre);
            this.gpb_proveedor.Controls.Add(this.label4);
            this.gpb_proveedor.Controls.Add(this.txt_precio);
            this.gpb_proveedor.Controls.Add(this.txt_costo);
            this.gpb_proveedor.Controls.Add(this.label7);
            this.gpb_proveedor.Controls.Add(this.label6);
            this.gpb_proveedor.Controls.Add(this.txt_cantidad);
            this.gpb_proveedor.Controls.Add(this.label1);
            this.gpb_proveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_proveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpb_proveedor.Location = new System.Drawing.Point(13, 158);
            this.gpb_proveedor.Name = "gpb_proveedor";
            this.gpb_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gpb_proveedor.Size = new System.Drawing.Size(752, 142);
            this.gpb_proveedor.TabIndex = 52;
            this.gpb_proveedor.TabStop = false;
            this.gpb_proveedor.Text = "Datos generales";
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Location = new System.Drawing.Point(28, 91);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(93, 20);
            this.lbl_proveedor.TabIndex = 22;
            this.lbl_proveedor.Text = "proveedor:";
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Location = new System.Drawing.Point(419, 89);
            this.txt_proveedor.MaxLength = 11;
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Size = new System.Drawing.Size(21, 26);
            this.txt_proveedor.TabIndex = 11;
            this.txt_proveedor.Tag = "id_proveedor";
            this.txt_proveedor.Visible = false;
            // 
            // cbo_proveedor
            // 
            this.cbo_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_proveedor.FormattingEnabled = true;
            this.cbo_proveedor.ItemHeight = 20;
            this.cbo_proveedor.Location = new System.Drawing.Point(125, 89);
            this.cbo_proveedor.Name = "cbo_proveedor";
            this.cbo_proveedor.Size = new System.Drawing.Size(288, 28);
            this.cbo_proveedor.TabIndex = 13;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(419, 25);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(39, 26);
            this.txt_estado.TabIndex = 19;
            this.txt_estado.TabStop = false;
            this.txt_estado.Tag = "estado";
            this.txt_estado.Text = "ACTIVO";
            this.txt_estado.Visible = false;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(125, 26);
            this.txt_nombre.MaxLength = 100;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(288, 26);
            this.txt_nombre.TabIndex = 12;
            this.txt_nombre.TabStop = false;
            this.txt_nombre.Tag = "nombre_producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre:";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(516, 59);
            this.txt_precio.MaxLength = 11;
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(205, 26);
            this.txt_precio.TabIndex = 16;
            this.txt_precio.Tag = "precio_producto";
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(516, 26);
            this.txt_costo.MaxLength = 11;
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(206, 26);
            this.txt_costo.TabIndex = 15;
            this.txt_costo.Tag = "costo_producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Costo:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(125, 56);
            this.txt_cantidad.MaxLength = 8;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(288, 26);
            this.txt_cantidad.TabIndex = 13;
            this.txt_cantidad.Tag = "cantidad_producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad:";
            // 
            // txt_lbl
            // 
            this.txt_lbl.AutoSize = true;
            this.txt_lbl.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_lbl.Location = new System.Drawing.Point(331, 9);
            this.txt_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_lbl.Name = "txt_lbl";
            this.txt_lbl.Size = new System.Drawing.Size(140, 34);
            this.txt_lbl.TabIndex = 51;
            this.txt_lbl.Text = "Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(50, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 106);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navegador";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::contrato_trabajo.Properties.Resources.imprimir;
            this.button1.Location = new System.Drawing.Point(604, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 89);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // frm_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(774, 314);
            this.Controls.Add(this.gpb_proveedor);
            this.Controls.Add(this.txt_lbl);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "frm_producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frm_producto_Load);
            this.gpb_proveedor.ResumeLayout(false);
            this.gpb_proveedor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_proveedor;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.TextBox txt_proveedor;
        private System.Windows.Forms.ComboBox cbo_proveedor;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.ToolTip toolTip1;
    }
}