namespace Inventario
{
    partial class FormDevolucionCompra
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
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_añadir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_bodega = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_apellido_cliente = new System.Windows.Forms.TextBox();
            this.txt_nom_cliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_fecha_dev = new System.Windows.Forms.DateTimePicker();
            this.dgw_requisicion = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cant_devuelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_requisicion)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(357, 490);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(137, 23);
            this.btn_crear.TabIndex = 27;
            this.btn_crear.Text = "Crear";
            this.toolTip1.SetToolTip(this.btn_crear, "generar devolución sobre compra");
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Location = new System.Drawing.Point(435, 448);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(201, 23);
            this.btn_quitar.TabIndex = 26;
            this.btn_quitar.Text = "Quitar";
            this.toolTip1.SetToolTip(this.btn_quitar, "quitar producto");
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_añadir
            // 
            this.btn_añadir.Location = new System.Drawing.Point(194, 448);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(201, 23);
            this.btn_añadir.TabIndex = 25;
            this.btn_añadir.Text = "Añadir";
            this.toolTip1.SetToolTip(this.btn_añadir, "Añadir producto");
            this.btn_añadir.UseVisualStyleBackColor = true;
            this.btn_añadir.Click += new System.EventHandler(this.btn_añadir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nit);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbo_bodega);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_apellido_cliente);
            this.groupBox1.Controls.Add(this.txt_nom_cliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(26, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 180);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de  factura";
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(170, 25);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(253, 20);
            this.txt_nit.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "NIT:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(170, 110);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(253, 20);
            this.txt_direccion.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dirección:";
            // 
            // cbo_bodega
            // 
            this.cbo_bodega.FormattingEnabled = true;
            this.cbo_bodega.Location = new System.Drawing.Point(170, 141);
            this.cbo_bodega.Name = "cbo_bodega";
            this.cbo_bodega.Size = new System.Drawing.Size(253, 21);
            this.cbo_bodega.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Venta de bodega:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nombres:";
            // 
            // txt_apellido_cliente
            // 
            this.txt_apellido_cliente.Location = new System.Drawing.Point(307, 74);
            this.txt_apellido_cliente.Name = "txt_apellido_cliente";
            this.txt_apellido_cliente.Size = new System.Drawing.Size(116, 20);
            this.txt_apellido_cliente.TabIndex = 3;
            // 
            // txt_nom_cliente
            // 
            this.txt_nom_cliente.Location = new System.Drawing.Point(170, 74);
            this.txt_nom_cliente.Name = "txt_nom_cliente";
            this.txt_nom_cliente.Size = new System.Drawing.Size(116, 20);
            this.txt_nom_cliente.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha:";
            // 
            // dtp_fecha_dev
            // 
            this.dtp_fecha_dev.Location = new System.Drawing.Point(587, 17);
            this.dtp_fecha_dev.Name = "dtp_fecha_dev";
            this.dtp_fecha_dev.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_dev.TabIndex = 22;
            // 
            // dgw_requisicion
            // 
            this.dgw_requisicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_requisicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Cant_devuelta,
            this.Precio_prod});
            this.dgw_requisicion.Location = new System.Drawing.Point(20, 241);
            this.dgw_requisicion.Name = "dgw_requisicion";
            this.dgw_requisicion.Size = new System.Drawing.Size(761, 159);
            this.dgw_requisicion.TabIndex = 21;
            this.dgw_requisicion.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_requisicion_CellValueChanged);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "CODIGO";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MaxDropDownItems = 100;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Descripcion.Width = 275;
            // 
            // Cant_devuelta
            // 
            this.Cant_devuelta.HeaderText = "Cantidad ";
            this.Cant_devuelta.Name = "Cant_devuelta";
            this.Cant_devuelta.ToolTipText = "cantidad del producto seleccionado que ingresará";
            // 
            // Precio_prod
            // 
            this.Precio_prod.HeaderText = "Precio";
            this.Precio_prod.Name = "Precio_prod";
            this.Precio_prod.Width = 250;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(546, 403);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 20);
            this.lbl_total.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Valor total de la factura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(513, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Q.";
            // 
            // FormDevolucionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 516);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_añadir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_fecha_dev);
            this.Controls.Add(this.dgw_requisicion);
            this.Name = "FormDevolucionCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar factura";
            this.Load += new System.EventHandler(this.FormDevolucionCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_requisicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_añadir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_bodega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_fecha_dev;
        private System.Windows.Forms.DataGridView dgw_requisicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txt_nom_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_apellido_cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_devuelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_prod;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}