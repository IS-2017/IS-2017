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


namespace contrato_trabajo
{
    public partial class frm_puesto_lab : Form
    {
        #region Variables del Form Puesto Laboral
        //=======================================================================================================================
        //------------------------------------------------ Variables ------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        String Codigo;
        Boolean Editar;
        String atributo;
        CapaNegocio fn = new CapaNegocio();
        DataGridView dg;
        #endregion

        #region Visualizar Form Puesto Laboral
        //=======================================================================================================================
        //------------------------------------------------ Visualizar Form ------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public frm_puesto_lab(DataGridView dgv, String id_puesto_laboral_pk, String nombre_puesto, String descripcion, String salario_base, String estado, Boolean Editar1, Boolean tipo_accion)
        {
            try
            {
                this.dg = dgv;
                this.Editar = Editar1;
                InitializeComponent();
                atributo = "id_puesto_laboral_pk";
                this.Codigo = id_puesto_laboral_pk;
                if (tipo_accion == true)
                {
                    this.txt_nombre_puesto.Text = nombre_puesto;
                    this.txt_descripcion_puesto.Text = descripcion;
                    this.txt_nmup_cantidad_puesto.Text = salario_base; nmup_cantidad_puesto.Value = Convert.ToDecimal(txt_nmup_cantidad_puesto.Text);
                    this.fn.ActivarControles(gpb_puestos);
                }
                else
                {
                    fn.ActivarControles(gpb_puestos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Cargar Form Puesto Laboral
        //=======================================================================================================================
        //------------------------------------------------ Form Puesto Laboral---------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void frm_puesto_lab_Load(object sender, EventArgs e)
        {
            try
            {
                fn.InhabilitarComponentes(gpb_puestos);
                fn.InhabilitarComponentes(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Eliminar
        //=======================================================================================================================
        //-------------------------------------------------- Eliminar ----------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_puesto_laboral_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string tabla = "puesto_laboral";
                    fn.eliminar(tabla, atributo2, codigo2);
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_gridview();
                    decimal valor_minimo = 2893.21m;
                    nmup_cantidad_puesto.Value = valor_minimo;
                    fn.LimpiarComponentes(gpb_puestos);
                    fn.InhabilitarComponentes(gpb_puestos);
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
        //-------------------------------------------------- Cancelar ----------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(gpb_puestos);
                fn.InhabilitarComponentes(gpb_puestos);
                decimal valor_minimo = 2893.21m;
                nmup_cantidad_puesto.Value = valor_minimo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Actualizar
        //=======================================================================================================================
        //-------------------------------------------------- Actualizar --------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Cargar_gridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Cargar_gridview()
        {
            string tabla = "puesto_laboral";
            fn.ActualizarGrid(this.dg, "SELECT id_puesto_laboral_pk, nombre_puesto, descripcion, salario_base, estado FROM `puesto_laboral` WHERE estado = 'ACTIVO' ", tabla);
        }
        #endregion

        #region Boton Guardar
        //=======================================================================================================================
        //-------------------------------------------------- Guardar ----------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_estado.Text = "ACTIVO";
                TextBox[] textbox = { txt_nombre_puesto, txt_descripcion_puesto, txt_nmup_cantidad_puesto, txt_estado};
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "puesto_laboral";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fn.InhabilitarComponentes(gpb_puestos);
                        Cargar_gridview();
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_gridview();
                        decimal valor_minimo = 2893.21m;
                        nmup_cantidad_puesto.Value = valor_minimo;
                        fn.LimpiarComponentes(gpb_puestos);
                        fn.InhabilitarComponentes(gpb_puestos);
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
        //-------------------------------------------------- Editar ----------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "id_puesto_laboral_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_puesto.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_descripcion_puesto.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); 
                this.txt_nmup_cantidad_puesto.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); nmup_cantidad_puesto.Value = Convert.ToDecimal(txt_nmup_cantidad_puesto.Text);
                fn.ActivarControles(gpb_puestos);
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton Nuevo
        //=======================================================================================================================
        //-------------------------------------------------- Nuevo ----------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_puestos);
                decimal valor_minimo = 2893.21m;
                nmup_cantidad_puesto.Value = valor_minimo;
                fn.LimpiarComponentes(gpb_puestos);
                txt_nmup_cantidad_puesto.Text = nmup_cantidad_puesto.Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Funciones a Realizar
        //=======================================================================================================================
        //-------------------------------------------------- Funciones ----------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void nmup_cantidad_puesto_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_nmup_cantidad_puesto.Text = nmup_cantidad_puesto.Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Botones de Navegacion
        //=======================================================================================================================
        //-------------------------------------------------- Navegacion ---------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_puesto.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_descripcion_puesto.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_nmup_cantidad_puesto.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); nmup_cantidad_puesto.Value = Convert.ToDecimal(txt_nmup_cantidad_puesto.Text);
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
                this.txt_nombre_puesto.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_descripcion_puesto.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_nmup_cantidad_puesto.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); nmup_cantidad_puesto.Value = Convert.ToDecimal(txt_nmup_cantidad_puesto.Text);
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
                this.txt_nombre_puesto.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_descripcion_puesto.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_nmup_cantidad_puesto.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); nmup_cantidad_puesto.Value = Convert.ToDecimal(txt_nmup_cantidad_puesto.Text);
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
                this.txt_nombre_puesto.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_descripcion_puesto.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_nmup_cantidad_puesto.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); nmup_cantidad_puesto.Value = Convert.ToDecimal(txt_nmup_cantidad_puesto.Text);
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
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '_')
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

        private void txt_nombre_puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_LetrasNumeros(e);
        }

        private void txt_descripcion_puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_LetrasNumeros(e);
        }

        #endregion


    }
}
