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
    public partial class frm_calculo_horas_grid : Form
    {
        public frm_calculo_horas_grid()
        {
            InitializeComponent();
        }
        String id_devengo, fe, nombr, des, cant, cant_horas, id_e,p;
        capa_datos cd = new capa_datos();
        Boolean Editar1;

        private void dgv_calculo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                Editar1 = true;
                id_devengo = this.dgv_calculo.CurrentRow.Cells[0].Value.ToString();
                fe = this.dgv_calculo.CurrentRow.Cells[1].Value.ToString();
                nombr = this.dgv_calculo.CurrentRow.Cells[2].Value.ToString();
                des = this.dgv_calculo.CurrentRow.Cells[3].Value.ToString();
                cant = this.dgv_calculo.CurrentRow.Cells[4].Value.ToString();
                cant_horas = this.dgv_calculo.CurrentRow.Cells[5].Value.ToString();
                id_e = this.dgv_calculo.CurrentRow.Cells[6].Value.ToString();
                string nombre_jornada = cd.nombre_jornada(id_e);
                double sueldo = cd.ObtenerSueldo(id_e);
                double precio_dia = sueldo / 30;
                if (nombre_jornada == "matutina")
                {
                    double precio_hora_matutina = precio_dia / 8;
                    double precio_aproximado_matutina = Math.Round(precio_hora_matutina, 2);
                    p = precio_aproximado_matutina.ToString();

                }
                if (nombre_jornada == "vespertina")
                {
                    double precio_hora_vespertina = precio_dia / 6;
                    double precio_aproximado_vespertina = Math.Round(precio_hora_vespertina, 2);
                    p = precio_aproximado_vespertina.ToString();
                }
                if (nombre_jornada == "mixta")
                {
                    double precio_hora_mixta = precio_dia / 7;
                    double precio_aproximado_mixta = Math.Round(precio_hora_mixta, 2);
                    p = precio_aproximado_mixta.ToString();
                }
                frm_calculo_horas a = new frm_calculo_horas(dgv_calculo, id_devengo, fe, nombr, des, cant, cant_horas, id_e, p, Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void gpb_navegador_Enter(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_calculo.DataSource = cd.cargar("select id_devengo_pk, fecha, nombre_devengo, descripcion, cantidad_devengado, cantidad_horas_extra, id_empleado_pk from devengos where nombre_devengo = 'horas extra' and estado = 'ACTIVO' order by id_devengo_pk");
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_calculo);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                nombr = "horas extra";
                frm_calculo_horas a = new frm_calculo_horas(dgv_calculo, id_devengo, fe, nombr, des, cant, cant_horas, id_e, p, Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_calculo);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_calculo);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_calculo);
        }

        CapaNegocio fn = new CapaNegocio();
        private void frm_calculo_horas_grid_Load(object sender, EventArgs e)
        {
            dgv_calculo.DataSource = cd.cargar("select id_devengo_pk,fecha,nombre_devengo,descripcion,cantidad_devengado,cantidad_horas_extra,id_empleado_pk from devengos where nombre_devengo='horas extra' and estado='ACTIVO' order by id_devengo_pk");
        }
    }
}
