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
    public partial class frm_hora_extras_grid : Form
    {
        public frm_hora_extras_grid()
        {
            InitializeComponent();
        }
        String id_hora, descripcion, porcentaje;
        CapaNegocio fn = new CapaNegocio();
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            frm_horas a = new frm_horas(dgv_horas, id_hora, descripcion, porcentaje, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        Boolean Editar1;

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_horas);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_horas);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_horas);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_horas);
        }

        private void dgv_horas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            id_hora = this.dgv_horas.CurrentRow.Cells[0].Value.ToString();
            descripcion = this.dgv_horas.CurrentRow.Cells[1].Value.ToString();
            porcentaje = this.dgv_horas.CurrentRow.Cells[2].Value.ToString();

            frm_horas a = new frm_horas(dgv_horas, id_hora, descripcion, porcentaje, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            capa_datos cd = new capa_datos();
            dgv_horas.DataSource = cd.cargar("id_hora_pk,descripcion,porcentaje from tasa_hora_extra where estado='ACTIVO' order by id_hora_pk");
        }

        capa_datos cd = new capa_datos();
        private void frm_hora_extras_grid_Load(object sender, EventArgs e)
        {
            dgv_horas.DataSource = cd.cargar("select id_hora_pk,descripcion,porcentaje from tasa_hora_extra where estado='ACTIVO' order by id_hora_pk");
            dgv_horas.Columns[0].HeaderText = "ID Tasa";
            dgv_horas.Columns[1].HeaderText = "Nombre";
            dgv_horas.Columns[2].HeaderText = "Porcentaje";
        }

    }
}
