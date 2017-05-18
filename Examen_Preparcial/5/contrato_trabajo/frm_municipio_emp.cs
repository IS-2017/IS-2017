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
    public partial class frm_municipio_emp : Form
    {
        String Codigo;
        Boolean Editar;
        String atributo;
        MySqlCommand comand;
        CapaNegocio fn = new CapaNegocio();
        DataGridView dg;
        public frm_municipio_emp(DataGridView dgv, String id_municipio_pk, String nombre_municipio, String ciudad_municipio, String ppueblo_municipio, String aldea_municipio, Boolean Editar1, Boolean tipo_accion)
        {
            InitializeComponent();
            this.dg = dgv;
            this.Editar = Editar1;
            atributo = "id_municipio_pk";
            this.Codigo = id_municipio_pk;
            if (tipo_accion == true)
            {
                this.txt_cod_mun.Text = id_municipio_pk;
                this.txt_nombre_mun.Text = nombre_municipio;
                this.txt_ciudad_mun.Text = ciudad_municipio;
                this.txt_pueblo_mun.Text = ppueblo_municipio;
                this.txt_aldea_mun.Text = aldea_municipio;
                this.fn.ActivarControles(gpb_nuevo_mun);
            }
            else
            {
                fn.ActivarControles(gpb_nuevo_mun);
            }
        }

        private void frm_municipio_emp_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(this);
            fn.InhabilitarComponentes(gpb_nuevo_mun);
            cbo_zona_llenado();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_nuevo_mun);
                fn.LimpiarComponentes(gpb_nuevo_mun);
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
                TextBox[] textbox = { txt_cod_mun, txt_nombre_mun, txt_ciudad_mun, txt_pueblo_mun, txt_aldea_mun, txt_id_zona_cambio, txt_estado };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "emp_municipio";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        fn.ActualizarGrid(this.dg, "Select `id_municipio_pk`, `nombre_municipio`, `ciudad_municipio`, `ppueblo_municipio`,`aldea_municipio`, `id_zona_emp_pk` from emp_municipio WHERE estado = 'ACTIVO' ", tabla);
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fn.ActualizarGrid(this.dg, "Select `id_municipio_pk`, `nombre_municipio`, `ciudad_municipio`, `ppueblo_municipio`,`aldea_municipio`, `id_zona_emp_pk` from emp_municipio WHERE estado = 'ACTIVO' ", tabla);
                        Conexionmysql.ObtenerConexion();
                    }
                    fn.LimpiarComponentes(this);
                    fn.LimpiarComponentes(gpb_nuevo_mun);
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
                atributo = "id_municipio_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_cod_mun.Text = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_mun.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_ciudad_mun.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_pueblo_mun.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_aldea_mun.Text = this.dg.CurrentRow.Cells[4].Value.ToString();

                fn.ActivarControles(gpb_nuevo_mun);
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_municipio_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string tabla = "emp_municipio";
                    fn.eliminar(tabla, atributo2, codigo2);
                    MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "emp_municipio";
                operaciones op = new operaciones();
                op.ejecutar(dg, tabla);
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
                fn.LimpiarComponentes(gpb_nuevo_mun);
                fn.InhabilitarComponentes(gpb_nuevo_mun);
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
                string tabla = "emp_municipio";
                fn.ActualizarGrid(this.dg, "Select `id_municipio_pk`, `nombre_municipio`, `ciudad_municipio`, `ppueblo_municipio`,`aldea_municipio`, `id_zona_emp_pk` from emp_municipio WHERE estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cbo_zona_llenado()
        {
            Conexionmysql.ObtenerConexion();
            DataSet ds = new DataSet();
            String Query = "SELECT DISTINCT id_zona_emp_pk, nombre_zona_emp FROM emp_zona WHERE estado <> 'INACTIVO'";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            dad.Fill(ds, "nombre_zona_emp");
            cbo_zona.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_zona.ValueMember = ("id_zona_emp_pk");
            //se indica el valor a desplegar en el combobox
            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["nombre_zona_emp"] = dr["nombre_zona_emp"].ToString();
            }
            cbo_zona.DataSource = dt;
            cbo_zona.DisplayMember = "nombre_zona_emp";
        }

        private void cbo_zona_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_id_zona_cambio.Text = cbo_zona.SelectedValue.ToString();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                atributo = "id_municipio_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_cod_mun.Text = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_mun.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_ciudad_mun.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_pueblo_mun.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_aldea_mun.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_id_zona_cambio.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); cbo_zona.Text = txt_id_zona_cambio.Text;
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
                atributo = "id_municipio_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_cod_mun.Text = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_mun.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_ciudad_mun.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_pueblo_mun.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_aldea_mun.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_id_zona_cambio.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); cbo_zona.Text = txt_id_zona_cambio.Text;
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
                atributo = "id_municipio_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_cod_mun.Text = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_mun.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_ciudad_mun.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_pueblo_mun.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_aldea_mun.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_id_zona_cambio.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); cbo_zona.Text = txt_id_zona_cambio.Text;
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
                atributo = "id_municipio_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_cod_mun.Text = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_mun.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_ciudad_mun.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_pueblo_mun.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_aldea_mun.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_id_zona_cambio.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); cbo_zona.Text = txt_id_zona_cambio.Text;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
