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
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        nomina nomina = new nomina();
        private void button3_Click(object sender, EventArgs e)
        {
            {

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "nomina")
                    {
                        string tipo =cbo_tipo.SelectedItem.ToString();
                        if (tipo == "DEVENGO")
                        {
                            nomina = (nomina)frm;
                            nomina.dgv_nonimas.CurrentRow.Cells[12].Value = txt_cant_pagar.Text;
                            nomina.dgv_nonimas.Columns[12].Visible = true;
                         
                        }
                        else
                        {
                            nomina = (nomina)frm;
                            nomina.dgv_nonimas.CurrentRow.Cells[13].Value = txt_cant_pagar.Text;
                            nomina.dgv_nonimas.Columns[13].Visible = true;
                        }
                        this.Close();
                        break;
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_cant_pagar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
