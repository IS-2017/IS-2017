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
    public partial class frm_reporte_jornada : Form
    {

        CapaNegocio fn = new CapaNegocio();

        public frm_reporte_jornada()
        {
            InitializeComponent();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            ActualizarTablas();
        }

        public void ActualizarTablas()
        {
            try
            {
                string tabla = "emp_jornadatrabajo";
                fn.ActualizarGrid(this.dgv_reporte_jornada, "SELECT forma_cobro, nombre_jornada, horas_trabajo, jdiaria_dias, jhora_diario, estado FROM `emp_jornadatrabajo` WHERE estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        public void GenerarReporte()
        {
            try
            {
                dts_jornadas Ds = new dts_jornadas();
                int filas = dgv_reporte_jornada.Rows.Count;
                for (int i = 0; i < filas - 1; i++)
                {
                    Ds.Tables[0].Rows.Add(new object[]
                    {
                    dgv_reporte_jornada[0,i].Value.ToString(),
                    dgv_reporte_jornada[1,i].Value.ToString(),
                    dgv_reporte_jornada[2,i].Value.ToString(),
                    dgv_reporte_jornada[3,i].Value.ToString(),
                    dgv_reporte_jornada[4,i].Value.ToString()

                    });
                    ReportDocument cRep = new ReportDocument();
                    cRep.Load("C:/reporteJornada.rpt");
                    cRep.SetDataSource(Ds);
                    crystalReportViewer1.ReportSource = cRep;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            ActualizarTablas();
            GenerarReporte();
        }
    }
}
