namespace contrato_trabajo
{
    partial class frm_medio_distribucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_medio_distribucion));
            this.gpb_medio_distribucion = new System.Windows.Forms.GroupBox();
            this.txt_estado_medio = new System.Windows.Forms.TextBox();
            this.txt_nombre_medio = new System.Windows.Forms.TextBox();
            this.lbl_nombre_medio = new System.Windows.Forms.Label();
            this.txt_url_medio = new System.Windows.Forms.TextBox();
            this.lbl_url_medio = new System.Windows.Forms.Label();
            this.txt_correo_medio = new System.Windows.Forms.TextBox();
            this.txt_telefono_medio = new System.Windows.Forms.TextBox();
            this.lbl_telefono_medio = new System.Windows.Forms.Label();
            this.lbl_correo_medio = new System.Windows.Forms.Label();
            this.txt_lbl = new System.Windows.Forms.Label();
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
            this.gpb_medio_distribucion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_medio_distribucion
            // 
            this.gpb_medio_distribucion.Controls.Add(this.txt_estado_medio);
            this.gpb_medio_distribucion.Controls.Add(this.txt_nombre_medio);
            this.gpb_medio_distribucion.Controls.Add(this.lbl_nombre_medio);
            this.gpb_medio_distribucion.Controls.Add(this.txt_url_medio);
            this.gpb_medio_distribucion.Controls.Add(this.lbl_url_medio);
            this.gpb_medio_distribucion.Controls.Add(this.txt_correo_medio);
            this.gpb_medio_distribucion.Controls.Add(this.txt_telefono_medio);
            this.gpb_medio_distribucion.Controls.Add(this.lbl_telefono_medio);
            this.gpb_medio_distribucion.Controls.Add(this.lbl_correo_medio);
            this.gpb_medio_distribucion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_medio_distribucion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpb_medio_distribucion.Location = new System.Drawing.Point(7, 164);
            this.gpb_medio_distribucion.Name = "gpb_medio_distribucion";
            this.gpb_medio_distribucion.Size = new System.Drawing.Size(747, 122);
            this.gpb_medio_distribucion.TabIndex = 52;
            this.gpb_medio_distribucion.TabStop = false;
            this.gpb_medio_distribucion.Text = "Datos generales";
            // 
            // txt_estado_medio
            // 
            this.txt_estado_medio.Location = new System.Drawing.Point(6, 88);
            this.txt_estado_medio.Name = "txt_estado_medio";
            this.txt_estado_medio.Size = new System.Drawing.Size(29, 26);
            this.txt_estado_medio.TabIndex = 19;
            this.txt_estado_medio.TabStop = false;
            this.txt_estado_medio.Tag = "estado";
            this.txt_estado_medio.Text = "ACTIVO";
            this.txt_estado_medio.Visible = false;
            // 
            // txt_nombre_medio
            // 
            this.txt_nombre_medio.Location = new System.Drawing.Point(125, 23);
            this.txt_nombre_medio.MaxLength = 150;
            this.txt_nombre_medio.Name = "txt_nombre_medio";
            this.txt_nombre_medio.Size = new System.Drawing.Size(288, 26);
            this.txt_nombre_medio.TabIndex = 12;
            this.txt_nombre_medio.Tag = "nombre_medio";
            this.txt_nombre_medio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_medio_KeyPress);
            // 
            // lbl_nombre_medio
            // 
            this.lbl_nombre_medio.AutoSize = true;
            this.lbl_nombre_medio.Location = new System.Drawing.Point(56, 23);
            this.lbl_nombre_medio.Name = "lbl_nombre_medio";
            this.lbl_nombre_medio.Size = new System.Drawing.Size(72, 20);
            this.lbl_nombre_medio.TabIndex = 16;
            this.lbl_nombre_medio.Text = "Nombre:";
            // 
            // txt_url_medio
            // 
            this.txt_url_medio.Location = new System.Drawing.Point(509, 23);
            this.txt_url_medio.MaxLength = 250;
            this.txt_url_medio.Multiline = true;
            this.txt_url_medio.Name = "txt_url_medio";
            this.txt_url_medio.Size = new System.Drawing.Size(223, 89);
            this.txt_url_medio.TabIndex = 15;
            this.txt_url_medio.Tag = "url_medio";
            // 
            // lbl_url_medio
            // 
            this.lbl_url_medio.AutoSize = true;
            this.lbl_url_medio.Location = new System.Drawing.Point(472, 26);
            this.lbl_url_medio.Name = "lbl_url_medio";
            this.lbl_url_medio.Size = new System.Drawing.Size(32, 20);
            this.lbl_url_medio.TabIndex = 10;
            this.lbl_url_medio.Text = "Url:";
            // 
            // txt_correo_medio
            // 
            this.txt_correo_medio.Location = new System.Drawing.Point(125, 53);
            this.txt_correo_medio.MaxLength = 150;
            this.txt_correo_medio.Name = "txt_correo_medio";
            this.txt_correo_medio.Size = new System.Drawing.Size(288, 26);
            this.txt_correo_medio.TabIndex = 13;
            this.txt_correo_medio.Tag = "correo_medio";
            this.txt_correo_medio.Leave += new System.EventHandler(this.txt_correo_medio_Leave);
            // 
            // txt_telefono_medio
            // 
            this.txt_telefono_medio.Location = new System.Drawing.Point(125, 88);
            this.txt_telefono_medio.MaxLength = 20;
            this.txt_telefono_medio.Name = "txt_telefono_medio";
            this.txt_telefono_medio.Size = new System.Drawing.Size(288, 26);
            this.txt_telefono_medio.TabIndex = 14;
            this.txt_telefono_medio.Tag = "telefono_medio";
            this.txt_telefono_medio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_medio_KeyPress);
            // 
            // lbl_telefono_medio
            // 
            this.lbl_telefono_medio.AutoSize = true;
            this.lbl_telefono_medio.Location = new System.Drawing.Point(51, 88);
            this.lbl_telefono_medio.Name = "lbl_telefono_medio";
            this.lbl_telefono_medio.Size = new System.Drawing.Size(75, 20);
            this.lbl_telefono_medio.TabIndex = 1;
            this.lbl_telefono_medio.Text = "Telefono:";
            // 
            // lbl_correo_medio
            // 
            this.lbl_correo_medio.AutoSize = true;
            this.lbl_correo_medio.Location = new System.Drawing.Point(63, 56);
            this.lbl_correo_medio.Name = "lbl_correo_medio";
            this.lbl_correo_medio.Size = new System.Drawing.Size(65, 20);
            this.lbl_correo_medio.TabIndex = 0;
            this.lbl_correo_medio.Text = "Correo:";
            // 
            // txt_lbl
            // 
            this.txt_lbl.AutoSize = true;
            this.txt_lbl.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_lbl.Location = new System.Drawing.Point(243, 10);
            this.txt_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_lbl.Name = "txt_lbl";
            this.txt_lbl.Size = new System.Drawing.Size(262, 34);
            this.txt_lbl.TabIndex = 51;
            this.txt_lbl.Text = "Medio de Difusion";
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
            this.groupBox2.Location = new System.Drawing.Point(44, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 106);
            this.groupBox2.TabIndex = 50;
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
            this.btn_reporte.Location = new System.Drawing.Point(513, 10);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(86, 89);
            this.btn_reporte.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btn_reporte, "Reporte");
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.button1_Click);
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
            this.btn_ultimo.Location = new System.Drawing.Point(641, 56);
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
            this.btn_primero.Location = new System.Drawing.Point(605, 56);
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
            this.btn_siguiente.Location = new System.Drawing.Point(641, 19);
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
            this.btn_anterior.Location = new System.Drawing.Point(605, 19);
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
            // frm_medio_distribucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(762, 298);
            this.Controls.Add(this.gpb_medio_distribucion);
            this.Controls.Add(this.txt_lbl);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_medio_distribucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medio de Difusion";
            this.Load += new System.EventHandler(this.frm_medio_distribucion_Load);
            this.gpb_medio_distribucion.ResumeLayout(false);
            this.gpb_medio_distribucion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_medio_distribucion;
        private System.Windows.Forms.TextBox txt_nombre_medio;
        private System.Windows.Forms.Label lbl_nombre_medio;
        private System.Windows.Forms.TextBox txt_url_medio;
        private System.Windows.Forms.Label lbl_url_medio;
        private System.Windows.Forms.TextBox txt_correo_medio;
        private System.Windows.Forms.TextBox txt_telefono_medio;
        private System.Windows.Forms.Label lbl_telefono_medio;
        private System.Windows.Forms.Label lbl_correo_medio;
        private System.Windows.Forms.Label txt_lbl;
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
        private System.Windows.Forms.TextBox txt_estado_medio;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}