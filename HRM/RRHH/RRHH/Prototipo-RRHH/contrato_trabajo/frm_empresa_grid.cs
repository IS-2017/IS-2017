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
    public partial class frm_empresa_grid : Form
    {
        String id_empresa_pk, nombre_empresa, direccion_empresa, correo_empresa, telefono_empresa, NIT_empresa;

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "empresa";
            fn.ActualizarGrid(this.dgv_empresa, "Select * from empresa WHERE estado_empresa <> 'INACTIVO' ", tabla);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_empresa);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_empresa);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_empresa);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_empresa);
        }

        private void frm_empresa_grid_Load(object sender, EventArgs e)
        {
            string tabla = "empresa";
            fn.ActualizarGrid(this.dgv_empresa, "Select * from empresa WHERE estado_empresa <> 'INACTIVO' ", tabla);
        }

        private void dgv_empresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            id_empresa_pk = this.dgv_empresa.CurrentRow.Cells[0].Value.ToString();
            nombre_empresa = this.dgv_empresa.CurrentRow.Cells[1].Value.ToString();
            direccion_empresa = this.dgv_empresa.CurrentRow.Cells[2].Value.ToString();
            NIT_empresa = this.dgv_empresa.CurrentRow.Cells[3].Value.ToString();
            telefono_empresa = this.dgv_empresa.CurrentRow.Cells[4].Value.ToString();
            correo_empresa = this.dgv_empresa.CurrentRow.Cells[5].Value.ToString();
            frm_empresa a = new frm_empresa(dgv_empresa, id_empresa_pk, nombre_empresa, direccion_empresa, NIT_empresa, telefono_empresa, correo_empresa, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "empresa";
            //op.ejecutar(dgv_busqueda_documento, tabla);
        }

        Boolean Editar1;
        CapaNegocio fn = new CapaNegocio();
        public frm_empresa_grid()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            frm_empresa a = new frm_empresa(dgv_empresa,id_empresa_pk,nombre_empresa,direccion_empresa,NIT_empresa,telefono_empresa,correo_empresa,Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }


    }
}
