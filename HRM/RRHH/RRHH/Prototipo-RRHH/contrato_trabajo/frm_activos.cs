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
    public partial class frm_activos : Form
    {

        string imgLoc;
        string imgname;
        String Codigo;
        Boolean Editar;
        String atributo;
        MySqlCommand comand;
        CapaNegocio fn = new CapaNegocio();
        DataGridView dg;

        public frm_activos(DataGridView dgv, String id_activos_emp_pk, String nombre_activo, String cantidad_activo, String descripcion_activo, String estado, Boolean Editar1, Boolean tipo_accion)
        {
            this.dg = dgv;
            this.Editar = Editar1;
            InitializeComponent();
            atributo = "id_activos_emp_pk";
            this.Codigo = id_activos_emp_pk;
            if (tipo_accion == true)
            {

                this.txt_nombre_activo.Text = nombre_activo;
                this.txt_nmup_cantidad_activo.Text = cantidad_activo; nmup_cantidad_activo.Value = Convert.ToInt32(txt_nmup_cantidad_activo.Text);
                this.txt_descripcion_activo.Text = descripcion_activo;

                this.fn.ActivarControles(gpb_activos);
            }
            else
            {
                fn.ActivarControles(gpb_activos);
            }
        }

        private void nmup_cantidad_activo_ValueChanged(object sender, EventArgs e)
        {
            txt_nmup_cantidad_activo.Text = nmup_cantidad_activo.Value.ToString();
        }

        private void frm_activos_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_activos);
            fn.InhabilitarComponentes(this);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_activos);
                fn.LimpiarComponentes(gpb_activos);

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
                TextBox[] textbox = { txt_nombre_activo, txt_nmup_cantidad_activo, txt_descripcion_activo, txt_estado };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "activos_empresa";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Conexionmysql.ObtenerConexion();
                    }
                    fn.LimpiarComponentes(this);
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
                atributo = "id_activos_emp_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_activo.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_nmup_cantidad_activo.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); nmup_cantidad_activo.Value = Convert.ToInt32(txt_nmup_cantidad_activo.Text);
                this.txt_descripcion_activo.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                fn.ActivarControles(gpb_activos);
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
                String atributo2 = "id_activos_emp_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string tabla = "activos_empresa";
                    fn.eliminar(tabla, atributo2, codigo2);
                    MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Editar = false;
                fn.LimpiarComponentes(gpb_activos);
                fn.InhabilitarComponentes(gpb_activos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "activos_empresa";
            fn.ActualizarGrid(this.dg, "SELECT * FROM `activos_empresa` WHERE estado = 'ACTIVO' ", tabla);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dg);
            this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
            this.txt_nombre_activo.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
            this.txt_nmup_cantidad_activo.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); nmup_cantidad_activo.Value = Convert.ToInt32(txt_nmup_cantidad_activo.Text);
            this.txt_descripcion_activo.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dg);
            this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
            this.txt_nombre_activo.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
            this.txt_nmup_cantidad_activo.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); nmup_cantidad_activo.Value = Convert.ToInt32(txt_nmup_cantidad_activo.Text);
            this.txt_descripcion_activo.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dg);
            this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
            this.txt_nombre_activo.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
            this.txt_nmup_cantidad_activo.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); nmup_cantidad_activo.Value = Convert.ToInt32(txt_nmup_cantidad_activo.Text);
            this.txt_descripcion_activo.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dg);
            this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
            this.txt_nombre_activo.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
            this.txt_nmup_cantidad_activo.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); nmup_cantidad_activo.Value = Convert.ToInt32(txt_nmup_cantidad_activo.Text);
            this.txt_descripcion_activo.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
