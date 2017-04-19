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

namespace contrato_trabajo
{
    public partial class frm_medio_distribucion : Form
    {
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String Codigo;
        String atributo;
        DataGridView dg;

        public frm_medio_distribucion()
        {
            InitializeComponent();
        }

        public frm_medio_distribucion(DataGridView gb, String id_medio_distribucion, String nombre_medio, String correo_medio, String telefono_medio, String url_medio, Boolean Editar1)
        {
            this.dg = gb;
            this.Editar = Editar1;
            InitializeComponent();
            atributo = "id_medio_distribucion";
            this.Codigo = id_medio_distribucion;
            if (Editar == true)
            {
                this.txt_correo_medio.Text = correo_medio;
                this.txt_nombre_medio.Text = nombre_medio;
                this.txt_telefono_medio.Text = telefono_medio;
                this.txt_url_medio.Text = url_medio;
            }
        }

        private void frm_medio_distribucion_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_medio_distribucion);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_correo_medio.Enabled = true; txt_nombre_medio.Enabled = true; txt_telefono_medio.Enabled = true; txt_url_medio.Enabled = true;
            txt_correo_medio.Text = ""; txt_nombre_medio.Text = ""; txt_telefono_medio.Text = ""; txt_url_medio.Text = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox[] textbox = { txt_correo_medio, txt_estado_medio, txt_nombre_medio, txt_telefono_medio, txt_url_medio };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "medio_distribucion";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /*bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_dep.Text, "documento");
                        if (insertar == 0)
                        {
                            btn_guardar.Enabled = false;
                        }*/
                        txt_correo_medio.Text = ""; txt_nombre_medio.Text = ""; txt_telefono_medio.Text = ""; txt_url_medio.Text = "";
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_correo_medio.Text = ""; txt_nombre_medio.Text = ""; txt_telefono_medio.Text = ""; txt_url_medio.Text = "";
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
                atributo = "id_medio_distribucion";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_medio.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_correo_medio.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_telefono_medio.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_url_medio.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
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
                String atributo2 = "id_medio_distribucion";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "medio_distribucion";
                    fn.eliminar(tabla, atributo2, codigo2);
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //bita.Eliminar("Eliminacion de empresa con el numero: " + codigo2, "empresa");
                    txt_correo_medio.Text = ""; txt_nombre_medio.Text = ""; txt_telefono_medio.Text = ""; txt_url_medio.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "medio_distribucion";
            //op.ejecutar(this.dg, tabla);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_correo_medio.Enabled = false; txt_nombre_medio.Enabled = false; txt_telefono_medio.Enabled = false; txt_url_medio.Enabled = false;
            txt_correo_medio.Text = ""; txt_nombre_medio.Text = ""; txt_telefono_medio.Text = ""; txt_url_medio.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "medio_distribucion";
            fn.ActualizarGrid(this.dg, "Select * from medio_distribucion WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                TextBox[] textbox = { txt_correo_medio, txt_nombre_medio, txt_telefono_medio, txt_url_medio};
                fn.llenartextbox(textbox, dg);
            }
            catch
            {
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Siguiente(dg);
                TextBox[] textbox = { txt_correo_medio, txt_nombre_medio, txt_telefono_medio, txt_url_medio };
                fn.llenartextbox(textbox, dg);
            }
            catch
            {
            }
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Primero(dg);
                TextBox[] textbox = { txt_correo_medio, txt_nombre_medio, txt_telefono_medio, txt_url_medio };
                fn.llenartextbox(textbox, dg);
            }
            catch
            {
            }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Ultimo(dg);
                TextBox[] textbox = { txt_correo_medio, txt_nombre_medio, txt_telefono_medio, txt_url_medio };
                fn.llenartextbox(textbox, dg);
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
