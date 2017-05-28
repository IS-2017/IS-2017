using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesNavegador;
using CrystalDecisions.CrystalReports.Engine;

namespace contrato_trabajo
{
    public partial class frm_reporte_puestos : Form
    {
        CapaNegocio fn = new CapaNegocio();

        public frm_reporte_puestos()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            ActualizarTablas();
            GenerarReporte();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            ActualizarTablas();
        }

        public void ActualizarTablas()
        {
            try
            {
                string tabla = "puesto_laboral";
                fn.ActualizarGrid(this.dgv_reporte_puesto, "SELECT nombre_puesto, descripcion, salario_base, id_puesto_laboral_pk FROM `puesto_laboral` WHERE estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GenerarReporte()
        {
            try
            {
                dts_puestos Ds = new dts_puestos();
                int filas = dgv_reporte_puesto.Rows.Count;
                for (int i = 0; i < filas - 1; i++)
                {
                    Ds.Tables[0].Rows.Add(new object[]
                    {
                    dgv_reporte_puesto[0,i].Value.ToString(),
                    dgv_reporte_puesto[1,i].Value.ToString(),
                    dgv_reporte_puesto[2,i].Value.ToString(),
                    dgv_reporte_puesto[3,i].Value.ToString()

                    });
                    ReportDocument cRep = new ReportDocument();
                    cRep.Load("C:/reportePuestos.rpt");
                    cRep.SetDataSource(Ds);
                    crystalReportViewer1.ReportSource = cRep;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
