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
    public partial class frm_reporte_deduccion : Form
    {
        public frm_reporte_deduccion()
        {
            InitializeComponent();
        }
        capa_datos cd = new capa_datos();
        private void frm_reporte_deduccion_Load(object sender, EventArgs e)
        {
            cd.llenar_id_empleado(cbo_empleado);
            cbo_empleado.SelectedIndex = -1;
            dgv_deduccion.DataSource = cd.cargar("select empleado.id_empleado_pk,concat(nombre_emp,' ',apellido_emp) as nombre,empresa.id_empresa_pk,empresa.nombre_empresa,nombre_deduccion,fecha,cantidad_horas,cantidad_deduccion from deducciones inner join empleado on empleado.id_empleado_pk=deducciones.id_empleado_pk inner join empresa on empleado.id_empresa_pk=empresa.id_empresa_pk where deducciones.estado='activo';");
            dtp_fin.Enabled = false;
            dtp_inicio.Enabled = false;
            btn_filtrar.Enabled = false;
        }

        private void cbo_empleado_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                dgv_deduccion.DataSource = cd.cargar("select empleado.id_empleado_pk,concat(nombre_emp,' ',apellido_emp) as nombre,empresa.id_empresa_pk,empresa.nombre_empresa,nombre_deduccion,fecha,cantidad_horas,cantidad_deduccion from deducciones inner join empleado on empleado.id_empleado_pk=deducciones.id_empleado_pk inner join empresa on empleado.id_empresa_pk=empresa.id_empresa_pk where deducciones.estado='activo' and deducciones.id_empleado_pk='"+cbo_empleado.SelectedValue.ToString()+"';");
            }
            catch { }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                cbo_empleado.SelectedValue = -1;
                dgv_deduccion.DataSource = cd.cargar("select empleado.id_empleado_pk,concat(nombre_emp,' ',apellido_emp) as nombre,empresa.id_empresa_pk,empresa.nombre_empresa,nombre_deduccion,fecha,cantidad_horas,cantidad_deduccion from deducciones inner join empleado on empleado.id_empleado_pk=deducciones.id_empleado_pk inner join empresa on empleado.id_empresa_pk=empresa.id_empresa_pk where deducciones.estado='activo' and fecha between '"+dtp_inicio.Value.ToString("yyyy-MM-dd")+"' and '"+dtp_fin.Value.ToString("yyyy-MM-dd")+"';");
            }
            catch { }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            ds_deducciones Ds = new ds_deducciones();
            int filas = dgv_deduccion.Rows.Count;
            for (int i = 0; i < filas - 1; i++)
            {
                Ds.Tables[0].Rows.Add(new object[]
                {
                    dgv_deduccion[0,i].Value.ToString(),
                    dgv_deduccion[1,i].Value.ToString(),
                    dgv_deduccion[2,i].Value.ToString(),
                    dgv_deduccion[3,i].Value.ToString(),
                    dgv_deduccion[4,i].Value.ToString(),
                    dgv_deduccion[5,i].Value.ToString(),
                    dgv_deduccion[4,i].Value.ToString(),
                    dgv_deduccion[7,i].Value.ToString(),
                    
                });
                
            }
            ReportDocument cRep = new ReportDocument();
            cRep.Load(@"C:\Users\ccarrera\Desktop\Vieres\RRHH\RRHH\Prototipo-RRHH\contrato_trabajo\rpt_deducciones.rpt");
            cRep.SetDataSource(Ds);
            frm_viewerDeducion fd = new frm_viewerDeducion();
            fd.crystalReportViewer1.ReportSource = cRep;
            fd.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dtp_fin.Enabled = true;
            dtp_inicio.Enabled = true;
            btn_filtrar.Enabled = true;
            cbo_empleado.SelectedIndex = -1;
        }
    }
}
