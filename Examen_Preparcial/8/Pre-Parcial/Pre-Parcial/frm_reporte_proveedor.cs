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

namespace Pre_Parcial
{
    public partial class frm_reporte_proveedor : Form
    {
        CapaNegocio fn = new CapaNegocio();

        public frm_reporte_proveedor()
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
                string tabla = "cliente";
                fn.ActualizarGrid(this.dgv_reporte_prov, "SELECT nombre_proveedor, direccion_proveedor, telefono_proveedor, correo_proveedor FROM `proveedor` WHERE estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_reporte_proveedor_Load(object sender, EventArgs e)
        {
            ActualizarTablas();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            ActualizarTablas();
            GenerarReporte();
        }

        public void GenerarReporte()
        {
            try
            {
                dts_proveedor Ds = new dts_proveedor();
                int filas = dgv_reporte_prov.Rows.Count;
                for (int i = 0; i < filas - 1; i++)
                {
                    Ds.Tables[0].Rows.Add(new object[]
                    {
                    dgv_reporte_prov[0,i].Value.ToString(),
                    dgv_reporte_prov[1,i].Value.ToString(),
                    dgv_reporte_prov[2,i].Value.ToString(),
                    dgv_reporte_prov[3,i].Value.ToString()

                    });
                    ReportDocument cRep = new ReportDocument();
                    cRep.Load("C:/reporteProveedor.rpt");
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
