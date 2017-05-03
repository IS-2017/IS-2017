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

namespace contrato_trabajo
{
    public partial class frm_emp_correos : Form
    {
        #region Variables Form Empleado Correos
        //=======================================================================================================================
        //--------------------------------------------- Variables --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        String id_emp;
        String atributo, Codigo;
        CapaNegocio fn = new CapaNegocio();
        DataGridView dg;
        Boolean Editar;
        #endregion

        #region Visualizar Contenido Form Empleado Correos
        //=======================================================================================================================
        //--------------------------------------------- Visualizar Contenido ----------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public frm_emp_correos(DataGridView dgv, String id_correo, String correo1, String descripcion, String codigo_emp, Boolean Editar1, Boolean tipo_accion)
        {
            try
            {
                InitializeComponent();
                this.dg = dgv;
                this.Editar = Editar1;
                atributo = "id_correo_electronico_emp";
                this.Codigo = id_correo;
                this.id_emp = codigo_emp;
                if (tipo_accion == true)
                {

                    this.txt_correo_1.Text = correo1;
                    this.txt_detalle_correo.Text = descripcion;

                    this.txt_id_emp.Text = codigo_emp;
                }
                else
                {
                    fn.ActivarControles(this);
                    this.txt_id_emp.Text = codigo_emp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Cargar al inicio del Form
        //=======================================================================================================================
        //--------------------------------------------- Cargar Form --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void frm_emp_correos_Load(object sender, EventArgs e)
        {
            try
            {
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
        //--------------------------------------------- Nuevo --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(this);
                fn.LimpiarComponentes(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Guardar
        //=======================================================================================================================
        //--------------------------------------------- Guardar --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox[] textbox = { txt_correo_1, txt_detalle_correo, txt_estado, txt_id_emp };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "emp_correo_electronico";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fn.InhabilitarComponentes(this);
                        Codigo = this.dg.CurrentRow.Cells[4].Value.ToString();
                        string tabla2 = "emp_telefono";
                        fn.ActualizarGrid(this.dg, "SELECT id_correo_electronico_emp, correo_electronico1_emp, descripcion_correo, estado, id_empleado_pk FROM `emp_correo_electronico` WHERE id_empleado_pk = '" + txt_id_emp.Text + "' and estado = 'ACTIVO' ", tabla2);
                        fn.InhabilitarComponentes(this);
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Conexionmysql.ObtenerConexion();
                        Codigo = this.dg.CurrentRow.Cells[4].Value.ToString();
                        string tabla3 = "emp_telefono";
                        fn.ActualizarGrid(this.dg, "SELECT id_correo_electronico_emp, correo_electronico1_emp, descripcion_correo, estado, id_empleado_pk FROM `emp_correo_electronico` WHERE id_empleado_pk = '" + txt_id_emp.Text + "' and estado = 'ACTIVO' ", tabla3);
                        fn.LimpiarComponentes(this);
                        fn.InhabilitarComponentes(this);
                    }
                    //fn.LimpiarComponentes(this);
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
        //--------------------------------------------- Editar --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "id_correo_electronico_emp";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_correo_1.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_detalle_correo.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                fn.ActivarControles(this);
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton Eliminar
        //=======================================================================================================================
        //--------------------------------------------- Eliminar --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_correo_electronico_emp";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string tabla = "emp_correo_electronico";
                    fn.eliminar(tabla, atributo2, codigo2);
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fn.ActualizarGrid(this.dg, "SELECT id_correo_electronico_emp, correo_electronico1_emp, descripcion_correo, estado, id_empleado_pk FROM `emp_correo_electronico` WHERE id_empleado_pk = '" + txt_id_emp.Text + "' and estado = 'ACTIVO' ", tabla);
                    fn.LimpiarComponentes(this);
                    fn.InhabilitarComponentes(this);
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
        //--------------------------------------------- Cancelar --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(this);
                fn.InhabilitarComponentes(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Actualizar
        //=======================================================================================================================
        //--------------------------------------------- Actualizar --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Codigo = id_emp;
                string tabla = "emp_correo_electronico";
                fn.ActualizarGrid(this.dg, "SELECT id_correo_electronico_emp, correo_electronico1_emp, descripcion_correo, estado, id_empleado_pk FROM `emp_correo_electronico` WHERE id_empleado_pk = '" + Codigo + "' and estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Botones de Navegacion
        //=======================================================================================================================
        //--------------------------------------------- Navegacion --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_correo_1.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_detalle_correo.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
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
                this.txt_correo_1.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_detalle_correo.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
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
                this.txt_correo_1.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_detalle_correo.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
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
                this.txt_correo_1.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_detalle_correo.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    

    }
}
