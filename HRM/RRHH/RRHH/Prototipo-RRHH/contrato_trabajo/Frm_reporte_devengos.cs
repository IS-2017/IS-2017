using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CrystalDecisions.CrystalReports.Engine;

namespace contrato_trabajo
{
    public partial class Frm_reporte_devengos : Form
    {
        public Frm_reporte_devengos()
        {
            InitializeComponent();
        }
        capa_datos ca = new capa_datos();
        private void Frm_reporte_devengos_Load(object sender, EventArgs e)
        {
            try
            {
                ca.llenar_id_empresa(cbo_empresa);
                cbo_empresa.SelectedIndex = -1;

                ca.llenar_id_empleado(cbo_empleado);
                cbo_empleado.SelectedIndex = -1;

                dgv_devengos.DataSource = ca.cargar("select empleado.id_empleado_pk, concat(nombre_emp,' ', apellido_emp)as nombre, empleado.id_empresa_pk, nombre_empresa, nombre_devengo, fecha, cantidad_devengado, cantidad_horas_extra from empleado inner join devengos on empleado.id_empleado_pk = devengos.id_empleado_pk inner join empresa on empleado.id_empresa_pk =  empresa.id_empresa_pk");

            }
            catch
            {
            }
        }

       
      
      

        private void button2_Click(object sender, EventArgs e)
        {
        
           dgv_devengos.DataSource = ca.cargar("select empleado.id_empleado_pk, concat(nombre_emp, ' ', apellido_emp) as nombre, empleado.id_empresa_pk,nombre_empresa, nombre_devengo, fecha, cantidad_devengado, cantidad_horas_extra from empleado inner join devengos on empleado.id_empleado_pk = devengos.id_empleado_pk inner join empresa on empleado.id_empresa_pk = empresa.id_empresa_pk where fecha between '" + dateTimePickerinicio.Value.ToString("yyyy-MM-dd") + "'and '" + dateTimePickerfin.Value.ToString("yyyy-MM-dd") + "';");
            cbo_empleado.SelectedIndex = -1;
            cbo_empresa.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet_devengos Ds = new DataSet_devengos();
            int filas = dgv_devengos.Rows.Count;

            for (int i = 0; i < filas - 1; i++)
            {

                Ds.Tables[0].Rows.Add(new object[]
                {
                    dgv_devengos[0,i].Value.ToString(),
                    dgv_devengos[1,i].Value.ToString(),
                    dgv_devengos[2,i].Value.ToString(),
                    dgv_devengos[3,i].Value.ToString(),
                    dgv_devengos[4,i].Value.ToString(),
                    dgv_devengos[5,i].Value.ToString(),
                    dgv_devengos[6,i].Value.ToString(),
                    dgv_devengos[7,i].Value.ToString(),
                    


                });

            }
            ReportDocument cRep = new ReportDocument();
            cRep.Load("C:/Users/GABRIELA/Dropbox/Semestre 9/Ingenieria de Software/Vieres/RRHH/RRHH/Prototipo-RRHH/contrato_trabajo/rpt_devengos.rpt");
            cRep.SetDataSource(Ds);
            reporte_devengos_halar pr = new reporte_devengos_halar();
            pr.crystalReportViewer1.ReportSource = cRep;
            pr.Show();

        }

       
        private void cbo_empresa_DropDownClosed(object sender, EventArgs e)
        {
            
            dgv_devengos.DataSource = ca.cargar("select empleado.id_empleado_pk, concat(nombre_emp,' ', apellido_emp)as nombre, empleado.id_empresa_pk, nombre_empresa, nombre_devengo, fecha, cantidad_devengado, cantidad_horas_extra from empleado inner join devengos on empleado.id_empleado_pk = devengos.id_empleado_pk inner join empresa on empleado.id_empresa_pk =  empresa.id_empresa_pk where empresa.id_empresa_pk = '"+cbo_empresa.SelectedValue.ToString()+"'");
            cbo_empleado.SelectedIndex = -1;
        }

        private void cbo_empleado_DropDownClosed(object sender, EventArgs e)
        {
            dgv_devengos.DataSource = ca.cargar("select empleado.id_empleado_pk, concat(nombre_emp,' ', apellido_emp)as nombre, empleado.id_empresa_pk, nombre_empresa, nombre_devengo, fecha, cantidad_devengado, cantidad_horas_extra from empleado inner join devengos on empleado.id_empleado_pk = devengos.id_empleado_pk inner join empresa on empleado.id_empresa_pk =  empresa.id_empresa_pk where empleado.id_empleado_pk = '" + cbo_empleado.SelectedValue.ToString() + "'");
            cbo_empresa.SelectedIndex = -1;

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_devengos.DataSource = ca.cargar("select empleado.id_empleado_pk, concat(nombre_emp,' ', apellido_emp)as nombre, empleado.id_empresa_pk, nombre_empresa, nombre_devengo, fecha, cantidad_devengado, cantidad_horas_extra from empleado inner join devengos on empleado.id_empleado_pk = devengos.id_empleado_pk inner join empresa on empleado.id_empresa_pk =  empresa.id_empresa_pk");
        }
    }

}

