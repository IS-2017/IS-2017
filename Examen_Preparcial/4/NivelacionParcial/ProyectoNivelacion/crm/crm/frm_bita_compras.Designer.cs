namespace crm
{
    partial class frm_bita_compras
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
            this.dgv_bita_compras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bita_compras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_bita_compras
            // 
            this.dgv_bita_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bita_compras.Location = new System.Drawing.Point(12, 30);
            this.dgv_bita_compras.Name = "dgv_bita_compras";
            this.dgv_bita_compras.Size = new System.Drawing.Size(295, 346);
            this.dgv_bita_compras.TabIndex = 1;
            // 
            // frm_bita_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 415);
            this.Controls.Add(this.dgv_bita_compras);
            this.Name = "frm_bita_compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frm_bita_compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bita_compras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bita_compras;
    }
}