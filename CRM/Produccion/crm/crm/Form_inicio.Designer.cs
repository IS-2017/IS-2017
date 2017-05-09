namespace crm
{
    partial class Form_inicio
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            this.tile = new DevExpress.XtraEditors.TileControl();
            this.Grupo1 = new DevExpress.XtraEditors.TileGroup();
            this.item_negocios = new DevExpress.XtraEditors.TileItem();
            this.item_contactos = new DevExpress.XtraEditors.TileItem();
            this.item_calendario = new DevExpress.XtraEditors.TileItem();
            this.itemcasos = new DevExpress.XtraEditors.TileItem();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.item_clientes = new DevExpress.XtraEditors.TileItem();
            this.item_personal = new DevExpress.XtraEditors.TileItem();
            this.item_pronosticos = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.item_productos = new DevExpress.XtraEditors.TileItem();
            this.item_ventas = new DevExpress.XtraEditors.TileItem();
            this.item_cobros = new DevExpress.XtraEditors.TileItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tile
            // 
            this.tile.AppearanceItem.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tile.AppearanceItem.Hovered.Options.UseFont = true;
            this.tile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile.DragSize = new System.Drawing.Size(0, 0);
            this.tile.Groups.Add(this.Grupo1);
            this.tile.Groups.Add(this.tileGroup2);
            this.tile.Groups.Add(this.tileGroup3);
            this.tile.ItemSize = 130;
            this.tile.Location = new System.Drawing.Point(0, 0);
            this.tile.MaxId = 26;
            this.tile.Name = "tile";
            this.tile.SelectionColor = System.Drawing.Color.LightSkyBlue;
            this.tile.Size = new System.Drawing.Size(1033, 634);
            this.tile.TabIndex = 0;
            this.tile.Text = "tileControl1";
            // 
            // Grupo1
            // 
            this.Grupo1.Items.Add(this.item_negocios);
            this.Grupo1.Items.Add(this.item_contactos);
            this.Grupo1.Items.Add(this.item_calendario);
            this.Grupo1.Items.Add(this.itemcasos);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Text = "grupo1";
            // 
            // item_negocios
            // 
            this.item_negocios.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.item_negocios.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.item_negocios.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.item_negocios.AppearanceItem.Hovered.Options.UseBorderColor = true;
            this.item_negocios.AppearanceItem.Normal.BackColor = System.Drawing.Color.Teal;
            this.item_negocios.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Teal;
            this.item_negocios.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.item_negocios.AppearanceItem.Normal.Options.UseBackColor = true;
            this.item_negocios.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.item_negocios.AppearanceItem.Normal.Options.UseFont = true;
            this.item_negocios.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.item_negocios.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "Negocios";
            this.item_negocios.Elements.Add(tileItemElement1);
            this.item_negocios.Id = 14;
            this.item_negocios.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.item_negocios.Name = "item_negocios";
            this.item_negocios.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.item_negocios_ItemClick);
            // 
            // item_contactos
            // 
            this.item_contactos.AppearanceItem.Normal.BackColor = System.Drawing.Color.Yellow;
            this.item_contactos.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Yellow;
            this.item_contactos.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.item_contactos.AppearanceItem.Normal.Options.UseBackColor = true;
            this.item_contactos.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.item_contactos.AppearanceItem.Normal.Options.UseFont = true;
            this.item_contactos.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.item_contactos.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement2.Text = "Contactos";
            this.item_contactos.Elements.Add(tileItemElement2);
            this.item_contactos.Id = 15;
            this.item_contactos.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.item_contactos.Name = "item_contactos";
            this.item_contactos.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.item_contactos_ItemClick);
            // 
            // item_calendario
            // 
            this.item_calendario.AppearanceItem.Normal.BackColor = System.Drawing.Color.Peru;
            this.item_calendario.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Peru;
            this.item_calendario.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.item_calendario.AppearanceItem.Normal.Options.UseBackColor = true;
            this.item_calendario.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.item_calendario.AppearanceItem.Normal.Options.UseFont = true;
            this.item_calendario.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.item_calendario.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement3.Text = "Calendario";
            this.item_calendario.Elements.Add(tileItemElement3);
            this.item_calendario.Id = 16;
            this.item_calendario.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.item_calendario.Name = "item_calendario";
            this.item_calendario.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.item_calendario_ItemClick);
            // 
            // itemcasos
            // 
            this.itemcasos.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.itemcasos.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.itemcasos.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemcasos.AppearanceItem.Normal.Options.UseBackColor = true;
            this.itemcasos.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.itemcasos.AppearanceItem.Normal.Options.UseFont = true;
            this.itemcasos.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.itemcasos.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement4.Text = "Casos";
            this.itemcasos.Elements.Add(tileItemElement4);
            this.itemcasos.Id = 23;
            this.itemcasos.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.itemcasos.Name = "itemcasos";
            this.itemcasos.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.itemcasos_ItemClick);
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.item_clientes);
            this.tileGroup2.Items.Add(this.item_personal);
            this.tileGroup2.Items.Add(this.item_pronosticos);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // item_clientes
            // 
            this.item_clientes.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkOrchid;
            this.item_clientes.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkOrchid;
            this.item_clientes.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.item_clientes.AppearanceItem.Normal.Options.UseBackColor = true;
            this.item_clientes.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.item_clientes.AppearanceItem.Normal.Options.UseFont = true;
            this.item_clientes.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.item_clientes.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement5.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement5.Text = "Clientes";
            this.item_clientes.Elements.Add(tileItemElement5);
            this.item_clientes.Id = 9;
            this.item_clientes.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.item_clientes.Name = "item_clientes";
            this.item_clientes.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.item_clientes_ItemClick);
            // 
            // item_personal
            // 
            this.item_personal.AppearanceItem.Hovered.BackColor = System.Drawing.Color.Red;
            this.item_personal.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.Red;
            this.item_personal.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.item_personal.AppearanceItem.Hovered.Options.UseBorderColor = true;
            this.item_personal.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray;
            this.item_personal.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray;
            this.item_personal.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.item_personal.AppearanceItem.Normal.Options.UseBackColor = true;
            this.item_personal.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.item_personal.AppearanceItem.Normal.Options.UseFont = true;
            this.item_personal.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.item_personal.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement6.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement6.Text = "Personal";
            this.item_personal.Elements.Add(tileItemElement6);
            this.item_personal.Id = 17;
            this.item_personal.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.item_personal.Name = "item_personal";
            this.item_personal.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.item_personal_ItemClick);
            // 
            // item_pronosticos
            // 
            this.item_pronosticos.AppearanceItem.Normal.BackColor = System.Drawing.Color.OrangeRed;
            this.item_pronosticos.AppearanceItem.Normal.BorderColor = System.Drawing.Color.OrangeRed;
            this.item_pronosticos.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.item_pronosticos.AppearanceItem.Normal.Options.UseBackColor = true;
            this.item_pronosticos.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.item_pronosticos.AppearanceItem.Normal.Options.UseFont = true;
            this.item_pronosticos.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.item_pronosticos.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement7.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement7.Text = "Pronosticos";
            this.item_pronosticos.Elements.Add(tileItemElement7);
            this.item_pronosticos.Id = 18;
            this.item_pronosticos.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.item_pronosticos.Name = "item_pronosticos";
            this.item_pronosticos.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.item_pronosticos_ItemClick);
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.item_productos);
            this.tileGroup3.Items.Add(this.item_ventas);
            this.tileGroup3.Items.Add(this.item_cobros);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // item_productos
            // 
            this.item_productos.AppearanceItem.Normal.BackColor = System.Drawing.Color.Red;
            this.item_productos.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Red;
            this.item_productos.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.item_productos.AppearanceItem.Normal.Options.UseBackColor = true;
            this.item_productos.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.item_productos.AppearanceItem.Normal.Options.UseFont = true;
            this.item_productos.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.item_productos.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement8.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement8.Text = "Productos";
            this.item_productos.Elements.Add(tileItemElement8);
            this.item_productos.Id = 20;
            this.item_productos.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.item_productos.Name = "item_productos";
            this.item_productos.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.item_productos_ItemClick);
            // 
            // item_ventas
            // 
            this.item_ventas.AppearanceItem.Normal.BackColor = System.Drawing.Color.Turquoise;
            this.item_ventas.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Turquoise;
            this.item_ventas.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.item_ventas.AppearanceItem.Normal.Options.UseBackColor = true;
            this.item_ventas.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.item_ventas.AppearanceItem.Normal.Options.UseFont = true;
            this.item_ventas.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.item_ventas.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement9.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement9.Text = "Ventas";
            this.item_ventas.Elements.Add(tileItemElement9);
            this.item_ventas.Id = 21;
            this.item_ventas.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.item_ventas.Name = "item_ventas";
            this.item_ventas.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.item_ventas_ItemClick);
            // 
            // item_cobros
            // 
            this.item_cobros.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.item_cobros.AppearanceItem.Normal.Options.UseFont = true;
            this.item_cobros.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.item_cobros.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement10.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement10.Text = "Cobros";
            this.item_cobros.Elements.Add(tileItemElement10);
            this.item_cobros.Id = 25;
            this.item_cobros.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.item_cobros.Name = "item_cobros";
            this.item_cobros.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.item_cobros_ItemClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CRM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(451, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estadisticas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(794, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Otros";
            // 
            // Form_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 634);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tile);
            this.Name = "Form_inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form_inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tile;
        private DevExpress.XtraEditors.TileGroup Grupo1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem item_clientes;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem item_negocios;
        private DevExpress.XtraEditors.TileItem item_contactos;
        private DevExpress.XtraEditors.TileItem item_calendario;
        private DevExpress.XtraEditors.TileItem item_personal;
        private DevExpress.XtraEditors.TileItem item_pronosticos;
        private DevExpress.XtraEditors.TileItem item_productos;
        private DevExpress.XtraEditors.TileItem item_ventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TileItem itemcasos;
        private DevExpress.XtraEditors.TileItem item_cobros;
    }
}