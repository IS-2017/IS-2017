using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Reporteador;
using FuncionesNavegador;
using seguridad;

namespace MDI_CORTO_MIERCOLES_17
{
    public partial class MDI_contenedor : Form
    {
        prueba_grid pgrid;
        frm_bien_grid bien;
        frm_proveedor_grid prove;
        frm_cliente_grid cliente;
        frm_inventario inve;

        String usuario;
        public MDI_contenedor(String user)
        {
            usuario = user;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String espacio = "                                                                         ";
            ActiveForm.Text = "Examen Corto" + espacio + "Usuario: " + usuario;
            MdiClient Chld;
            foreach (Control crtl in this.Controls)
            {
                try
                {
                    Chld = (MdiClient)crtl;
                    Chld.BackColor = this.BackColor;
                }
                catch (InvalidCastException exe)
                { }
            }
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(inve == null)
            {
                inve = new frm_inventario();
                inve.MdiParent = this;
                inve.FormClosed += new FormClosedEventHandler(inve_FormClosed);
                inve.Show();
            }
        }
        void inve_FormClosed(object sender, EventArgs e)
        {
            inve = null;
        }

        private void bienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bien == null)
            {
                bien = new frm_bien_grid();
                bien.MdiParent = this;
                bien.FormClosed += new FormClosedEventHandler(bien_FormClosed);
                bien.Show();
            }
        }
        void bien_FormClosed(object sender, EventArgs e)
        {
            bien = null;
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (prove == null)
            {
                prove = new frm_proveedor_grid();
                prove.MdiParent = this;
                prove.FormClosed += new FormClosedEventHandler(prove_FormClosed);
                prove.Show();
            }
        }
        void prove_FormClosed(object sender, EventArgs e)
        {
            prove = null;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                cliente = new frm_cliente_grid();
                cliente.MdiParent = this;
                cliente.FormClosed += new FormClosedEventHandler(cliente_FormClosed);
                cliente.Show();
            }
        }
        void cliente_FormClosed(object sender, EventArgs e)
        {
            cliente = null;
        }
    }
}
