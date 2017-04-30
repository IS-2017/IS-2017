using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using FuncionesNavegador;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace contrato_trabajo
{
    class Capa_de_datos2
    {
        //Llenando Combobox para Indemnizacion
        //Programado por Gladiz Cruz
        public void llenar_cbx(ComboBox cb)
        {

            try
            {
                OdbcConnection con = Conexionmysql.ObtenerConexion();
                OdbcCommand cmd;
                DataTable dt = new DataTable();
                cmd = new OdbcCommand("select id_empresa_pk, nombre_empresa from empresa where estado='ACTIVO'", con);
                OdbcDataAdapter adaptador = new OdbcDataAdapter(cmd);
                adaptador.Fill(dt);

                cb.DataSource = dt;
                cb.DisplayMember = "id_empresa_pk";
                cb.ValueMember = "id_empresa_pk";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Llenando Combobox para indemnizacion
        //Programado por Gladis Cruz
        public DataTable llenar_cbo_empleado(string id_empresa)
        {
            DataTable dt = new DataTable();
            try
            {
                OdbcConnection con = Conexionmysql.ObtenerConexion();
                OdbcCommand cmd;

                cmd = new OdbcCommand("select id_empleado_pk, nombre_emp FROM empleado WHERE id_empresa_pk = '" + id_empresa + "'", Conexionmysql.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(cmd);
                adaptador.Fill(dt);
                return dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

         
         }
    }




