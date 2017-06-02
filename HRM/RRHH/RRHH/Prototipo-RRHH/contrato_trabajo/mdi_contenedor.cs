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
using seguridad;


namespace contrato_trabajo
{
    public partial class mdi_contenedor : Form
    {
        frm_activos_grid frm_activo;
        frm_aguinaldo frm_aguinaldo;
        frm_area_grid frm_area;
        frm_asistencia_cap frm_asistencia_cap;
        frm_bono_14 bono14;
        frm_seguro_social_grid seguro_ssocial;
        frm_cancelar_nominas cancelar_nomina;
        frm_candidato candidato;
        frm_capacitaciones_grid capacitaciones;
        frm_comisiones_grid comisiones;
        frm_comisiones_linea comisiones_linea;
        frm_comisiones_marca comisiones_marca;
        frm_comisiones_producto comisiones_producto;
        frm_comisiones_vendedor comisiones_vendedor;
        frm_contrato_grid contrato_grid;
        frm_desempeno_laboral desempeno_laboral;
        frm_empleado_grid empleado;
        frm_empresa_grid empresa;
        frm_estadistica_Pagos estadistica_pago;
        frm_grid_funcion funcion_grid;
        frm_grid_candidato candidato_grid;
        frm_grid_medio_distribucion medio_difucion;
        //frm_horas_extras horas_extra;
        frm_jornada_grid jornada_grid;
        //frm_nomina_grid nomina_grid;
        //frm_Otros otros;
        // frm_pago_impuestos pago_impuestos;
        frm_perfil_reclutamiento_grid perfil_reclutamiento;
        frm_indemnizacion indemnizacion;
        frm_prestaciones prestaciones;
        frm_progreso_reclutamiento progreso_reclutamiento;
        frm_puesto_lab_grid puesto_laboral;
        frm_reclutamiento_grid reclutamiento;
        frm_reportes_de_empleado reporte_empleado;
        frm_ubicacion ubicacion;
        FormAsignarPermisosUsuario nusr;
        FormDeshabilitarUsuario form_desh;
        Form_EditarPrivilegios form_priv;
        Form_EditarPerfil form_perf;
        CambioPass form_cambpass;
        FormAsignacionPerfil form_asig;
        agregarapp form_app;
        //Modificar_aplicacion form_app_UD = new Modificar_aplicacion();
        seguridad.Historial form_hist;
        //Form_login form_log = new Form_login();
        Form_infouser form_infouser;
        FormEliminarPerfil inofuser;
        // frm_vacaciones vacaciones;
        frm_vacaciones frm_vacas;
        nomina frm_nomina;
        frm_hora_extras_grid horas_grid;
        frm_impuesto_grid impuesto_grid;
        examen_evaluacion_grid frm_examenes;
        frm_calificacion_evaluacion_grid frm_cal_ex;
        frm_calculo_horas_grid fhoras;
        Frm_devengos_grid deve;
        frm_calculo_hora_descuento_grid dhoras;
        Frm_otros_deduccion_grif dedu;
        Reporte_nomina renomina;
        Frm_reporte_devengos redevengo;
        frm_reporte_deduccion rededu;

        String usuario;

        public mdi_contenedor(String user)
        {
            usuario = user;
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            String espacio = "                                                                                                                   ";
            ActiveForm.Text = "Modulo Recursos Humanos"+ espacio + "Usuario: " +usuario;
            BloquearMDI();
            Bloqueo.DesbloquearMDI(menuStrip1);
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

        private void BloquearMDI()
        {
            foreach (ToolStripMenuItem menu_principal in menuStrip1.Items)
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
            if (empleado == null)
            {
                empleado = new frm_empleado_grid();
                empleado.MdiParent = this;
                empleado.FormClosed += new FormClosedEventHandler(empleado_FormClosed);
                empleado.Show();
            }
        }
        void empleado_FormClosed(object sender, EventArgs e)
        {
            empleado = null;
        }

        private void contratosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (contrato_grid == null)
            {
                contrato_grid = new frm_contrato_grid();
                contrato_grid.MdiParent = this;
                contrato_grid.FormClosed += new FormClosedEventHandler(contrato_grid_FormClosed);
                contrato_grid.Show();
            }
        }
        void contrato_grid_FormClosed(object sender, EventArgs e)
        {
            contrato_grid = null;
        }

