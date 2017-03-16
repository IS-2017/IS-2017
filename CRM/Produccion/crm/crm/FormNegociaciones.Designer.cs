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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNegociaciones));
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement13 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement14 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement15 = new DevExpress.XtraEditors.TileItemElement();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_nuevo = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.pag_lista = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pag_estado = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileestado = new DevExpress.XtraEditors.TileControl();
            this.tileGroup5 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
            this.tileItem6 = new DevExpress.XtraEditors.TileItem();
            this.tileItem7 = new DevExpress.XtraEditors.TileItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.pag_lista.SuspendLayout();
            this.pag_estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(944, 473);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(58, 9);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(99, 29);
            this.btn_nuevo.TabIndex = 1;
            this.btn_nuevo.Text = "Añadir negocio";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(783, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(780, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar";
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.pag_lista);
            this.navigationPane1.Controls.Add(this.pag_estado);
            this.navigationPane1.Location = new System.Drawing.Point(1, 53);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pag_lista,
            this.pag_estado});
            this.navigationPane1.RegularSize = new System.Drawing.Size(1010, 533);
            this.navigationPane1.SelectedPage = this.pag_estado;
            this.navigationPane1.SelectedPageIndex = 1;
            this.navigationPane1.Size = new System.Drawing.Size(1010, 533);
            this.navigationPane1.TabIndex = 4;
            this.navigationPane1.Text = "Negociaciones";
            // 
            // pag_lista
            // 
            this.pag_lista.Caption = "Lista";
            this.pag_lista.Controls.Add(this.gridControl1);
            this.pag_lista.Image = ((System.Drawing.Image)(resources.GetObject("pag_lista.Image")));
            this.pag_lista.Name = "pag_lista";
            this.pag_lista.PageText = "";
            this.pag_lista.Size = new System.Drawing.Size(944, 473);
            // 
            // pag_estado
            // 
            this.pag_estado.Caption = "Estado";
            this.pag_estado.Controls.Add(this.tileestado);
            this.pag_estado.Image = ((System.Drawing.Image)(resources.GetObject("pag_estado.Image")));
            this.pag_estado.Name = "pag_estado";
            this.pag_estado.Size = new System.Drawing.Size(944, 473);
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
            // tileestado
            // 
            this.tileestado.AllowSelectedItem = true;
            this.tileestado.DragSize = new System.Drawing.Size(0, 0);
            this.tileestado.Groups.Add(this.tileGroup5);
            this.tileestado.Location = new System.Drawing.Point(49, 62);
            this.tileestado.MaxId = 7;
            this.tileestado.Name = "tileestado";
            this.tileestado.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileestado.Size = new System.Drawing.Size(843, 371);
            this.tileestado.TabIndex = 0;
            this.tileestado.Text = "tileControl1";
            // 
            // tileGroup5
            // 
            this.tileGroup5.Items.Add(this.tileItem3);
            this.tileGroup5.Items.Add(this.tileItem7);
            this.tileGroup5.Items.Add(this.tileItem4);
            this.tileGroup5.Items.Add(this.tileItem5);
            this.tileGroup5.Items.Add(this.tileItem6);
            this.tileGroup5.Name = "tileGroup5";
            // 
            // tileItem3
            // 
            tileItemElement11.Text = "tileItem3";
            this.tileItem3.Elements.Add(tileItemElement11);
            this.tileItem3.Id = 2;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem3.Name = "tileItem3";
            // 
            // tileItem4
            // 
            tileItemElement12.Text = "tileItem4";
            this.tileItem4.Elements.Add(tileItemElement12);
            this.tileItem4.Id = 3;
            this.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem4.Name = "tileItem4";
            // 
            // tileItem5
            // 
            tileItemElement13.Text = "tileItem5";
            this.tileItem5.Elements.Add(tileItemElement13);
            this.tileItem5.Id = 4;
            this.tileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem5.Name = "tileItem5";
            // 
            // tileItem6
            // 
            tileItemElement14.Text = "tileItem6";
            this.tileItem6.Elements.Add(tileItemElement14);
            this.tileItem6.Id = 5;
            this.tileItem6.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem6.Name = "tileItem6";
            // 
            // tileItem7
            // 
            tileItemElement15.Text = "tileItem7";
            this.tileItem7.Elements.Add(tileItemElement15);
            this.tileItem7.Id = 6;
            this.tileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem7.Name = "tileItem7";
            // 
            // FormNegociaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 589);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.navigationPane1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.label1);
            this.Name = "FormNegociaciones";
            this.Text = "Negocios";
            this.Load += new System.EventHandler(this.FormNegociaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.pag_lista.ResumeLayout(false);
            this.pag_estado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_nuevo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage pag_lista;
        private DevExpress.XtraBars.Navigation.NavigationPage pag_estado;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileControl tileestado;
        private DevExpress.XtraEditors.TileGroup tileGroup5;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraEditors.TileItem tileItem5;
        private DevExpress.XtraEditors.TileItem tileItem6;
        private DevExpress.XtraEditors.TileItem tileItem7;
    }
}