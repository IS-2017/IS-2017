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
    public partial class frm_horas_extras:Form
    {
        public frm_horas_extras()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
           


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_horas_extras_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_nomina nomina = new frm_nomina();
            foreach(Form frm in Application.OpenForms)
            {
                if(frm.Name=="frm_nomina")
                {
                    nomina = (frm_nomina)frm;
                    nomina.dataGridView1.Rows.Add("Pago de Horas Extras", "HORAS EXTRA", textBox3.Text, textBox1.Text);
                    nomina.Agregar.Enabled = false;
                    this.Close();
                    break;
                }
            }
        }
    }
}
