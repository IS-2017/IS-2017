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
    public partial class frm_grid_candidato : Form
    {
        String id_candidato_pk, nombre_candidato, apellido_candidato, cv_candidato, id_reclutamiento_candidato;

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "candidato";
            //op.ejecutar(dgv_rec_busq, tabla);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "candidato";
            fn.ActualizarGrid(this.dgv_candidato_busq, "Select * from candidato WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_candidato_busq);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_candidato_busq);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_candidato_busq);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_candidato_busq);
        }

        private void dgv_candidato_busq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            id_candidato_pk = this.dgv_candidato_busq.CurrentRow.Cells[0].Value.ToString();
            nombre_candidato = this.dgv_candidato_busq.CurrentRow.Cells[2].Value.ToString();
            apellido_candidato = this.dgv_candidato_busq.CurrentRow.Cells[3].Value.ToString();
            cv_candidato = this.dgv_candidato_busq.CurrentRow.Cells[4].Value.ToString();
            id_reclutamiento_candidato = this.dgv_candidato_busq.CurrentRow.Cells[5].Value.ToString();
            frm_candidato a = new frm_candidato(dgv_candidato_busq, id_candidato_pk, nombre_candidato, apellido_candidato, cv_candidato, id_reclutamiento_candidato, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            frm_candidato a = new frm_candidato(dgv_candidato_busq, id_candidato_pk, nombre_candidato, apellido_candidato, cv_candidato, id_reclutamiento_candidato, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void txt_nombre_busq_candidato_KeyUp(object sender, KeyEventArgs e)
        {
            string tabla = "candidato";
            fn.ActualizarGrid(this.dgv_candidato_busq, "select * from candidato where nombre_candidato like '" + txt_nombre_busq_candidato.Text + "%' and estado <> 'INACTIVO'", tabla);
        }

        Boolean Editar1;
        CapaNegocio fn = new CapaNegocio();

        public frm_grid_candidato()
        {
            InitializeComponent();
        }

        private void frm_grid_candidato_Load(object sender, EventArgs e)
        {
            string tabla = "candidato";
            fn.ActualizarGrid(this.dgv_candidato_busq, "Select * from candidato WHERE estado <> 'INACTIVO' ", tabla);
        }
    }
}