        private void capacitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (capacitaciones == null)
            {
                capacitaciones = new frm_capacitaciones_grid();
                capacitaciones.MdiParent = this;
                capacitaciones.FormClosed += new FormClosedEventHandler(capacitaciones_FormClosed);
                capacitaciones.Show();
            }
        }
        void capacitaciones_FormClosed(object sender, EventArgs e)
        {
            capacitaciones = null;
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
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
            
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
            if (comisiones_marca == null)
            {
                comisiones_marca = new frm_comisiones_marca();
                comisiones_marca.MdiParent = this;
                comisiones_marca.FormClosed += new FormClosedEventHandler(comisiones_marca_FormClosed);
                comisiones_marca.Show();
            }
        }
        void comisiones_marca_FormClosed(object sender, EventArgs e)
        {
            comisiones_marca = null;
        }

        private void porVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comisiones_vendedor == null)
            {
                comisiones_vendedor = new frm_comisiones_vendedor();
                comisiones_vendedor.MdiParent = this;
                comisiones_vendedor.FormClosed += new FormClosedEventHandler(comisiones_vendedor_FormClosed);
                comisiones_vendedor.Show();
            }
        }
        void comisiones_vendedor_FormClosed(object sender, EventArgs e)
        {
            comisiones_vendedor = null;
        }

        private void porLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comisiones_linea == null)
            {
                comisiones_linea = new frm_comisiones_linea();
                comisiones_linea.MdiParent = this;
                comisiones_linea.FormClosed += new FormClosedEventHandler(comisiones_linea_FormClosed);
                comisiones_linea.Show();
            }
        }
        void comisiones_linea_FormClosed(object sender, EventArgs e)
        {
            comisiones_linea = null;
        }

        private void porProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comisiones_producto == null)
            {
                comisiones_producto = new frm_comisiones_producto();
                comisiones_producto.MdiParent = this;
                comisiones_producto.FormClosed += new FormClosedEventHandler(comisiones_producto_FormClosed);
                comisiones_producto.Show();
            }
        }
        void comisiones_producto_FormClosed(object sender, EventArgs e)
        {
            comisiones_producto = null;
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir.Form2 f2 = new Form2();
            f2.Show();
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

        private void reclutamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reclutamiento == null)
            {
                reclutamiento = new frm_reclutamiento_grid();
                reclutamiento.MdiParent = this;
                reclutamiento.FormClosed += new FormClosedEventHandler(reclutamiento_FormClosed);
                reclutamiento.Show();
            }
        }
        void reclutamiento_FormClosed(object sender, EventArgs e)
        {
            reclutamiento = null;
        }

        private void medioDeDistribucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_grid_medio_distribucion cn = new frm_grid_medio_distribucion();
            cn.MdiParent = this;
            cn.StartPosition = FormStartPosition.CenterScreen;
            cn.Show();
        }



        private void activosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_activo == null)
            {
                frm_activo = new frm_activos_grid();
                frm_activo.MdiParent = this;
                frm_activo.FormClosed += new FormClosedEventHandler(frm_activo_FormClosed);
                frm_activo.Show();
            }
        }
        void frm_activo_FormClosed(object sender, EventArgs e)
        {
            frm_activo = null;
        }

        private void jornadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jornada_grid == null)
            {
                jornada_grid = new frm_jornada_grid();
                jornada_grid.MdiParent = this;
                jornada_grid.FormClosed += new FormClosedEventHandler(jornada_grid_FormClosed);
                jornada_grid.Show();
            }
        }
        void jornada_grid_FormClosed(object sender, EventArgs e)
        {
            jornada_grid = null;
        }

        private void puestoLaboralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (puesto_laboral == null)
            {
                puesto_laboral = new frm_puesto_lab_grid();
                puesto_laboral.MdiParent = this;
                puesto_laboral.FormClosed += new FormClosedEventHandler(puesto_laboral_FormClosed);
                puesto_laboral.Show();
            }
        }
        void puesto_laboral_FormClosed(object sender, EventArgs e)
        {
            puesto_laboral = null;
        }

        private void perfilReclutamientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (perfil_reclutamiento == null)
            {
                perfil_reclutamiento = new frm_perfil_reclutamiento_grid();
                perfil_reclutamiento.MdiParent = this;
                perfil_reclutamiento.FormClosed += new FormClosedEventHandler(perfil_reclutamiento_FormClosed);
                perfil_reclutamiento.Show();
            }
        }
        void perfil_reclutamiento_FormClosed(object sender, EventArgs e)
        {
            perfil_reclutamiento = null;
        }

        private void candidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (candidato_grid == null)
            {
                candidato_grid = new frm_grid_candidato();
                candidato_grid.MdiParent = this;
                candidato_grid.FormClosed += new FormClosedEventHandler(candidato_grid_FormClosed);
                candidato_grid.Show();
            }
        }
        void candidato_grid_FormClosed(object sender, EventArgs e)
        {
            candidato_grid = null;
        }

        private void medioDeDifuciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (medio_difucion == null)
            {
                medio_difucion = new frm_grid_medio_distribucion();
                medio_difucion.MdiParent = this;
                medio_difucion.FormClosed += new FormClosedEventHandler(medio_difucion_FormClosed);
                medio_difucion.Show();
            }
        }
        void medio_difucion_FormClosed(object sender, EventArgs e)
        {
            medio_difucion = null;
        }

        private void funcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (funcion_grid == null)
            {
                funcion_grid = new frm_grid_funcion();
                funcion_grid.MdiParent = this;
                funcion_grid.FormClosed += new FormClosedEventHandler(funcion_grid_FormClosed);
                funcion_grid.Show();
            }
        }
        void funcion_grid_FormClosed(object sender, EventArgs e)
        {
            funcion_grid = null;
        }

        private void examenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_examenes == null)
            {
                frm_examenes = new examen_evaluacion_grid();
                frm_examenes.MdiParent = this;
                frm_examenes.FormClosed += new FormClosedEventHandler(frm_examenes_FormClosed);
                frm_examenes.Show();
            }
        }
        void frm_examenes_FormClosed(object sender, EventArgs e)
        {
            frm_examenes = null;
        }

        private void areaDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_area == null)
            {
                frm_area = new frm_area_grid();
                frm_area.MdiParent = this;
                frm_area.FormClosed += new FormClosedEventHandler(frm_area_FormClosed);
                frm_area.Show();
            }
        }
        void frm_area_FormClosed(object sender, EventArgs e)
        {
            frm_area = null;
        }

        private void horasExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (horas_grid == null)
            {
                horas_grid = new frm_hora_extras_grid();
                horas_grid.MdiParent = this;
                horas_grid.FormClosed += new FormClosedEventHandler(horas_grid_FormClosed);
                horas_grid.Show();
            }
        }
        void horas_grid_FormClosed(object sender, EventArgs e)
        {
            horas_grid = null;
        }

        private void tasaImpuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (impuesto_grid == null)
            {
                impuesto_grid = new frm_impuesto_grid();
                impuesto_grid.MdiParent = this;
                impuesto_grid.FormClosed += new FormClosedEventHandler(impuesto_grid_FormClosed);
                impuesto_grid.Show();
            }
        }
        void impuesto_grid_FormClosed(object sender, EventArgs e)
        {
            impuesto_grid = null;
        }

        private void seguroSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguro_ssocial == null)
            {
                seguro_ssocial = new frm_seguro_social_grid();
                seguro_ssocial.MdiParent = this;
                seguro_ssocial.FormClosed += new FormClosedEventHandler(seguro_ssocial_FormClosed);
                seguro_ssocial.Show();
            }
        }
        void seguro_ssocial_FormClosed(object sender, EventArgs e)
        {
            seguro_ssocial = null;
        }

        private void evaluaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (progreso_reclutamiento == null)
            {
                progreso_reclutamiento = new frm_progreso_reclutamiento();
                progreso_reclutamiento.MdiParent = this;
                progreso_reclutamiento.FormClosed += new FormClosedEventHandler(progreso_reclutamiento_FormClosed);
                progreso_reclutamiento.Show();
            }
        }
        void progreso_reclutamiento_FormClosed(object sender, EventArgs e)
        {
            progreso_reclutamiento = null;
        }

        private void asistenciaCapacitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_asistencia_cap == null)
            {
                frm_asistencia_cap = new frm_asistencia_cap();
                frm_asistencia_cap.MdiParent = this;
                frm_asistencia_cap.FormClosed += new FormClosedEventHandler(frm_asistencia_cap_FormClosed);
                frm_asistencia_cap.Show();
            }
        }
        void frm_asistencia_cap_FormClosed(object sender, EventArgs e)
        {
            frm_asistencia_cap = null;
        }

        private void indemnizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (indemnizacion == null)
            {
                indemnizacion = new frm_indemnizacion();
                indemnizacion.MdiParent = this;
                indemnizacion.FormClosed += new FormClosedEventHandler(indemnizacion_FormClosed);
                indemnizacion.Show();
            }
        }
        void indemnizacion_FormClosed(object sender, EventArgs e)
        {
            indemnizacion = null;
        }

        private void nominaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frm_nomina == null)
            {
                frm_nomina = new nomina();
                frm_nomina.MdiParent = this;
                frm_nomina.FormClosed += new FormClosedEventHandler(nomina_grid_FormClosed);
                frm_nomina.Show();
            }
        }
        void nomina_grid_FormClosed(object sender, EventArgs e)
        {
            frm_nomina = null;
        }

        private void reporteDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_infouser == null)
            {
                form_infouser = new Form_infouser();
                form_infouser.MdiParent = this;

                form_infouser.FormClosed += new FormClosedEventHandler(FormInfoUser_FormClosed);
                form_infouser.Show();
            }
        }
        public void FormInfoUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_infouser = null;
        }

        private void vacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_vacas == null)
            {
                frm_vacas = new frm_vacaciones();
                frm_vacas.MdiParent = this;

                frm_vacas.FormClosed += new FormClosedEventHandler(vacaciones_FormClosed);
                frm_vacas.Show();
            }
        }
        public void vacaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_vacas = null;
        }

        private void calificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_cal_ex == null)
            {
                frm_cal_ex = new frm_calificacion_evaluacion_grid();
                frm_cal_ex.MdiParent = this;
                frm_cal_ex.FormClosed += new FormClosedEventHandler(frm_cal_ex_FormClosed);
                frm_cal_ex.Show();
            }
        }

        void frm_cal_ex_FormClosed(object sender, EventArgs e)
        {
            frm_cal_ex = null;
        }

        private void horasExtraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fhoras == null)
            {
                fhoras = new frm_calculo_horas_grid();
                fhoras.MdiParent = this;

                fhoras.FormClosed += new FormClosedEventHandler(fhoras_FormClosed);
                fhoras.Show();
            }
        }
        public void fhoras_FormClosed(object sender, FormClosedEventArgs e)
        {
            fhoras = null;
        }

        private void devengoExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deve == null)
            {
                deve = new Frm_devengos_grid();
                deve.MdiParent = this;

                deve.FormClosed += new FormClosedEventHandler(deve_FormClosed);
                deve.Show();
            }
        }
        public void deve_FormClosed(object sender, FormClosedEventArgs e)
        {
            deve = null;
        }

        private void horasDescontadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dhoras == null)
            {
                dhoras = new frm_calculo_hora_descuento_grid();
                dhoras.MdiParent = this;

                dhoras.FormClosed += new FormClosedEventHandler(dhoras_FormClosed);
                dhoras.Show();
            }
        }
        public void dhoras_FormClosed(object sender, FormClosedEventArgs e)
        {
            dhoras = null;
        }

        private void deducionExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dedu == null)
            {
                dedu = new Frm_otros_deduccion_grif();
                dedu.MdiParent = this;

                dedu.FormClosed += new FormClosedEventHandler(dedu_FormClosed);
                dedu.Show();
            }
        }
        public void dedu_FormClosed(object sender, FormClosedEventArgs e)
        {
            dedu = null;
        }

        private void nominaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (renomina == null)
            {
                renomina = new Reporte_nomina();
                renomina.MdiParent = this;

                renomina.FormClosed += new FormClosedEventHandler(reno_FormClosed);
                renomina.Show();
            }
        }
        public void reno_FormClosed(object sender, FormClosedEventArgs e)
        {
            renomina = null;
        }

        private void devengoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (redevengo == null)
            {
                redevengo = new Frm_reporte_devengos();
                redevengo.MdiParent = this;

                redevengo.FormClosed += new FormClosedEventHandler(rede_FormClosed);
                redevengo.Show();
            }
        }
        public void rede_FormClosed(object sender, FormClosedEventArgs e)
        {
            redevengo = null;
        }

        private void deduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rededu == null)
            {
                rededu = new frm_reporte_deduccion();
                rededu.MdiParent = this;

                rededu.FormClosed += new FormClosedEventHandler(rededu_FormClosed);
                rededu.Show();
            }
        }
        public void rededu_FormClosed(object sender, FormClosedEventArgs e)
        {
            rededu = null;
        }
    }
}

