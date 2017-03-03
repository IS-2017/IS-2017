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
    public partial class frm_nomina : Form
    {
        public frm_nomina()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {

            DataGridViewRow entrada = new DataGridViewRow();
            dataGridView1.Rows.Add(entrada);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != dataGridView1.Rows.Count - 1)
            {

                DataGridViewRow entrada = new DataGridViewRow();
                entrada = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
                dataGridView1.Rows.Remove(entrada);

            }
        }

        private void Nomina_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

