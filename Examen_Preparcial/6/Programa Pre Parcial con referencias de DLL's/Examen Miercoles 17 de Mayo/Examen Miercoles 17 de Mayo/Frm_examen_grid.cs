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


namespace Examen_Miercoles_17_de_Mayo
{
    public partial class Frm_examen_grid : Form
    {
        public Frm_examen_grid()
        {
            InitializeComponent();
        }
        capa_datos ca = new capa_datos();
        private void Frm_examen_grid_Load(object sender, EventArgs e)
        {
          
            dgv_examen.DataSource = ca.cargar("select id_bien_pk, descripcion, precio_venta, marca, id_proveedor from bien");
            dgv_examen.Columns[0].HeaderText = "ID bien";
            dgv_examen.Columns[1].HeaderText = "Descripcion";
            dgv_examen.Columns[2].HeaderText = "Precio Venta";
            dgv_examen.Columns[3].HeaderText = "Marca";
            dgv_examen.Columns[4].HeaderText = "Id Proveedor";

        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_examen);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_examen);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_examen);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_examen);
        }
        Boolean Editar1;
        String Id_bien;
        String Descripcion;
        String Precio;
        String Marca;
        String Id_proveedor;
        
        
        private void btn_nuevo_Click(object sender, EventArgs e)
        {

            Editar1 = false;
            Frm_examen a = new Frm_examen(dgv_examen, Id_bien, Descripcion, Precio, Marca, Id_proveedor, Editar1);
            a.MdiParent = this.ParentForm;
         
            a.Show();
            
        }

        private void cbo_examen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                capa_datos ca = new capa_datos();
                dgv_examen.DataSource = ca.cargar("");
            }
            catch { }
        }

        private void dgv_examen_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv_examen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            Id_bien = this.dgv_examen.CurrentRow.Cells[0].Value.ToString();
            Descripcion = this.dgv_examen.CurrentRow.Cells[1].Value.ToString();
            Precio = this.dgv_examen.CurrentRow.Cells[2].Value.ToString();
            Marca = this.dgv_examen.CurrentRow.Cells[3].Value.ToString();
            Id_proveedor = this.dgv_examen.CurrentRow.Cells[4].Value.ToString();
           

            Frm_examen a = new Frm_examen(dgv_examen, Id_bien, Descripcion, Precio, Marca, Id_proveedor, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }
    }
}
