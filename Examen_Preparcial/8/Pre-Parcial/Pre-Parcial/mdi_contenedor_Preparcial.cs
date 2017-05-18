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
using seguridad;

namespace Pre_Parcial
{
    public partial class mdi_contenedor_Preparcial : Form
    {
        frm_clientes_grid cliente_grid;
        frm_clientes cliente;
        frm_proveedor_grid proveedor_grid;
        frm_proveedor proveedor;
        frm_producto_grid producto_grid;
        frm_producto producto;
        frm_inventario_grid inventario_grid;
        frm_inventario inventario;
        seguridad.Historial form_hist;
        FormAsignacionPerfil form_asig;
        Form_EditarPerfil form_perf;
        FormEliminarPerfil inofuser;
        FormAsignarPermisosUsuario nusr;
        Form_EditarPrivilegios form_priv;
        FormDeshabilitarUsuario form_desh;
        agregarapp form_app;


        private int childFormNumber = 0;

        string usuario;

        public mdi_contenedor_Preparcial(String user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void BloquearMDI()
        {
            foreach (ToolStripMenuItem menu_principal in menuStrip.Items)
            {
                foreach (ToolStripMenuItem sub_menu in menu_principal.DropDownItems)
                {
                    sub_menu.Enabled = false;
                }
                menu_principal.Enabled = false;
            }


            inicioToolStripMenuItem.Enabled = true;
            foreach (ToolStripMenuItem item_inicio in inicioToolStripMenuItem.DropDownItems)
            {
                item_inicio.Enabled = true;
            }
            helpMenu.Enabled = true;
            foreach (ToolStripMenuItem help_Menu in helpMenu.DropDownItems)
            {
                help_Menu.Enabled = true;
            }
            windowsMenu.Enabled = true;
            foreach (ToolStripMenuItem ventanas in windowsMenu.DropDownItems)
            {
                ventanas.Enabled = true;
            }
        }

        private void mdi_contenedor_Preparcial_Load(object sender, EventArgs e)
        {
            String espacio = "                                                                                                                   ";
            ActiveForm.Text = "Modulo Recursos Humanos" + espacio + "Usuario: " + usuario;
            BloquearMDI();
            Bloqueo.DesbloquearMDI(menuStrip);
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

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login log = new frm_login();
            log.ShowDialog();

            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cliente_grid == null)
            {
                cliente_grid = new frm_clientes_grid();
                cliente_grid.MdiParent = this;
                cliente_grid.FormClosed += new FormClosedEventHandler(cliente_grid_FormClosed);
                cliente_grid.Show();
            }
        }
        void cliente_grid_FormClosed(object sender, EventArgs e)
        {
            cliente_grid = null;
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proveedor_grid == null)
            {
                proveedor_grid = new frm_proveedor_grid();
                proveedor_grid.MdiParent = this;
                proveedor_grid.FormClosed += new FormClosedEventHandler(proveedor_grid_FormClosed);
                proveedor_grid.Show();
            }
        }
        void proveedor_grid_FormClosed(object sender, EventArgs e)
        {
            proveedor_grid = null;
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (producto_grid == null)
            {
                producto_grid = new frm_producto_grid();
                producto_grid.MdiParent = this;
                producto_grid.FormClosed += new FormClosedEventHandler(producto_grid_FormClosed);
                producto_grid.Show();
            }
        }
        void producto_grid_FormClosed(object sender, EventArgs e)
        {
            producto_grid = null;
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inventario_grid == null)
            {
                inventario_grid = new frm_inventario_grid();
                inventario_grid.MdiParent = this;
                inventario_grid.FormClosed += new FormClosedEventHandler(inventario_grid_FormClosed);
                inventario_grid.Show();
            }
        }
        void inventario_grid_FormClosed(object sender, EventArgs e)
        {
            inventario_grid = null;
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_hist == null)
            {
                form_hist = new Historial();
                form_hist.MdiParent = this;

                form_hist.FormClosed += new FormClosedEventHandler(Historial_FormClosed);
                form_hist.Show();
            }
        }
        void Historial_FormClosed(object sender, EventArgs e)
        {
            form_hist = null;
        }

        private void crerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_asig == null)
            {
                form_asig = new FormAsignacionPerfil();
                form_asig.MdiParent = this;

                form_asig.FormClosed += new FormClosedEventHandler(FormAsignacionPerfil_FormClosed);
                form_asig.Show();
            }
        }
        public void FormAsignacionPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_asig = null;
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (form_perf == null)
            {
                form_perf = new Form_EditarPerfil();
                form_perf.MdiParent = this;

                form_perf.FormClosed += new FormClosedEventHandler(Form_EditarPerfil_FormClosed);
                form_perf.Show();
            }
        }
        public void Form_EditarPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_perf = null;
        }

        private void deshabilitarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (inofuser == null)
            {
                inofuser = new FormEliminarPerfil();
                inofuser.MdiParent = this;

                inofuser.FormClosed += new FormClosedEventHandler(FormEliminarPerfil_FormClosed);
                inofuser.Show();
            }
        }
        public void FormEliminarPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            inofuser = null;
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (nusr == null)
                {
                    nusr = new FormAsignarPermisosUsuario();
                    nusr.MdiParent = this;

                    nusr.FormClosed += new FormClosedEventHandler(FormAsignarPermisosUsuario_FormClosed);
                    nusr.Show();
                }
        }
        public void FormAsignarPermisosUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            nusr = null;
        }

        private void modificarUSuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_priv == null)
            {
                form_priv = new Form_EditarPrivilegios();
                form_priv.MdiParent = this;

                form_priv.FormClosed += new FormClosedEventHandler(Form_EditarPrivilegios_FormClosed);
                form_priv.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                form_priv.Show();
            }
        }
        public void Form_EditarPrivilegios_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_priv = null;
        }

        private void deshabilitarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_desh == null)
            {
                form_desh = new FormDeshabilitarUsuario();
                form_desh.MdiParent = this;

                form_desh.FormClosed += new FormClosedEventHandler(FormDeshabilitarUsuario_FormClosed);
                form_desh.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                form_desh.Show();
            }
        }
        public void FormDeshabilitarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_desh = null;
        }

        private void gestiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (form_app == null)
            {
                form_app = new agregarapp();
                form_app.MdiParent = this;
                form_app.FormClosed += new FormClosedEventHandler(agregarapp_FormClosed);
                form_app.Show();
            }
        }
        public void agregarapp_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_app = null;
        }
    }
}
