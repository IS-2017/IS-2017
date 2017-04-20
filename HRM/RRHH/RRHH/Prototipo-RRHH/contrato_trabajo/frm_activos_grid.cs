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
using dllconsultas;


namespace contrato_trabajo
{
    public partial class frm_activos_grid : Form
    {

        String j;
        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar1;
        Boolean tipo_accion;
        String id_activos_emp_pk, nombre_activo, cantidad_activo, descripcion_activo, estado;

        public frm_activos_grid()
        {
            InitializeComponent();
        }

        private void frm_activos_grid_Load(object sender, EventArgs e)
        {
            string tabla = "activos_empresa";
            fn.ActualizarGrid(this.dgv_activos, "SELECT * FROM `activos_empresa` WHERE estado = 'ACTIVO' ", tabla);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            frm_activos activo = new frm_activos(dgv_activos, id_activos_emp_pk, nombre_activo, cantidad_activo, descripcion_activo, estado, Editar1, tipo_accion);
            activo.MdiParent = this.ParentForm;
            activo.Show();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "activos_empresa";
            op.ejecutar(dgv_activos, tabla);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "activos_empresa";
            fn.ActualizarGrid(this.dgv_activos, "SELECT * FROM `activos_empresa` WHERE estado = 'ACTIVO' ", tabla);

        }

        private void dgv_activos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            tipo_accion = true;

            id_activos_emp_pk = this.dgv_activos.CurrentRow.Cells[0].Value.ToString();
            nombre_activo = this.dgv_activos.CurrentRow.Cells[1].Value.ToString();
            cantidad_activo = this.dgv_activos.CurrentRow.Cells[2].Value.ToString();
            descripcion_activo = this.dgv_activos.CurrentRow.Cells[3].Value.ToString();
            estado = this.dgv_activos.CurrentRow.Cells[4].Value.ToString();

            frm_activos activo = new frm_activos(dgv_activos, id_activos_emp_pk, nombre_activo, cantidad_activo, descripcion_activo, estado, Editar1, tipo_accion);
            activo.MdiParent = this.ParentForm;
            activo.Show();

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_activos);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_activos);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_activos);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_activos);
        }
    }
}
