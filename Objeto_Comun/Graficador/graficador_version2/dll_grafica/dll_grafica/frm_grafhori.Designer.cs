﻿namespace Graf1
{
    partial class frm_grafhori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_grafhori));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_acpt = new System.Windows.Forms.Button();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.btn_y = new System.Windows.Forms.Button();
            this.btn_x = new System.Windows.Forms.Button();
            this.btn_gengraf = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_historico = new System.Windows.Forms.Button();
            this.cbo_msem = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbo_mmes2 = new System.Windows.Forms.ComboBox();
            this.cbo_mmes = new System.Windows.Forms.ComboBox();
            this.txt_ames = new System.Windows.Forms.TextBox();
            this.cbo_ssem = new System.Windows.Forms.ComboBox();
            this.txt_asem = new System.Windows.Forms.TextBox();
            this.cbo_fecha = new System.Windows.Forms.ComboBox();
            this.btn_mensual = new System.Windows.Forms.Button();
            this.btn_semanal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(454, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btn_acpt
            // 
            this.btn_acpt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_acpt.BackgroundImage")));
            this.btn_acpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_acpt.Location = new System.Drawing.Point(602, 35);
            this.btn_acpt.Name = "btn_acpt";
            this.btn_acpt.Size = new System.Drawing.Size(60, 60);
            this.btn_acpt.TabIndex = 2;
            this.btn_acpt.UseVisualStyleBackColor = true;
            this.btn_acpt.Click += new System.EventHandler(this.btn_acpt_Click);
            // 
            // dgv_datos
            // 
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(12, 101);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.Size = new System.Drawing.Size(768, 216);
            this.dgv_datos.TabIndex = 3;
            // 
            // btn_y
            // 
            this.btn_y.Location = new System.Drawing.Point(541, 357);
            this.btn_y.Name = "btn_y";
            this.btn_y.Size = new System.Drawing.Size(75, 25);
            this.btn_y.TabIndex = 4;
            this.btn_y.Text = "Y";
            this.btn_y.UseVisualStyleBackColor = true;
            this.btn_y.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_x
            // 
            this.btn_x.Location = new System.Drawing.Point(622, 357);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(75, 25);
            this.btn_x.TabIndex = 5;
            this.btn_x.Text = "X";
            this.btn_x.UseVisualStyleBackColor = true;
            this.btn_x.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_gengraf
            // 
            this.btn_gengraf.Location = new System.Drawing.Point(568, 401);
            this.btn_gengraf.Name = "btn_gengraf";
            this.btn_gengraf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_gengraf.Size = new System.Drawing.Size(113, 34);
            this.btn_gengraf.TabIndex = 7;
            this.btn_gengraf.Text = "Genera grafica";
            this.btn_gengraf.UseVisualStyleBackColor = true;
            this.btn_gengraf.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // btn_historico
            // 
            this.btn_historico.Location = new System.Drawing.Point(128, 165);
            this.btn_historico.Name = "btn_historico";
            this.btn_historico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_historico.Size = new System.Drawing.Size(113, 32);
            this.btn_historico.TabIndex = 59;
            this.btn_historico.Text = "Crear Historico";
            this.btn_historico.UseVisualStyleBackColor = true;
            this.btn_historico.Click += new System.EventHandler(this.btn_historico_Click);
            // 
            // cbo_msem
            // 
            this.cbo_msem.FormattingEnabled = true;
            this.cbo_msem.Location = new System.Drawing.Point(177, 405);
            this.cbo_msem.Name = "cbo_msem";
            this.cbo_msem.Size = new System.Drawing.Size(47, 21);
            this.cbo_msem.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(161, 460);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "-";
            // 
            // cbo_mmes2
            // 
            this.cbo_mmes2.FormattingEnabled = true;
            this.cbo_mmes2.Location = new System.Drawing.Point(177, 457);
            this.cbo_mmes2.Name = "cbo_mmes2";
            this.cbo_mmes2.Size = new System.Drawing.Size(47, 21);
            this.cbo_mmes2.TabIndex = 56;
            // 
            // cbo_mmes
            // 
            this.cbo_mmes.FormattingEnabled = true;
            this.cbo_mmes.Location = new System.Drawing.Point(113, 457);
            this.cbo_mmes.Name = "cbo_mmes";
            this.cbo_mmes.Size = new System.Drawing.Size(47, 21);
            this.cbo_mmes.TabIndex = 53;
            // 
            // txt_ames
            // 
            this.txt_ames.Location = new System.Drawing.Point(239, 457);
            this.txt_ames.Name = "txt_ames";
            this.txt_ames.Size = new System.Drawing.Size(47, 20);
            this.txt_ames.TabIndex = 50;
            this.txt_ames.TextChanged += new System.EventHandler(this.txt_ames_TextChanged);
            // 
            // cbo_ssem
            // 
            this.cbo_ssem.FormattingEnabled = true;
            this.cbo_ssem.Location = new System.Drawing.Point(113, 405);
            this.cbo_ssem.Name = "cbo_ssem";
            this.cbo_ssem.Size = new System.Drawing.Size(47, 21);
            this.cbo_ssem.TabIndex = 49;
            // 
            // txt_asem
            // 
            this.txt_asem.Location = new System.Drawing.Point(239, 406);
            this.txt_asem.Name = "txt_asem";
            this.txt_asem.Size = new System.Drawing.Size(47, 20);
            this.txt_asem.TabIndex = 44;
            this.txt_asem.TextChanged += new System.EventHandler(this.txt_asem_TextChanged);
            // 
            // cbo_fecha
            // 
            this.cbo_fecha.FormattingEnabled = true;
            this.cbo_fecha.Location = new System.Drawing.Point(233, 19);
            this.cbo_fecha.Name = "cbo_fecha";
            this.cbo_fecha.Size = new System.Drawing.Size(126, 21);
            this.cbo_fecha.TabIndex = 60;
            this.cbo_fecha.SelectedIndexChanged += new System.EventHandler(this.cbo_fecha_SelectedIndexChanged);
            // 
            // btn_mensual
            // 
            this.btn_mensual.Location = new System.Drawing.Point(21, 454);
            this.btn_mensual.Name = "btn_mensual";
            this.btn_mensual.Size = new System.Drawing.Size(75, 23);
            this.btn_mensual.TabIndex = 63;
            this.btn_mensual.Text = "Mensual";
            this.btn_mensual.UseVisualStyleBackColor = true;
            this.btn_mensual.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btn_semanal
            // 
            this.btn_semanal.Location = new System.Drawing.Point(21, 403);
            this.btn_semanal.Name = "btn_semanal";
            this.btn_semanal.Size = new System.Drawing.Size(75, 23);
            this.btn_semanal.TabIndex = 62;
            this.btn_semanal.Text = "Semanal";
            this.btn_semanal.UseVisualStyleBackColor = true;
            this.btn_semanal.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Titulo del Grafico";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 20);
            this.label10.TabIndex = 65;
            this.label10.Text = "Seleccione Campo Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Semana";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(110, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 71;
            this.label8.Text = "Mes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(184, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 70;
            this.label7.Text = "Mes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 69;
            this.label6.Text = "Año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 32);
            this.label1.TabIndex = 72;
            this.label1.Text = "GRAFICA HORIZONTAL";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.BackgroundImage")));
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.Location = new System.Drawing.Point(668, 35);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(60, 60);
            this.btn_actualizar.TabIndex = 73;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(568, 465);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(113, 34);
            this.btn_nuevo.TabIndex = 74;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_historico);
            this.groupBox1.Controls.Add(this.cbo_fecha);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 203);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Historico";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(509, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 201);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generacion de Grafica";
            // 
            // frm_grafhori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(809, 534);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_mensual);
            this.Controls.Add(this.btn_semanal);
            this.Controls.Add(this.cbo_msem);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbo_mmes2);
            this.Controls.Add(this.cbo_mmes);
            this.Controls.Add(this.txt_ames);
            this.Controls.Add(this.cbo_ssem);
            this.Controls.Add(this.txt_asem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_gengraf);
            this.Controls.Add(this.btn_x);
            this.Controls.Add(this.btn_y);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.btn_acpt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_grafhori";
            this.Text = "Grafica Horizontal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_acpt;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Button btn_y;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.Button btn_gengraf;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_historico;
        private System.Windows.Forms.ComboBox cbo_msem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbo_mmes2;
        private System.Windows.Forms.ComboBox cbo_mmes;
        private System.Windows.Forms.TextBox txt_ames;
        private System.Windows.Forms.ComboBox cbo_ssem;
        private System.Windows.Forms.TextBox txt_asem;
        private System.Windows.Forms.ComboBox cbo_fecha;
        private System.Windows.Forms.Button btn_mensual;
        private System.Windows.Forms.Button btn_semanal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

