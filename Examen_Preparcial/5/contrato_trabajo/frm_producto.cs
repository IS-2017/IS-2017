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
    public partial class frm_producto : Form
    {
        #region Variables - Otto Hernandez
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String Codigo;
        String atributo;
        DataGridView dg;
        #endregion

        #region Inicializar - Otto Hernandez
        public frm_producto()
        {
            InitializeComponent();
        }

        public frm_producto(DataGridView gb, string id_producto, string nombre_producto, string costo_producto, string cantidad_producto, string precio_producto, string id_proveedor, Boolean Editar1)
        {
            try
            {
                InitializeComponent();
                this.dg = gb;
                this.Editar = Editar1;
                atributo = "id_producto";
                this.Codigo = id_producto;
                if (Editar == true)
                {
                    this.txt_cantidad.Text = cantidad_producto;
                    this.txt_nombre.Text = nombre_producto;
                    this.txt_costo.Text = costo_producto;
                    this.txt_proveedor.Text = id_proveedor; cbo_proveedor.Text = txt_proveedor.Text;
                    this.txt_precio.Text = precio_producto;
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
                txt_cantidad.Enabled = true; txt_costo.Enabled = true; txt_nombre.Enabled = true; cbo_proveedor.Enabled = true; txt_precio.Enabled = true; 
                txt_cantidad.Text = ""; txt_costo.Text = ""; txt_nombre.Text = ""; txt_proveedor.Text = ""; txt_precio.Text = "";
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
                txt_proveedor.Text = cbo_proveedor.SelectedValue.ToString();
                TextBox[] textbox = { txt_cantidad, txt_costo, txt_nombre, txt_precio, txt_proveedor,txt_estado};
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "producto";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        fn.ActualizarGrid(this.dg, "Select * from producto WHERE estado <> 'INACTIVO' ", tabla);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /*bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_dep.Text, "documento");
                        if (insertar == 0)
                        {
                            btn_guardar.Enabled = false;
                        }*/
                        txt_cantidad.Text = ""; txt_costo.Text = ""; txt_nombre.Text = ""; txt_precio.Text = ""; txt_proveedor.Text = ""; 
                        txt_cantidad.Enabled = false; txt_costo.Enabled = false; txt_nombre.Enabled = false; txt_precio.Enabled = false; txt_proveedor.Enabled = false;
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        fn.ActualizarGrid(this.dg, "Select * from producto WHERE estado <> 'INACTIVO' ", tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_cantidad.Text = ""; txt_costo.Text = ""; txt_nombre.Text = ""; txt_precio.Text = ""; txt_proveedor.Text = "";
                        txt_cantidad.Enabled = false; txt_costo.Enabled = false; txt_nombre.Enabled = false; txt_precio.Enabled = false; cbo_proveedor.Enabled = false;
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
                txt_cantidad.Enabled = true; txt_costo.Enabled = true; txt_nombre.Enabled = true; txt_precio.Enabled = true; cbo_proveedor.Enabled = true;
                Editar = true;
                atributo = "id_producto";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_costo.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_cantidad.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_precio.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_proveedor.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); cbo_proveedor.Text = txt_proveedor.Text;
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
                String atributo2 = "id_producto";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "producto";
                    fn.eliminar(tabla, atributo2, codigo2);
                    fn.ActualizarGrid(this.dg, "Select * from producto WHERE estado <> 'INACTIVO' ", tabla);
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
                string tabla = "producto";
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
                txt_cantidad.Enabled = false; txt_costo.Enabled = false; txt_nombre.Enabled = false; cbo_proveedor.Enabled = false; txt_precio.Enabled = false;
                txt_cantidad.Text = ""; txt_costo.Text = ""; txt_nombre.Text = ""; txt_proveedor.Text = ""; txt_precio.Text = "";
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
                string tabla = "producto";
                fn.ActualizarGrid(this.dg, "Select * from producto WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Reporteador - Otto Hernandez
        private void button1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Botones de navegacion - Otto Hernandez
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                TextBox[] textbox = { txt_cantidad, txt_costo, txt_nombre, txt_precio, txt_proveedor};
                fn.llenartextbox(textbox, dg);
                cbo_proveedor.Text = txt_proveedor.Text;
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
                TextBox[] textbox = { txt_cantidad, txt_costo, txt_nombre, txt_precio, txt_proveedor };
                fn.llenartextbox(textbox, dg);
                cbo_proveedor.Text = txt_proveedor.Text;
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
                TextBox[] textbox = { txt_cantidad, txt_costo, txt_nombre, txt_precio, txt_proveedor };
                fn.llenartextbox(textbox, dg);
                cbo_proveedor.Text = txt_proveedor.Text;
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
                TextBox[] textbox = { txt_cantidad, txt_costo, txt_nombre, txt_precio, txt_proveedor };
                fn.llenartextbox(textbox, dg);
                cbo_proveedor.Text = txt_proveedor.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Llenar Combobox - Otto Hernandez
        public void llenarCboProveedor()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Ayuda.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_proveedor, nombre_proveedor from proveedor";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "proveedor");
                cbo_proveedor.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_proveedor.ValueMember = ("id_proveedor");
                //se indica el valor a desplegar en el combobox
                DataTable dt = ds.Tables[0];
                dt.Columns.Add("NewColumn", typeof(string));
                foreach (DataRow dr in dt.Rows)
                {
                    dr["nombre_proveedor"] = dr["id_proveedor"].ToString() + "|" + dr["nombre_proveedor"].ToString();
                }
                cbo_proveedor.DataSource = dt;
                cbo_proveedor.DisplayMember = "nombre_proveedor";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region load form - Otto Hernandez
        private void frm_producto_Load(object sender, EventArgs e)
        {
            try
            {
                fn.InhabilitarComponentes(gpb_proveedor);
                llenarCboProveedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
