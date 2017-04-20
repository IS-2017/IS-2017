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
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String Codigo;
        String atributo;
        DataGridView dg;

        public frm_perfil_reclutamiento()
        {
            InitializeComponent();
        }

        public frm_perfil_reclutamiento(DataGridView gb, String id_perfil_reclutamiento_pk, String titulo_puesto, String descripcion_puesto, String detalle, String division, String departamento, String localizacion, String id_empresa_pk, Boolean Editar1)
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
                this.txt_division_perfil_reclutamiento.Text = division;
                this.txt_localizacion_perfil_reclutamiento.Text = localizacion;
                this.txt_empresa_perfil_reclutamiento.Text = id_empresa_pk; cbo_empresa_perfil_reclutamiento.Text = txt_empresa_perfil_reclutamiento.Text;
                this.txt_titulo_puesto_perfil_reclutamiento.Text = titulo_puesto;
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_departamento_perfil_reclutamiento.Enabled = true; txt_descripcion_puesto_perfil_reclutamiento.Enabled = true; txt_detalle_perfil_reclutamiento.Enabled = true; txt_division_perfil_reclutamiento.Enabled = true; txt_localizacion_perfil_reclutamiento.Enabled = true; cbo_empresa_perfil_reclutamiento.Enabled = true; txt_titulo_puesto_perfil_reclutamiento.Enabled = true;
            txt_departamento_perfil_reclutamiento.Text = ""; txt_descripcion_puesto_perfil_reclutamiento.Text = ""; txt_detalle_perfil_reclutamiento.Text = ""; txt_division_perfil_reclutamiento.Text = ""; txt_localizacion_perfil_reclutamiento.Text = ""; txt_titulo_puesto_perfil_reclutamiento.Text = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_empresa_perfil_reclutamiento.Text = cbo_empresa_perfil_reclutamiento.SelectedValue.ToString();
                TextBox[] textbox = { txt_estado_perfil_privilegio,txt_departamento_perfil_reclutamiento,txt_descripcion_puesto_perfil_reclutamiento,txt_detalle_perfil_reclutamiento,txt_division_perfil_reclutamiento,txt_localizacion_perfil_reclutamiento,txt_empresa_perfil_reclutamiento,txt_titulo_puesto_perfil_reclutamiento };
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
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /*bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_dep.Text, "documento");
                        if (insertar == 0)
                        {
                            btn_guardar.Enabled = false;
                        }*/
                        txt_departamento_perfil_reclutamiento.Text = ""; txt_descripcion_puesto_perfil_reclutamiento.Text = ""; txt_detalle_perfil_reclutamiento.Text = ""; txt_division_perfil_reclutamiento.Text = ""; txt_localizacion_perfil_reclutamiento.Text = ""; txt_empresa_perfil_reclutamiento.Text = ""; txt_titulo_puesto_perfil_reclutamiento.Text = "";
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_departamento_perfil_reclutamiento.Text = ""; txt_descripcion_puesto_perfil_reclutamiento.Text = ""; txt_detalle_perfil_reclutamiento.Text = ""; txt_division_perfil_reclutamiento.Text = ""; txt_localizacion_perfil_reclutamiento.Text = ""; txt_empresa_perfil_reclutamiento.Text = ""; txt_titulo_puesto_perfil_reclutamiento.Text = "";
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
                atributo = "id_perfil_reclutamiento_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_titulo_puesto_perfil_reclutamiento.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_descripcion_puesto_perfil_reclutamiento.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_detalle_perfil_reclutamiento.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_division_perfil_reclutamiento.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
                this.txt_departamento_perfil_reclutamiento.Text = this.dg.CurrentRow.Cells[6].Value.ToString();
                this.txt_localizacion_perfil_reclutamiento.Text = this.dg.CurrentRow.Cells[7].Value.ToString();
                this.txt_empresa_perfil_reclutamiento.Text = this.dg.CurrentRow.Cells[8].Value.ToString(); cbo_empresa_perfil_reclutamiento.Text = txt_empresa_perfil_reclutamiento.Text;
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
                String atributo2 = "id_perfil_reclutamiento_pk";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "perfil_reclutamiento";
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
            string tabla = "perfil_reclutamiento";
            //op.ejecutar(this.dg, tabla);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_departamento_perfil_reclutamiento.Enabled = false; txt_descripcion_puesto_perfil_reclutamiento.Enabled = false; txt_detalle_perfil_reclutamiento.Enabled = false; txt_division_perfil_reclutamiento.Enabled = false; txt_localizacion_perfil_reclutamiento.Enabled = false; cbo_empresa_perfil_reclutamiento.Enabled = false; txt_titulo_puesto_perfil_reclutamiento.Enabled = false;
            txt_departamento_perfil_reclutamiento.Text = ""; txt_descripcion_puesto_perfil_reclutamiento.Text = ""; txt_detalle_perfil_reclutamiento.Text = ""; txt_division_perfil_reclutamiento.Text = ""; txt_localizacion_perfil_reclutamiento.Text = ""; txt_titulo_puesto_perfil_reclutamiento.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "perfil_reclutamiento";
            fn.ActualizarGrid(this.dg, "Select * from perfil_reclutamiento WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dg);
            TextBox[] textbox = { txt_departamento_perfil_reclutamiento, txt_descripcion_puesto_perfil_reclutamiento, txt_detalle_perfil_reclutamiento, txt_division_perfil_reclutamiento, txt_localizacion_perfil_reclutamiento, txt_empresa_perfil_reclutamiento, txt_titulo_puesto_perfil_reclutamiento };
            fn.llenartextbox(textbox, dg);
            cbo_empresa_perfil_reclutamiento.Text = txt_empresa_perfil_reclutamiento.Text;

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dg);
            TextBox[] textbox = { txt_departamento_perfil_reclutamiento, txt_descripcion_puesto_perfil_reclutamiento, txt_detalle_perfil_reclutamiento, txt_division_perfil_reclutamiento, txt_localizacion_perfil_reclutamiento, txt_empresa_perfil_reclutamiento, txt_titulo_puesto_perfil_reclutamiento };
            fn.llenartextbox(textbox, dg);
            cbo_empresa_perfil_reclutamiento.Text = txt_empresa_perfil_reclutamiento.Text;
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dg);
            TextBox[] textbox = { txt_departamento_perfil_reclutamiento, txt_descripcion_puesto_perfil_reclutamiento, txt_detalle_perfil_reclutamiento, txt_division_perfil_reclutamiento, txt_localizacion_perfil_reclutamiento, txt_empresa_perfil_reclutamiento, txt_titulo_puesto_perfil_reclutamiento };
            fn.llenartextbox(textbox, dg);
            cbo_empresa_perfil_reclutamiento.Text = txt_empresa_perfil_reclutamiento.Text;
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dg);
            TextBox[] textbox = { txt_departamento_perfil_reclutamiento, txt_descripcion_puesto_perfil_reclutamiento, txt_detalle_perfil_reclutamiento, txt_division_perfil_reclutamiento, txt_localizacion_perfil_reclutamiento, txt_empresa_perfil_reclutamiento, txt_titulo_puesto_perfil_reclutamiento };
            fn.llenartextbox(textbox, dg);
            cbo_empresa_perfil_reclutamiento.Text = txt_empresa_perfil_reclutamiento.Text;
        }

        private void frm_reclutamiento_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_perfil_reclutamiento);
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
    }
}
