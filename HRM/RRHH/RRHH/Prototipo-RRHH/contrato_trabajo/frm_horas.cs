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
    public partial class frm_horas : Form
    {
        public frm_horas()
        {
            InitializeComponent();
        }

        private void frm_horas_Load(object sender, EventArgs e)
        {

        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String codigo;
        DataGridView dg;
        public frm_horas(DataGridView gb, String id_tasa, String descripcion, String porcentaje, Boolean Editar1)
        {
            this.dg = gb;
            this.Editar = Editar1;
            this.codigo = id_tasa;
            InitializeComponent();
            if (Editar == true)
            {
                this.txt_des.Text = descripcion;
                this.txt_precio.Text = porcentaje;

            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_des.Enabled = true; txt_precio.Enabled = true;
            txt_des.Text = ""; txt_precio.Text = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            capa_negocio cp = new capa_negocio();
            if (Editar)
            {
                cp.ModificarHora(codigo, txt_des.Text, txt_precio.Text);
            }
            else
            {
                cp.InsertarHora(txt_des.Text, txt_precio.Text);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_des.Enabled = false; txt_precio.Enabled = false;
            txt_des.Text = ""; txt_precio.Text = "";
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;

                this.codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_des.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_precio.Text = this.dg.CurrentRow.Cells[2].Value.ToString();

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
                //String atributo2 = "id_empresa_pk";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    capa_negocio cn = new capa_negocio();
                    cn.eliminarHora(codigo2);
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //bita.Eliminar("Eliminacion de empresa con el numero: " + codigo2, "empresa");
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            capa_datos cd = new capa_datos();
            this.dg.DataSource = cd.cargar("select id_hora_pk,descripcion,porcentaje from tasa_hora_extra where estado='ACTIVO' order by id_hora_pk");

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dg);
            TextBox[] textbox = { txt_des, txt_precio };
            fn.llenartextbox(textbox, dg);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dg);
            TextBox[] textbox = { txt_des, txt_precio };
            fn.llenartextbox(textbox, dg);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dg);
            TextBox[] textbox = { txt_des, txt_precio };
            fn.llenartextbox(textbox, dg);

        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dg);
            TextBox[] textbox = { txt_des, txt_precio };
            fn.llenartextbox(textbox, dg);
        }
    }
}
