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
    public partial class frm_activos : Form
    {
        #region Variables del Form Activos
        //=======================================================================================================================
        //--------------------------------------Variables--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        String Codigo;
        Boolean Editar;
        String atributo;
        int contador_letras;
        CapaNegocio fn = new CapaNegocio();
        DataGridView dg;
        
        #endregion

        #region Inicio del Form
        //=======================================================================================================================
        //--------------------------------------Form Activos--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public frm_activos(DataGridView dgv, String id_activos_emp_pk, String nombre_activo, String num_serie_activo, String precio_activo, String descripcion_activo , String estado, Boolean Editar1, Boolean tipo_accion)
        {
            try
            {
                this.dg = dgv;
                this.Editar = Editar1;
                InitializeComponent();
                atributo = "id_activos_emp_pk";
                this.Codigo = id_activos_emp_pk;
                if (tipo_accion == true)
                {
                    this.txt_nombre_activo.Text = nombre_activo;
                    this.txt_serie_activo.Text = num_serie_activo;
                    this.txt_nmup_cantidad_activo.Text = precio_activo; nmup_cantidad_activo.Value = Convert.ToDecimal(txt_nmup_cantidad_activo.Text);
                    this.txt_descripcion_activo.Text = descripcion_activo;
                    this.fn.ActivarControles(gpb_activos);
                }
                else
                {
                    fn.ActivarControles(gpb_activos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Funciones a Realizar
        //=======================================================================================================================
        //-----------------------------------------------------------------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void nmup_cantidad_activo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_nmup_cantidad_activo.Text = nmup_cantidad_activo.Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Carga del Form Activos
        //=======================================================================================================================
        //--------------------------------------Carga del Form--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void frm_activos_Load(object sender, EventArgs e)
        {
            try
            {
                fn.InhabilitarComponentes(gpb_activos);
                fn.InhabilitarComponentes(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Nuevo
        //=======================================================================================================================
        //--------------------------------------Nuevo--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_activos);
                fn.LimpiarComponentes(gpb_activos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Guardar
        //=======================================================================================================================
        //--------------------------------------Guardar--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_estado.Text = "ACTIVO";
                TextBox[] textbox = { txt_nombre_activo, txt_serie_activo, txt_nmup_cantidad_activo, txt_descripcion_activo, txt_estado };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "activos_empresa";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fn.InhabilitarComponentes(gpb_activos);
                        Actualizar_grid();
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fn.LimpiarComponentes(gpb_activos);
                        fn.InhabilitarComponentes(gpb_activos);
                        Actualizar_grid();
                        Conexionmysql.ObtenerConexion();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Editar
        //=======================================================================================================================
        //--------------------------------------Editar--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "id_activos_emp_pk";           
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_activo.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_serie_activo.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); 
                this.txt_nmup_cantidad_activo.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); nmup_cantidad_activo.Value = Convert.ToDecimal(txt_nmup_cantidad_activo.Text);
                this.txt_descripcion_activo.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                fn.ActivarControles(gpb_activos);
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton Eliminar
        //=======================================================================================================================
        //--------------------------------------Eliminar--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_activos_emp_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string tabla = "activos_empresa";
                    fn.eliminar(tabla, atributo2, codigo2);
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar_grid();
                    fn.InhabilitarComponentes(gpb_activos);
                    fn.LimpiarComponentes(gpb_activos);
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton Cancelar
        //=======================================================================================================================
        //--------------------------------------Cancelar--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(gpb_activos);
                fn.InhabilitarComponentes(gpb_activos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Actualizar
        //=======================================================================================================================
        //--------------------------------------Actualizar--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Actualizar_grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Actualizar_grid()
        {
            string tabla = "activos_empresa";
            fn.ActualizarGrid(this.dg, "SELECT id_activos_emp_pk, nombre_activo, num_serie_activo, precio_activo, descripcion_activo, estado FROM `activos_empresa` WHERE estado = 'ACTIVO' ", tabla);
        }
        #endregion

        #region Botones de Navegacion
        //=======================================================================================================================
        //--------------------------------------Navegacion--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_activo.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_serie_activo.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_nmup_cantidad_activo.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); nmup_cantidad_activo.Value = Convert.ToDecimal(txt_nmup_cantidad_activo.Text);
                this.txt_descripcion_activo.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Siguiente(dg);
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_activo.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_serie_activo.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_nmup_cantidad_activo.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); nmup_cantidad_activo.Value = Convert.ToDecimal(txt_nmup_cantidad_activo.Text);
                this.txt_descripcion_activo.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Primero(dg);
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_activo.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_serie_activo.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_nmup_cantidad_activo.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); nmup_cantidad_activo.Value = Convert.ToDecimal(txt_nmup_cantidad_activo.Text);
                this.txt_descripcion_activo.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Ultimo(dg);
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_activo.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_serie_activo.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_nmup_cantidad_activo.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); nmup_cantidad_activo.Value = Convert.ToDecimal(txt_nmup_cantidad_activo.Text);
                this.txt_descripcion_activo.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Validaciones
        //=======================================================================================================================
        //--------------------------------------Navegacion--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public void Validacion_LetrasNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '_' )
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Llene el campo con caracteres permitidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_nombre_activo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_LetrasNumeros(e);
        }

        private void txt_serie_activo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_LetrasNumeros(e);
        }

        private void txt_descripcion_activo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_LetrasNumeros(e);
        }

        #endregion


    }
}
