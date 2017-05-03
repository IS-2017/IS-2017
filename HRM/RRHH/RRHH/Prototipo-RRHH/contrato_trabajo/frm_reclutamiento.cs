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
using FuncionesNavegador;

namespace contrato_trabajo
{
    public partial class frm_reclutamiento : Form
    {
        #region validar - Otto Hernandez
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String Codigo;
        String atributo;
        DataGridView dg,dg2;
        Validar val;
        #endregion

        #region Inicializar - Otto Hernandez
        public frm_reclutamiento()
        {
            InitializeComponent();
        }

        public frm_reclutamiento(DataGridView gb, String id_reclutamiento,String id_perfil_reclutamiento, String nombre, String medio_distribucion, Boolean Editar1)
        {
            try
            {
                this.dg = gb;
                this.Editar = Editar1;
                InitializeComponent();
                atributo = "id_reclutamiento_pk";
                this.Codigo = id_reclutamiento;
                if (Editar == true)
                {
                    this.txt_nombre_reclutamiento.Text = nombre;
                    this.txt_medio_distribucion.Text = medio_distribucion; cbo_medio_distribucion.Text = txt_medio_distribucion.Text;
                    this.txt_perfil_reclutamiento.Text = id_perfil_reclutamiento; cbo_perfil_reclutamiento.Text = txt_perfil_reclutamiento.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_reclutamiento_Load(object sender, EventArgs e)
        {
            try
            {
                fn.InhabilitarComponentes(gpb_datos_reclutamiento);
                llenarCboMedioDistribucion();
                llenarCboPerfilReclutamiento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton nuevo - Otto Hernandez
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                cbo_medio_distribucion.Enabled = true; cbo_perfil_reclutamiento.Enabled = true; txt_nombre_reclutamiento.Enabled = true;
                txt_medio_distribucion.Text = ""; txt_perfil_reclutamiento.Text = ""; txt_nombre_reclutamiento.Text = "";
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
                txt_medio_distribucion.Text = cbo_medio_distribucion.SelectedValue.ToString();
                txt_perfil_reclutamiento.Text = cbo_perfil_reclutamiento.SelectedValue.ToString();
                TextBox[] textbox = { txt_medio_distribucion, txt_nombre_reclutamiento, txt_perfil_reclutamiento, txt_estado_reclutamiento};
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "reclutamiento";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        fn.ActualizarGrid(this.dg, "Select * from reclutamiento WHERE estado <> 'INACTIVO' ", tabla);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /*bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_dep.Text, "documento");
                        if (insertar == 0)
                        {
                            btn_guardar.Enabled = false;
                        }*/
                        txt_medio_distribucion.Text = ""; txt_nombre_reclutamiento.Text = ""; txt_perfil_reclutamiento.Text = "";
                        cbo_medio_distribucion.Enabled = false; cbo_perfil_reclutamiento.Enabled = false; txt_nombre_reclutamiento.Enabled = false;
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        fn.ActualizarGrid(this.dg, "Select * from reclutamiento WHERE estado <> 'INACTIVO' ", tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_medio_distribucion.Text = ""; txt_nombre_reclutamiento.Text = ""; txt_perfil_reclutamiento.Text = "";
                        cbo_medio_distribucion.Enabled = false; cbo_perfil_reclutamiento.Enabled = false; txt_nombre_reclutamiento.Enabled = false;
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
                cbo_perfil_reclutamiento.Enabled = true; cbo_medio_distribucion.Enabled = true; txt_nombre_reclutamiento.Enabled = true;
                Editar = true;
                atributo = "id_reclutamiento_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_reclutamiento.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_perfil_reclutamiento.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); cbo_perfil_reclutamiento.Text = txt_perfil_reclutamiento.Text;
                this.txt_medio_distribucion.Text = this.dg.CurrentRow.Cells[4].Value.ToString(); cbo_medio_distribucion.Text = txt_medio_distribucion.Text;
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
                String atributo2 = "id_reclutamiento_pk";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "reclutamiento";
                    fn.eliminar(tabla, atributo2, codigo2);
                    fn.ActualizarGrid(this.dg, "Select * from reclutamiento WHERE estado <> 'INACTIVO' ", tabla);
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
                string tabla = "reclutamiento";
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
                cbo_medio_distribucion.Enabled = false; cbo_perfil_reclutamiento.Enabled = false; txt_nombre_reclutamiento.Enabled = false;
                txt_medio_distribucion.Text = ""; txt_perfil_reclutamiento.Text = ""; txt_nombre_reclutamiento.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton actualizar - Otto Hernandez
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "reclutamiento";
                fn.ActualizarGrid(this.dg, "Select * from reclutamiento WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Botones de navegacion - Otto Hernandez
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                TextBox[] textbox = { txt_medio_distribucion, txt_nombre_reclutamiento, txt_perfil_reclutamiento};
                fn.llenartextbox(textbox, dg);
                cbo_medio_distribucion.Text = txt_medio_distribucion.Text;
                cbo_perfil_reclutamiento.Text = txt_perfil_reclutamiento.Text;
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
                TextBox[] textbox = { txt_medio_distribucion, txt_nombre_reclutamiento, txt_perfil_reclutamiento };
                fn.llenartextbox(textbox, dg);
                cbo_medio_distribucion.Text = txt_medio_distribucion.Text;
                cbo_perfil_reclutamiento.Text = txt_perfil_reclutamiento.Text;
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
                TextBox[] textbox = { txt_medio_distribucion, txt_nombre_reclutamiento, txt_perfil_reclutamiento };
                fn.llenartextbox(textbox, dg);
                cbo_medio_distribucion.Text = txt_medio_distribucion.Text;
                cbo_perfil_reclutamiento.Text = txt_perfil_reclutamiento.Text;
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
                fn.Anterior(dg);
                TextBox[] textbox = { txt_medio_distribucion, txt_nombre_reclutamiento, txt_perfil_reclutamiento };
                fn.llenartextbox(textbox, dg);
                cbo_medio_distribucion.Text = txt_medio_distribucion.Text;
                cbo_perfil_reclutamiento.Text = txt_perfil_reclutamiento.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Reporte - Otto Hernandez
        private void button1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Llenar Combobox - Otto Hernandez
        public void llenarCboPerfilReclutamiento()
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
                dad.Fill(ds, "reclutamiento");
                cbo_perfil_reclutamiento.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_perfil_reclutamiento.ValueMember = ("id_perfil_reclutamiento_pk");
                //se indica el valor a desplegar en el combobox
                DataTable dt = ds.Tables[0];
                dt.Columns.Add("NewColumn", typeof(string));
                foreach (DataRow dr in dt.Rows)
                {
                    dr["titulo_puesto"] = dr["id_perfil_reclutamiento_pk"].ToString() + "|" + dr["titulo_puesto"].ToString();
                }
                cbo_perfil_reclutamiento.DataSource = dt;
                cbo_perfil_reclutamiento.DisplayMember = "titulo_puesto";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void llenarCboMedioDistribucion()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Ayuda.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_medio_distribucion, nombre_medio from medio_distribucion";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "medio_distribucion");
                cbo_medio_distribucion.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_medio_distribucion.ValueMember = ("id_medio_distribucion");
                //se indica el valor a desplegar en el combobox
                DataTable dt = ds.Tables[0];
                dt.Columns.Add("NewColumn", typeof(string));
                foreach (DataRow dr in dt.Rows)
                {
                    dr["nombre_medio"] = dr["id_medio_distribucion"].ToString() + "|" + dr["nombre_medio"].ToString();
                }
                cbo_medio_distribucion.DataSource = dt;
                cbo_medio_distribucion.DisplayMember = "nombre_medio";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region validaciones - Otto Hernandez
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

        #region KeyPress de Textbox - Otto Hernandez
        private void txt_nombre_reclutamiento_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion
    }
}
