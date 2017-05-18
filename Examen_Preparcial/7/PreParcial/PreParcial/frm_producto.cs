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

namespace PreParcial
{
    public partial class frm_producto : Form
    {
        public frm_producto()
        {
            InitializeComponent();
        }



        CapaNegocio fn = new CapaNegocio();
        String Codigo;
        Boolean Editar;
        String atributo;
        public void llenarproveedor()
        {
            Conexion.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql=
            String Query = "select id_proveedor_pk, nombre FROM proveedor where estado <> 'INACTIVO' ";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexion.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "proveedor");
            cbo_prove.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_prove.ValueMember = ("id_proveedor_pk");
            //se indica el valor a desplegar en el combobox
            cbo_prove.DisplayMember = ("nombre");
            Conexion.Desconectar();
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
                string selectedItem = cbo_prove.SelectedValue.ToString();
                txt_id_prov.Text = selectedItem;
                TextBox[] textbox = { txt_descr,txt_id_prov,txt_nombre,txt_precio};
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

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                fn.ActivarControles(groupBox1);
                atributo = "id_producto_pk";
                this.Codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txt_descr.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.txt_precio.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                

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
                String atributo2 = "id_producto_pk";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "producto";
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

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "producto";
                fn.ActualizarGrid(this.dataGridView1, "Select  id_producto_pk, nombre_producto, descripcion, precio  FROM producto where estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_producto_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(groupBox1);
            llenarproveedor();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dataGridView1);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dataGridView1);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dataGridView1);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dataGridView1);
        }
    }
}
