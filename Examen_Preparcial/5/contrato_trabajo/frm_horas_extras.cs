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
            capa_datos ca = new capa_datos();
            ca.llenar_cbo_horas_extra(comboBox2);
            comboBox2.SelectedIndex = -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
        nomina nomina = new nomina();
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "nomina")
                {
                    nomina = (nomina)frm;
                    nomina.dgv_nonimas.CurrentRow.Cells[10].Value = total_total.ToString();
                    nomina.dgv_nonimas.Columns[10].Visible = true;
                    nomina.dgv_nonimas.CurrentRow.Cells[15].Value = txt_cant_horas_extra.Text;
                    this.Close();
                    break;
                }
            }

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

          

        }
        double total_total;
        private void txt_cant_horas_extra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string porcentaje_hora_extra = comboBox2.SelectedValue.ToString(); //PORCENTAJE VALOR DE LA HORA EXTRA
                double porcentaje = Convert.ToDouble(comboBox2.SelectedValue.ToString());
                string cantidad_horas_extra = txt_cant_horas_extra.Text;
                double cant_horas_extra = Convert.ToDouble(cantidad_horas_extra); // CANTIDAD HORAS EXTRA TRABAJADAS
                double precio_hora = Convert.ToDouble(txt_precio_hora.Text); // VALOR DE LA HORA
                double precio_hora_extra_total = precio_hora * porcentaje; // VALOR DE LA HORA YA EXTRA
                double total_pagar_horas_extra = cant_horas_extra * precio_hora_extra_total;
                total_total = Math.Round(total_pagar_horas_extra, 2);
                txt_porcentaje.Text = porcentaje.ToString();
                txt_total.Text = total_total.ToString();
                //   
               
            }
            catch
            {

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

