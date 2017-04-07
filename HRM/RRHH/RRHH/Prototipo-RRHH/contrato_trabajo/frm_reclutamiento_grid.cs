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
    public partial class frm_reclutamiento_grid : Form
    {
        string id_reclutamiento_pk, titulo_puesto, descripcion_puesto, requisito, detalle, division, departamento, localizacion, id_empresa_pk;

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_rec_busq);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_rec_busq);
        }

        private void txt_titulo_puesto_busq_rec_KeyUp(object sender, KeyEventArgs e)
        {
            string tabla = "reclutamiento";
            fn.ActualizarGrid(this.dgv_rec_busq, "select * from reclutamiento where titulo_puesto like '" + txt_titulo_puesto_busq_rec.Text + "%' and estado_reclutamiento <> 'INACTIVO'", tabla);
        }

        private void frm_reclutamiento_grid_Load(object sender, EventArgs e)
        {
            string tabla = "reclutamiento";
            fn.ActualizarGrid(this.dgv_rec_busq, "Select * from reclutamiento WHERE estado_reclutamiento <> 'INACTIVO' ", tabla);
        }

        private void dgv_rec_busq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            id_reclutamiento_pk = this.dgv_rec_busq.CurrentRow.Cells[0].Value.ToString();
            titulo_puesto = this.dgv_rec_busq.CurrentRow.Cells[1].Value.ToString();
            descripcion_puesto = this.dgv_rec_busq.CurrentRow.Cells[2].Value.ToString();
            requisito = this.dgv_rec_busq.CurrentRow.Cells[3].Value.ToString();
            detalle = this.dgv_rec_busq.CurrentRow.Cells[4].Value.ToString();
            division = this.dgv_rec_busq.CurrentRow.Cells[5].Value.ToString();
            departamento = this.dgv_rec_busq.CurrentRow.Cells[6].Value.ToString();
            localizacion = this.dgv_rec_busq.CurrentRow.Cells[7].Value.ToString();
            id_empresa_pk = this.dgv_rec_busq.CurrentRow.Cells[9].Value.ToString();
            frm_reclutamiento a = new frm_reclutamiento(dgv_rec_busq, id_reclutamiento_pk, titulo_puesto, descripcion_puesto, requisito, detalle, division, departamento, localizacion, id_empresa_pk, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_rec_busq);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_rec_busq);
        }


        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "reclutamiento";
            fn.ActualizarGrid(this.dgv_rec_busq, "Select * from reclutamiento WHERE estado_reclutamiento <> 'INACTIVO' ", tabla);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "reclutamiento";
            //op.ejecutar(dgv_rec_busq, tabla);
        }

        Boolean Editar1;
        CapaNegocio fn = new CapaNegocio();

        public frm_reclutamiento_grid()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            frm_reclutamiento a = new frm_reclutamiento(dgv_rec_busq, id_reclutamiento_pk, titulo_puesto, descripcion_puesto, requisito, detalle, division, departamento, localizacion, id_empresa_pk, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }


    }
}
