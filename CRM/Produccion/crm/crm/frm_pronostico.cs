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
    public partial class frm_pronostico : DevExpress.XtraEditors.XtraForm
    {
        public frm_pronostico()
        {
            InitializeComponent();
        }

        private void frm_pronostico_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}