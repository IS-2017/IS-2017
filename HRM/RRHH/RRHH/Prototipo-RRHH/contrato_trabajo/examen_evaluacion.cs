using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace contrato_trabajo
{
    public partial class examen_evaluacion : Form
    {
        #region Variables - Otto Hernandez
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String Codigo;
        String atributo;
        DataGridView dg;
        Validar val;
        #endregion

        #region Inicializar - Otto Hernandez
        public examen_evaluacion()
        {
            InitializeComponent();
        }

        public examen_evaluacion(DataGridView gb, String id_examen_evaluacion_pk, String nombre_examen_evaluacion, String nota_maxima_examen_evaluacion, String id_area_trabajo_pk, Boolean Editar1)
        {
            try
            {
                this.dg = gb;
                this.Editar = Editar1;
                InitializeComponent();
                atributo = "id_examen_evaluacion_pk";
                this.Codigo = id_examen_evaluacion_pk;
                if (Editar == true)
                {
                    this.txt_nombre_ex_ev.Text = nombre_examen_evaluacion;
                    this.txt_nota_maxima_ex_ev.Text = nota_maxima_examen_evaluacion;
                    this.txt_id_area_trabajo_pk_examen_evaluacion.Text = id_area_trabajo_pk;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Load form - Otto Hernandez
        private void examen_evaluacion_Load(object sender, EventArgs e)
        {
            try
            {
                fn.InhabilitarComponentes(gpb_ex_ev);
                llenarCboAreaTrabajo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        #region Boton Nuevo - Otto Hernandez
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                txt_nombre_ex_ev.Enabled = true; txt_nota_maxima_ex_ev.Enabled = true; cbo_are_trabajo_pk_examen_evaluacion.Enabled = true;
                txt_nota_maxima_ex_ev.Text = ""; txt_nombre_ex_ev.Text = ""; txt_id_area_trabajo_pk_examen_evaluacion.Text = "";
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
                txt_id_area_trabajo_pk_examen_evaluacion.Text = cbo_are_trabajo_pk_examen_evaluacion.Text;
                TextBox[] textbox = { txt_estado_ex_ev, txt_nombre_ex_ev, txt_nota_maxima_ex_ev, txt_id_area_trabajo_pk_examen_evaluacion};
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "examen_evaluacion";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /*bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_dep.Text, "documento");
                        if (insertar == 0)
                        {
                            btn_guardar.Enabled = false;
                        }*/
                        fn.ActualizarGrid(this.dg, "Select * from examen_evaluacion WHERE estado <> 'INACTIVO' ", tabla);
                        txt_nombre_ex_ev.Text = ""; txt_nota_maxima_ex_ev.Text = ""; txt_id_area_trabajo_pk_examen_evaluacion.Text = "";
                        txt_nombre_ex_ev.Enabled = false; txt_nota_maxima_ex_ev.Enabled = false; cbo_are_trabajo_pk_examen_evaluacion.Enabled = false;
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fn.ActualizarGrid(this.dg, "Select * from examen_evaluacion WHERE estado <> 'INACTIVO' ", tabla);
                        txt_nombre_ex_ev.Text = ""; txt_nota_maxima_ex_ev.Text = ""; txt_id_area_trabajo_pk_examen_evaluacion.Text = "";
                        txt_nombre_ex_ev.Enabled = false; txt_nota_maxima_ex_ev.Enabled = false; cbo_are_trabajo_pk_examen_evaluacion.Enabled = false;
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
                txt_nombre_ex_ev.Enabled = true; txt_nota_maxima_ex_ev.Enabled = true; cbo_are_trabajo_pk_examen_evaluacion.Enabled = true;
                Editar = true;
                atributo = "id_examen_evaluacion_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_ex_ev.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_nota_maxima_ex_ev.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_id_area_trabajo_pk_examen_evaluacion.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
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
                String atributo2 = "id_examen_evaluacion_pk";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "examen_evaluacion";
                    fn.eliminar(tabla, atributo2, codigo2);
                    fn.ActualizarGrid(this.dg, "Select * from examen_evaluacion WHERE estado <> 'INACTIVO' ", tabla);
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
                string tabla = "examen_evaluacion";
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
                txt_nombre_ex_ev.Enabled = false; txt_nota_maxima_ex_ev.Enabled = false; cbo_are_trabajo_pk_examen_evaluacion.Enabled = false;
                txt_nombre_ex_ev.Text = ""; txt_nota_maxima_ex_ev.Text = ""; txt_id_area_trabajo_pk_examen_evaluacion.Text = "";
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
                string tabla = "examen_evaluacion";
                fn.ActualizarGrid(this.dg, "Select * from examen_evaluacion WHERE estado <> 'INACTIVO' ", tabla);
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
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                TextBox[] textbox = { txt_nombre_ex_ev, txt_nota_maxima_ex_ev,txt_id_area_trabajo_pk_examen_evaluacion};
                fn.llenartextbox(textbox, dg);
                cbo_are_trabajo_pk_examen_evaluacion.Text = txt_id_area_trabajo_pk_examen_evaluacion.Text;
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
                TextBox[] textbox = { txt_nombre_ex_ev, txt_nota_maxima_ex_ev, txt_id_area_trabajo_pk_examen_evaluacion };
                fn.llenartextbox(textbox, dg);
                cbo_are_trabajo_pk_examen_evaluacion.Text = txt_id_area_trabajo_pk_examen_evaluacion.Text;
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
                TextBox[] textbox = { txt_nombre_ex_ev, txt_nota_maxima_ex_ev, txt_id_area_trabajo_pk_examen_evaluacion };
                fn.llenartextbox(textbox, dg);
                cbo_are_trabajo_pk_examen_evaluacion.Text = txt_id_area_trabajo_pk_examen_evaluacion.Text;
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
                TextBox[] textbox = { txt_nombre_ex_ev, txt_nota_maxima_ex_ev, txt_id_area_trabajo_pk_examen_evaluacion };
                fn.llenartextbox(textbox, dg);
                cbo_are_trabajo_pk_examen_evaluacion.Text = txt_id_area_trabajo_pk_examen_evaluacion.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        #region validar letras - Otto Hernandez
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region validar solo numeros - Otto Hernandez
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_nombre_ex_ev_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_nota_maxima_ex_ev_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                validacion_solonumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region llenar combobox - Otto Hernandez
        public void llenarCboAreaTrabajo()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Ayuda.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_area_trabajo_pk, puesto from area_trabajo";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "area_trabajo");
                cbo_are_trabajo_pk_examen_evaluacion.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_are_trabajo_pk_examen_evaluacion.ValueMember = ("id_area_trabajo_pk");
                //se indica el valor a desplegar en el combobox
                DataTable dt = ds.Tables[0];
                dt.Columns.Add("NewColumn", typeof(string));
                foreach (DataRow dr in dt.Rows)
                {
                    dr["puesto"] = dr["id_area_trabajo_pk"].ToString() + "|" + dr["puesto"].ToString();
                }
                cbo_are_trabajo_pk_examen_evaluacion.DataSource = dt;
                cbo_are_trabajo_pk_examen_evaluacion.DisplayMember = "puesto";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void gpb_ex_ev_Enter(object sender, EventArgs e)
        {

        }
    }
}
