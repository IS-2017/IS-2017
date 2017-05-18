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

namespace PreParcial
{
    public partial class frm_precio : Form
    {
        public frm_precio()
        {
            InitializeComponent();
        }

        CapaNegocio fn = new CapaNegocio();
        String Codigo;
        Boolean Editar;
        String atributo;
        public void llenarproducto()
        {
            Conexion.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql=
            String Query = "select id_producto_pk, nombre_producto FROM producto where estado <> 'INACTIVO' ";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexion.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "producto");
            cbo_produ.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_produ.ValueMember = ("id_producto_pk");
            //se indica el valor a desplegar en el combobox
            cbo_produ.DisplayMember = ("nombre_producto");
            Conexion.Desconectar();
        }

        public void llenarinventario()
        {
            string selectedItem = cbo_produ.SelectedValue.ToString();
            OdbcConnection Conexion2;
            OdbcCommand Query2 = new OdbcCommand();
            OdbcDataReader consultar2;
            //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
            //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
            Conexion2 = new OdbcConnection();
            Conexion2.ConnectionString = sql;
            Conexion2.Open();
            Query2.CommandText = "SELECT id_inventario_pk from bien where id_producto_pk = '" + selectedItem + "' AND estado <>'INACTIVO';";
            Query2.Connection = Conexion2;
            consultar2 = Query2.ExecuteReader();
            while (consultar2.Read())
            {

                txt_pro.Text = Convert.ToString(consultar2.GetInt32(0));
                // MessageBox.Show(Convert.ToString(cadena_act));
            }
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(groupBox1);
                fn.LimpiarComponentes(groupBox1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = cbo_produ.SelectedValue.ToString();
                txt_pro.Text = selectedItem;
                TextBox[] textbox = { txt_pro, txt_cantidad };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "precio";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);


                    }
                    else
                    {
                        fn.insertar(datos, tabla);

                    }
                    fn.LimpiarComponentes(groupBox1);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbo_produ_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_pro.Text = "";
            llenarinventario();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                fn.ActivarControles(groupBox1);
                atributo = "id_precio_pk";
                this.Codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                
                this.txt_cantidad.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a modificar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_precio_pk";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "precio";
                    fn.eliminar(tabla, atributo2, codigo2);
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //bita.Eliminar("Eliminacion de empresa con el numero: " + codigo2, "empresa");
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                fn.ActivarControles(groupBox1);
                Editar = true;
                fn.LimpiarComponentes(groupBox1);
                fn.InhabilitarComponentes(groupBox1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_precio_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(groupBox1);
            llenarproducto();
            llenarinventario();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "precio";
                fn.ActualizarGrid(this.dataGridView1, "SELECT Pr.nombre_producto, P.precio FROM precio P, bien B, producto Pr Where P.id_inventario_pk = B.id_inventario_pk AND B.id_producto_pk = Pr.id_producto_pk AND P.estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
