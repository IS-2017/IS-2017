using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace crm
{
    public partial class FormActividadesCalendario : Form
    {
        public FormActividadesCalendario()
        {
            InitializeComponent();
        }

        private void FormActividadesCalendario_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
