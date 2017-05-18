using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesNavegador;
using dllconsultas;
using System.Data.Odbc;
using MySql.Data.MySqlClient;
using System.Threading;
using System.IO;

namespace contrato_trabajo
{
    public partial class frm_empleado : Form
    {

        #region Cargar Form de Empleados
        //=======================================================================================================================
        //--------------------------------------Form Empleados--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public frm_empleado(DataGridView dgv, String id_empleado_pk, Boolean Editar, Boolean tipo_accion)
        {
            this.dg = dgv;
            this.Editar1 = Editar;
            InitializeComponent();
            //atributo = "id_empleado_pk";
            this.Codigo = id_empleado_pk;
            string tabla = "empleado";
            this.accion1 = tipo_accion;
            fn.ActualizarGrid(this.dgv_datos_generales_emp, "Select * from empleado WHERE id_empleado_pk = '" + id_empleado_pk + "' ", tabla);
            string tabla2 = "emp_datopersonal ";
            fn.ActualizarGrid(this.dgv_datos_personales, "SELECT fecha_nacimiento, nombre_del_padre, nombre_de_madre, genero_empleado, estado_civil, documentacion_del_trabajador, observaciones_emp FROM empleado, emp_datopersonal WHERE empleado.id_empleado_pk = emp_datopersonal.id_empleado_pk AND empleado.id_empleado_pk = '" + id_empleado_pk + "' ", tabla2);

        }
        #endregion

        #region Valiables del Form
        //=======================================================================================================================
        //--------------------------------------Form Empleados--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        string imgLoc;
        string imgname;
        Boolean Editar1;
        Boolean accion1;
        Boolean entrar;
        String Codigo, Codigo1;
        String atributo, atributo2;
        DataGridView dg;
        CapaNegocio fn = new CapaNegocio();
        #endregion

