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
using System.Data.Odbc;

namespace contrato_trabajo
{
    public partial class frm_perfil_reclutamiento_grid : Form
    {
        string id_perfil_reclutamiento_pk, titulo_puesto, descripcion_puesto, detalle, division, departamento, localizacion, id_empresa_pk;

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_perfil_reclutamiento_busq);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_perfil_reclutamiento_busq);
        }

        private void txt_titulo_puesto_busq_rec_KeyUp(object sender, KeyEventArgs e)
        {
            string tabla = "perfil_reclutamiento";
            fn.ActualizarGrid(this.dgv_perfil_reclutamiento_busq, "select * from perfil_reclutamiento where titulo_puesto like '" + txt_titulo_puesto_busq_perfil_reclutamiento.Text + "%' and estado <> 'INACTIVO'", tabla);
        }

        private void frm_reclutamiento_grid_Load(object sender, EventArgs e)
        {
            string tabla = "perfil_reclutamiento";
            fn.ActualizarGrid(this.dgv_perfil_reclutamiento_busq, "Select * from perfil_reclutamiento WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void dgv_rec_busq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            id_perfil_reclutamiento_pk = this.dgv_perfil_reclutamiento_busq.CurrentRow.Cells[0].Value.ToString();
            titulo_puesto = this.dgv_perfil_reclutamiento_busq.CurrentRow.Cells[2].Value.ToString();
            descripcion_puesto = this.dgv_perfil_reclutamiento_busq.CurrentRow.Cells[3].Value.ToString();
            detalle = this.dgv_perfil_reclutamiento_busq.CurrentRow.Cells[4].Value.ToString();
            division = this.dgv_perfil_reclutamiento_busq.CurrentRow.Cells[5].Value.ToString();
            departamento = this.dgv_perfil_reclutamiento_busq.CurrentRow.Cells[6].Value.ToString();
            localizacion = this.dgv_perfil_reclutamiento_busq.CurrentRow.Cells[7].Value.ToString();
            id_empresa_pk = this.dgv_perfil_reclutamiento_busq.CurrentRow.Cells[8].Value.ToString();
            frm_perfil_reclutamiento a = new frm_perfil_reclutamiento(dgv_perfil_reclutamiento_busq, id_perfil_reclutamiento_pk, titulo_puesto, descripcion_puesto, detalle, division, departamento, localizacion, id_empresa_pk, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_perfil_reclutamiento_busq);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_perfil_reclutamiento_busq);
        }


        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "perfil_reclutamiento";
            fn.ActualizarGrid(this.dgv_perfil_reclutamiento_busq, "Select * from perfil_reclutamiento WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "perfil_reclutamiento";
            //op.ejecutar(dgv_rec_busq, tabla);
        }

        Boolean Editar1;
        CapaNegocio fn = new CapaNegocio();

        public frm_perfil_reclutamiento_grid()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            frm_perfil_reclutamiento a = new frm_perfil_reclutamiento(dgv_perfil_reclutamiento_busq, id_perfil_reclutamiento_pk, titulo_puesto, descripcion_puesto, detalle, division, departamento, localizacion, id_empresa_pk, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }


    }
}
