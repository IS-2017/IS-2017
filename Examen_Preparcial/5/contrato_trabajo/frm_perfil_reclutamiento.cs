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
    public partial class frm_perfil_reclutamiento : Form
    {
        #region Variables - Otto Hernandez
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String Codigo;
        String atributo;
        DataGridView dg;
        #endregion

        #region Inicilializar - Otto Hernandez
        public frm_perfil_reclutamiento()
        {
            InitializeComponent();
        }

        public frm_perfil_reclutamiento(DataGridView gb, String id_perfil_reclutamiento_pk, String titulo_puesto, String descripcion_puesto, String detalle, String division, String departamento, String localizacion, String id_empresa_pk, Boolean Editar1)
        {
            try
            {
                this.dg = gb;
                this.Editar = Editar1;
                InitializeComponent();
                atributo = "id_perfil_reclutamiento_pk";
                this.Codigo = id_perfil_reclutamiento_pk;
                if (Editar == true)
                {
                    this.txt_departamento_perfil_reclutamiento.Text = departamento;
                    this.txt_descripcion_puesto_perfil_reclutamiento.Text = descripcion_puesto;
                    this.txt_detalle_perfil_reclutamiento.Text = detalle;
                    this.txt_id_area_trabajo_pk_perfil_reclutamiento.Text = division; cbo_are_trabajo_pk_perfil_reclutamiento.Text = txt_id_area_trabajo_pk_perfil_reclutamiento.Text;
                    this.txt_localizacion_perfil_reclutamiento.Text = localizacion;
                    this.txt_empresa_perfil_reclutamiento.Text = id_empresa_pk; cbo_empresa_perfil_reclutamiento.Text = txt_empresa_perfil_reclutamiento.Text;
                    this.txt_titulo_puesto_perfil_reclutamiento.Text = titulo_puesto;
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
                fn.InhabilitarComponentes(gpb_perfil_reclutamiento);
                llenarCboEmpresa();
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
                txt_departamento_perfil_reclutamiento.Enabled = true; txt_descripcion_puesto_perfil_reclutamiento.Enabled = true; txt_detalle_perfil_reclutamiento.Enabled = true; cbo_are_trabajo_pk_perfil_reclutamiento.Enabled = true; txt_localizacion_perfil_reclutamiento.Enabled = true; cbo_empresa_perfil_reclutamiento.Enabled = true; txt_titulo_puesto_perfil_reclutamiento.Enabled = true;
                txt_departamento_perfil_reclutamiento.Text = ""; txt_descripcion_puesto_perfil_reclutamiento.Text = ""; txt_detalle_perfil_reclutamiento.Text = ""; txt_id_area_trabajo_pk_perfil_reclutamiento.Text = ""; txt_localizacion_perfil_reclutamiento.Text = ""; txt_titulo_puesto_perfil_reclutamiento.Text = "";
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
                txt_empresa_perfil_reclutamiento.Text = cbo_empresa_perfil_reclutamiento.SelectedValue.ToString();
                txt_id_area_trabajo_pk_perfil_reclutamiento.Text = cbo_are_trabajo_pk_perfil_reclutamiento.SelectedValue.ToString();
                TextBox[] textbox = { txt_estado_perfil_privilegio,txt_departamento_perfil_reclutamiento,txt_descripcion_puesto_perfil_reclutamiento,txt_detalle_perfil_reclutamiento,txt_id_area_trabajo_pk_perfil_reclutamiento,txt_localizacion_perfil_reclutamiento,txt_empresa_perfil_reclutamiento,txt_titulo_puesto_perfil_reclutamiento };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "perfil_reclutamiento";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        fn.ActualizarGrid(this.dg, "Select * from perfil_reclutamiento WHERE estado <> 'INACTIVO' ", tabla);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /*bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_dep.Text, "documento");
                        if (insertar == 0)
                        {
                            btn_guardar.Enabled = false;
                        }*/
                        txt_departamento_perfil_reclutamiento.Text = ""; txt_descripcion_puesto_perfil_reclutamiento.Text = ""; txt_detalle_perfil_reclutamiento.Text = ""; txt_id_area_trabajo_pk_perfil_reclutamiento.Text = ""; txt_localizacion_perfil_reclutamiento.Text = ""; txt_empresa_perfil_reclutamiento.Text = ""; txt_titulo_puesto_perfil_reclutamiento.Text = "";
                        txt_departamento_perfil_reclutamiento.Enabled = false; txt_descripcion_puesto_perfil_reclutamiento.Enabled = false; txt_detalle_perfil_reclutamiento.Enabled = false; cbo_are_trabajo_pk_perfil_reclutamiento.Enabled = false; txt_localizacion_perfil_reclutamiento.Enabled = false; cbo_empresa_perfil_reclutamiento.Enabled = false; txt_titulo_puesto_perfil_reclutamiento.Enabled = false;
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        fn.ActualizarGrid(this.dg, "Select * from perfil_reclutamiento WHERE estado <> 'INACTIVO' ", tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_departamento_perfil_reclutamiento.Text = ""; txt_descripcion_puesto_perfil_reclutamiento.Text = ""; txt_detalle_perfil_reclutamiento.Text = ""; txt_id_area_trabajo_pk_perfil_reclutamiento.Text = ""; txt_localizacion_perfil_reclutamiento.Text = ""; txt_empresa_perfil_reclutamiento.Text = ""; txt_titulo_puesto_perfil_reclutamiento.Text = "";
                        txt_departamento_perfil_reclutamiento.Enabled = false; txt_descripcion_puesto_perfil_reclutamiento.Enabled = false; txt_detalle_perfil_reclutamiento.Enabled = false; cbo_are_trabajo_pk_perfil_reclutamiento.Enabled = false; txt_localizacion_perfil_reclutamiento.Enabled = false; cbo_empresa_perfil_reclutamiento.Enabled = false; txt_titulo_puesto_perfil_reclutamiento.Enabled = false;
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
                txt_departamento_perfil_reclutamiento.Enabled = true; txt_descripcion_puesto_perfil_reclutamiento.Enabled = true; txt_detalle_perfil_reclutamiento.Enabled = true; cbo_are_trabajo_pk_perfil_reclutamiento.Enabled = true; txt_localizacion_perfil_reclutamiento.Enabled = true; cbo_empresa_perfil_reclutamiento.Enabled = true; txt_titulo_puesto_perfil_reclutamiento.Enabled = true;
                Editar = true;
                atributo = "id_perfil_reclutamiento_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_titulo_puesto_perfil_reclutamiento.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_descripcion_puesto_perfil_reclutamiento.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_detalle_perfil_reclutamiento.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_departamento_perfil_reclutamiento.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_localizacion_perfil_reclutamiento.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
                this.txt_empresa_perfil_reclutamiento.Text = this.dg.CurrentRow.Cells[7].Value.ToString(); cbo_empresa_perfil_reclutamiento.Text = txt_empresa_perfil_reclutamiento.Text;
                this.txt_id_area_trabajo_pk_perfil_reclutamiento.Text = this.dg.CurrentRow.Cells[8].Value.ToString(); cbo_are_trabajo_pk_perfil_reclutamiento.Text = txt_id_area_trabajo_pk_perfil_reclutamiento.Text;
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
                String atributo2 = "id_perfil_reclutamiento_pk";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "perfil_reclutamiento";
                    fn.eliminar(tabla, atributo2, codigo2);
                    fn.ActualizarGrid(this.dg, "Select * from perfil_reclutamiento WHERE estado <> 'INACTIVO' ", tabla);
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
                string tabla = "perfil_reclutamiento";
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
                txt_departamento_perfil_reclutamiento.Enabled = false; txt_descripcion_puesto_perfil_reclutamiento.Enabled = false; txt_detalle_perfil_reclutamiento.Enabled = false; cbo_are_trabajo_pk_perfil_reclutamiento.Enabled = false; txt_localizacion_perfil_reclutamiento.Enabled = false; cbo_empresa_perfil_reclutamiento.Enabled = false; txt_titulo_puesto_perfil_reclutamiento.Enabled = false;
                txt_departamento_perfil_reclutamiento.Text = ""; txt_descripcion_puesto_perfil_reclutamiento.Text = ""; txt_detalle_perfil_reclutamiento.Text = ""; txt_id_area_trabajo_pk_perfil_reclutamiento.Text = ""; txt_localizacion_perfil_reclutamiento.Text = ""; txt_titulo_puesto_perfil_reclutamiento.Text = "";
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
                string tabla = "perfil_reclutamiento";
                fn.ActualizarGrid(this.dg, "Select * from perfil_reclutamiento WHERE estado <> 'INACTIVO' ", tabla);
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
                TextBox[] textbox = { txt_departamento_perfil_reclutamiento, txt_descripcion_puesto_perfil_reclutamiento, txt_detalle_perfil_reclutamiento, txt_id_area_trabajo_pk_perfil_reclutamiento, txt_localizacion_perfil_reclutamiento, txt_empresa_perfil_reclutamiento, txt_titulo_puesto_perfil_reclutamiento };
                fn.llenartextbox(textbox, dg);
                cbo_empresa_perfil_reclutamiento.Text = txt_empresa_perfil_reclutamiento.Text;
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
                TextBox[] textbox = { txt_departamento_perfil_reclutamiento, txt_descripcion_puesto_perfil_reclutamiento, txt_detalle_perfil_reclutamiento, txt_id_area_trabajo_pk_perfil_reclutamiento, txt_localizacion_perfil_reclutamiento, txt_empresa_perfil_reclutamiento, txt_titulo_puesto_perfil_reclutamiento };
                fn.llenartextbox(textbox, dg);
                cbo_empresa_perfil_reclutamiento.Text = txt_empresa_perfil_reclutamiento.Text;
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
                TextBox[] textbox = { txt_departamento_perfil_reclutamiento, txt_descripcion_puesto_perfil_reclutamiento, txt_detalle_perfil_reclutamiento, txt_id_area_trabajo_pk_perfil_reclutamiento, txt_localizacion_perfil_reclutamiento, txt_empresa_perfil_reclutamiento, txt_titulo_puesto_perfil_reclutamiento };
                fn.llenartextbox(textbox, dg);
                cbo_empresa_perfil_reclutamiento.Text = txt_empresa_perfil_reclutamiento.Text;
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
                TextBox[] textbox = { txt_departamento_perfil_reclutamiento, txt_descripcion_puesto_perfil_reclutamiento, txt_detalle_perfil_reclutamiento, txt_id_area_trabajo_pk_perfil_reclutamiento, txt_localizacion_perfil_reclutamiento, txt_empresa_perfil_reclutamiento, txt_titulo_puesto_perfil_reclutamiento };
                fn.llenartextbox(textbox, dg);
                cbo_empresa_perfil_reclutamiento.Text = txt_empresa_perfil_reclutamiento.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Llenar Combobox - Otto Hernandez
        public void llenarCboEmpresa()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Ayuda.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_empresa_pk, nombre_empresa from empresa";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "empresa");
                cbo_empresa_perfil_reclutamiento.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_empresa_perfil_reclutamiento.ValueMember = ("id_empresa_pk");
                //se indica el valor a desplegar en el combobox
                DataTable dt = ds.Tables[0];
                dt.Columns.Add("NewColumn", typeof(string));
                foreach (DataRow dr in dt.Rows)
                {
                    dr["nombre_empresa"] = dr["id_empresa_pk"].ToString() + "|" + dr["nombre_empresa"].ToString();
                }
                cbo_empresa_perfil_reclutamiento.DataSource = dt;
                cbo_empresa_perfil_reclutamiento.DisplayMember = "nombre_empresa";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
                cbo_are_trabajo_pk_perfil_reclutamiento.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_are_trabajo_pk_perfil_reclutamiento.ValueMember = ("id_area_trabajo_pk");
                //se indica el valor a desplegar en el combobox
                DataTable dt = ds.Tables[0];
                dt.Columns.Add("NewColumn", typeof(string));
                foreach (DataRow dr in dt.Rows)
                {
                    dr["puesto"] = dr["id_area_trabajo_pk"].ToString() + "|" + dr["puesto"].ToString();
                }
                cbo_are_trabajo_pk_perfil_reclutamiento.DataSource = dt;
                cbo_are_trabajo_pk_perfil_reclutamiento.DisplayMember = "puesto";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Validaciones - Otto Hernandez
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

        #region Keypress textbox - Otto Hernandez
        private void txt_titulo_puesto_perfil_reclutamiento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_descripcion_puesto_perfil_reclutamiento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_detalle_perfil_reclutamiento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_departamento_perfil_reclutamiento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_localizacion_perfil_reclutamiento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
