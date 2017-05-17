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
    public partial class frm_reporte_activos : Form
    {
        CapaNegocio fn = new CapaNegocio();

        public frm_reporte_activos()
        {
            InitializeComponent();
        }


        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "activos_empresa";
            fn.ActualizarGrid(this.dgv_reporte_activo, "SELECT nombre_activo, num_serie_activo, precio_activo, descripcion_activo, id_activos_emp_pk FROM `activos_empresa` WHERE estado = 'ACTIVO' ", tabla);
        }

        public void GenerarReporte()
        {
            dts_activos Ds = new dts_activos();
            int filas = dgv_reporte_activo.Rows.Count;
            for (int i = 0; i < filas - 1; i++)
            {
                Ds.Tables[0].Rows.Add(new object[]
                {
                    dgv_reporte_activo[0,i].Value.ToString(),
                    dgv_reporte_activo[1,i].Value.ToString(),
                    dgv_reporte_activo[2,i].Value.ToString(),
                    dgv_reporte_activo[3,i].Value.ToString(),
                    dgv_reporte_activo[4,i].Value.ToString()

                });
                ReportDocument cRep = new ReportDocument();
                cRep.Load("C:/reporteActivos.rpt");
                cRep.SetDataSource(Ds);
                crystalReportViewer1.ReportSource = cRep;
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }
    }
}
