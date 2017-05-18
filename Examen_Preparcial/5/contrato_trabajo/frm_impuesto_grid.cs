using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuncionesNavegador;
using System.Windows.Forms;

namespace contrato_trabajo
{
    public partial class frm_impuesto_grid : Form
    {
        public frm_impuesto_grid()
        {
            InitializeComponent();
        }
        String id_tasa, mini, max, porcentaje;
        CapaNegocio fn = new CapaNegocio();
        capa_datos cd = new capa_datos();
        private void frm_impuesto_Load(object sender, EventArgs e)
        {
            dgv_impuesto.DataSource = cd.cargar("select id_tasa_pk,minimo_sueldo,maximo_sueldo,porcentaje from tasa_impuesto where estado='ACTIVO'");
            dgv_impuesto.Columns[0].HeaderText = "ID Impuesto";
            dgv_impuesto.Columns[1].HeaderText = "Minimo";
            dgv_impuesto.Columns[2].HeaderText = "Maximo";
            dgv_impuesto.Columns[3].HeaderText = "Porcentaje";


        }
        Boolean Editar1;
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            frm_impuesto a = new frm_impuesto(dgv_impuesto, id_tasa, mini, max, porcentaje, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(this.dgv_impuesto);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(this.dgv_impuesto);
        }

        private void dgv_impuesto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_impuesto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            id_tasa = this.dgv_impuesto.CurrentRow.Cells[0].Value.ToString();
            mini = this.dgv_impuesto.CurrentRow.Cells[1].Value.ToString();
            max = this.dgv_impuesto.CurrentRow.Cells[2].Value.ToString();
            porcentaje = this.dgv_impuesto.CurrentRow.Cells[3].Value.ToString();

            frm_impuesto a = new frm_impuesto(dgv_impuesto, id_tasa, mini, max, porcentaje, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_impuesto.DataSource = cd.cargar("select id_tasa_pk,minimo_sueldo,maximo_sueldo,porcentaje from tasa_impuesto where estado='ACTIVO'");
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(this.dgv_impuesto);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(this.dgv_impuesto);
        }
    }
}
