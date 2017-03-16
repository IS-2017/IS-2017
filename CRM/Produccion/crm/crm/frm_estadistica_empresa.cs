using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace crm
{
    public partial class frm_estadistica_empresa : DevExpress.XtraEditors.XtraForm
    {
        public frm_estadistica_empresa()
        {
            InitializeComponent();
        }

        private void btn_semanal_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_estadistica_empresa_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}