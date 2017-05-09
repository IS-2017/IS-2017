namespace crm
{
    partial class FormNegociaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNegociaciones));
            this.dgv_negocios = new DevExpress.XtraGrid.GridControl();
            this.dgv_neg = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.pag_lista = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pag_estado = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.tileBar3 = new DevExpress.XtraBars.Navigation.TileBar();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.tileBar2 = new DevExpress.XtraBars.Navigation.TileBar();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.grupo_preparacion = new DevExpress.XtraEditors.GroupControl();
            this.tileBar0 = new DevExpress.XtraBars.Navigation.TileBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clie = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_normal = new DevExpress.XtraEditors.SimpleButton();
            this.ddb_clientes = new DevExpress.XtraEditors.DropDownButton();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.btn_empresa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_negocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_neg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.pag_lista.SuspendLayout();
            this.pag_estado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupo_preparacion)).BeginInit();
            this.grupo_preparacion.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_negocios
            // 
            this.dgv_negocios.Location = new System.Drawing.Point(0, 54);
            this.dgv_negocios.MainView = this.dgv_neg;
            this.dgv_negocios.Name = "dgv_negocios";
            this.dgv_negocios.Size = new System.Drawing.Size(947, 412);
            this.dgv_negocios.TabIndex = 0;
            this.dgv_negocios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_neg});
            this.dgv_negocios.Click += new System.EventHandler(this.dgv_negocios_Click);
            this.dgv_negocios.DoubleClick += new System.EventHandler(this.dgv_negocios_DoubleClick);
            // 
            // dgv_neg
            // 
            this.dgv_neg.GridControl = this.dgv_negocios;
            this.dgv_neg.Name = "dgv_neg";
            this.dgv_neg.OptionsView.ShowFooter = true;
            this.dgv_neg.OptionsView.ShowGroupPanel = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(783, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 2;
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.pag_lista);
            this.navigationPane1.Controls.Add(this.pag_estado);
            this.navigationPane1.Location = new System.Drawing.Point(1, 65);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pag_lista,
            this.pag_estado});
            this.navigationPane1.RegularSize = new System.Drawing.Size(1013, 526);
            this.navigationPane1.SelectedPage = this.pag_estado;
            this.navigationPane1.SelectedPageIndex = 0;
            this.navigationPane1.Size = new System.Drawing.Size(1013, 526);
            this.navigationPane1.TabIndex = 4;
            this.navigationPane1.Text = "Negociaciones";
            // 
            // pag_lista
            // 
            this.pag_lista.Caption = "Lista";
            this.pag_lista.Controls.Add(this.popupControlContainer1);
            this.pag_lista.Controls.Add(this.ddb_clientes);
            this.pag_lista.Controls.Add(this.btn_normal);
            this.pag_lista.Controls.Add(this.btn_cat);
            this.pag_lista.Controls.Add(this.label1);
            this.pag_lista.Controls.Add(this.dgv_negocios);
            this.pag_lista.Image = ((System.Drawing.Image)(resources.GetObject("pag_lista.Image")));
            this.pag_lista.Name = "pag_lista";
            this.pag_lista.PageText = "";
            this.pag_lista.Size = new System.Drawing.Size(947, 466);
            // 
            // pag_estado
            // 
            this.pag_estado.Caption = "Estado";
            this.pag_estado.Controls.Add(this.groupControl5);
            this.pag_estado.Controls.Add(this.groupControl3);
            this.pag_estado.Controls.Add(this.groupControl2);
            this.pag_estado.Controls.Add(this.grupo_preparacion);
            this.pag_estado.Image = ((System.Drawing.Image)(resources.GetObject("pag_estado.Image")));
            this.pag_estado.Name = "pag_estado";
            this.pag_estado.Size = new System.Drawing.Size(947, 466);
            // 
            // groupControl5
            // 
            this.groupControl5.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl5.CaptionImage")));
            this.groupControl5.Controls.Add(this.tileBar3);
            this.groupControl5.Controls.Add(this.groupControl6);
            this.groupControl5.Location = new System.Drawing.Point(711, 3);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(230, 459);
            this.groupControl5.TabIndex = 5;
            this.groupControl5.Text = "Cierre y acuerdo";
            // 
            // tileBar3
            // 
            this.tileBar3.AllowDrag = false;
            this.tileBar3.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar3.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBar3.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar3.ItemSize = 80;
            this.tileBar3.Location = new System.Drawing.Point(5, 37);
            this.tileBar3.Name = "tileBar3";
            this.tileBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileBar3.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar3.Size = new System.Drawing.Size(220, 417);
            this.tileBar3.TabIndex = 5;
            this.tileBar3.Text = "tileBar4";
            // 
            // groupControl6
            // 
            this.groupControl6.Location = new System.Drawing.Point(236, 0);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(230, 239);
            this.groupControl6.TabIndex = 4;
            this.groupControl6.Text = "groupControl6";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImage")));
            this.groupControl3.Controls.Add(this.tileBar2);
            this.groupControl3.Controls.Add(this.groupControl4);
            this.groupControl3.Location = new System.Drawing.Point(475, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(230, 460);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Propuesta realizada";
            // 
            // tileBar2
            // 
            this.tileBar2.AllowDrag = false;
            this.tileBar2.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar2.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBar2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar2.ItemSize = 80;
            this.tileBar2.Location = new System.Drawing.Point(5, 37);
            this.tileBar2.Name = "tileBar2";
            this.tileBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileBar2.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar2.Size = new System.Drawing.Size(220, 417);
            this.tileBar2.TabIndex = 2;
            this.tileBar2.Text = "tileBar3";
            // 
            // groupControl4
            // 
            this.groupControl4.Location = new System.Drawing.Point(236, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(230, 239);
            this.groupControl4.TabIndex = 4;
            this.groupControl4.Text = "groupControl4";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.tileBar1);
            this.groupControl2.Location = new System.Drawing.Point(239, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(230, 459);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Discusión";
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.ItemSize = 80;
            this.tileBar1.Location = new System.Drawing.Point(5, 37);
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(220, 417);
            this.tileBar1.TabIndex = 1;
            this.tileBar1.Text = "tileBar2";
            // 
            // grupo_preparacion
            // 
            this.grupo_preparacion.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo_preparacion.AppearanceCaption.Options.UseFont = true;
            this.grupo_preparacion.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grupo_preparacion.CaptionImage")));
            this.grupo_preparacion.Controls.Add(this.tileBar0);
            this.grupo_preparacion.Location = new System.Drawing.Point(3, 3);
            this.grupo_preparacion.Name = "grupo_preparacion";
            this.grupo_preparacion.Size = new System.Drawing.Size(230, 459);
            this.grupo_preparacion.TabIndex = 1;
            this.grupo_preparacion.Text = "Preparación o análisis";
            // 
            // tileBar0
            // 
            this.tileBar0.AllowDrag = false;
            this.tileBar0.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar0.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBar0.AppearanceText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tileBar0.AppearanceText.Options.UseFont = true;
            this.tileBar0.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar0.ItemSize = 80;
            this.tileBar0.Location = new System.Drawing.Point(5, 37);
            this.tileBar0.MaxId = 3;
            this.tileBar0.Name = "tileBar0";
            this.tileBar0.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileBar0.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar0.Size = new System.Drawing.Size(220, 417);
            this.tileBar0.TabIndex = 0;
            this.tileBar0.Text = "tileBar0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(737, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar";
            // 
            // tileGroup1
            // 
            this.tileGroup1.Name = "tileGroup1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Name = "tileGroup3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btn_nuevo);
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Controls.Add(this.btn_ultimo);
            this.panel2.Controls.Add(this.btn_actualizar);
            this.panel2.Controls.Add(this.btn_guardar);
            this.panel2.Controls.Add(this.btn_buscar);
            this.panel2.Controls.Add(this.btn_primero);
            this.panel2.Controls.Add(this.btn_anterior);
            this.panel2.Controls.Add(this.btn_editar);
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Controls.Add(this.btn_siguiente);
            this.panel2.Location = new System.Drawing.Point(176, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 56);
            this.panel2.TabIndex = 188;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::crm.Properties.Resources.imprimir1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(479, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 50);
            this.button2.TabIndex = 182;
            this.button2.UseVisualStyleBackColor = true;
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
            this.btn_nuevo.Size = new System.Drawing.Size(49, 50);
            this.btn_nuevo.TabIndex = 4;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click_1);
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
            this.btn_cancelar.Location = new System.Drawing.Point(315, 0);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(49, 51);
            this.btn_cancelar.TabIndex = 176;
            this.btn_cancelar.UseVisualStyleBackColor = true;
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
            this.btn_ultimo.Location = new System.Drawing.Point(452, 25);
            this.btn_ultimo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(19, 26);
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
            this.btn_actualizar.Location = new System.Drawing.Point(372, 1);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(45, 50);
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
            this.btn_guardar.Location = new System.Drawing.Point(86, 4);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(44, 50);
            this.btn_guardar.TabIndex = 3;
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
            this.btn_buscar.Location = new System.Drawing.Point(256, 3);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(51, 51);
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
            this.btn_primero.Location = new System.Drawing.Point(425, 25);
            this.btn_primero.Margin = new System.Windows.Forms.Padding(4);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(19, 26);
            this.btn_primero.TabIndex = 180;
            this.btn_primero.UseVisualStyleBackColor = true;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
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
            this.btn_anterior.Location = new System.Drawing.Point(425, 1);
            this.btn_anterior.Margin = new System.Windows.Forms.Padding(4);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(19, 21);
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
            this.btn_editar.Location = new System.Drawing.Point(138, 4);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(51, 50);
            this.btn_editar.TabIndex = 5;
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
            this.btn_eliminar.Location = new System.Drawing.Point(197, 3);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(51, 51);
            this.btn_eliminar.TabIndex = 6;
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
            this.btn_siguiente.Location = new System.Drawing.Point(452, 1);
            this.btn_siguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(19, 21);
            this.btn_siguiente.TabIndex = 179;
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agrupar por:";
            // 
            // btn_clie
            // 
            this.btn_clie.Image = ((System.Drawing.Image)(resources.GetObject("btn_clie.Image")));
            this.btn_clie.Location = new System.Drawing.Point(0, 3);
            this.btn_clie.Name = "btn_clie";
            this.btn_clie.Size = new System.Drawing.Size(81, 26);
            this.btn_clie.TabIndex = 2;
            this.btn_clie.Text = "Persona";
            this.btn_clie.Click += new System.EventHandler(this.btn_clie_Click);
            // 
            // btn_cat
            // 
            this.btn_cat.Image = ((System.Drawing.Image)(resources.GetObject("btn_cat.Image")));
            this.btn_cat.Location = new System.Drawing.Point(739, 22);
            this.btn_cat.Name = "btn_cat";
            this.btn_cat.Size = new System.Drawing.Size(81, 26);
            this.btn_cat.TabIndex = 3;
            this.btn_cat.Text = "Categoría";
            this.btn_cat.Click += new System.EventHandler(this.btn_cat_Click);
            // 
            // btn_normal
            // 
            this.btn_normal.Image = ((System.Drawing.Image)(resources.GetObject("btn_normal.Image")));
            this.btn_normal.Location = new System.Drawing.Point(836, 22);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(81, 26);
            this.btn_normal.TabIndex = 4;
            this.btn_normal.Text = "Ver normal";
            this.btn_normal.Click += new System.EventHandler(this.btn_normal_Click);
            // 
            // ddb_clientes
            // 
            this.ddb_clientes.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.ddb_clientes.DropDownControl = this.popupControlContainer1;
            this.ddb_clientes.Image = ((System.Drawing.Image)(resources.GetObject("ddb_clientes.Image")));
            this.ddb_clientes.Location = new System.Drawing.Point(638, 23);
            this.ddb_clientes.MenuManager = this.barManager1;
            this.ddb_clientes.Name = "ddb_clientes";
            this.ddb_clientes.Size = new System.Drawing.Size(81, 25);
            this.ddb_clientes.TabIndex = 5;
            this.ddb_clientes.Text = "Cliente";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            this.barManager1.StatusBar = this.bar3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1026, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 568);
            this.barDockControlBottom.Size = new System.Drawing.Size(1026, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 568);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1026, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 568);
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.btn_empresa);
            this.popupControlContainer1.Controls.Add(this.btn_clie);
            this.popupControlContainer1.Location = new System.Drawing.Point(638, 42);
            this.popupControlContainer1.Manager = this.barManager1;
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(81, 54);
            this.popupControlContainer1.TabIndex = 7;
            this.popupControlContainer1.Visible = false;
            // 
            // btn_empresa
            // 
            this.btn_empresa.Image = ((System.Drawing.Image)(resources.GetObject("btn_empresa.Image")));
            this.btn_empresa.Location = new System.Drawing.Point(0, 28);
            this.btn_empresa.Name = "btn_empresa";
            this.btn_empresa.Size = new System.Drawing.Size(81, 26);
            this.btn_empresa.TabIndex = 3;
            this.btn_empresa.Text = "Empresa";
            this.btn_empresa.Click += new System.EventHandler(this.btn_empresa_Click);
            // 
            // FormNegociaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.navigationPane1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormNegociaciones";
            this.Text = "Negocios";
            this.Load += new System.EventHandler(this.FormNegociaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_negocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_neg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.pag_lista.ResumeLayout(false);
            this.pag_lista.PerformLayout();
            this.pag_estado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grupo_preparacion)).EndInit();
            this.grupo_preparacion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgv_negocios;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_neg;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage pag_lista;
        private DevExpress.XtraBars.Navigation.NavigationPage pag_estado;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
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
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl grupo_preparacion;
        private DevExpress.XtraBars.Navigation.TileBar tileBar0;
        private DevExpress.XtraBars.Navigation.TileBar tileBar3;
        private DevExpress.XtraBars.Navigation.TileBar tileBar2;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_normal;
        private DevExpress.XtraEditors.SimpleButton btn_cat;
        private DevExpress.XtraEditors.SimpleButton btn_clie;
        private DevExpress.XtraEditors.DropDownButton ddb_clientes;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraEditors.SimpleButton btn_empresa;
    }
}