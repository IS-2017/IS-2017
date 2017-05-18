namespace crm
{
    partial class frm_bitacora_ventas
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
            this.dgv_bita_ventas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bita_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_bita_ventas
            // 
            this.dgv_bita_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bita_ventas.Location = new System.Drawing.Point(42, 27);
            this.dgv_bita_ventas.Name = "dgv_bita_ventas";
            this.dgv_bita_ventas.Size = new System.Drawing.Size(295, 346);
            this.dgv_bita_ventas.TabIndex = 0;
            // 
            // frm_bitacora_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 400);
            this.Controls.Add(this.dgv_bita_ventas);
            this.Name = "frm_bitacora_ventas";
            this.Text = "Bitacora de Facturas";
            this.Load += new System.EventHandler(this.frm_bitacora_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bita_ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bita_ventas;
    }
}