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
    public partial class frm_calculo_hora_descuento : Form
    {
        public frm_calculo_hora_descuento()
        {
            InitializeComponent();
        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String codigo;
        DataGridView dg;
        capa_datos cn = new capa_datos();
        capa_negocio cc = new capa_negocio();
        public frm_calculo_hora_descuento(DataGridView gb, String id_descuento, String fecha, String nom_d, String des_d, String cant_d, String cant_h, String id_emp, String Precio, Boolean Editar1)
        {
            this.dg = gb;
            this.Editar = Editar1;
            this.codigo = id_descuento;
            InitializeComponent();
            if (Editar == true)
            {
                this.dt_fecha.Text = fecha;
                this.txt_des.Text = des_d;
                cn.llenar_id_empleado(cbo_empleado);
                this.cbo_empleado.SelectedValue = id_emp;
                this.txt_can_d.Text = cant_d;
                this.txt_can_h.Text = cant_h;
                this.txt_nom.Text = nom_d;
                this.txt_precio.Text = Precio;
                cn.llenar_cbo_horas_extra(this.cbo_por);
               cbo_por.SelectedIndex = -1;
            }
            else
            {
                cn.llenar_id_empleado(this.cbo_empleado);
                cbo_empleado.SelectedIndex = -1;
                cn.llenar_cbo_horas_extra(cbo_por);
                this.txt_nom.Text = nom_d;
                cbo_por.SelectedIndex = -1;
            }
        }

        double total_total;
        private void frm_calculo_hora_descuento_Load(object sender, EventArgs e)
        {

        }

        private void txt_can_h_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar v = new Validar();
            v.validacion_solonumeros(e);
        }

        private void txt_can_h_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_can_h.Text == "")
                { txt_can_d.Text = ""; }
                else
                {
                    double porcentaje = Convert.ToDouble(cbo_por.SelectedValue.ToString());
                    double cant_horas_extra = Convert.ToDouble(txt_can_h.Text); // CANTIDAD HORAS EXTRA TRABAJADAS
                    double precio_hora = Convert.ToDouble(txt_precio.Text); // VALOR DE LA HORA
                    double precio_hora_extra_total = precio_hora * porcentaje; // VALOR DE LA HORA YA EXTRA
                    double total_pagar_horas_extra = cant_horas_extra * precio_hora_extra_total;
                    total_total = Math.Round(total_pagar_horas_extra, 2);
                    txt_can_d.Text = total_total.ToString();
                }
            }
            catch
            {
            }

        }
        

        private void cbo_empleado_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                string nombre_jornada = cn.nombre_jornada(cbo_empleado.SelectedValue.ToString());
                double sueldo = cn.ObtenerSueldo(cbo_empleado.SelectedValue.ToString());
                double precio_dia = sueldo / 30;
                if (nombre_jornada == "matutina")
                {
                    double precio_hora_matutina = precio_dia / 8;
                    double precio_aproximado_matutina = Math.Round(precio_hora_matutina, 2);
                    txt_precio.Text = precio_aproximado_matutina.ToString();

                }
                if (nombre_jornada == "vespertina")
                {
                    double precio_hora_vespertina = precio_dia / 6;
                    double precio_aproximado_vespertina = Math.Round(precio_hora_vespertina, 2);
                    txt_precio.Text = precio_aproximado_vespertina.ToString();
                }
                if (nombre_jornada == "mixta")
                {
                    double precio_hora_mixta = precio_dia / 7;
                    double precio_aproximado_mixta = Math.Round(precio_hora_mixta, 2);
                    txt_precio.Text = precio_aproximado_mixta.ToString();
                }
            }
            catch { }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            limpiar("e");
        }
        void limpiar(String e)
        {
            txt_can_d.Text = ""; txt_can_h.Text = ""; txt_des.Text = ""; txt_precio.Text = "";
            cn.llenar_id_empleado(cbo_empleado); cn.llenar_cbo_horas_extra(cbo_por); cbo_por.SelectedIndex = -1; cbo_empleado.SelectedIndex = -1;
            if (e == "e")
            { txt_can_d.Enabled = true; txt_can_h.Enabled = true; txt_des.Enabled = true; txt_precio.Enabled = true; cbo_empleado.Enabled = true; cbo_por.Enabled = true; dt_fecha.Enabled = true; }
            if (e == "d")
            { txt_can_d.Enabled = false; txt_can_h.Enabled = false; txt_des.Enabled = false; txt_precio.Enabled = false; cbo_empleado.Enabled = false; cbo_por.Enabled = false; dt_fecha.Enabled = false; }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Editar)
            {
                cc.ModificarHoraDec(codigo, dt_fecha.Value.ToString("yyyy-MM-dd"), txt_nom.Text, txt_des.Text, txt_can_d.Text, txt_can_h.Text, cbo_empleado.SelectedValue.ToString());
                limpiar("e");
                btn_actualizar.PerformClick();
            }
            else
            {
                cc.InsertarHoraDec(dt_fecha.Value.ToString("yyyy-MM-dd"), txt_nom.Text, txt_des.Text, txt_can_d.Text, txt_can_h.Text, cbo_empleado.SelectedValue.ToString());
                limpiar("e");
                btn_actualizar.PerformClick();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                cbo_por.SelectedIndex = 1;
                this.codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.dt_fecha.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_nom.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_des.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_can_d.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_can_h.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
                this.cbo_empleado.SelectedValue = this.dg.CurrentRow.Cells[6].Value.ToString();
                string nombre_jornada = cn.nombre_jornada(cbo_empleado.SelectedValue.ToString());
                double sueldo = cn.ObtenerSueldo(cbo_empleado.SelectedValue.ToString());
                double precio_dia = sueldo / 30;
                if (nombre_jornada == "matutina")
                {
                    double precio_hora_matutina = precio_dia / 8;
                    double precio_aproximado_matutina = Math.Round(precio_hora_matutina, 2);
                    txt_precio.Text = precio_aproximado_matutina.ToString();

                }
                if (nombre_jornada == "vespertina")
                {
                    double precio_hora_vespertina = precio_dia / 6;
                    double precio_aproximado_vespertina = Math.Round(precio_hora_vespertina, 2);
                    txt_precio.Text = precio_aproximado_vespertina.ToString();
                }
                if (nombre_jornada == "mixta")
                {
                    double precio_hora_mixta = precio_dia / 7;
                    double precio_aproximado_mixta = Math.Round(precio_hora_mixta, 2);
                    txt_precio.Text = precio_aproximado_mixta.ToString();
                }

            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a modificar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    cc.eliminarHoraDec(codigo2);
                    limpiar("e");
                    btn_actualizar.PerformClick();
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
            limpiar("d");
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.dg.DataSource = cn.cargar("select id_deduccion_pk,fecha,nombre_deduccion,descripcion,cantidad_deduccion,cantidad_horas,id_empleado_pk from deducciones where nombre_deduccion='horas descontadas' and estado='ACTIVO' order by id_deduccion_pk");
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dg);
            TextBox[] textbox = { txt_nom, txt_can_d, txt_can_h, txt_des, txt_emp, txt_fecha };
            fn.llenartextbox(textbox, dg);
            cbo_empleado.SelectedValue = txt_emp.Text;
            dt_fecha.Text = txt_fecha.Text;
           // cbo_por.SelectedIndex = 1;
            string nombre_jornada = cn.nombre_jornada(txt_emp.Text);
            double sueldo = cn.ObtenerSueldo(txt_emp.Text);
            double precio_dia = sueldo / 30;
            if (nombre_jornada == "matutina")
            {
                double precio_hora_matutina = precio_dia / 8;
                double precio_aproximado_matutina = Math.Round(precio_hora_matutina, 2);
                txt_precio.Text = precio_aproximado_matutina.ToString();

            }
            if (nombre_jornada == "vespertina")
            {
                double precio_hora_vespertina = precio_dia / 6;
                double precio_aproximado_vespertina = Math.Round(precio_hora_vespertina, 2);
                txt_precio.Text = precio_aproximado_vespertina.ToString();
            }
            if (nombre_jornada == "mixta")
            {
                double precio_hora_mixta = precio_dia / 7;
                double precio_aproximado_mixta = Math.Round(precio_hora_mixta, 2);
                txt_precio.Text = precio_aproximado_mixta.ToString();
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dg);
            TextBox[] textbox = { txt_nom, txt_can_d, txt_can_h, txt_des, txt_emp, txt_fecha };
            fn.llenartextbox(textbox, dg);
            cbo_empleado.SelectedValue = txt_emp.Text;
            dt_fecha.Text = txt_fecha.Text;
           // cbo_por.SelectedIndex = 1;
            string nombre_jornada = cn.nombre_jornada(txt_emp.Text);
            double sueldo = cn.ObtenerSueldo(txt_emp.Text);
            double precio_dia = sueldo / 30;
            if (nombre_jornada == "matutina")
            {
                double precio_hora_matutina = precio_dia / 8;
                double precio_aproximado_matutina = Math.Round(precio_hora_matutina, 2);
                txt_precio.Text = precio_aproximado_matutina.ToString();

            }
            if (nombre_jornada == "vespertina")
            {
                double precio_hora_vespertina = precio_dia / 6;
                double precio_aproximado_vespertina = Math.Round(precio_hora_vespertina, 2);
                txt_precio.Text = precio_aproximado_vespertina.ToString();
            }
            if (nombre_jornada == "mixta")
            {
                double precio_hora_mixta = precio_dia / 7;
                double precio_aproximado_mixta = Math.Round(precio_hora_mixta, 2);
                txt_precio.Text = precio_aproximado_mixta.ToString();
            }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dg);
            TextBox[] textbox = { txt_nom, txt_can_d, txt_can_h, txt_des, txt_emp, txt_fecha };
            fn.llenartextbox(textbox, dg);
            cbo_empleado.SelectedValue = txt_emp.Text;
            dt_fecha.Text = txt_fecha.Text;
            //cbo_por.SelectedIndex = 1;
            string nombre_jornada = cn.nombre_jornada(txt_emp.Text);
            double sueldo = cn.ObtenerSueldo(txt_emp.Text);
            double precio_dia = sueldo / 30;
            if (nombre_jornada == "matutina")
            {
                double precio_hora_matutina = precio_dia / 8;
                double precio_aproximado_matutina = Math.Round(precio_hora_matutina, 2);
                txt_precio.Text = precio_aproximado_matutina.ToString();

            }
            if (nombre_jornada == "vespertina")
            {
                double precio_hora_vespertina = precio_dia / 6;
                double precio_aproximado_vespertina = Math.Round(precio_hora_vespertina, 2);
                txt_precio.Text = precio_aproximado_vespertina.ToString();
            }
            if (nombre_jornada == "mixta")
            {
                double precio_hora_mixta = precio_dia / 7;
                double precio_aproximado_mixta = Math.Round(precio_hora_mixta, 2);
                txt_precio.Text = precio_aproximado_mixta.ToString();
            }
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dg);
            TextBox[] textbox = { txt_nom, txt_can_d, txt_can_h, txt_des, txt_emp, txt_fecha };
            fn.llenartextbox(textbox, dg);
            cbo_empleado.SelectedValue = txt_emp.Text;
            dt_fecha.Text = txt_fecha.Text;
            //cbo_por.SelectedIndex = 1;
            string nombre_jornada = cn.nombre_jornada(txt_emp.Text);
            double sueldo = cn.ObtenerSueldo(txt_emp.Text);
            double precio_dia = sueldo / 30;
            if (nombre_jornada == "matutina")
            {
                double precio_hora_matutina = precio_dia / 8;
                double precio_aproximado_matutina = Math.Round(precio_hora_matutina, 2);
                txt_precio.Text = precio_aproximado_matutina.ToString();

            }
            if (nombre_jornada == "vespertina")
            {
                double precio_hora_vespertina = precio_dia / 6;
                double precio_aproximado_vespertina = Math.Round(precio_hora_vespertina, 2);
                txt_precio.Text = precio_aproximado_vespertina.ToString();
            }
            if (nombre_jornada == "mixta")
            {
                double precio_hora_mixta = precio_dia / 7;
                double precio_aproximado_mixta = Math.Round(precio_hora_mixta, 2);
                txt_precio.Text = precio_aproximado_mixta.ToString();
            }
        }
    }
}
