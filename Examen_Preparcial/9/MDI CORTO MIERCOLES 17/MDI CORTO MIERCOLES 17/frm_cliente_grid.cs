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
    public partial class frm_cliente_grid : Form
    {
        public frm_cliente_grid()
        {
            InitializeComponent();
        }
        capa_datos cd = new capa_datos();

        private void frm_cliente_grid_Load(object sender, EventArgs e)
        {
            dgv_cliente.DataSource = cd.cargar("select * from cliente");
            dgv_cliente.Columns[0].HeaderText = "ID Cliente";
            dgv_cliente.Columns[1].HeaderText = "Nombre";
            dgv_cliente.Columns[2].HeaderText = "Apellido";
            dgv_cliente.Columns[3].HeaderText = "Telefono";
            dgv_cliente.Columns[4].HeaderText = "Direccion";
            dgv_cliente.Columns[5].HeaderText = "Estado";
        }
    }
}
