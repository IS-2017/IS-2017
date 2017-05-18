using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crm
{
    public partial class frm_bita_compras : Form
    {
        public frm_bita_compras()
        {
            InitializeComponent();
        }
        CapaDatosPersonas capadatos = new CapaDatosPersonas();

        private void frm_bita_compras_Load(object sender, EventArgs e)
        {
            DataTable dt_bita = capadatos.bitacora_compras();
            dgv_bita_compras.DataSource = dt_bita;
        }
    }
}
