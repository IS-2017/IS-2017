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
    public partial class frm_Otros : Form
    {
        public frm_Otros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                frm_nomina nomina = new frm_nomina();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "frm_nomina")
                    {
                        nomina = (frm_nomina)frm;
                        nomina.dataGridView1.Rows.Add(txt_descripcion.Text,cbo_tipo.SelectedItem.ToString(),txt_cant_pagar.Text);
                        this.Close();
                        break;
                    }
                }
            }
            catch
            {

            }
        }
    }
}