        #region Insertar en las Tablas
        //=======================================================================================================================
        //--------------------------------------INSERTAR TABLAS--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public void InsertarDatosEmpleado()
        {
            if (tbc_datos_emp.SelectedTab == General)
            {
                try
                {
                    
                    txt_estado.Text = "ACTIVO";
                    TextBox[] textbox = { txt_codigo_emp, txt_dpi_emp, txt_igss_emp, txt_estado, txt_nombres_emp, txt_apellidos_emp, txt_cbo_estado_emp, txt_dtp_fecha_alta_emp, txt_dtp_fecha_baja_emp, txt_domicilio_emp, txt_cbo_nacionalidad_emp, txt_cbo_forma_pago_emp, txt_cbo_empresa_asig, txt_nom_img };
                    DataTable datos = fn.construirDataTable(textbox);
                    if (datos.Rows.Count == 0)
                    {
                        string tabla = "empleado";
                        if (Editar1)
                        {
                            fn.modificar(datos, tabla, atributo, Codigo);
                        }
                        else
                        {
                            fn.insertar(datos, tabla);
                            Conexionmysql.ObtenerConexion();
                        }
                    }
                    else
                    {
                        string tabla = "empleado";
                        if (Editar1)
                        {
                            fn.modificar(datos, tabla, atributo, Codigo);
                        }
                        else
                        {
                            fn.insertar(datos, tabla);
                            Conexionmysql.ObtenerConexion();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if (tbc_datos_emp.SelectedTab == Personal)
            {
                try
                {

                    txt_estado.Text = "ACTIVO";    
                    TextBox[] textbox1 = { txt_estado, txt_dtp_fecha_nacimiento_emp, txt_nombre_padre_emp, txt_nombre_madre_emp, txt_cbo_genero_emp, txt_cbo_estado_civil_emp, txt_folder_empleado, txt_id_empleado_P, txt_observaciones_emp };
                    DataTable datos1 = fn.construirDataTable(textbox1);
                    if (datos1.Rows.Count == 0)
                    {
                        string tabla2 = "emp_datopersonal";
                        if (Editar1)
                        {
                            fn.modificar(datos1, tabla2, atributo2, Codigo1);
                        }
                        else
                        {
                            fn.insertar(datos1, tabla2);
                            Conexionmysql.ObtenerConexion();
                        }
                    }
                    else
                    {
                        string tabla2 = "emp_datopersonal";
                        if (Editar1)
                        {
                            fn.modificar(datos1, tabla2, atributo2, Codigo1);
                        }
                        else
                        {
                            fn.insertar(datos1, tabla2);
                            Conexionmysql.ObtenerConexion();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            if (tbc_datos_emp.SelectedTab == Situacion)
            {
                try
                {
                    txt_estado.Text = "ACTIVO";
                    TextBox[] textbox = { txt_cbo_puesto_laboral, txt_cbo_area_laboral, txt_cbo_jornadas_trabajo };
                    DataTable datos = fn.construirDataTable(textbox);
                    if (datos.Rows.Count == 0)
                    {
                        string tabla = "empleado";
                        if (Editar1)
                        {
                            fn.modificar(datos, tabla, atributo, Codigo);
                        }
                        else
                        {
                            fn.insertar(datos, tabla);
                            Conexionmysql.ObtenerConexion();
                        }
                    }
                    else
                    {
                        string tabla = "empleado";
                        if (Editar1)
                        {
                            fn.modificar(datos, tabla, atributo, Codigo);
                        }
                        else
                        {
                            fn.insertar(datos, tabla);
                            Conexionmysql.ObtenerConexion();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }
        #endregion

        #region Llenar Informacion del Empleado
        //=======================================================================================================================
        //--------------------------------------Llenar Informacion--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public void cargarDatos()
        {
            //if (accion1 == true && tbc_datos_emp.SelectedTab == General)
            //{
                try
                {
                    txt_id_empleado_P.Text =  this.dgv_datos_generales_emp.CurrentRow.Cells[0].Value.ToString();
                txt_codigo_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[0].Value.ToString();
                    txt_dpi_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[1].Value.ToString();
                    txt_igss_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[2].Value.ToString();
                    txt_cbo_estado_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[3].Value.ToString(); cbo_estado_emp.Text = txt_cbo_estado_emp.Text;
                    txt_dtp_fecha_alta_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[4].Value.ToString(); dtp_fecha_alta_emp.Text = txt_dtp_fecha_alta_emp.Text;
                    txt_dtp_fecha_baja_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[5].Value.ToString(); dtp_fecha_baja_emp.Text = txt_dtp_fecha_baja_emp.Text;
                    txt_nombres_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[6].Value.ToString();
                    txt_apellidos_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[7].Value.ToString();
                    //txt_telefono_hogar_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[8].Value.ToString();
                    //txt_tel_movil_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[9].Value.ToString();
                    txt_nom_img.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[10].Value.ToString();
                    txt_domicilio_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[11].Value.ToString();
                    txt_cbo_nacionalidad_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[12].Value.ToString(); cbo_nacionalidad_emp.Text = txt_cbo_nacionalidad_emp.Text;
                    txt_cbo_forma_pago_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[13].Value.ToString(); cbo_forma_pago_emp.Text = txt_cbo_forma_pago_emp.Text;
                string direc = txt_nom_img.Text;
                pic_empleado.ImageLocation = @"C:\empleados\" + direc;
            }
                catch
                {

                }
           // }
            //if (accion1 == true && tbc_datos_emp.SelectedTab == Personal)
            //{
                try
                {
                    txt_dtp_fecha_nacimiento_emp.Text = this.dgv_datos_personales.CurrentRow.Cells[0].Value.ToString();
                    txt_nombre_padre_emp.Text = this.dgv_datos_personales.CurrentRow.Cells[1].Value.ToString();
                    txt_nombre_madre_emp.Text = this.dgv_datos_personales.CurrentRow.Cells[2].Value.ToString();
                    txt_cbo_genero_emp.Text = this.dgv_datos_personales.CurrentRow.Cells[3].Value.ToString(); cbo_genero_emp.Text = txt_cbo_genero_emp.Text;
                    txt_cbo_estado_civil_emp.Text = this.dgv_datos_personales.CurrentRow.Cells[4].Value.ToString(); cbo_estado_civil_emp.Text = txt_cbo_estado_civil_emp.Text;
                    txt_folder_empleado.Text = this.dgv_datos_personales.CurrentRow.Cells[5].Value.ToString();
                    txt_observaciones_emp.Text = this.dgv_datos_personales.CurrentRow.Cells[6].Value.ToString();

                }
                catch
                {

                }
           // }
        }
        #endregion

        #region Inicio del Form
        //=======================================================================================================================
        //--------------------------------------Inicio Form--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void Empleado_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(tbc_datos_emp);
            fn.InhabilitarComponentes(General);
            fn.InhabilitarComponentes(Personal);
            fn.InhabilitarComponentes(Situacion);
            fn.InhabilitarComponentes(this);
            dtp_fecha_alta_emp.Format = DateTimePickerFormat.Custom;
            dtp_fecha_alta_emp.CustomFormat = "yyyy-MM-dd";
            dtp_fecha_baja_emp.Format = DateTimePickerFormat.Custom;
            dtp_fecha_baja_emp.CustomFormat = "yyyy-MM-dd";
            dtp_fecha_nacimiento_emp.Format = DateTimePickerFormat.Custom;
            dtp_fecha_nacimiento_emp.CustomFormat = "yyyy-MM-dd";
            entrar = true;
            cargarDatos();
            llenaridempresa();
            llenarJornada();
            llenarPuesto();
            llenarAreaEmpres();
        }
        #endregion

        #region Boton Examinar Imagen
        //=======================================================================================================================
        //--------------------------------------Imagen--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_examinar_pic_emp_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Selecciones su foto de perfil";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    imgname = dlg.SafeFileName.ToString();
                    txt_nom_img.Text = imgname;
                    pic_empleado.ImageLocation = imgLoc;
                    txt_direc_img.Text = imgLoc;
                    string targetPath = @"C:/empleados";
                    string sourceFile = System.IO.Path.Combine(imgLoc);
                    string destFile = System.IO.Path.Combine(targetPath, imgname);
                    if (!System.IO.Directory.Exists(targetPath))
                    {
                        System.IO.Directory.CreateDirectory(targetPath);
                    }
                    System.IO.File.Copy(sourceFile, destFile, true);
                    txt_img_final.Text = destFile;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Nuevo Empleado
        //=======================================================================================================================
        //--------------------------------------Nuevo Empleado--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                entrar = true;
                fn.ActivarControles(gpb_datos_emp);
                fn.ActivarControles(General);
                dtp_fecha_baja_emp.Enabled = false;
                fn.ActivarControles(Personal);
                fn.ActivarControles(this);
                fn.LimpiarComponentes(gpb_datos_emp);
                fn.LimpiarComponentes(General);
                fn.LimpiarComponentes(Personal);
                fn.LimpiarComponentes(Situacion);
                pic_empleado.Image = null;
                dgv_datos_generales_emp.DataSource = null;
                dgv_datos_personales.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Cancelar Accion
        //=======================================================================================================================
        //--------------------------------------Cancelar--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                 fn.LimpiarComponentes(tbc_datos_emp);
                 fn.LimpiarComponentes(General);
                 fn.LimpiarComponentes(Personal);
                fn.LimpiarComponentes(Situacion);
                fn.InhabilitarComponentes(tbc_datos_emp);
                fn.InhabilitarComponentes(General);
                fn.InhabilitarComponentes(Personal);
                fn.InhabilitarComponentes(Situacion);
                fn.LimpiarComponentes(this);
                fn.InhabilitarComponentes(this);
                pic_empleado.InitialImage = null;
                pic_empleado.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Actualizar Grid
        //=======================================================================================================================
        //--------------------------------------Actualizar--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Boton Guardar Datos
        //=======================================================================================================================
        //--------------------------------------Guardar--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (entrar == true)
                {
                    InsertarDatosEmpleado();
                    fn.InhabilitarComponentes(General);
                    fn.InhabilitarComponentes(Personal);
                    fn.InhabilitarComponentes(Situacion);

                }
                if (entrar == false)
                {
                    MessageBox.Show("update");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Boton Detalle del Nombre del Empleado
        //=======================================================================================================================
        //--------------------------------------Nombre Detallado--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public void btn_detalle_nombre_emp_Click(object sender, EventArgs e)
        {
            try
            {
                frm_desglosar_nombre des_nombre = new frm_desglosar_nombre(this);
                des_nombre.MdiParent = this.ParentForm;
                des_nombre.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Asignacion del Nombre del empleado - Ayuda
        //=======================================================================================================================
        //--------------------------------------Asignacion Nombre--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public void PassNombre(string strValue)
        {
            txt_nombres_emp.Text = strValue;
        }

        public void PassApellido(string strValue)
        {
            txt_apellidos_emp.Text = strValue;
        }
        #endregion

        #region Acciones a realizar
        //=======================================================================================================================
        //-------------------------------------Funciones a Realizar---------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void cbo_estado_emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cbo_estado_emp.Text = cbo_estado_emp.Text;
            
        }

        private void dtp_fecha_alta_emp_ValueChanged(object sender, EventArgs e)
        {
            txt_dtp_fecha_alta_emp.Text = dtp_fecha_alta_emp.Text;
        }

        private void dtp_fecha_baja_emp_ValueChanged(object sender, EventArgs e)
        {
            txt_dtp_fecha_baja_emp.Text = dtp_fecha_baja_emp.Text;
        }

        private void cbo_nacionalidad_emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cbo_nacionalidad_emp.Text = cbo_nacionalidad_emp.Text;
        }

        private void cbo_forma_pago_emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cbo_forma_pago_emp.Text = cbo_forma_pago_emp.Text;
        } 

        private void dtp_fecha_nacimiento_emp_ValueChanged(object sender, EventArgs e)
        {
            txt_dtp_fecha_nacimiento_emp.Text = dtp_fecha_nacimiento_emp.Text;
        }

        private void cbo_genero_emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cbo_genero_emp.Text = cbo_genero_emp.Text;
        }

        private void cbo_estado_civil_emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cbo_estado_civil_emp.Text = cbo_estado_civil_emp.Text;
        }

        private void cbo_empresa_asig_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cbo_empresa_asig.Text = cbo_empresa_asig.SelectedValue.ToString();
        }

        private void cbo_puesto_laboral_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_cbo_puesto_laboral.Text = cbo_puesto_laboral.SelectedValue.ToString();
        }

        private void cbo_area_laboral_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_cbo_area_laboral.Text = cbo_area_laboral.SelectedValue.ToString();
        }

        private void cbo_jornadas_trabajo_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_cbo_jornadas_trabajo.Text = cbo_jornadas_trabajo.SelectedValue.ToString();
        }

        private void txt_cbo_jornadas_trabajo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_puesto_laboral_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cbo_jornadas_trabajo.Text = cbo_jornadas_trabajo.Text;
            if (cbo_jornadas_trabajo.SelectedItem.ToString() == "VENDEDOR" || cbo_jornadas_trabajo.SelectedItem.ToString() == "Vendedor")
            {
                txt_cbo_jornadas_trabajo.Enabled = true;
            }
        }
        #endregion

        #region Boton Examinar carpeta del empleado
        //=======================================================================================================================
        //--------------------------------------Examinar Carpeta--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_examinar_documentacion_emp_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_folder_empleado.Text = fbd.SelectedPath;
            }
        }
        #endregion

        #region Boton para mostrar Empresas
        //=======================================================================================================================
        //--------------------------------------Mostrar Empresa--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_empresa_emp_Click(object sender, EventArgs e)
        {
            try
            {
                frm_empresa_grid empre_emp = new frm_empresa_grid();
                empre_emp.MdiParent = this.ParentForm;
                empre_emp.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Cargar Informacion en ComboBox
        //=======================================================================================================================
        //--------------------------------------Cargar ComboBox--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public void llenaridempresa()
        {
            Conexionmysql.ObtenerConexion();
            DataSet ds = new DataSet();
            String Query = "SELECT id_empresa_pk, nombre_empresa FROM empresa WHERE estado ='ACTIVO'";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            dad.Fill(ds, "empresa");
            cbo_empresa_asig.DataSource = ds.Tables[0].DefaultView;
            cbo_empresa_asig.ValueMember = ("id_empresa_pk");
            cbo_empresa_asig.DisplayMember = ("nombre_empresa");
            Conexionmysql.Desconectar();
        }

        public void llenarJornada()
        {
            Conexionmysql.ObtenerConexion();
            DataSet ds = new DataSet();
            String Query = "SELECT id_jornadatrabajo_pk, forma_cobro FROM emp_jornadatrabajo WHERE estado ='ACTIVO'";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            dad.Fill(ds, "emp_jornadatrabajo");
            cbo_jornadas_trabajo.DataSource = ds.Tables[0].DefaultView;
            cbo_jornadas_trabajo.ValueMember = ("id_jornadatrabajo_pk");
            cbo_jornadas_trabajo.DisplayMember = ("forma_cobro");
            Conexionmysql.Desconectar();
        }

        public void llenarPuesto()
        {
            Conexionmysql.ObtenerConexion();
            DataSet ds = new DataSet();
            String Query = "SELECT id_puesto_laboral_pk, nombre_puesto FROM puesto_laboral WHERE estado ='ACTIVO'";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            dad.Fill(ds, "puesto_laboral");
            cbo_puesto_laboral.DataSource = ds.Tables[0].DefaultView;
            cbo_puesto_laboral.ValueMember = ("id_puesto_laboral_pk");
            cbo_puesto_laboral.DisplayMember = ("nombre_puesto");
            Conexionmysql.Desconectar();
        }

        public void llenarAreaEmpres()
        {
            Conexionmysql.ObtenerConexion();
            DataSet ds = new DataSet();
            String Query = "SELECT id_area_trabajo_pk, puesto FROM area_trabajo WHERE estado ='ACTIVO'";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            dad.Fill(ds, "area_trabajo");
            cbo_area_laboral.DataSource = ds.Tables[0].DefaultView;
            cbo_area_laboral.ValueMember = ("id_area_trabajo_pk");
            cbo_area_laboral.DisplayMember = ("puesto");
            Conexionmysql.Desconectar();
        }

        #endregion

        #region Boton Agregar Telefono
        //=======================================================================================================================
        //--------------------------------------Telefono Empleado--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_agragar_telefonos_Click(object sender, EventArgs e)
        {
            try
            {
                
                Codigo = this.dgv_datos_generales_emp.CurrentRow.Cells[0].Value.ToString();
                frm_emp_telefono_grid telefono = new frm_emp_telefono_grid(Codigo);
                telefono.MdiParent = this.ParentForm;
                telefono.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Editar
        //=======================================================================================================================
        //------------------------------------------------- Editar --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (tbc_datos_emp.SelectedTab == General)
            {
                Editar1 = true;
                atributo = "id_empleado_pk";

                fn.ActivarControles(gpb_datos_emp);
                fn.ActivarControles(General);
                dtp_fecha_baja_emp.Enabled = false;

            }
            if (tbc_datos_emp.SelectedTab == Personal)
            {
                if (string.IsNullOrEmpty(txt_folder_empleado.Text.Trim()))
                {
                    Editar1 = false;
                    Codigo1 = "Id_datopersonal";
                    atributo2 = "Id_datopersonal";
                    fn.ActivarControles(gpb_datos_emp);
                    txt_estado.Text = "ACTIVO";
                    dtp_fecha_baja_emp.Enabled = false;
                    fn.ActivarControles(Personal);
                }
                else
                {
                    Editar1 = true;
                    atributo2 = "Id_datopersonal";
                    Codigo1 = "Id_datopersonal";
                    fn.ActivarControles(gpb_datos_emp);
                    txt_estado.Text = "ACTIVO";
                    dtp_fecha_baja_emp.Enabled = false;
                    fn.ActivarControles(Personal);
                }

            }
            if (tbc_datos_emp.SelectedTab == Situacion)
            {
                Editar1 = true;
                atributo = "id_empleado_pk";
                
                //Codigo1 = "Id_datopersonal";
                    fn.ActivarControles(gpb_datos_emp);
                    txt_estado.Text = "ACTIVO";
                    fn.ActivarControles(Situacion);
                txt_cbo_jornadas_trabajo.Enabled = false;

            }
        }
        #endregion

        #region Boton Agregar Correo
        //=======================================================================================================================
        //------------------------------------------Correo Empleado--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_agregar_correos_Click(object sender, EventArgs e)
        {
            try
            {

                Codigo = this.dgv_datos_generales_emp.CurrentRow.Cells[0].Value.ToString();
                frm_emp_correos_grid correos = new frm_emp_correos_grid(Codigo);
                correos.MdiParent = this.ParentForm;
                correos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

    }
}
