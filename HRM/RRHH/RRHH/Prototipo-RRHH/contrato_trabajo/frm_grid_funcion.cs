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
    public partial class frm_grid_funcion : Form
    {
        String id_funcion, sueldo_funcion, descripcion_funcion, nombre_funcion, id_perfil_reclutamiento_fk;

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "funcion";
            //op.ejecutar(dgv_rec_busq, tabla);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "funcion";
            fn.ActualizarGrid(this.dgv_funcion_busq, "Select * from funcion WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_funcion_busq);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_funcion_busq);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_funcion_busq);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_funcion_busq);
        }

        private void dgv_funcion_busq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            id_funcion = this.dgv_funcion_busq.CurrentRow.Cells[0].Value.ToString();
            sueldo_funcion = this.dgv_funcion_busq.CurrentRow.Cells[1].Value.ToString();
            descripcion_funcion = this.dgv_funcion_busq.CurrentRow.Cells[2].Value.ToString();
            nombre_funcion = this.dgv_funcion_busq.CurrentRow.Cells[3].Value.ToString();
            id_perfil_reclutamiento_fk = this.dgv_funcion_busq.CurrentRow.Cells[4].Value.ToString();
            frm_funcion a = new frm_funcion(dgv_funcion_busq, id_funcion, sueldo_funcion, descripcion_funcion, nombre_funcion, id_perfil_reclutamiento_fk, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void txt_nombre_busq_funcion_KeyUp(object sender, KeyEventArgs e)
        {
            string tabla = "funcion";
            fn.ActualizarGrid(this.dgv_funcion_busq, "select * from funcion where nombre_funcion like '" + txt_nombre_busq_funcion.Text + "%' and estado <> 'INACTIVO'", tabla);
        }

        private void frm_grid_funcion_Load(object sender, EventArgs e)
        {
            string tabla = "funcion";
            fn.ActualizarGrid(this.dgv_funcion_busq, "Select * from funcion WHERE estado <> 'INACTIVO' ", tabla);
        }

        Boolean Editar1;
        CapaNegocio fn = new CapaNegocio();

        public frm_grid_funcion()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            frm_funcion a = new frm_funcion(dgv_funcion_busq, id_funcion, sueldo_funcion, descripcion_funcion, nombre_funcion, id_perfil_reclutamiento_fk, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }


    }
}
