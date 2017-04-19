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
using System.Drawing;
using System.Data;
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
            atributo = "id_empleado_pk";
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
        String Codigo;
        Boolean Editar1;
        Boolean accion1;
        Boolean entrar;
        String atributo;
        MySqlCommand comand;
        CapaNegocio fn = new CapaNegocio();
        DataGridView dg;
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
                    Conexionmysql.ObtenerConexion();
                    String Query = "INSERT INTO `empleado` (`id_empleado_pk`, `id_empleado_pk`, `dpi_emp`, `no_afiliacionIGSS_emp`, `estadolaboral`, `fecha_de_alta_emp`, `fecha_de_baja_emp`, `nombre_emp`, `apellido_emp`, `telefono_hogar_emp`, `telefono_movil_emp`, `fotografia_emp`, `direccion_emp`, `nacionalidad_emp`, `periodo_pago`, `estado`, `id_empresa_pk`) VALUES ('"+txt_codigo_emp.Text+"','" + txt_nombres_emp.Text + "', '" + txt_dpi_emp.Text + "', '" + txt_igss_emp.Text + "', '" + txt_cbo_estado_emp.Text + "', '" + txt_dtp_fecha_alta_emp.Text + "', '" + txt_dtp_fecha_baja_emp.Text + "', '" + txt_nombres_emp.Text + "', '" + txt_apellidos_emp.Text + "', '" + txt_telefono_hogar_emp.Text + "', '" + txt_tel_movil_emp.Text + "', '" + txt_nom_img.Text + "', '" + txt_domicilio_emp.Text + "', '" + txt_cbo_nacionalidad_emp.Text + "', '" + txt_cbo_forma_pago_emp.Text + "', 'ACTIVO', '"+txt_cbo_empresa_asig.Text+"');";
                    Conexionmysql.EjecutarMySql(Query);
                    Conexionmysql.Desconectar();


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
                    Conexionmysql.ObtenerConexion();
                    String Query2 = "INSERT INTO `emp_datopersonal` (`fecha_nacimiento`, `nombre_del_padre`, `nombre_de_madre`, `genero_empleado`, `estado_civil`, `documentacion_del_trabajador`, `observaciones_emp`, `id_empleado_pk`) VALUES ('" + txt_dtp_fecha_nacimiento_emp.Text + "', '" + txt_nombre_padre_emp.Text + "', '" + txt_nombre_madre_emp.Text + "', '" + txt_cbo_genero_emp.Text + "', '" + txt_cbo_estado_civil_emp.Text + "', '" + txt_folder_empleado.Text + "', '" + txt_observaciones_emp.Text + "', '" + Codigo + "');";
                    Conexionmysql.EjecutarMySql(Query2);
                    Conexionmysql.Desconectar();


                }
                catch
                {
                    MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }

        }
        #endregion

        #region Llenar Informacion del Empleado
        //=======================================================================================================================
        //--------------------------------------INSERTAR TABLAS--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public void cargarDatos()
        {
            //if (accion1 == true && tbc_datos_emp.SelectedTab == General)
            //{
                try
                {
                    txt_codigo_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[0].Value.ToString();
                    txt_dpi_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[1].Value.ToString();
                    txt_igss_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[2].Value.ToString();
                    txt_cbo_estado_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[3].Value.ToString(); cbo_estado_emp.Text = txt_cbo_estado_emp.Text;
                    txt_dtp_fecha_alta_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[4].Value.ToString(); dtp_fecha_alta_emp.Text = txt_dtp_fecha_alta_emp.Text;
                    txt_dtp_fecha_baja_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[5].Value.ToString(); dtp_fecha_baja_emp.Text = txt_dtp_fecha_baja_emp.Text;
                    txt_nombres_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[6].Value.ToString();
                    txt_apellidos_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[7].Value.ToString();
                    txt_telefono_hogar_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[8].Value.ToString();
                    txt_tel_movil_emp.Text = this.dgv_datos_generales_emp.CurrentRow.Cells[9].Value.ToString();
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
            entrar = true;
            cargarDatos();
            llenaridempresa();
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
                fn.ActivarControles(Situacion);
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
        //--------------------------------------Nombre--------------------------------------------------------------
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
        //--------------------------------------Nombre--------------------------------------------------------------
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
        //----------------------------------------------------------------------------------------------------
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
        #endregion

        #region Boton Examinar carpeta del empleado
        //=======================================================================================================================
        //--------------------------------------Nombre--------------------------------------------------------------
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
        //--------------------------------------Nombre--------------------------------------------------------------
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
        //--------------------------------------Nombre--------------------------------------------------------------
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

        #endregion

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

        private void btn_editar_Click(object sender, EventArgs e)
        {
            fn.ActivarControles(gpb_datos_emp);
            fn.ActivarControles(General);
            dtp_fecha_baja_emp.Enabled = false;
            fn.ActivarControles(Personal);
            fn.ActivarControles(Situacion);
        }

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
    }
}
