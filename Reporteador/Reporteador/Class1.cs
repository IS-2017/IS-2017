using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Reporteador
{
    public class Reporte
    {
        private static OdbcCommand mySqlComando;
        public void insertarRPT(string nombre, string ruta)
        {
            try
            {
                mySqlComando = new OdbcCommand(string.Format("Insert into reporteador(nombre,ubicacion) values ('{0}','{1}')", nombre, ruta), seguridad.Conexion.ConexionPermisos());
                mySqlComando.ExecuteNonQuery();
                MessageBox.Show("Se inserto con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en insercion");
            }
        }

        public DataTable cargar(string query)
        {
            // llenado del data grid view 
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(query, seguridad.Conexion.ConexionPermisos());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(dt);
            return dt;

        }
        public void Ejecutar(String Reporte)
        {
            if (Opciones.Opcion == null || Opciones.Opcion == "VISUALIZAR")
            {
                try
                {
                    Visualizar vz = new Visualizar();
                    vz.Modulo(Reporte);
                    vz.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (Opciones.Opcion == "IMPRESORA")
            {
                try
                {
                    DialogResult accepat = MessageBox.Show("Enviar a Impresora Ahora?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (accepat == DialogResult.OK)
                    {

                        ReportDocument rDocument = new ReportDocument();
                        rDocument.Load(Reporte);
                        rDocument.PrintToPrinter(1, true, 1, 2);
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
