using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Reporte_nomina : Form
    {
        public Reporte_nomina()
        {
            InitializeComponent();
        }
        capa_datos ca = new capa_datos();
        private void Reporte_nomina_Load(object sender, EventArgs e)
        {
            try
            {
                ca.llenar_id_empresa(comboBox1);
                comboBox1.SelectedIndex = -1;
                dgv_nomina.DataSource = ca.cargar("select empleado.id_empleado_pk,CONCAT(nombre_emp,' ',apellido_emp) as 'nombre', detalle_nomina.id_nomina_pk,descripcion, fecha_inicio_pago, fecha_fin_pago, sueldo_base, nombre, total_a_pagar as 'valor' ,total, nomina.id_empresa_pk,id_detalle_nomina_pk from nomina inner join detalle_nomina on nomina.id_nomina_pk = detalle_nomina.id_nomina_pk inner join empleado on nomina.id_empleado_pk = empleado.id_empleado_pk;");

            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataSetNomina Ds = new DataSetNomina();
            int filas = dgv_nomina.Rows.Count;

            for (int i = 0; i < filas - 1; i++)
            {

                Ds.Tables[0].Rows.Add(new object[]
                {
                    dgv_nomina[0,i].Value.ToString(),
                    dgv_nomina[1,i].Value.ToString(),
                    dgv_nomina[2,i].Value.ToString(),
                    dgv_nomina[3,i].Value.ToString(),
                    dgv_nomina[4,i].Value.ToString(),
                    dgv_nomina[5,i].Value.ToString(),
                    dgv_nomina[6,i].Value.ToString(),
                    dgv_nomina[7,i].Value.ToString(),
                    dgv_nomina[8,i].Value.ToString(),
                    dgv_nomina[9,i].Value.ToString(),
                    dgv_nomina[10,i].Value.ToString(),
                    dgv_nomina[11,i].Value.ToString(),


                });

            }
            ReportDocument cRep = new ReportDocument();
            cRep.Load("C:/Users/GABRIELA/Dropbox/Semestre 9/Ingenieria de Software/Vieres/RRHH/RRHH/Prototipo-RRHH/contrato_trabajo/rpt_nomina.rpt");
            cRep.SetDataSource(Ds);
            Reporte_nomina_halar pr = new Reporte_nomina_halar();
            pr.crystalReportViewer1.ReportSource = cRep;
            pr.Show();
           
            //crystalReportViewer1.ReportSource = cRep;
            //crystalReportViewer1.Visible = true;
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      

     

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                dgv_nomina.DataSource = ca.cargar("select empleado.id_empleado_pk,CONCAT(nombre_emp,' ',apellido_emp) as 'nombre', detalle_nomina.id_nomina_pk,descripcion, fecha_inicio_pago, fecha_fin_pago, sueldo_base, nombre, total_a_pagar as 'valor' ,total, nomina.id_empresa_pk,id_detalle_nomina_pk from nomina inner join detalle_nomina on nomina.id_nomina_pk = detalle_nomina.id_nomina_pk inner join empleado on nomina.id_empleado_pk = empleado.id_empleado_pk where nomina.id_empresa_pk = '" + comboBox1.SelectedValue.ToString() + "';");

            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                dgv_nomina.DataSource = ca.cargar("select empleado.id_empleado_pk,CONCAT(nombre_emp, ' ', apellido_emp) as 'nombre', detalle_nomina.id_nomina_pk,descripcion, fecha_inicio_pago, fecha_fin_pago, sueldo_base, nombre, total_a_pagar as 'valor' ,total, nomina.id_empresa_pk,id_detalle_nomina_pk from nomina inner join detalle_nomina on nomina.id_nomina_pk = detalle_nomina.id_nomina_pk inner join empleado on nomina.id_empleado_pk = empleado.id_empleado_pk where fecha_inicio_pago between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'and '" + dateTimePicker2.Value.ToString() + "';");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
          
            dgv_nomina.DataSource = ca.cargar("select empleado.id_empleado_pk,CONCAT(nombre_emp,' ',apellido_emp) as 'nombre', detalle_nomina.id_nomina_pk,descripcion, fecha_inicio_pago, fecha_fin_pago, sueldo_base, nombre, total_a_pagar as 'valor' ,total, nomina.id_empresa_pk,id_detalle_nomina_pk from nomina inner join detalle_nomina on nomina.id_nomina_pk = detalle_nomina.id_nomina_pk inner join empleado on nomina.id_empleado_pk = empleado.id_empleado_pk;");

        }
    }
}

