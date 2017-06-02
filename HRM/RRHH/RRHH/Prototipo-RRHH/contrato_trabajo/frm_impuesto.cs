using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contrato_trabajo
{
    public partial class frm_impuesto : Form
    {
        public frm_impuesto()
        {
            InitializeComponent();
        }
        
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String codigo;
        DataGridView dg;
        public frm_impuesto(DataGridView gb, String id_tasa, String mini, String max, String Porcentaje, Boolean Editar1)
        {
            this.dg = gb;
            this.Editar = Editar1;
            this.codigo = id_tasa;
            InitializeComponent();
            if (Editar == true)
            {
                this.txt_inferior.Text = mini;
                this.txt_superior.Text = max;
                this.txt_porcentaje.Text = Porcentaje;

            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            capa_negocio cn = new capa_negocio();
            //cn.InsertarTasa(txt_nombre.Text,txt_porcentaje.Text);
        }

        private void frm_impuesto_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(txt_inferior);
            fn.InhabilitarComponentes(txt_superior);
            fn.InhabilitarComponentes(txt_porcentaje);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_inferior.Enabled = true; txt_porcentaje.Enabled = true; txt_superior.Enabled = true;
            txt_superior.Text = ""; txt_porcentaje.Text = ""; txt_inferior.Text = "";

        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            capa_negocio cp = new capa_negocio();
            if (Editar)
            {
                cp.ModificarTasa(codigo, txt_inferior.Text, txt_superior.Text, txt_porcentaje.Text);
            }
            else
            {
                cp.InsertarTasa(txt_inferior.Text, txt_superior.Text, txt_porcentaje.Text);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dg);
            TextBox[] textbox = { txt_inferior, txt_superior, txt_porcentaje };
            fn.llenartextbox(textbox, dg);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dg);
            TextBox[] textbox = { txt_inferior, txt_superior, txt_porcentaje };
            fn.llenartextbox(textbox, dg);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dg);
            TextBox[] textbox = { txt_inferior, txt_superior, txt_porcentaje };
            fn.llenartextbox(textbox, dg);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dg);
            TextBox[] textbox = { txt_inferior, txt_superior, txt_porcentaje };
            fn.llenartextbox(textbox, dg);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                //String atributo2 = "id_empresa_pk";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    capa_negocio cn = new capa_negocio();
                    cn.eliminarTasa(codigo2);
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
            Editar = false;
            txt_inferior.Enabled = false; txt_superior.Enabled = false; txt_porcentaje.Enabled = false;
            txt_inferior.Text = ""; txt_superior.Text = ""; txt_porcentaje.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            capa_datos cd = new capa_datos();
            this.dg.DataSource = cd.cargar("select id_tasa_pk,minimo_sueldo,maximo_sueldo,porcentaje from tasa_impuesto where estado='ACTIVO' order by id_tasa_pk");

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;

                this.codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_inferior.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_superior.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_porcentaje.Text = this.dg.CurrentRow.Cells[3].Value.ToString();

            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a modificar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_porcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar v = new Validar();
            v.validacion_solonumeros(e);
        }
    }
}
