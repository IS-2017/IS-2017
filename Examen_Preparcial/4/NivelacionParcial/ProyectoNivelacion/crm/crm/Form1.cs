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

namespace crm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       

        string tipo;
        DataTable dt_permisos = new DataTable();


        frm_productos prod = new frm_productos();
        frm_cliente cliente_form = new frm_cliente();
        frm_proveedor prov = new frm_proveedor();
        Form_inicio ini = new Form_inicio();
        Form_Casos caso = new Form_Casos();
        Historial bitacora = new Historial();
        agregarapp ap = new agregarapp();
        Modificar_aplicacion modap = new Modificar_aplicacion();
        FormAsignarPermisosUsuario crearu = new FormAsignarPermisosUsuario();
        Form_EditarPrivilegios edi = new Form_EditarPrivilegios();
        FormDeshabilitarUsuario desh = new FormDeshabilitarUsuario();
        FormAsignacionPerfil asper = new FormAsignacionPerfil();
        Form_EditarPerfil edper = new Form_EditarPerfil();
        FormEliminarPerfil elper = new FormEliminarPerfil();
        CambioPass camb = new CambioPass();
        frm_pedido soli = new frm_pedido();
        frm_factura fac = new frm_factura();
        frm_bitacora_ventas bita_v = new frm_bitacora_ventas();
        frm_bita_compras bita_c = new frm_bita_compras();



        private void LimpiarMDI()
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void ClearAllMDIs()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
               // f.Dispose();
            }
        }

        private void otroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void caToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // conexion odbc
            //try
            //{
            //    seguridad.Conexion.DSN = "crm";
            //    seguridad.Conexion.PassWord = "1234";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}


            BloquearMDI();
            Bloqueo.DesbloquearMDI(menuStrip1);

         

            //------------------------
            tipo = OpBD.VerificarTipoUsuario();
            if(tipo == "administrador")
            {
                //estadisticasToolStripMenuItem.Enabled = false;
                seguridadToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem item_seg in seguridadToolStripMenuItem.DropDownItems)
                {
                    item_seg.Enabled = true;
                }

            }


        
            caso = null;
            bitacora = null;
            ap = null;
            modap = null;
            crearu = null;
            edi = null;
            desh = null;
            asper = null;
            edper = null;
            elper = null;
            camb = null;
            cliente_form = null;
            prov = null;
            prod = null;
            soli = null;
            fac = null;
            bita_v = null;
            bita_c = null;



            if (ini == null)
            {
                ini = new Form_inicio();
                ini.MdiParent = this;

                ini.FormClosed += new FormClosedEventHandler(frm_inicio_FormClosed);
                ini.Show();
            }
        }


        private void BloquearMDI()
        {
            //foreach (ToolStripMenuItem menu_principal in menuStrip1.Items)
            //{
            //    foreach (ToolStripMenuItem sub_menu in menu_principal.DropDownItems)
            //    {
            //        sub_menu.Enabled = false;
            //    }
            //     menu_principal.Enabled = false;
            //}


            //toolStripMenuItem1.Enabled = true;
            //foreach(ToolStripMenuItem item_inicio in toolStripMenuItem1.DropDownItems)
            //{
            //    item_inicio.Enabled = true;
            //}

        }





        private void actividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, "104");
            //if (dt.Rows.Count > 0)
            //{
                // ClearAllMDIs();
                LimpiarMDI();
                
            //}
            //else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

      

        private void FormActividadesCalendario_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, "103");
            //if (dt.Rows.Count > 0)
            //{
                // ClearAllMDIs();
                LimpiarMDI();
                
            //}
            //else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

        private void FormCotactos_FormClosed(object sender, FormClosedEventArgs e)
        {
        }


        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ClearAllMDIs();

           //DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User,"104");
           // if (dt.Rows.Count > 0)
           // {
                LimpiarMDI();
              
            //else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

        private void FormNegociaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, "112");
            //if (dt.Rows.Count > 0)
            //{
                //ClearAllMDIs();
                LimpiarMDI();
                
            //}
            //else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

        private void frm_estadistica_empresa_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void personalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, "113");
            //if (dt.Rows.Count > 0)
            //{
                //ClearAllMDIs();
                LimpiarMDI();
               
            //}
            //else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

        private void frm_estadistica_personal_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void proyeccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, "114");
            //if (dt.Rows.Count > 0)
            //{
                //ClearAllMDIs();
                LimpiarMDI();
                
            //}
            //else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

        private void frm_pronostico_FormClosed(object sender, FormClosedEventArgs e)
        {
        }


       


        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //frm_cliente clt = new frm_cliente();
            //clt.Show();
            LimpiarMDI();
            if (cliente_form == null)
            {
                cliente_form = new frm_cliente();
                cliente_form.MdiParent = this;

                cliente_form.FormClosed += new FormClosedEventHandler(frm_cliente_FormClosed);
                cliente_form.Show();
            }

        }
        private void frm_cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            cliente_form = null;
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // LimpiarMDI();
           
        }

        private void frm_empresa_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //// LimpiarMDI();
            //if (ini == null)
            //{
            //    ini = new Form_inicio();
            //    ini.MdiParent = this;

            //    ini.FormClosed += new FormClosedEventHandler(frm_inicio_FormClosed);
            //    ini.Show();
            //}
        }

        private void frm_inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            ini = null;
        }


        // Pestaña de Empleados
        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (prov == null)
            {
                prov = new frm_proveedor();
                prov.MdiParent = this;

                prov.FormClosed += new FormClosedEventHandler(Prov_FormClosed);
                //prov.FormClosed += Prov_FormClosed(Prov_FormClosed);
                prov.Show();
            }
        }

        private void Prov_FormClosed(object sender, FormClosedEventArgs e)
        {
            prov = null;
        }

        private void frm_NuevoEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void casosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, "102");
            //if (dt.Rows.Count > 0)
            //{
                //LimpiarMDI();
                if (caso == null)
                {
                caso = new Form_Casos();
                cliente_form = new frm_cliente();
                caso.MdiParent = this;

                caso.FormClosed += new FormClosedEventHandler(Form_Casos_FormClosed);
                caso.Show();
                //cliente_form = new frm_cliente();
                //cliente_form.MdiParent = this;

                //cliente_form.FormClosed += new FormClosedEventHandler(frm_cliente_FormClosed);
                //cliente_form.Show();
            }

            //}else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

        private void Form_Casos_FormClosed(object sender, FormClosedEventArgs e)
        {
            caso = null;
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LimpiarMDI();
            if (bitacora == null)
            {
                bitacora = new Historial();
                bitacora.MdiParent = this;

                bitacora.FormClosed += new FormClosedEventHandler(Historial_FormClosed);
                bitacora.Show();
            }
        }

        private void Historial_FormClosed(object sender, FormClosedEventArgs e)
        {
            bitacora = null;
        }

        private void agregarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AGREGAR APLICACION
        //    if (ap == null)
        //    {
        //        ap = new agregarapp();
        //        ap.MdiParent = this;

        //        ap.FormClosed += new FormClosedEventHandler(agregarap_FormClosed);
        //        ap.Show();
        //    }
        }

        private void agregarap_FormClosed(object sender, FormClosedEventArgs e)
        {
            ap = null;
        }

        private void modificarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MODIFICAR APLICACION 
            //if (modap == null)
            //{
            //    modap = new Modificar_aplicacion();
            //    modap.MdiParent = this;
            //    modap.FormClosed += new FormClosedEventHandler(ModificarAplicacion_FormClosed);
            //    modap.Show();
            //}
        }

        private void ModificarAplicacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            modap = null;
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (crearu == null)
            {
                crearu = new FormAsignarPermisosUsuario();
                crearu.MdiParent = this;

                crearu.FormClosed += new FormClosedEventHandler(FormAsignarPermisosUsuario_FormClosed);
                crearu.Show();
            }
        }

        private void FormAsignarPermisosUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            crearu = null;
        }

        private void editarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (edi == null)
            {
                edi = new Form_EditarPrivilegios();
                edi.MdiParent = this;

                edi.FormClosed += new FormClosedEventHandler(FormEditarPrivilegios_FormClosed);
                edi.Show();
            }
        }

        private void FormEditarPrivilegios_FormClosed(object sender, FormClosedEventArgs e)
        {
            edi = null;
        }

        private void deshabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (desh == null)
            {
                desh = new FormDeshabilitarUsuario();
                desh.MdiParent = this;
                desh.FormClosed += new FormClosedEventHandler(FormDeshabilitarUsuario_FormClosed);
                desh.Show();
            }
        }

        private void FormDeshabilitarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            desh = null;
        }

        private void crearPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (asper == null)
            {
                asper = new FormAsignacionPerfil();
                asper.MdiParent = this;
                asper.FormClosed += new FormClosedEventHandler(FormAsignacionPerfil_FormClosed);
                asper.Show();
            }
        }

        private void FormAsignacionPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            asper = null;
        }

        private void editarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (edper == null)
            {
                edper = new Form_EditarPerfil();
                edper.MdiParent = this;
                edper.FormClosed += new FormClosedEventHandler(Form_EditarPerfil_FormClosed);
                edper.Show();
            }
        }

        private void Form_EditarPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            edper = null;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (elper == null)
            {
                elper = new FormEliminarPerfil();
                elper.MdiParent = this;
                elper.FormClosed += new FormClosedEventHandler(FormEliminarPerfil_FormClosed);
                elper.Show();
            }
        }

        private void FormEliminarPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            elper = null;
        }

        private void gToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (camb == null)
            {
                camb = new CambioPass();
                camb.MdiParent = this;
                camb.FormClosed += new FormClosedEventHandler(CambioPass_FormClosed);
                camb.Show();
            }
        }

        private void CambioPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            camb = null;
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Close();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // LimpiarMDI();
            if (ini == null)
            {
                ini = new Form_inicio();
                ini.MdiParent = this;

                ini.FormClosed += new FormClosedEventHandler(frm_inicio_FormClosed);
                ini.Show();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Close();
        }

        private void metasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, "115");
            if (dt.Rows.Count > 0)
            {
                //ClearAllMDIs();
                LimpiarMDI();
               
            }
            else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

        private void frm_pronostico_ventas_Secundario_form_closed(object sender, FormClosedEventArgs e)
        {
        }

        private void ingresoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, "116");
            if (dt.Rows.Count > 0)
            {
                //ClearAllMDIs();
                LimpiarMDI();
                
            }
            else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

        private void inventario_form_closed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, "117");
            if (dt.Rows.Count > 0)
            {
                //ClearAllMDIs();
                LimpiarMDI();
                
            }
            else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

        private void inventario_bodega_form_closed(object sender, FormClosedEventArgs e)
        {
        }

        private void listaDePrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (soli == null)
            {
                soli = new frm_pedido();
                soli.MdiParent = this;

                //prod.FormClosed += new FormClosedEventHandler(Prov_FormClosed);
                //prov.FormClosed += Prov_FormClosed(Prov_FormClosed);
                soli.FormClosed += new FormClosedEventHandler(lista_de_precios_form_closed);
                soli.Show();
            }
        }

        private void lista_de_precios_form_closed(object sender, FormClosedEventArgs e)
        {
            soli = null;
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        // facturacion
        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarMDI();
            if (fac == null)
            {
                fac = new frm_factura();
                fac.MdiParent = this;

                //fac.FormClosed += new FormClosedEventHandler(frm_cliente_FormClosed);
                fac.FormClosed += new FormClosedEventHandler(Fac_FormClosed);
                fac.Show();
            }
        }

        private void Fac_FormClosed(object sender, FormClosedEventArgs e)
        {
            fac = null;
        }

        private void cotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aBONOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_abonos_form_closed(object sender, FormClosedEventArgs e)
        {
        }

        private void bALANCEToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void frm_balance_form_closed(object sender, FormClosedEventArgs e)
        {
        }

        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

            if (OpBD.CambioIdioma == true)
            {
                this.Controls.Clear();
                InitializeComponent();
                OpBD.CambioIdioma = false;

                ini = null;
                if (ini == null)
                {
                    ini = new Form_inicio();
                    ini.MdiParent = this;

                    ini.FormClosed += new FormClosedEventHandler(frm_inicio_FormClosed);
                    ini.Show();
                }

               
                  
            }
        }

        private void morososToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobros.Cuenta ct = new Cobros.Cuenta();
            ct.Show();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        // productos:
        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (prod == null)
            {
                prod = new frm_productos();
                prod.MdiParent = this;

                //prod.FormClosed += new FormClosedEventHandler(Prov_FormClosed);
                //prov.FormClosed += Prov_FormClosed(Prov_FormClosed);
                prod.FormClosed += new FormClosedEventHandler(Prod_FormClosed);
                prod.Show();
            }
        }

        private void Prod_FormClosed(object sender, FormClosedEventArgs e)
        {
            prod = null;
        }

        private void bitacoraDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bita_v == null)
            {
                bita_v = new frm_bitacora_ventas();
                bita_v.MdiParent = this;

                //prod.FormClosed += new FormClosedEventHandler(Prov_FormClosed);
                //prov.FormClosed += Prov_FormClosed(Prov_FormClosed);
                //bita_v.FormClosed += new FormClosedEventHandler(Prod_FormClosed);
                bita_v.FormClosed += new FormClosedEventHandler(Bita_v_FormClosed);
                bita_v.Show();
            }
        }

        private void Bita_v_FormClosed(object sender, FormClosedEventArgs e)
        {
            bita_v = null;
        }

        private void bitacoraDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bita_c == null)
            {
                bita_c = new frm_bita_compras();
                bita_c.MdiParent = this;
                //bita_c.FormClosed += new FormClosedEventHandler(Bita_v_FormClosed);
                bita_c.FormClosed += new FormClosedEventHandler(Bita_c_FormClosed);
                bita_c.Show();
            }
        }

        private void Bita_c_FormClosed(object sender, FormClosedEventArgs e)
        {
            bita_c = null;
        }
    }
}
