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
    public partial class frm_grid_medio_distribucion : Form
    {
        String id_medio_distribucion, nombre_medio, correo_medio, telefono_medio, url_medio;
        Boolean Editar1;
        CapaNegocio fn = new CapaNegocio();

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_medio_busq);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_medio_busq);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_medio_busq);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "medio_distribucion";
            //op.ejecutar(dgv_rec_busq, tabla);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            frm_medio_distribucion a = new frm_medio_distribucion(dgv_medio_busq, id_medio_distribucion, nombre_medio, correo_medio, telefono_medio, url_medio, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void txt_nombre_busq_medio_KeyUp(object sender, KeyEventArgs e)
        {
            string tabla = "medio_distribucion";
            fn.ActualizarGrid(this.dgv_medio_busq, "select * from medio_distribucion where nombre_medio like '" + txt_nombre_busq_medio.Text + "%' and estado <> 'INACTIVO'", tabla);
        }

        private void dgv_medio_busq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            id_medio_distribucion = this.dgv_medio_busq.CurrentRow.Cells[0].Value.ToString();
            nombre_medio = this.dgv_medio_busq.CurrentRow.Cells[2].Value.ToString();
            correo_medio = this.dgv_medio_busq.CurrentRow.Cells[3].Value.ToString();
            telefono_medio = this.dgv_medio_busq.CurrentRow.Cells[4].Value.ToString();
            url_medio = this.dgv_medio_busq.CurrentRow.Cells[5].Value.ToString();
            frm_medio_distribucion a = new frm_medio_distribucion(dgv_medio_busq, id_medio_distribucion, nombre_medio, correo_medio, telefono_medio, url_medio, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_medio_busq);
        }
        

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "medio_distribucion";
            fn.ActualizarGrid(this.dgv_medio_busq, "Select * from medio_distribucion WHERE estado <> 'INACTIVO' ", tabla);
        }

        public frm_grid_medio_distribucion()
        {
            InitializeComponent();
        }

        private void frm_grid_medio_distribucion_Load(object sender, EventArgs e)
        {
            string tabla = "medio_distribucion";
            fn.ActualizarGrid(this.dgv_medio_busq, "Select * from medio_distribucion WHERE estado <> 'INACTIVO' ", tabla);
        }


    }
}
