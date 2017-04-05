using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Abrir;

namespace contrato_trabajo
{
    public partial class mdi_contenedor : Form
    {
        
        public mdi_contenedor()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
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
            toolStripProgressBar1.Minimum = 1;
            toolStripProgressBar1.Maximum = 50;

        }




        private void listaDeEmpleadosAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_nomina_grid cn = new frm_nomina_grid();
            cn.MdiParent = this;
            cn.StartPosition = FormStartPosition.CenterScreen;
            cn.Show();
        }



        private void empresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_empresa_grid cn = new frm_empresa_grid();
            cn.MdiParent = this;
            cn.StartPosition = FormStartPosition.CenterScreen;
            cn.Show();
        }

        private void Contenedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_empleado cn = new frm_empleado();
            cn.MdiParent = this;
            cn.StartPosition = FormStartPosition.CenterScreen;
            cn.Show();
            for (int i = 1; i <= 50; i++) {
                Thread.Sleep(50); toolStripProgressBar1.Value = i;
            } toolStripProgressBar1.Value = 1;

        }

        private void contratosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Contrato cont = new Contrato();
            cont.MdiParent = this;
            cont.StartPosition = FormStartPosition.CenterScreen;
            cont.Show();
        }

        private void capacitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_capacitaciones cap = new frm_capacitaciones();
            cap.MdiParent = this;
            cap.StartPosition = FormStartPosition.CenterScreen;
            cap.Show();
        }
        

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            dlg.ShowDialog();
        }

        private void cutToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void prestacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_prestaciones pres = new frm_prestaciones();
            pres.MdiParent = this;
            pres.StartPosition = FormStartPosition.CenterScreen;
            pres.Show();
        }

        private void desempeñoLaboralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_desempeno_laboral deslab = new frm_desempeno_laboral();
            deslab.MdiParent = this;
            deslab.StartPosition = FormStartPosition.CenterScreen;
            deslab.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_estadistica_Pagos estad_pag = new frm_estadistica_Pagos();
            estad_pag.MdiParent = this;
            estad_pag.StartPosition = FormStartPosition.CenterScreen;
            estad_pag.Show();
        }

        private void porMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_comisiones_marca comi_marc = new frm_comisiones_marca();
            comi_marc.MdiParent = this;
            comi_marc.StartPosition = FormStartPosition.CenterScreen;
            comi_marc.Show();
        }

        private void porVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_comisiones_vendedor comi_vend = new frm_comisiones_vendedor();
            comi_vend.MdiParent = this;
            comi_vend.StartPosition = FormStartPosition.CenterScreen;
            comi_vend.Show();
        }

        private void porLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_comisiones_linea comi_lin = new frm_comisiones_linea();
            comi_lin.MdiParent = this;
            comi_lin.StartPosition = FormStartPosition.CenterScreen;
            comi_lin.Show();
        }

        private void porProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_comisiones_producto comi_prod = new frm_comisiones_producto();
            comi_prod.MdiParent = this;
            comi_prod.StartPosition = FormStartPosition.CenterScreen;
            comi_prod.Show();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir.Form2 f2 = new Form2();
            f2.Show();   
        }

        private void modificarUSuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seguridad.Form_EditarPrivilegios editar = new seguridad.Form_EditarPrivilegios();
            editar.Show();
        }

        private void gestiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seguridad.Historial historial = new seguridad.Historial();
            historial.Show();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seguridad.FormAsignacionPerfil asig = new seguridad.FormAsignacionPerfil();
            asig.Show();
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            seguridad.Form_EditarPerfil editar = new seguridad.Form_EditarPerfil();
            editar.Show();
        }

        private void deshabilitarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            seguridad.FormEliminarPerfil eliminar = new seguridad.FormEliminarPerfil();
            eliminar.Show();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seguridad.FormAsignarPermisosUsuario asignar = new seguridad.FormAsignarPermisosUsuario();
            asignar.Show();
        }

        private void deshabilitarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seguridad.FormDeshabilitarUsuario deshabilitar = new  seguridad.FormDeshabilitarUsuario();
            deshabilitar.Show();

        }

        private void gestiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            seguridad.agregarapp agregar = new seguridad.agregarapp();
            agregar.Show();
        }

        private void reclutamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_reclutamiento_grid cn = new frm_reclutamiento_grid();
            cn.MdiParent = this;
            cn.StartPosition = FormStartPosition.CenterScreen;
            cn.Show();
        }
    }
}

