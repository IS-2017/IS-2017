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
using System.Data.Odbc;

namespace Pre_Parcial
{
    public partial class frm_reporte_producto : Form
    {
        CapaNegocio fn = new CapaNegocio();

        public frm_reporte_producto()
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
                string tabla = "producto";
                fn.ActualizarGrid(this.dgv_reporte_prod, "SELECT nombre_producto, descripcion_producto, precio_producto, fecha_registro_producto FROM `producto` WHERE estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_reporte_producto_Load(object sender, EventArgs e)
        {
            ActualizarTablas();
            Llenar_proveedor();
        }

        public void Llenar_proveedor()
        {
            Conexionmysql.ObtenerConexion();
            DataSet ds = new DataSet();
            String Query = "SELECT id_proveedor_pk, nombre_proveedor FROM proveedor WHERE estado ='ACTIVO'";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            dad.Fill(ds, "proveedor");
            cbo_id_prov.DataSource = ds.Tables[0].DefaultView;
            cbo_id_prov.ValueMember = ("id_proveedor_pk");
            cbo_id_prov.DisplayMember = ("nombre_proveedor");
            Conexionmysql.Desconectar();
        }

        private void cbo_id_prov_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cbo_id_prov.Text = cbo_id_prov.SelectedValue.ToString();
            //string tabla = "producto";
            //fn.ActualizarGrid(this.dgv_reporte_prod, "SELECT nombre_producto, descripcion_producto, precio_producto, fecha_registro_producto FROM `producto` WHERE estado = 'ACTIVO' ", tabla);
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
                dts_producto Ds = new dts_producto();
                int filas = dgv_reporte_prod.Rows.Count;
                for (int i = 0; i < filas - 1; i++)
                {
                    Ds.Tables[0].Rows.Add(new object[]
                    {
                    dgv_reporte_prod[0,i].Value.ToString(),
                    dgv_reporte_prod[1,i].Value.ToString(),
                    dgv_reporte_prod[2,i].Value.ToString(),
                    dgv_reporte_prod[3,i].Value.ToString()

                    });
                    ReportDocument cRep = new ReportDocument();
                    cRep.Load("C:/reporteProducto.rpt");
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
