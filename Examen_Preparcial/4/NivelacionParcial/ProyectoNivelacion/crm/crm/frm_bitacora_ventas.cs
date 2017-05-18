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
    public partial class frm_bitacora_ventas : Form
    {
        public frm_bitacora_ventas()
        {
            InitializeComponent();
        }
        CapaDatosPersonas capadatos = new CapaDatosPersonas();

        private void frm_bitacora_ventas_Load(object sender, EventArgs e)
        {
            DataTable dt_bita = capadatos.bitacora_ventas();
            dgv_bita_ventas.DataSource = dt_bita;
            
        }
    }
}
