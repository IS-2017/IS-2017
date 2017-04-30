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
    public partial class frm_emp_telefonos : Form
    {
        #region Variables del Form Empleado Telefonos
        //=======================================================================================================================
        //------------------------------------------------ Variables-------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        String id_emp;
        String atributo, Codigo;
        CapaNegocio fn = new CapaNegocio();
        DataGridView dg;
        Boolean Editar;
        #endregion

        #region Visualizar Form Empleado Telefonos
        //=======================================================================================================================
        //-------------------------------------------Visualizar Form -------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public frm_emp_telefonos(DataGridView dgv, String id_telefono, String numero1, String numero2, String numero3, String descripcion, String codigo_emp, Boolean Editar1, Boolean tipo_accion)
        {
            try
            {
                InitializeComponent();
                this.dg = dgv;
                this.Editar = Editar1;
                atributo = "id_telefono_emp_pk";
                this.Codigo = id_telefono;
                if (tipo_accion == true)
                {
                    this.txt_telefono_1.Text = numero1;
                    this.txt_detalle_telefono.Text = descripcion;
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

        #region Cargar al Inicio del Form
        //=======================================================================================================================
        //------------------------------------------- Cargar Form -------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void frm_emp_telefonos_Load(object sender, EventArgs e)
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
        //--------------------------------------------------- Nuevo -------------------------------------------------------------
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
        //--------------------------------------------------- Guardar -------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox[] textbox = { txt_telefono_1, txt_detalle_telefono, txt_estado, txt_id_emp };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "emp_telefono";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fn.InhabilitarComponentes(this);
                        fn.ActualizarGrid(this.dg, "SELECT id_telefono_emp_pk, numero_telefono1_emp, descripcion_tel, estado, id_empleado_pk FROM `emp_telefono` WHERE id_empleado_pk = '" + txt_id_emp.Text + "' and estado = 'ACTIVO' ", tabla);
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fn.LimpiarComponentes(this);
                        fn.InhabilitarComponentes(this);
                        fn.ActualizarGrid(this.dg, "SELECT id_telefono_emp_pk, numero_telefono1_emp, descripcion_tel, estado, id_empleado_pk FROM `emp_telefono` WHERE id_empleado_pk = '" + txt_id_emp.Text + "' and estado = 'ACTIVO' ", tabla);
                        Cargar_datos_gridview();
                        Conexionmysql.ObtenerConexion();                 
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
        //--------------------------------------------------- Editar -------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "id_telefono_emp_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_telefono_1.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_detalle_telefono.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
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
        //--------------------------------------------------- Eliminar -------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_telefono_emp_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string tabla = "emp_telefono";
                    fn.eliminar(tabla, atributo2, codigo2);
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fn.LimpiarComponentes(this);
                    fn.InhabilitarComponentes(this);
                    fn.ActualizarGrid(this.dg, "SELECT id_telefono_emp_pk, numero_telefono1_emp, descripcion_tel, estado, id_empleado_pk FROM `emp_telefono` WHERE id_empleado_pk = '" + txt_id_emp.Text + "' and estado = 'ACTIVO' ", tabla);
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
        //--------------------------------------------------- Cancelar -------------------------------------------------------------
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
        //--------------------------------------------------- Actualizar ---------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Codigo = this.dg.CurrentRow.Cells[4].Value.ToString();
                Cargar_datos_gridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Cargar_datos_gridview()
        {
            string tabla = "emp_telefono";
            fn.ActualizarGrid(this.dg, "SELECT id_telefono_emp_pk, numero_telefono1_emp, descripcion_tel, estado, id_empleado_pk FROM `emp_telefono` WHERE id_empleado_pk = '" + Codigo + "' and estado = 'ACTIVO' ", tabla);
        }
        #endregion

        #region Botones Navegacion
        //=======================================================================================================================
        //--------------------------------------------------- Navegacion -------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_telefono_1.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_detalle_telefono.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
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
                this.txt_telefono_1.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_detalle_telefono.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
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
                this.txt_telefono_1.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_detalle_telefono.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
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
                this.txt_telefono_1.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_detalle_telefono.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

    }
}
