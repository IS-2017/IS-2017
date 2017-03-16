namespace crm
{
    partial class FormContactos
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.memoExEdit1 = new DevExpress.XtraEditors.MemoExEdit();
            this.btn_opciones = new DevExpress.XtraEditors.DropDownButton();
            this.MenuOpciones = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.btn_eliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_midificar = new DevExpress.XtraEditors.SimpleButton();
            this.ManagerOpciones = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoExEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuOpciones)).BeginInit();
            this.MenuOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerOpciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(25, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(90, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Nuevo contacto";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.memoExEdit1);
            this.groupControl1.Location = new System.Drawing.Point(752, 53);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(216, 491);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Datos:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(50, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "labelControl3";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(50, 153);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "labelControl2";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(50, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "labelControl1";
            // 
            // memoExEdit1
            // 
            this.memoExEdit1.Location = new System.Drawing.Point(50, 197);
            this.memoExEdit1.Name = "memoExEdit1";
            this.memoExEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.memoExEdit1.Size = new System.Drawing.Size(100, 20);
            this.memoExEdit1.TabIndex = 0;
            // 
            // btn_opciones
            // 
            this.btn_opciones.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.btn_opciones.DropDownControl = this.MenuOpciones;
            this.btn_opciones.Location = new System.Drawing.Point(585, 24);
            this.btn_opciones.Name = "btn_opciones";
            this.btn_opciones.Size = new System.Drawing.Size(147, 23);
            this.btn_opciones.TabIndex = 5;
            this.btn_opciones.Text = "Opciones";
            // 
            // MenuOpciones
            // 
            this.MenuOpciones.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.MenuOpciones.Controls.Add(this.btn_eliminar);
            this.MenuOpciones.Controls.Add(this.btn_midificar);
            this.MenuOpciones.Location = new System.Drawing.Point(585, 34);
            this.MenuOpciones.Manager = this.ManagerOpciones;
            this.MenuOpciones.Name = "MenuOpciones";
            this.MenuOpciones.Size = new System.Drawing.Size(182, 53);
            this.MenuOpciones.TabIndex = 6;
            this.MenuOpciones.Visible = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(3, 27);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(176, 23);
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "Eliminar";
            // 
            // btn_midificar
            // 
            this.btn_midificar.Location = new System.Drawing.Point(3, 3);
            this.btn_midificar.Name = "btn_midificar";
            this.btn_midificar.Size = new System.Drawing.Size(176, 23);
            this.btn_midificar.TabIndex = 11;
            this.btn_midificar.Text = "Modificar";
            // 
            // ManagerOpciones
            // 
            this.ManagerOpciones.DockControls.Add(this.barDockControlTop);
            this.ManagerOpciones.DockControls.Add(this.barDockControlBottom);
            this.ManagerOpciones.DockControls.Add(this.barDockControlLeft);
            this.ManagerOpciones.DockControls.Add(this.barDockControlRight);
            this.ManagerOpciones.Form = this;
            this.ManagerOpciones.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(991, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 589);
            this.barDockControlBottom.Size = new System.Drawing.Size(991, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 589);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(991, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 589);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(25, 53);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ManagerOpciones;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(689, 491);
            this.gridControl1.TabIndex = 26;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // FormContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 589);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.MenuOpciones);
            this.Controls.Add(this.btn_opciones);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormContactos";
            this.Text = "Contactos";
            this.Load += new System.EventHandler(this.FormContactos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoExEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuOpciones)).EndInit();
            this.MenuOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManagerOpciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoExEdit memoExEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DropDownButton btn_opciones;
        private DevExpress.XtraBars.PopupControlContainer MenuOpciones;
        private DevExpress.XtraBars.BarManager ManagerOpciones;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton btn_eliminar;
        private DevExpress.XtraEditors.SimpleButton btn_midificar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}