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
    public partial class frm_reclutamiento : Form
    {
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String Codigo;
        String atributo;
        DataGridView dg;

        public frm_reclutamiento()
        {
            InitializeComponent();
        }

        public frm_reclutamiento(DataGridView gb, String id_reclutamiento_pk, String titulo_puesto, String descripcion_puesto, String requisito, String detalle, String division, String departamento, String localizacion, String id_empresa_pk, Boolean Editar1)
        {
            this.dg = gb;
            this.Editar = Editar1;
            InitializeComponent();
            atributo = "id_reclutamiento_pk";
            this.Codigo = id_reclutamiento_pk;
            if (Editar == true)
            {
                this.txt_departamento_rec.Text = departamento;
                this.txt_descripcion_puesto_rec.Text = descripcion_puesto;
                this.txt_detalle_rec.Text = detalle;
                this.txt_division_rec.Text = division;
                this.txt_localizacion_rec.Text = localizacion;
                this.txt_nombre_rec.Text = id_empresa_pk; cbo_nombre_rec.Text = txt_nombre_rec.Text;
                this.txt_requisito_rec.Text = requisito;
                this.txt_titulo_puesto_rec.Text = titulo_puesto;
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_departamento_rec.Enabled = true; txt_descripcion_puesto_rec.Enabled = true; txt_detalle_rec.Enabled = true; txt_division_rec.Enabled = true; txt_localizacion_rec.Enabled = true; cbo_nombre_rec.Enabled = true; txt_requisito_rec.Enabled = true; txt_titulo_puesto_rec.Enabled = true;
            txt_departamento_rec.Text = ""; txt_descripcion_puesto_rec.Text = ""; txt_detalle_rec.Text = ""; txt_division_rec.Text = ""; txt_localizacion_rec.Text = ""; txt_requisito_rec.Text = ""; txt_titulo_puesto_rec.Text = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_nombre_rec.Text = cbo_nombre_rec.SelectedValue.ToString();
                TextBox[] textbox = { txt_departamento_rec,txt_descripcion_puesto_rec,txt_detalle_rec,txt_division_rec,txt_localizacion_rec,txt_nombre_rec,txt_requisito_rec,txt_titulo_puesto_rec };
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
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /*bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_dep.Text, "documento");
                        if (insertar == 0)
                        {
                            btn_guardar.Enabled = false;
                        }*/
                        txt_departamento_rec.Text = ""; txt_descripcion_puesto_rec.Text = ""; txt_detalle_rec.Text = ""; txt_division_rec.Text = ""; txt_localizacion_rec.Text = ""; txt_nombre_rec.Text = ""; txt_requisito_rec.Text = ""; txt_titulo_puesto_rec.Text = "";
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_departamento_rec.Text = ""; txt_descripcion_puesto_rec.Text = ""; txt_detalle_rec.Text = ""; txt_division_rec.Text = ""; txt_localizacion_rec.Text = ""; txt_nombre_rec.Text = ""; txt_requisito_rec.Text = ""; txt_titulo_puesto_rec.Text = "";
                    }
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
                atributo = "id_reclutamiento_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_titulo_puesto_rec.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_descripcion_puesto_rec.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_requisito_rec.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_detalle_rec.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_division_rec.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
                this.txt_departamento_rec.Text = this.dg.CurrentRow.Cells[6].Value.ToString();
                this.txt_localizacion_rec.Text = this.dg.CurrentRow.Cells[7].Value.ToString();
                this.txt_nombre_rec.Text = this.dg.CurrentRow.Cells[8].Value.ToString(); cbo_nombre_rec.Text = txt_nombre_rec.Text;
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
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_reclutamiento_pk";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "reclutamiento";
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "reclutamiento";
            //op.ejecutar(this.dg, tabla);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_departamento_rec.Enabled = false; txt_descripcion_puesto_rec.Enabled = false; txt_detalle_rec.Enabled = false; txt_division_rec.Enabled = false; txt_localizacion_rec.Enabled = false; cbo_nombre_rec.Enabled = false; txt_requisito_rec.Enabled = false; txt_titulo_puesto_rec.Enabled = false;
            txt_departamento_rec.Text = ""; txt_descripcion_puesto_rec.Text = ""; txt_detalle_rec.Text = ""; txt_division_rec.Text = ""; txt_localizacion_rec.Text = ""; txt_requisito_rec.Text = ""; txt_titulo_puesto_rec.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "reclutamiento";
            fn.ActualizarGrid(this.dg, "Select * from reclutamiento WHERE estado_reclutamiento <> 'INACTIVO' ", tabla);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dg);
            TextBox[] textbox = { txt_departamento_rec, txt_descripcion_puesto_rec, txt_detalle_rec, txt_division_rec, txt_localizacion_rec, txt_nombre_rec, txt_requisito_rec, txt_titulo_puesto_rec };
            fn.llenartextbox(textbox, dg);
            cbo_nombre_rec.Text = txt_nombre_rec.Text;

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dg);
            TextBox[] textbox = { txt_departamento_rec, txt_descripcion_puesto_rec, txt_detalle_rec, txt_division_rec, txt_localizacion_rec, txt_nombre_rec, txt_requisito_rec, txt_titulo_puesto_rec };
            fn.llenartextbox(textbox, dg);
            cbo_nombre_rec.Text = txt_nombre_rec.Text;
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dg);
            TextBox[] textbox = { txt_departamento_rec, txt_descripcion_puesto_rec, txt_detalle_rec, txt_division_rec, txt_localizacion_rec, txt_nombre_rec, txt_requisito_rec, txt_titulo_puesto_rec };
            fn.llenartextbox(textbox, dg);
            cbo_nombre_rec.Text = txt_nombre_rec.Text;
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dg);
            TextBox[] textbox = { txt_departamento_rec, txt_descripcion_puesto_rec, txt_detalle_rec, txt_division_rec, txt_localizacion_rec, txt_nombre_rec, txt_requisito_rec, txt_titulo_puesto_rec };
            fn.llenartextbox(textbox, dg);
            cbo_nombre_rec.Text = txt_nombre_rec.Text;
        }

        private void frm_reclutamiento_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(txt_departamento_rec);
            fn.InhabilitarComponentes(txt_descripcion_puesto_rec);
            fn.InhabilitarComponentes(txt_detalle_rec);
            fn.InhabilitarComponentes(txt_division_rec);
            fn.InhabilitarComponentes(txt_localizacion_rec);
            fn.InhabilitarComponentes(cbo_nombre_rec);
            fn.InhabilitarComponentes(txt_requisito_rec);
            fn.InhabilitarComponentes(txt_titulo_puesto_rec);
            llenarCboEmpresa();
        }

        public void llenarCboEmpresa()
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
            cbo_nombre_rec.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_nombre_rec.ValueMember = ("id_empresa_pk");
            //se indica el valor a desplegar en el combobox
            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["nombre_empresa"] = dr["id_empresa_pk"].ToString() + "|" + dr["nombre_empresa"].ToString();
            }
            cbo_nombre_rec.DataSource = dt;
            cbo_nombre_rec.DisplayMember = "nombre_empresa";
        }
    }
}
