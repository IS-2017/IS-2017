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
    public partial class frm_seguro_social : Form
    {
        public frm_seguro_social()
        {
            InitializeComponent();
        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String codigo;
        DataGridView dg;
        capa_datos cn = new capa_datos();
        public frm_seguro_social(DataGridView gb, String id_social, String p_laboral, String p_patronal,String fecha,String empresa, Boolean Editar1)
        {
            this.dg = gb;
            this.Editar = Editar1;
            this.codigo = id_social;
            InitializeComponent();
            if (Editar == true)
            {
                this.txt_p_laboral.Text = p_laboral;
                this.txt_p_patronal.Text = p_patronal;
                this.dt_fecha.Text = fecha;
                this.cbo_empresa.Text = empresa;

            }
        }
        private void frm_seguro_social_Load(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_p_laboral.Enabled = true; txt_p_patronal.Enabled = true;
            txt_p_laboral.Text = ""; txt_p_patronal.Text = "";
            cn.llenar_id_empresa(cbo_empresa);
            cbo_empresa.SelectedIndex = -1;
        }
        capa_negocio cp = new capa_negocio();
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            dt_fecha.Format = DateTimePickerFormat.Custom;
            dt_fecha.CustomFormat = "yyyy-MM-dd";
            if (Editar)
            {
                cp.ModificarSocial(codigo,txt_p_laboral.Text,txt_p_patronal.Text,dt_fecha.Text,cbo_empresa.SelectedValue.ToString());
            }
            else
            {
                cp.InsertarSocial(txt_p_laboral.Text,txt_p_patronal.Text,dt_fecha.Text,cbo_empresa.SelectedValue.ToString());
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
                    cn.eliminarSocial(codigo2);
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
            txt_p_laboral.Enabled = false; txt_p_patronal.Enabled = false;cbo_empresa.Enabled = false;
            txt_p_laboral.Text = ""; txt_p_patronal.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dg);
            TextBox[] textbox = { txt_p_patronal, txt_p_laboral,txt_fecha,txt_emp };
            fn.llenartextbox(textbox, dg);
            cbo_empresa.Text = txt_emp.Text;
            dt_fecha.Text = txt_fecha.Text;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dg);
            TextBox[] textbox = { txt_p_patronal, txt_p_laboral, txt_fecha, txt_emp };
            fn.llenartextbox(textbox, dg);
            cbo_empresa.Text = txt_emp.Text;
            dt_fecha.Text = txt_fecha.Text;
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dg);
            TextBox[] textbox = { txt_p_patronal, txt_p_laboral, txt_fecha, txt_emp };
            fn.llenartextbox(textbox, dg);
            cbo_empresa.Text = txt_emp.Text;
            dt_fecha.Text = txt_fecha.Text;
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dg);
            TextBox[] textbox = { txt_p_patronal, txt_p_laboral, txt_fecha, txt_emp };
            fn.llenartextbox(textbox, dg);
            cbo_empresa.Text = txt_emp.Text;
            dt_fecha.Text = txt_fecha.Text;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;

                this.codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_p_laboral.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_p_patronal.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.cbo_empresa.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.dt_fecha.Text = this.dg.CurrentRow.Cells[3].Value.ToString();

            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a modificar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
