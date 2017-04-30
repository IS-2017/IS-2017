using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abrir;

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
          
            frm_horas_extras he = new frm_horas_extras();
            he.Show();
           
          
                
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
           
            
                DataGridViewRow entrada = new DataGridViewRow();
                entrada = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
                dataGridView1.Rows.Remove(entrada);

            
        }

        private void Nomina_Load(object sender, EventArgs e)
        {
            try
            {
                //LLENANDO PRIMER FILA DEL DATAGRIDVIEW
                DataGridViewRow entradabase = new DataGridViewRow();
                dataGridView1.Rows.Add(entradabase);
                dataGridView1.Rows[0].Cells[0].Value = "Pago de Salario del Mes";
                dataGridView1.Rows[0].Cells[1].Value = "SUELDO BASE";
                dataGridView1.Rows[0].Cells[2].Value = "4000";



                //LLENADO FILA 2 DEL DATAGRIDVIEW
                DataGridViewRow entradaboni = new DataGridViewRow();
                dataGridView1.Rows.Add(entradaboni);
                dataGridView1.Rows[1].Cells[0].Value = "Pago de Bonificación del Mes";
                dataGridView1.Rows[1].Cells[1].Value = "BONIFICACION";
                dataGridView1.Rows[1].Cells[2].Value = "250";

                //LLENANDO FILA 3
                DataGridViewRow entradacomi = new DataGridViewRow();
                dataGridView1.Rows.Add(entradacomi);
                dataGridView1.Rows[2].Cells[0].Value = "Pago de Comisión";
                dataGridView1.Rows[2].Cells[1].Value = "COMISION";
                dataGridView1.Rows[2].Cells[2].Value = "150";

                //LLENANDO FILA 4
                DataGridViewRow salidaIGSS = new DataGridViewRow();
                dataGridView1.Rows.Add(salidaIGSS);
                dataGridView1.Rows[3].Cells[0].Value = "Pago de Seguro Social";
                dataGridView1.Rows[3].Cells[1].Value = "IGSS";
                dataGridView1.Rows[3].Cells[2].Value = "200";

                //LLENANDO FILA 5 
                DataGridViewRow ISR = new DataGridViewRow();
                dataGridView1.Rows.Add(ISR);
                dataGridView1.Rows[4].Cells[0].Value = "Pago de Impuesto";
                dataGridView1.Rows[4].Cells[1].Value = "ISR";
                dataGridView1.Rows[4].Cells[2].Value = "75";





                //LLENANDO BONO 14 Y AGUINALDO 
                fecha_hoy.Format = DateTimePickerFormat.Custom;
                fecha_hoy.CustomFormat = "yyyy-MM-dd";
                String fecha = fecha_hoy.Text;
               
                if (fecha == "2017-07-30")
                {
                    int numero = Convert.ToInt32(dataGridView1.Rows.Count);
                    DataGridViewRow entradabono = new DataGridViewRow();
                    dataGridView1.Rows.Add(entradabono);
                    dataGridView1.Rows[numero].Cells[0].Value = "Pago de Bono 14 mes de Julio";
                    dataGridView1.Rows[numero].Cells[1].Value = "BONO 14";
                    dataGridView1.Rows[numero].Cells[2].Value = "4000";

                }

                if (fecha == "2017-12-30")
                {
                    int numero = Convert.ToInt32(dataGridView1.Rows.Count);
                    DataGridViewRow entradaguinaldo = new DataGridViewRow();
                    dataGridView1.Rows.Add(entradaguinaldo);
                    dataGridView1.Rows[numero].Cells[0].Value = "Pago de Aguinaldo del año";
                    dataGridView1.Rows[numero].Cells[1].Value = "AGUINALDO";
                    dataGridView1.Rows[numero].Cells[2].Value = "4000";

                }





            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index == 5)
            {
               if (Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value) == "HORAS EXTRA")
                {
                    DataGridViewRow entrada = new DataGridViewRow();
                    entrada = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
                    dataGridView1.Rows.Remove(entrada);
                    Agregar.Enabled = true;
                }
                else
                {

                    DataGridViewRow entrada = new DataGridViewRow();
                    entrada = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
                    dataGridView1.Rows.Remove(entrada);

                }
            }


           else if (dataGridView1.CurrentRow.Index == 6)
            {
                if (Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value) == "HORAS EXTRA")
                {
                    DataGridViewRow entrada = new DataGridViewRow();
                    entrada = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
                    dataGridView1.Rows.Remove(entrada);
                    Agregar.Enabled = true;
                }
                else
                {

                    DataGridViewRow entrada = new DataGridViewRow();
                    entrada = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
                    dataGridView1.Rows.Remove(entrada);
                }
            }

            else
            {
                MessageBox.Show("No se Puede eliminar dicha Fila");
            }

        }
      



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

       
        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            
        }

        private void dataGridView1_Validated(object sender, EventArgs e)
        {
            
        }

        private void Nominas_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

       

        //private void dgvcombo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "BONIFICACION")


        //        {
        //            //        //dataGridView1.CurrentRow.Cells[2].Value = "250";
        //            //        MessageBox.Show("re puta que es lo que esta pasando");

        //            //        

        //            MessageBox.Show("hola nene");
        //        }
        //    }
        //    catch
        //    {

        //    }
        //}

        //private void dataGridView1_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    if (e.Control is ComboBox)
        //    {
        //        DataGridViewComboBoxEditingControl dgvcombo = e.Control as DataGridViewComboBoxEditingControl;



        //        dgvcombo.SelectedIndexChanged -= new EventHandler(dgvcombo_SelectedIndexChanged);
        //        dgvcombo.SelectedIndexChanged += new EventHandler(dgvcombo_SelectedIndexChanged);

        //    }
        //}

        private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abrir.Form1 f1 = new Form1();
            f1.Crystal = @"C:\Users\ccarrera\Desktop\prueba2\CrystalReport2.rpt";
            f1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frm_Otros otros = new frm_Otros();
            otros.Show();
        }
    }
}

