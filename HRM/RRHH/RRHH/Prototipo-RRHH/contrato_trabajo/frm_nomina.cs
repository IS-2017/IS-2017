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

            DataGridViewRow entrada = new DataGridViewRow();
            dataGridView1.Rows.Add(entrada);
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
                DataGridViewRow entrada = new DataGridViewRow();
                dataGridView1.Rows.Add(entrada);
                dataGridView1.Rows[0].Cells[0].Value = "¨Sueldo Base del Mes";
                DataGridViewComboBoxCell combo = dataGridView1.Rows[0].Cells[1] as DataGridViewComboBoxCell;
                combo.Value = "SUELDO BASE";
                dataGridView1.Rows[0].Cells[2].Value = "4000";

                //LLENADO FILA 2
                DataGridViewRow entrada2 = new DataGridViewRow();
                dataGridView1.Rows.Add(entrada2);
                dataGridView1.Rows[1].Cells[0].Value = "Pago de Bonificación del Mes";
                DataGridViewComboBoxCell combito = dataGridView1.Rows[1].Cells[1] as DataGridViewComboBoxCell;
                combito.Value = "BONIFICACION";
                dataGridView1.Rows[1].Cells[2].Value = "250";


            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
            if (dataGridView1.Columns[e.ColumnIndex].Name == "TIPO")
            {
                DataGridViewComboBoxCell combo = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                String prueba = Convert.ToString(combo.Value);


                if (prueba == "SEGURO SOCIAL")
                {
                    frm_calculo_seguro_social calculo = new frm_calculo_seguro_social();
                    calculo.Show();
                }
                //if (prueba == "BONIFICACION")
                //{
                //    dataGridView1.Rows[e.RowIndex].Cells[2].Value = "250";

                //}
                if (prueba == "HORAS EXTRA")
                {
                    frm_horas_extras horas = new frm_horas_extras();
                    horas.Show();
                }
                if (prueba == "IMPUESTO")
                {
                    frm_pago_impuestos pago = new frm_pago_impuestos();
                    pago.Show();
                }
                if (prueba == "AGUINALDO")
                {
                    frm_aguinaldo aguinaldo = new frm_aguinaldo();
                    aguinaldo.Show(); 
                }
                if(prueba == "BONO 14")
                {
                    frm_bono_14 bono14 = new frm_bono_14();
                    bono14.Show();
                }
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abrir.Form1 f1 = new Form1();
            f1.Crystal = @"C:\Users\ccarrera\Desktop\prueba2\CrystalReport2.rpt";
            f1.Show();
        }
    }
}

