using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_CORTO_MIERCOLES_17
{
    public partial class frm_proveedor_grid : Form
    {
        public frm_proveedor_grid()
        {
            InitializeComponent();
        }
        capa_datos cd = new capa_datos();
        private void frm_proveedor_grid_Load(object sender, EventArgs e)
        {
            dgv_pro.DataSource = cd.cargar("select * from proveedor where estado='activo'");
            dgv_pro.Columns[0].HeaderText = "ID Proveedor";
            dgv_pro.Columns[1].HeaderText = "Nombre";
            dgv_pro.Columns[2].HeaderText = "Telefono";
            dgv_pro.Columns[3].HeaderText = "Direccion";
            dgv_pro.Columns[4].HeaderText = "Estado";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
