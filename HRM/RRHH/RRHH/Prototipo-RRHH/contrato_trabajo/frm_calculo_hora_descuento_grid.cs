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
    public partial class frm_calculo_hora_descuento_grid : Form
    {
        public frm_calculo_hora_descuento_grid()
        {
            InitializeComponent();
        }
        String id_desc, fe, nombr, des, cant, cant_horas, id_e, p;

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_descuento);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_descuento);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_descuento);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_descuento.DataSource = cd.cargar("select id_deduccion_pk,fecha,nombre_deduccion,descripcion,cantidad_deduccion,cantidad_horas,id_empleado_pk from deducciones where nombre_deduccion='horas descontadas' and estado='ACTIVO' order by id_deduccion_pk");
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_descuento);
        }

        private void dgv_descuento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            id_desc = this.dgv_descuento.CurrentRow.Cells[0].Value.ToString();
            fe = this.dgv_descuento.CurrentRow.Cells[1].Value.ToString();
            nombr = this.dgv_descuento.CurrentRow.Cells[2].Value.ToString();
            des = this.dgv_descuento.CurrentRow.Cells[3].Value.ToString();
            cant = this.dgv_descuento.CurrentRow.Cells[4].Value.ToString();
            cant_horas = this.dgv_descuento.CurrentRow.Cells[5].Value.ToString();
            id_e = this.dgv_descuento.CurrentRow.Cells[6].Value.ToString();
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
            frm_calculo_hora_descuento a = new frm_calculo_hora_descuento(dgv_descuento, id_desc, fe, nombr, des, cant, cant_horas, id_e, p, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        capa_datos cd = new capa_datos();
        Boolean Editar1;
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        private void frm_calculo_hora_descuento_grid_Load(object sender, EventArgs e)
        {
            dgv_descuento.DataSource = cd.cargar("select id_deduccion_pk,fecha,nombre_deduccion,descripcion,cantidad_deduccion,cantidad_horas,id_empleado_pk from deducciones where nombre_deduccion='horas descontadas' and estado='ACTIVO' order by id_deduccion_pk");

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                nombr = "horas descontadas";
                frm_calculo_hora_descuento a = new frm_calculo_hora_descuento(dgv_descuento,id_desc, fe, nombr, des, cant, cant_horas, id_e, p, Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
