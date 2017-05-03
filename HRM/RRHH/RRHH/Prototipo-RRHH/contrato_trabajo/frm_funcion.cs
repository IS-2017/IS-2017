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
using System.Data.Odbc;
using System.Collections;

namespace contrato_trabajo
{
    public partial class frm_funcion : Form
    {
        #region variables form - Otto Hernandez
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String Codigo;
        String atributo;
        DataGridView dg;
        Validar val;
        #endregion

        #region inicializar - Otto Hernandez
        public frm_funcion()
        {
            InitializeComponent();
        }


        public frm_funcion(DataGridView gb, String id_funcion, String sueldo_funcion, String descripcion_funcion, String nombre_funcion, String id_perfil_reclutamiento_fk, Boolean Editar1)
        {
            try
            {
                this.dg = gb;
                this.Editar = Editar1;
                InitializeComponent();
                atributo = "id_funcion";
                this.Codigo = id_funcion;
                if (Editar == true)
                {
                    this.txt_nombre_funcion.Text = nombre_funcion;
                    this.txt_sueldo_funcion.Text = sueldo_funcion;
                    this.txt_descripcion_funcion.Text = descripcion_funcion;
                    this.txt_id_perfil_reclutamiento_pk_funcion.Text = id_perfil_reclutamiento_fk; cbo_perfil_reclutamiento_funcion.Text = txt_id_perfil_reclutamiento_pk_funcion.Text;
                }
            }
            catch
            {

            }
        }


