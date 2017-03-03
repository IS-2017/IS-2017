using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contrato_trabajo
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        Timer t;

        private void Loading_Load(object sender, EventArgs e)
        {

        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void Loading_Shown(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 4000;
            t.Start();
            t.Tick += new EventHandler(t_Tick);
            this.timer1.Start();

        }

        void t_Tick(object sender, EventArgs e)
        {
            t.Stop();
            mdi_contenedor con = new mdi_contenedor();
            con.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }
    }
}
