namespace Pre_Parcial
{
    partial class frm_login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.Lbl_ejemplo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_hsc = new System.Windows.Forms.PictureBox();
            this.btn_logear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_hsc)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ejemplo
            // 
            this.Lbl_ejemplo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ejemplo.AutoSize = true;
            this.Lbl_ejemplo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ejemplo.ForeColor = System.Drawing.Color.White;
            this.Lbl_ejemplo.Location = new System.Drawing.Point(33, 311);
            this.Lbl_ejemplo.Name = "Lbl_ejemplo";
            this.Lbl_ejemplo.Size = new System.Drawing.Size(153, 20);
            this.Lbl_ejemplo.TabIndex = 25;
            this.Lbl_ejemplo.Text = "Ejemplo: tgonzalesc";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 34);
            this.label3.TabIndex = 24;
            this.label3.Text = "Bienvenido 8";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(279, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 23;
            this.toolTip1.SetToolTip(this.button1, "Ayuda del Modulo");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pb_hsc
            // 
            this.pb_hsc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_hsc.BackgroundImage")));
            this.pb_hsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_hsc.Location = new System.Drawing.Point(8, 91);
            this.pb_hsc.Name = "pb_hsc";
            this.pb_hsc.Size = new System.Drawing.Size(312, 158);
            this.pb_hsc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_hsc.TabIndex = 22;
            this.pb_hsc.TabStop = false;
            // 
            // btn_logear
            // 
            this.btn_logear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logear.Location = new System.Drawing.Point(133, 389);
            this.btn_logear.Name = "btn_logear";
            this.btn_logear.Size = new System.Drawing.Size(146, 36);
            this.btn_logear.TabIndex = 21;
            this.btn_logear.Text = "Iniciar Sesion";
            this.toolTip1.SetToolTip(this.btn_logear, "Clic para iniciar sesion");
            this.btn_logear.UseVisualStyleBackColor = true;
            this.btn_logear.Click += new System.EventHandler(this.btn_logear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Usuario:";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(37, 363);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(242, 20);
            this.txt_contraseña.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txt_contraseña, "Ingresar contraseña");
            this.txt_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contraseña_KeyPress);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(37, 288);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(242, 20);
            this.txt_usuario.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txt_usuario, "Ingresar nombre de usuario");
            this.txt_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_usuario_KeyPress);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(84)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(336, 464);
            this.Controls.Add(this.Lbl_ejemplo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb_hsc);
            this.Controls.Add(this.btn_logear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_login_FormClosed);
            this.Load += new System.EventHandler(this.frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_hsc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Lbl_ejemplo;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb_hsc;
        private System.Windows.Forms.Button btn_logear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

