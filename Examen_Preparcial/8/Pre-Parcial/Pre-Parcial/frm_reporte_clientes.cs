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
    public partial class frm_reporte_clientes : Form
    {
        CapaNegocio fn = new CapaNegocio();

        public frm_reporte_clientes()
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
                fn.ActualizarGrid(this.dgv_reporte_clientes, "SELECT nombre_cliente, direccion_cliente, telefono_cliente, dpi_cliente, nit_cliente FROM `cliente` WHERE estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_reporte_clientes_Load(object sender, EventArgs e)
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
                dts_clientes Ds = new dts_clientes();
                int filas = dgv_reporte_clientes.Rows.Count;
                for (int i = 0; i < filas - 1; i++)
                {
                    Ds.Tables[0].Rows.Add(new object[]
                    {
                    dgv_reporte_clientes[0,i].Value.ToString(),
                    dgv_reporte_clientes[1,i].Value.ToString(),
                    dgv_reporte_clientes[2,i].Value.ToString(),
                    dgv_reporte_clientes[3,i].Value.ToString(),
                    dgv_reporte_clientes[4,i].Value.ToString()

                    });
                    ReportDocument cRep = new ReportDocument();
                    cRep.Load("C:/reporteClientes.rpt");
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
