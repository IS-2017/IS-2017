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

namespace contrato_trabajo
{
    public partial class frm_calificacion_evaluacion : Form
    {

        #region Variables - Otto Hernandez
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String Codigo;
        String atributo;
        DataGridView dg;
        Validar val;
        #endregion

        #region Load form - Otto Hernandez
        private void frm_calificacion_evaluacion_Load(object sender, EventArgs e)
        {
            try
            {
                fn.InhabilitarComponentes(gpb_ex_ev);
                llenarCboCandidato();
                llenarCboExamen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region inicializar - Otto Hernandez
        public frm_calificacion_evaluacion()
        {
            InitializeComponent();
        }

        public frm_calificacion_evaluacion(DataGridView gb, String id_evaluacion_pk, String descripcion, String puntuacion, String id_candidato_pk, String id_examen_evaluacion_fk, Boolean Editar1)
        {
            try
            {
                this.dg = gb;
                this.Editar = Editar1;
                InitializeComponent();
                atributo = "id_evaluacion_pk";
                this.Codigo = id_evaluacion_pk;
                if (Editar == true)
                {
                    this.txt_descripcion_cal_ev.Text = descripcion;
                    this.txt_id_candidato_cal_ev.Text = id_candidato_pk; cbo_candidato_cal_ev.Text = txt_id_candidato_cal_ev.Text;
                    this.txt_id_examen_ev_cal_ev.Text = id_candidato_pk; cbo_examen_cal_ev.Text = txt_id_examen_ev_cal_ev.Text;
                    this.txt_puntuacion_cal_ev.Text = puntuacion;
                }
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
                txt_descripcion_cal_ev.Enabled = true; cbo_candidato_cal_ev.Enabled = true; cbo_examen_cal_ev.Enabled = true; txt_puntuacion_cal_ev.Enabled = true;
                txt_descripcion_cal_ev.Text = ""; txt_id_candidato_cal_ev.Text = ""; txt_id_examen_ev_cal_ev.Text = ""; txt_puntuacion_cal_ev.Text = "";
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
                txt_descripcion_cal_ev.Enabled = true; cbo_candidato_cal_ev.Enabled = true; cbo_examen_cal_ev.Enabled = true; txt_puntuacion_cal_ev.Enabled = true;
                Editar = true;
                atributo = "id_evaluacion_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_descripcion_cal_ev.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_puntuacion_cal_ev.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_id_candidato_cal_ev.Text = this.dg.CurrentRow.Cells[4].Value.ToString(); cbo_candidato_cal_ev.Text = txt_id_candidato_cal_ev.Text;
                this.txt_id_examen_ev_cal_ev.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); cbo_examen_cal_ev.Text = txt_id_examen_ev_cal_ev.Text;
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
                String atributo2 = "id_evaluacion_pk";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "evaluacion";
                    fn.eliminar(tabla, atributo2, codigo2);
                    fn.ActualizarGrid(this.dg, "Select * from evaluacion WHERE estado <> 'INACTIVO' ", tabla);
                    Editar = false;
                    txt_descripcion_cal_ev.Text = ""; txt_puntuacion_cal_ev.Text = ""; txt_id_examen_ev_cal_ev.Text = ""; txt_id_candidato_cal_ev.Text = "";
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
                string tabla = "evaluacion";
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
                txt_descripcion_cal_ev.Enabled = false; cbo_candidato_cal_ev.Enabled = false; cbo_examen_cal_ev.Enabled = false; cbo_candidato_cal_ev.Enabled = false;
                txt_descripcion_cal_ev.Text = ""; txt_puntuacion_cal_ev.Text = ""; txt_id_examen_ev_cal_ev.Text = ""; txt_id_candidato_cal_ev.Text = "";
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
                string tabla = "evaluacion";
                fn.ActualizarGrid(this.dg, "Select * from evaluacion WHERE estado <> 'INACTIVO' ", tabla);
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
                TextBox[] textbox = { txt_descripcion_cal_ev, txt_id_candidato_cal_ev, txt_id_examen_ev_cal_ev, txt_puntuacion_cal_ev };
                fn.llenartextbox(textbox, dg);
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
                TextBox[] textbox = { txt_descripcion_cal_ev, txt_id_candidato_cal_ev, txt_id_examen_ev_cal_ev, txt_puntuacion_cal_ev };
                fn.llenartextbox(textbox, dg);
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
                TextBox[] textbox = { txt_descripcion_cal_ev, txt_id_candidato_cal_ev, txt_id_examen_ev_cal_ev, txt_puntuacion_cal_ev };
                fn.llenartextbox(textbox, dg);
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
                TextBox[] textbox = { txt_descripcion_cal_ev, txt_id_candidato_cal_ev, txt_id_examen_ev_cal_ev, txt_puntuacion_cal_ev };
                fn.llenartextbox(textbox, dg);
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
                txt_id_candidato_cal_ev.Text = cbo_candidato_cal_ev.Text;
                txt_id_examen_ev_cal_ev.Text = cbo_examen_cal_ev.Text;
                TextBox[] textbox = { txt_descripcion_cal_ev, txt_id_candidato_cal_ev, txt_id_examen_ev_cal_ev, txt_puntuacion_cal_ev, txt_estado_cal_ev };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "evaluacion";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /*bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_dep.Text, "documento");
                        if (insertar == 0)
                        {
                            btn_guardar.Enabled = false;
                        }*/
                        fn.ActualizarGrid(this.dg, "Select * from evaluacion WHERE estado <> 'INACTIVO' ", tabla);
                        txt_descripcion_cal_ev.Enabled = false; txt_puntuacion_cal_ev.Enabled = false; cbo_examen_cal_ev.Enabled = false; cbo_candidato_cal_ev.Enabled = false;
                        txt_descripcion_cal_ev.Text = ""; txt_puntuacion_cal_ev.Text = ""; txt_id_examen_ev_cal_ev.Text = ""; txt_id_candidato_cal_ev.Text = "";
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fn.ActualizarGrid(this.dg, "Select * from evaluacion WHERE estado <> 'INACTIVO' ", tabla);
                        txt_descripcion_cal_ev.Enabled = false; txt_puntuacion_cal_ev.Enabled = false; cbo_examen_cal_ev.Enabled = false; cbo_candidato_cal_ev.Enabled = false;
                        txt_descripcion_cal_ev.Text = ""; txt_puntuacion_cal_ev.Text = ""; txt_id_examen_ev_cal_ev.Text = ""; txt_id_candidato_cal_ev.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        #region Llenar Combobox - Otto Hernandez 
        public void llenarCboCandidato()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Ayuda.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_candidato_pk, nombre_candidato from candidato";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "candidato");
                cbo_candidato_cal_ev.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_candidato_cal_ev.ValueMember = ("id_candidato_pk");
                //se indica el valor a desplegar en el combobox
                DataTable dt = ds.Tables[0];
                dt.Columns.Add("NewColumn", typeof(string));
                foreach (DataRow dr in dt.Rows)
                {
                    dr["nombre_candidato"] = dr["id_candidato_pk"].ToString() + "|" + dr["nombre_candidato"].ToString();
                }
                cbo_candidato_cal_ev.DataSource = dt;
                cbo_candidato_cal_ev.DisplayMember = "nombre_candidato";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void llenarCboExamen()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Ayuda.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "SELECT DISTINCT ex.id_examen_evaluacion_pk, ex.nombre_examen_evaluacion from examen_evaluacion ex, candidato ca, perfil_reclutamiento pr, reclutamiento r where ex.id_area_trabajo_pk = (SELECT DISTINCT pr.id_area_trabajo_pk from perfil_reclutamiento pr, reclutamiento r where pr.id_perfil_reclutamiento_pk = (SELECT DISTINCT r.id_perfil_reclutamiento_pk from reclutamiento r, candidato ca where r.id_reclutamiento_pk = (SELECT DISTINCT ca.id_reclutamiento_pk from candidato ca where ca.id_candidato_pk = '" + cbo_candidato_cal_ev.SelectedValue.ToString() + "')));";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "examen_evaluacion");
                cbo_examen_cal_ev.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_examen_cal_ev.ValueMember = ("id_examen_evaluacion_pk");
                //se indica el valor a desplegar en el combobox
                DataTable dt = ds.Tables[0];
                dt.Columns.Add("NewColumn", typeof(string));
                foreach (DataRow dr in dt.Rows)
                {
                    dr["nombre_examen_evaluacion"] = dr["id_examen_evaluacion_pk"].ToString() + "|" + dr["nombre_examen_evaluacion"].ToString();
                }
                cbo_examen_cal_ev.DataSource = dt;
                cbo_examen_cal_ev.DisplayMember = "nombre_examen_evaluacion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Validar con dos numeros decimales - Otto Hernandez
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

        #region KeyPress - Otto Hernandez
        private void txt_descripcion_cal_ev_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_puntuacion_cal_ev_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                validacion_solonumerocondosdecimales(e,txt_puntuacion_cal_ev);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void cbo_candidato_cal_ev_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCboExamen();
        }
    }
}
