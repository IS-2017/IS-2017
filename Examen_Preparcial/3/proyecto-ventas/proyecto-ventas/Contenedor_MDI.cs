using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_ventas
{
    public partial class Contenedor_MDI : Form
    {
        String usuario;
        public Contenedor_MDI(String user)
        {
            usuario = user;
            InitializeComponent();
        }
        private void Contenedor_MDI_Load(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login f = new frm_login();
            f.Show();
            this.Close();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cliente c = new frm_cliente();
            c.Show();
        }

        private void catalogosPreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tipoprecio t = new frm_tipoprecio();
            t.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_inventario i = new frm_inventario();
            i.Show();
        }

        private void listadoPreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listadoprecio l = new frm_listadoprecio();
            l.Show();
        }
    }
}
