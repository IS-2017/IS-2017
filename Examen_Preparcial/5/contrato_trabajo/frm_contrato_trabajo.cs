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
    public partial class frm_contrato_trabajo : Form
    {
        public frm_contrato_trabajo()
        {
            InitializeComponent();
        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String codigo;
        DataGridView dg;

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_id_emp.Enabled = true; txt_id_empresa.Enabled = true; txt_fecha_inicio.Enabled = true; txt_periodo_pago.Enabled = true; txt_id_jornada.Enabled = true;
            txt_puesto.Enabled = true; txt_salario_base.Enabled = true; txt_nombre.Enabled = true; txt_nombre_empresa.Enabled = true; txt_nombre_empleado.Enabled = true; txt_bonificacion.Enabled = true; dateTimePicker1.Enabled = true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                capa_negocio cn = new capa_negocio();
                capa_datos cd = new capa_datos();
                string estado = "activo";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                String fecha = dateTimePicker1.Text;
                cn.ingresar_contrato(txt_fecha_inicio.Text, fecha, txt_puesto.Text, txt_salario_base.Text, txt_bonificacion.Text, txt_periodo_pago.Text, estado, txt_id_emp.Text, txt_id_jornada.Text, txt_dato_personal.Text, txt_id_empresa.Text);
                cn.actualizar_empleado_estado(txt_id_emp.Text);
                MessageBox.Show(" El empleado '" + txt_nombre_empleado.Text +"' ha sido contratado'");
                

            }
            else
            {

            }
        }

        public frm_contrato_trabajo(DataGridView gv, String Id_empleado, String Nombre_Empleado1, string nombre_Empleado2, String Id_Empresa, String Nombre_empresa, String fecha_alta, String Periodo_pago, String id_jornada, string nombre_jornada, string id_puesto, String puesto, String Salario_base, Boolean Editar1)
        {
            this.dg = gv;
            this.Editar = Editar1;
            InitializeComponent();
            if (Editar == false)
            {
                this.txt_id_emp.Text = Id_empleado;
                this.txt_nombre_empleado.Text = Nombre_Empleado1 + " " + nombre_Empleado2;
                this.txt_id_empresa.Text = Id_Empresa;
                this.txt_nombre_empresa.Text = Nombre_empresa;
                //dgv_contratos.Columns[5].HeaderText = "Estado Laboral";


                this.txt_fecha_inicio.Text = fecha_alta;
                this.txt_periodo_pago.Text = Periodo_pago;
                this.txt_id_jornada.Text = id_jornada;
                this.txt_nombre.Text = nombre_jornada;
                this.txt_puesto.Text = id_puesto;
                this.txt_salario_base.Text = Salario_base;

            }

        }

        private void frm_contrato_trabajo_Load(object sender, EventArgs e)
        {
            txt_id_emp.Enabled = false; txt_id_empresa.Enabled = false; txt_fecha_inicio.Enabled = false; txt_periodo_pago.Enabled = false; txt_id_jornada.Enabled = false;
            txt_puesto.Enabled = false; txt_salario_base.Enabled = false; txt_nombre.Enabled = false; txt_nombre_empresa.Enabled = false; txt_nombre_empleado.Enabled = false; txt_bonificacion.Enabled = false; dateTimePicker1.Enabled = false;
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dg);
            TextBox[] textbox = { txt_id_emp, textBox1, textBox2, txt_id_empresa, txt_fecha_inicio, txt_periodo_pago, txt_id_jornada, txt_puesto, txt_salario_base, txt_nombre, txt_nombre_empresa };
            fn.llenartextbox(textbox, dg);
            txt_nombre_empleado.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dg);
            TextBox[] textbox = { txt_id_emp, textBox1, textBox2, txt_id_empresa, txt_fecha_inicio, txt_periodo_pago, txt_id_jornada, txt_puesto, txt_salario_base, txt_nombre, txt_nombre_empresa };
            fn.llenartextbox(textbox, dg);
            txt_nombre_empleado.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dg);
            TextBox[] textbox = { txt_id_emp, textBox1, textBox2, txt_id_empresa, txt_fecha_inicio, txt_periodo_pago, txt_id_jornada, txt_puesto, txt_salario_base, txt_nombre, txt_nombre_empresa };
            fn.llenartextbox(textbox, dg);
            txt_nombre_empleado.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dg);
            TextBox[] textbox = { txt_id_emp, textBox1, textBox2, txt_id_empresa, txt_fecha_inicio, txt_periodo_pago, txt_id_jornada, txt_puesto, txt_salario_base, txt_nombre, txt_nombre_empresa };
            fn.llenartextbox(textbox, dg);
            txt_nombre_empleado.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
