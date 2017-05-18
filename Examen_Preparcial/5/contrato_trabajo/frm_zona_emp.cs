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
using dllconsultas;
using System.Data.Odbc;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Data;
using System.Threading;
using System.IO;

namespace contrato_trabajo
{
    public partial class frm_zona_emp : Form
    {
        String Codigo;
        Boolean Editar;
        String atributo;
        MySqlCommand comand;
        CapaNegocio fn = new CapaNegocio();
        DataGridView dg;
        public frm_zona_emp(DataGridView dgv, String id_zona_emp_pk, String nombre_zona_emp, String descripcion_zona_emp, Boolean Editar1, Boolean tipo_accion)
        {
            try
            {
                InitializeComponent();
                this.dg = dgv;
                this.Editar = Editar1;
                atributo = "id_zona_emp_pk";
                this.Codigo = id_zona_emp_pk;
                if (tipo_accion == true)
                {
                    this.txt_nombre_zona.Text = nombre_zona_emp;
                    this.txt_cod_zona.Text = id_zona_emp_pk;
                    this.txt_descripcion_zona.Text = descripcion_zona_emp;
                    this.fn.ActivarControles(gpb_nueva_zona);
                }
                else
                {
                    fn.ActivarControles(gpb_nueva_zona);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_zona_emp_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(this);
            fn.InhabilitarComponentes(gpb_nueva_zona);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_nueva_zona);
                fn.LimpiarComponentes(gpb_nueva_zona);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(gpb_nueva_zona);
                fn.InhabilitarComponentes(gpb_nueva_zona);
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
                txt_estado.Text = "ACTIVO";
                TextBox[] textbox = { txt_cod_zona, txt_descripcion_zona, txt_nombre_zona, txt_estado };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "emp_zona";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Conexionmysql.ObtenerConexion();
                    }
                    fn.LimpiarComponentes(this);
                    fn.LimpiarComponentes(gpb_nueva_zona);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "id_zona_emp_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_cod_zona.Text = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_zona.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_descripcion_zona.Text = this.dg.CurrentRow.Cells[2].Value.ToString();

                fn.ActivarControles(gpb_nueva_zona);
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //try
           // {
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_zona_emp_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string tabla = "emp_zona";
                    fn.eliminar(tabla, atributo2, codigo2);
                    MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
          /*  }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } */
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "emp_zona";
                operaciones op = new operaciones();
                op.ejecutar(dg, tabla);
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
                string tabla = "emp_zona";
                fn.ActualizarGrid(this.dg, "Select `id_zona_emp_pk`, `nombre_zona_emp`, `descripcion_zona_emp` from emp_zona WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                atributo = "id_zona_emp_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_cod_zona.Text = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_zona.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_descripcion_zona.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                
            }

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Siguiente(dg);
                atributo = "id_zona_emp_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_cod_zona.Text = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_zona.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_descripcion_zona.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Primero(dg);
                atributo = "id_zona_emp_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_cod_zona.Text = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_zona.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_descripcion_zona.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Ultimo(dg);
                atributo = "id_zona_emp_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_cod_zona.Text = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_zona.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_descripcion_zona.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