        private void frm_funcion_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_funciones);
            llenarCboFuncion();
        }
        #endregion

        #region Boton nuevo - Otto Hernandez
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                txt_descripcion_funcion.Enabled = true; cbo_perfil_reclutamiento_funcion.Enabled = true; txt_nombre_funcion.Enabled = true; txt_sueldo_funcion.Enabled = true; 
                txt_descripcion_funcion.Text = ""; txt_id_perfil_reclutamiento_pk_funcion.Text = ""; txt_nombre_funcion.Text = ""; txt_sueldo_funcion.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Guardar - Otto Hernandez
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_id_perfil_reclutamiento_pk_funcion.Text = cbo_perfil_reclutamiento_funcion.SelectedValue.ToString();
                TextBox[] textbox = { txt_descripcion_funcion, txt_id_perfil_reclutamiento_pk_funcion, txt_estado_funcion, txt_nombre_funcion, txt_sueldo_funcion};
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "funcion";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        fn.ActualizarGrid(this.dg, "Select * from funcion WHERE estado <> 'INACTIVO' ", tabla);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /*bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_dep.Text, "documento");
                        if (insertar == 0)
                        {
                            btn_guardar.Enabled = false;
                        }*/
                        txt_descripcion_funcion.Text = ""; txt_id_perfil_reclutamiento_pk_funcion.Text = ""; txt_nombre_funcion.Text = ""; txt_sueldo_funcion.Text = "";
                        txt_descripcion_funcion.Enabled = false; cbo_perfil_reclutamiento_funcion.Enabled = false; txt_nombre_funcion.Enabled = false; txt_sueldo_funcion.Enabled = false;
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        fn.ActualizarGrid(this.dg, "Select * from funcion WHERE estado <> 'INACTIVO' ", tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_descripcion_funcion.Text = ""; txt_id_perfil_reclutamiento_pk_funcion.Text = ""; txt_nombre_funcion.Text = ""; txt_sueldo_funcion.Text = "";
                        txt_descripcion_funcion.Enabled = false; cbo_perfil_reclutamiento_funcion.Enabled = false; txt_nombre_funcion.Enabled = false; txt_sueldo_funcion.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Editar - Otto Hernandez
        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_descripcion_funcion.Enabled = true; cbo_perfil_reclutamiento_funcion.Enabled = true; txt_nombre_funcion.Enabled = true; txt_sueldo_funcion.Enabled = true;
                Editar = true;
                atributo = "id_funcion";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_sueldo_funcion.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_descripcion_funcion.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_nombre_funcion.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_id_perfil_reclutamiento_pk_funcion.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); cbo_perfil_reclutamiento_funcion.Text = txt_id_perfil_reclutamiento_pk_funcion.Text;
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a modificar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton Eliminar - Otto Hernandez
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_funcion";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "funcion";
                    fn.eliminar(tabla, atributo2, codigo2);
                    fn.ActualizarGrid(this.dg, "Select * from funcion WHERE estado <> 'INACTIVO' ", tabla);
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //bita.Eliminar("Eliminacion de empresa con el numero: " + codigo2, "empresa");
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton Buscar - Otto Hernandez
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "funcion";
                //op.ejecutar(this.dg, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Cancelar - Otto Hernandez
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                txt_descripcion_funcion.Enabled = false; cbo_perfil_reclutamiento_funcion.Enabled = false; txt_nombre_funcion.Enabled = false; txt_sueldo_funcion.Enabled = false;
                txt_descripcion_funcion.Text = ""; txt_id_perfil_reclutamiento_pk_funcion.Text = ""; txt_nombre_funcion.Text = ""; txt_sueldo_funcion.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Actualizar - Otto Hernandez
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "funcion";
                fn.ActualizarGrid(this.dg, "Select * from funcion WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Reporte - Otto Hernandez
        private void btn_reporte_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Botones de Navegacion - Otto Hernandez
        #region Boton anterior - Otto Hernandez
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "funcion";
                fn.Anterior(dg);
                TextBox[] textbox = { txt_descripcion_funcion, txt_id_perfil_reclutamiento_pk_funcion, txt_nombre_funcion, txt_sueldo_funcion };
                fn.llenartextbox(textbox, dg);
                cbo_perfil_reclutamiento_funcion.Text = txt_id_perfil_reclutamiento_pk_funcion.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton siguiente - Otto Hernandez
        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "funcion";
                fn.Siguiente(dg);
                TextBox[] textbox = { txt_descripcion_funcion, txt_id_perfil_reclutamiento_pk_funcion, txt_nombre_funcion, txt_sueldo_funcion };
                fn.llenartextbox(textbox, dg);
                cbo_perfil_reclutamiento_funcion.Text = txt_id_perfil_reclutamiento_pk_funcion.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton primero - Otto Hernandez
        private void btn_primero_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Primero(dg);
                TextBox[] textbox = { txt_descripcion_funcion, txt_id_perfil_reclutamiento_pk_funcion, txt_nombre_funcion, txt_sueldo_funcion };
                fn.llenartextbox(textbox, dg);
                cbo_perfil_reclutamiento_funcion.Text = txt_id_perfil_reclutamiento_pk_funcion.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton ultimo - Otto Hernandez
        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Ultimo(dg);
                TextBox[] textbox = { txt_descripcion_funcion, txt_id_perfil_reclutamiento_pk_funcion, txt_nombre_funcion, txt_sueldo_funcion };
                fn.llenartextbox(textbox, dg);
                cbo_perfil_reclutamiento_funcion.Text = txt_id_perfil_reclutamiento_pk_funcion.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #endregion

        #region Combobox - Otto Hernandez
        public void llenarCboFuncion()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Ayuda.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_perfil_reclutamiento_pk, titulo_puesto from perfil_reclutamiento";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "perfil_reclutamiento");
                cbo_perfil_reclutamiento_funcion.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_perfil_reclutamiento_funcion.ValueMember = ("id_perfil_reclutamiento_pk");
                //se indica el valor a desplegar en el combobox
                DataTable dt = ds.Tables[0];
                dt.Columns.Add("NewColumn", typeof(string));
                foreach (DataRow dr in dt.Rows)
                {
                    dr["titulo_puesto"] = dr["id_perfil_reclutamiento_pk"].ToString() + "|" + dr["titulo_puesto"].ToString();
                }
                cbo_perfil_reclutamiento_funcion.DataSource = dt;
                cbo_perfil_reclutamiento_funcion.DisplayMember = "titulo_puesto";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region keypress de botones - Otto Hernandez
        private void txt_descripcion_funcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                validacion_sololetras(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txt_nombre_funcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                validacion_sololetras(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_sueldo_funcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                validacion_solonumerocondosdecimales(e, txt_sueldo_funcion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region validaciones - Otto Hernandez
        #region validacion de numeros con dos decimales - Otto Hernandez
        public void validacion_solonumerocondosdecimales(KeyPressEventArgs e, TextBox textbox)
        {
            try
            {
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                    return;
                }


                bool IsDec = false;
                int nroDec1 = 0, nroDec = 0;

                for (int i = 0; i < textbox.Text.Length; i++)
                {
                    if (textbox.Text[i] != '.' && !IsDec)
                    {
                        nroDec++;
                    }
                    if (textbox.Text[i] == '.')
                        IsDec = true;
                    if (nroDec >= 7 || IsDec && nroDec1++ >= 2)
                    {
                        if (nroDec >= 7)
                        {
                            MessageBox.Show("El numero no puede ser mayor a 7 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            e.Handled = true;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("El numero no puede tener mas de dos numeros despues del punto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            e.Handled = true;
                            return;
                        }
                    }
                }

                if (e.KeyChar >= 48 && e.KeyChar <= 57)
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == 46)
                {
                    e.Handled = (IsDec) ? true : false;
                }
                else
                {
                    MessageBox.Show("Llene el campo con numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                }

            }
            catch
            {
                //MessageBox.Show("Llene el campo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region validacion de letra - Otto Hernandez
        public void validacion_sololetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Llene el campo con letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                // MessageBox.Show("Llene el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region validacion de numeros - Otto Hernandez
        public void validacion_solonumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Llene el campo con numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                //MessageBox.Show("Llene el campo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #endregion
    }
}
