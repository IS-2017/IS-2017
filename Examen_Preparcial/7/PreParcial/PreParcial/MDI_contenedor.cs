using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seguridad;

namespace PreParcial
{
    public partial class MDI_contenedor : Form
    {
        String usuario;
        public MDI_contenedor()
        {
            //usuario = user;
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cliente cn = new frm_cliente();
            cn.MdiParent = this;
            cn.StartPosition = FormStartPosition.CenterScreen;
            cn.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_proveedor cn = new frm_proveedor();
            cn.MdiParent = this;
            cn.StartPosition = FormStartPosition.CenterScreen;
            cn.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_empresa cn = new frm_empresa();
            cn.MdiParent = this;
            cn.StartPosition = FormStartPosition.CenterScreen;
            cn.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_producto cn = new frm_producto();
            cn.MdiParent = this;
            cn.StartPosition = FormStartPosition.CenterScreen;
            cn.Show();

        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_inventario cn = new frm_inventario();
            cn.MdiParent = this;
            cn.StartPosition = FormStartPosition.CenterScreen;
            cn.Show();
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void precioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_precio cn = new frm_precio();
            cn.MdiParent = this;
            cn.StartPosition = FormStartPosition.CenterScreen;
            cn.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_pedido cn = new frm_pedido();
            cn.MdiParent = this;
            cn.StartPosition = FormStartPosition.CenterScreen;
            cn.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_factura cn = new frm_factura();
            cn.MdiParent = this;
            cn.StartPosition = FormStartPosition.CenterScreen;
            cn.Show();
        }
    }
}
