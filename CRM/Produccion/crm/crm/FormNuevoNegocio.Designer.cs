namespace crm
{
    partial class FormNuevoNegocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoNegocio));
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel4 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.dtp_fecha_cierre = new DevExpress.XtraEditors.DateEdit();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_detalles = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_nueva = new DevExpress.XtraEditors.SimpleButton();
            this.btn_refesh_cat = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_nuevo_emp = new DevExpress.XtraEditors.SimpleButton();
            this.btn_actualizar_emp = new DevExpress.XtraEditors.SimpleButton();
            this.btn_nuevo_perem = new DevExpress.XtraEditors.SimpleButton();
            this.btn_refresh_perem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbo_monedas = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_empleado = new System.Windows.Forms.ComboBox();
            this.cbo_cat = new System.Windows.Forms.ComboBox();
            this.btn_actualizar_mon = new DevExpress.XtraEditors.SimpleButton();
            this.btn_nueva_mon = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_perem = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_etapa = new DevExpress.XtraEditors.TrackBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fecha_cierre.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fecha_cierre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_etapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_etapa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_fecha_cierre
            // 
            this.dtp_fecha_cierre.EditValue = null;
            this.dtp_fecha_cierre.Location = new System.Drawing.Point(360, 315);
            this.dtp_fecha_cierre.Name = "dtp_fecha_cierre";
            this.dtp_fecha_cierre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_fecha_cierre.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_fecha_cierre.Size = new System.Drawing.Size(428, 20);
            this.dtp_fecha_cierre.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(178, 82);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(118, 13);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Titulo de la negociación";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(153, 123);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(145, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = " ¿Con quién es la negociación?";
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(360, 75);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(428, 21);
            this.txt_titulo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Detalles";
            // 
            // txt_detalles
            // 
            this.txt_detalles.Location = new System.Drawing.Point(360, 163);
            this.txt_detalles.Name = "txt_detalles";
            this.txt_detalles.Size = new System.Drawing.Size(428, 60);
            this.txt_detalles.TabIndex = 7;
            this.txt_detalles.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor del negocio";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(466, 238);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(188, 21);
            this.txt_valor.TabIndex = 10;
            this.txt_valor.TextChanged += new System.EventHandler(this.txt_valor_TextChanged);
            this.txt_valor.Leave += new System.EventHandler(this.txt_valor_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Categoría";
            // 
            // btn_nueva
            // 
            this.btn_nueva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nueva.Image = ((System.Drawing.Image)(resources.GetObject("btn_nueva.Image")));
            this.btn_nueva.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_nueva.Location = new System.Drawing.Point(660, 273);
            this.btn_nueva.Name = "btn_nueva";
            this.btn_nueva.Size = new System.Drawing.Size(61, 23);
            this.btn_nueva.TabIndex = 13;
            this.btn_nueva.ToolTip = "Nueva categoria";
            this.btn_nueva.Click += new System.EventHandler(this.btn_nueva_Click);
            // 
            // btn_refesh_cat
            // 
            this.btn_refesh_cat.Image = ((System.Drawing.Image)(resources.GetObject("btn_refesh_cat.Image")));
            this.btn_refesh_cat.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_refesh_cat.Location = new System.Drawing.Point(727, 273);
            this.btn_refesh_cat.Name = "btn_refesh_cat";
            this.btn_refesh_cat.Size = new System.Drawing.Size(61, 23);
            this.btn_refesh_cat.TabIndex = 14;
            this.btn_refesh_cat.ToolTip = "Actualizar";
            this.btn_refesh_cat.Click += new System.EventHandler(this.btn_refesh_cat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha estimada de cierre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Empleado responsable";
            // 
            // btn_nuevo_emp
            // 
            this.btn_nuevo_emp.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo_emp.Image")));
            this.btn_nuevo_emp.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_nuevo_emp.Location = new System.Drawing.Point(660, 349);
            this.btn_nuevo_emp.Name = "btn_nuevo_emp";
            this.btn_nuevo_emp.Size = new System.Drawing.Size(61, 23);
            this.btn_nuevo_emp.TabIndex = 18;
            this.btn_nuevo_emp.ToolTip = "Nuevo empleado";
            this.btn_nuevo_emp.Click += new System.EventHandler(this.btn_nuevo_emp_Click);
            // 
            // btn_actualizar_emp
            // 
            this.btn_actualizar_emp.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar_emp.Image")));
            this.btn_actualizar_emp.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_actualizar_emp.Location = new System.Drawing.Point(727, 348);
            this.btn_actualizar_emp.Name = "btn_actualizar_emp";
            this.btn_actualizar_emp.Size = new System.Drawing.Size(61, 23);
            this.btn_actualizar_emp.TabIndex = 19;
            this.btn_actualizar_emp.ToolTip = "Actualizar";
            this.btn_actualizar_emp.Click += new System.EventHandler(this.btn_actualizar_emp_Click);
            // 
            // btn_nuevo_perem
            // 
            this.btn_nuevo_perem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_perem.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo_perem.Image")));
            this.btn_nuevo_perem.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_nuevo_perem.Location = new System.Drawing.Point(660, 117);
            this.btn_nuevo_perem.Name = "btn_nuevo_perem";
            this.btn_nuevo_perem.Size = new System.Drawing.Size(61, 23);
            this.btn_nuevo_perem.TabIndex = 20;
            this.btn_nuevo_perem.ToolTip = "Nueva persona/empresa";
            this.btn_nuevo_perem.Click += new System.EventHandler(this.btn_nuevo_perem_Click);
            // 
            // btn_refresh_perem
            // 
            this.btn_refresh_perem.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh_perem.Image")));
            this.btn_refresh_perem.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_refresh_perem.Location = new System.Drawing.Point(727, 117);
            this.btn_refresh_perem.Name = "btn_refresh_perem";
            this.btn_refresh_perem.Size = new System.Drawing.Size(61, 23);
            this.btn_refresh_perem.TabIndex = 21;
            this.btn_refresh_perem.ToolTip = "actualizar";
            this.btn_refresh_perem.Click += new System.EventHandler(this.btn_refresh_perem_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.cbo_monedas);
            this.groupControl1.Controls.Add(this.btn_guardar);
            this.groupControl1.Controls.Add(this.cbo_empleado);
            this.groupControl1.Controls.Add(this.cbo_cat);
            this.groupControl1.Controls.Add(this.btn_actualizar_mon);
            this.groupControl1.Controls.Add(this.btn_nueva_mon);
            this.groupControl1.Controls.Add(this.cbo_perem);
            this.groupControl1.Controls.Add(this.comboBox1);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.tb_etapa);
            this.groupControl1.Controls.Add(this.btn_actualizar_emp);
            this.groupControl1.Controls.Add(this.btn_refresh_perem);
            this.groupControl1.Controls.Add(this.dtp_fecha_cierre);
            this.groupControl1.Controls.Add(this.btn_nuevo_perem);
            this.groupControl1.Controls.Add(this.lbl_titulo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btn_nuevo_emp);
            this.groupControl1.Controls.Add(this.txt_titulo);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.btn_refesh_cat);
            this.groupControl1.Controls.Add(this.txt_detalles);
            this.groupControl1.Controls.Add(this.btn_nueva);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txt_valor);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(925, 532);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "Datos del negocio:";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // cbo_monedas
            // 
            this.cbo_monedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_monedas.FormattingEnabled = true;
            this.cbo_monedas.Location = new System.Drawing.Point(360, 238);
            this.cbo_monedas.Name = "cbo_monedas";
            this.cbo_monedas.Size = new System.Drawing.Size(96, 21);
            this.cbo_monedas.TabIndex = 37;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(475, 479);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(154, 41);
            this.btn_guardar.TabIndex = 36;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cbo_empleado
            // 
            this.cbo_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empleado.FormattingEnabled = true;
            this.cbo_empleado.Location = new System.Drawing.Point(360, 351);
            this.cbo_empleado.Name = "cbo_empleado";
            this.cbo_empleado.Size = new System.Drawing.Size(294, 21);
            this.cbo_empleado.TabIndex = 35;
            // 
            // cbo_cat
            // 
            this.cbo_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cat.FormattingEnabled = true;
            this.cbo_cat.Location = new System.Drawing.Point(360, 275);
            this.cbo_cat.Name = "cbo_cat";
            this.cbo_cat.Size = new System.Drawing.Size(294, 21);
            this.cbo_cat.TabIndex = 34;
            // 
            // btn_actualizar_mon
            // 
            this.btn_actualizar_mon.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar_mon.Image")));
            this.btn_actualizar_mon.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_actualizar_mon.Location = new System.Drawing.Point(727, 236);
            this.btn_actualizar_mon.Name = "btn_actualizar_mon";
            this.btn_actualizar_mon.Size = new System.Drawing.Size(61, 23);
            this.btn_actualizar_mon.TabIndex = 33;
            this.btn_actualizar_mon.ToolTip = "Actualizar";
            this.btn_actualizar_mon.Click += new System.EventHandler(this.btn_actualizar_mon_Click);
            // 
            // btn_nueva_mon
            // 
            this.btn_nueva_mon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nueva_mon.Image = ((System.Drawing.Image)(resources.GetObject("btn_nueva_mon.Image")));
            this.btn_nueva_mon.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_nueva_mon.Location = new System.Drawing.Point(660, 236);
            this.btn_nueva_mon.Name = "btn_nueva_mon";
            this.btn_nueva_mon.Size = new System.Drawing.Size(61, 23);
            this.btn_nueva_mon.TabIndex = 32;
            this.btn_nueva_mon.ToolTip = "Nueva moneda";
            this.btn_nueva_mon.Click += new System.EventHandler(this.btn_nueva_mon_Click);
            // 
            // cbo_perem
            // 
            this.cbo_perem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_perem.FormattingEnabled = true;
            this.cbo_perem.Location = new System.Drawing.Point(466, 119);
            this.cbo_perem.Name = "cbo_perem";
            this.cbo_perem.Size = new System.Drawing.Size(188, 21);
            this.cbo_perem.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Persona",
            "Empresa"});
            this.comboBox1.Location = new System.Drawing.Point(365, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Etapa del negocio:";
            // 
            // tb_etapa
            // 
            this.tb_etapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_etapa.EditValue = null;
            this.tb_etapa.Location = new System.Drawing.Point(344, 394);
            this.tb_etapa.Name = "tb_etapa";
            this.tb_etapa.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.tb_etapa.Properties.Appearance.BackColor2 = System.Drawing.SystemColors.Control;
            this.tb_etapa.Properties.Appearance.Options.UseBackColor = true;
            this.tb_etapa.Properties.LabelAppearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tb_etapa.Properties.LabelAppearance.Options.UseForeColor = true;
            this.tb_etapa.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.tb_etapa.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "Preparación o análisis";
            trackBarLabel2.Label = "Discusión o desarrollo";
            trackBarLabel2.Value = 1;
            trackBarLabel3.Label = "Propuesta realizada";
            trackBarLabel3.Value = 2;
            trackBarLabel4.Label = "Cierre y acuerdo";
            trackBarLabel4.Value = 3;
            this.tb_etapa.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1,
            trackBarLabel2,
            trackBarLabel3,
            trackBarLabel4});
            this.tb_etapa.Properties.Maximum = 3;
            this.tb_etapa.Properties.ShowLabels = true;
            this.tb_etapa.Size = new System.Drawing.Size(535, 72);
            this.tb_etapa.TabIndex = 22;
            // 
            // FormNuevoNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 532);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormNuevoNegocio";
            this.Text = "Nuevo Negocio";
            this.Load += new System.EventHandler(this.FormNuevoNegocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fecha_cierre.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fecha_cierre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_etapa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_etapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtp_fecha_cierre;
        private System.Windows.Forms.Label lbl_titulo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_detalles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_nueva;
        private DevExpress.XtraEditors.SimpleButton btn_refesh_cat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btn_nuevo_emp;
        private DevExpress.XtraEditors.SimpleButton btn_actualizar_emp;
        private DevExpress.XtraEditors.SimpleButton btn_nuevo_perem;
        private DevExpress.XtraEditors.SimpleButton btn_refresh_perem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TrackBarControl tb_etapa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbo_perem;
        private DevExpress.XtraEditors.SimpleButton btn_actualizar_mon;
        private DevExpress.XtraEditors.SimpleButton btn_nueva_mon;
        private System.Windows.Forms.ComboBox cbo_empleado;
        private System.Windows.Forms.ComboBox cbo_cat;
        private System.Windows.Forms.ComboBox cbo_monedas;
        public DevExpress.XtraEditors.SimpleButton btn_guardar;
    }
}