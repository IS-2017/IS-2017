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
    public partial class Frm_devengos_grid : Form
    {
        public Frm_devengos_grid()
        {
            InitializeComponent();
        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_devengos);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_devengos);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_devengos);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_devengos);
        }
        capa_datos ca = new capa_datos();
        private void Frm_devengos_grid_Load(object sender, EventArgs e)
        {
            dgv_devengos.DataSource = ca.cargar("select id_devengo_pk, fecha, nombre_devengo, descripcion, cantidad_devengado, id_empleado_pk from devengos where nombre_devengo = 'devengo extra' and estado ='activo';");
            dgv_devengos.Columns[0].HeaderText = "ID devengo";
            dgv_devengos.Columns[1].HeaderText = "Fecha";
            dgv_devengos.Columns[2].HeaderText = "Nombre Devengo";
            dgv_devengos.Columns[3].HeaderText = "Descripción";
            dgv_devengos.Columns[4].HeaderText = "Cantidad Devengado";
            dgv_devengos.Columns[5].HeaderText = "Id Empleado";

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_devengos.DataSource = ca.cargar("select id_devengo_pk, fecha, nombre_devengo, descripcion, cantidad_devengado, id_empleado_pk from devengos where nombre_devengo = 'devengo extra' and estado ='activo';");
            dgv_devengos.Columns[0].HeaderText = "ID devengo";
            dgv_devengos.Columns[1].HeaderText = "Fecha";
            dgv_devengos.Columns[2].HeaderText = "Nombre Devengo";
            dgv_devengos.Columns[3].HeaderText = "Descripción";
            dgv_devengos.Columns[4].HeaderText = "Cantidad Devengado";
            dgv_devengos.Columns[5].HeaderText = "Id Empleado";
        }
        Boolean Editar1;
        string cod_devengo, id_Empleado, fecha, descricpion, cantidad, nombre_dev;

        private void dgv_devengos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            cod_devengo = this.dgv_devengos.CurrentRow.Cells[0].Value.ToString();
            fecha = this.dgv_devengos.CurrentRow.Cells[1].Value.ToString();
            nombre_dev = this.dgv_devengos.CurrentRow.Cells[2].Value.ToString();
            descricpion = this.dgv_devengos.CurrentRow.Cells[3].Value.ToString();
            cantidad = this.dgv_devengos.CurrentRow.Cells[4].Value.ToString();
            id_Empleado = this.dgv_devengos.CurrentRow.Cells[5].Value.ToString();
            frm_devengos a = new frm_devengos(dgv_devengos, cod_devengo, fecha, nombre_dev, descricpion, cantidad, id_Empleado, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            nombre_dev = "devengo extra";
            frm_devengos a = new frm_devengos(dgv_devengos,cod_devengo, fecha, nombre_dev, descricpion, cantidad, id_Empleado, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }
    }
}
