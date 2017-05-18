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

namespace MDI_CORTO_MIERCOLES_17
{
    public partial class frm_bien_grid : Form
    {
        public frm_bien_grid()
        {
            InitializeComponent();
        }
        capa_datos cd = new capa_datos();
        private void frm_bien_grid_Load(object sender, EventArgs e)
        {
            dgv_bien.DataSource = cd.cargar("select id_bien_pk,bien_nom,bien_des,bien_precio,id_proveedor_pk from bien where estado='activo'");
            dgv_bien.Columns[0].HeaderText = "ID Bien";
            dgv_bien.Columns[1].HeaderText = "Nombre";
            dgv_bien.Columns[2].HeaderText = "Descripcion";
            dgv_bien.Columns[3].HeaderText = "Precio";
            dgv_bien.Columns[4].HeaderText = "ID Proveedor";
        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_bien);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_bien);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_bien);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_bien);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            frm_bien a = new frm_bien(dgv_bien, id_bien, bien_nom, bien_des, bien_precio, id_proveedor, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }
        String id_bien, bien_nom, bien_des, bien_precio, id_proveedor;

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_bien.DataSource = cd.cargar("select id_bien_pk,bien_nom,bien_des,bien_precio,id_proveedor_pk from bien where estado='activo'");
        }

        private void gpb_navegador_Enter(object sender, EventArgs e)
        {

        }

        Boolean Editar1;

        private void dgv_bien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            id_bien = this.dgv_bien.CurrentRow.Cells[0].Value.ToString();
            bien_nom = this.dgv_bien.CurrentRow.Cells[1].Value.ToString();
            bien_des = this.dgv_bien.CurrentRow.Cells[2].Value.ToString();
            bien_precio = this.dgv_bien.CurrentRow.Cells[3].Value.ToString();
            id_proveedor = this.dgv_bien.CurrentRow.Cells[4].Value.ToString();
            
            frm_bien a = new frm_bien(dgv_bien, id_bien, bien_nom, bien_des,bien_precio ,id_proveedor, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }
    }
}
