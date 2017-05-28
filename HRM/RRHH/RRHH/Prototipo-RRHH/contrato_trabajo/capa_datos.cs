using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;
using seguridad;

namespace contrato_trabajo
{
    class capa_datos
    {
        public void llenar_id_empresa(ComboBox cb)
        {

            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd;
                DataTable dt = new DataTable();

                cmd = new OdbcCommand("select id_empresa_pk, nombre_empresa from empresa where estado='ACTIVO'", con);
                OdbcDataAdapter adaptador = new OdbcDataAdapter(cmd);
                adaptador.Fill(dt);

                cb.DataSource = dt;
                cb.DisplayMember = "nombre_empresa";
                cb.ValueMember = "id_empresa_pk";
                seguridad.Conexion.DesconectarODBC();
            }

            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void llenar_id_empleado(ComboBox cb)
        {

            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd;
                DataTable dt = new DataTable();

                cmd = new OdbcCommand("select id_empleado_pk, nombre_emp from empleado where estado='ACTIVO'", con);
                OdbcDataAdapter adaptador = new OdbcDataAdapter(cmd);
                adaptador.Fill(dt);

                cb.DataSource = dt;
                cb.DisplayMember = "nombre_emp";
                cb.ValueMember = "id_empleado_pk";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            seguridad.Conexion.DesconectarODBC();
        }
        public static AutoCompleteStringCollection LoadAutoComplete()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcCommand cmd = new OdbcCommand("select id_empresa_pk, nombre_empresa from empresa where estado='ACTIVO'", seguridad.Conexion.ObtenerConexionODBC());
                OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
                adap.Fill(dt);

                AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

                foreach (DataRow row in dt.Rows)
                {
                    stringCol.Add(Convert.ToString(row["nombre_empresa"]));
                }

                return stringCol;
            }
            catch
            {
                return null;
            }
        }
        public DataTable cargar(string query)
        {

            DataTable dt = new DataTable();
            try
            {
                OdbcCommand cmd = new OdbcCommand(query, seguridad.Conexion.ObtenerConexionODBC());
                OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
                adap.Fill(dt);
                seguridad.Conexion.DesconectarODBC();
            }
            catch
            {

            }
            return dt;

        }

        public Double ObtenerSueldo(String id_empleado)
        {
            DataTable dt2 = new DataTable();
            double sal;
            try
            {
                DataTable dt = new DataTable();
                String query = "select id_puesto_laboral_pk from empleado where id_empleado_pk='" + id_empleado + "'";
                OdbcCommand cmd = new OdbcCommand(query, seguridad.Conexion.ObtenerConexionODBC());
                OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
                adap.Fill(dt);
                string id_laboral = Convert.ToString(dt.Rows[0][0]);


                String query2 = "select salario_base from puesto_laboral where id_puesto_laboral_pk ='" + id_laboral + "'";
                OdbcCommand cmd2 = new OdbcCommand(query2, seguridad.Conexion.ObtenerConexionODBC());
                OdbcDataAdapter adap2 = new OdbcDataAdapter(cmd2);
                adap2.Fill(dt2);
                sal = Convert.ToDouble(dt2.Rows[0][0]);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sal = 0.00;
            }
            return sal;
            seguridad.Conexion.DesconectarODBC();
        }
        public int Validar_IGSS(String empresa)
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcCommand cmd = new OdbcCommand("select count(id_empleado_pk) from empleado where id_empresa_pk='" + empresa + "'", seguridad.Conexion.ObtenerConexionODBC());
                OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
                adap.Fill(dt);
                int numero = Convert.ToInt32(dt.Rows[0][0]);
                return numero;
            }
            catch
            {
                return 0;
            }
            seguridad.Conexion.DesconectarODBC();
        }

        public int Ejecutar_Mysql(string Query)
        {
            try
            {
                OdbcCommand MiComando = new OdbcCommand(Query, seguridad.Conexion.ObtenerConexionODBC());
                int FilasAfectadas = MiComando.ExecuteNonQuery();
                return 1;
             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            seguridad.Conexion.DesconectarODBC();
        }



        public string nombre_jornada(string id_empleado_pk)
        {
            string nombre_jornada2;
            try
            {
                OdbcCommand cmd = new OdbcCommand("select id_jornadatrabajo_pk from empleado where id_empleado_pk = '" + id_empleado_pk + "'", seguridad.Conexion.ObtenerConexionODBC());
                cmd.CommandType = CommandType.StoredProcedure;
                OdbcDataAdapter da = new OdbcDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                int resultado = Convert.ToInt32(dt.Rows[0][0]);

                OdbcCommand cmd2 = new OdbcCommand("select nombre_jornada from emp_jornadatrabajo where id_jornadatrabajo_pk= '" + resultado + "'", seguridad.Conexion.ObtenerConexionODBC());
                cmd2.CommandType = CommandType.StoredProcedure;
                OdbcDataAdapter dat = new OdbcDataAdapter();
                DataTable dtt = new DataTable();
                dat.SelectCommand = cmd2;
                dat.Fill(dtt);
                nombre_jornada2 = Convert.ToString(dtt.Rows[0][0]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                nombre_jornada2 = null;
            }
            return nombre_jornada2;
            seguridad.Conexion.DesconectarODBC();
        }


        public DataTable CalculoIGSS(string id_empleado, Double sueldo)
        {
            // string laboral;
            DataTable op = new DataTable();
            op.Columns.Add("Col1");
            op.Columns.Add("Col2");
            try
            {
                DataTable por = new DataTable();
                OdbcCommand Porcentajes = new OdbcCommand("select porcentaje_igss_laboral,porcentaje_igss_patronal from planilla_igss where id_planilla_igss_pk='1';", seguridad.Conexion.ObtenerConexionODBC());
                OdbcDataAdapter ad = new OdbcDataAdapter(Porcentajes);
                ad.Fill(por);
                Double labo = Convert.ToDouble(por.Rows[0][0]);
                Double patro = Convert.ToDouble(por.Rows[0][1]);
                Double cal_labo = sueldo * (labo / 100);
                Double cal_patro = sueldo * (patro / 100);
                DataRow p = op.NewRow();
                p[0] = Convert.ToString(cal_labo);
                p[1] = Convert.ToString(cal_patro);
                op.Rows.Add(p);

                // laboral = Convert.ToString(labo) +"% "+Convert.ToString(patro)+"sueldo"+Convert.ToString(sueldo)+" Laboral="+Convert.ToString(cal_labo)+"Patronal="+Convert.ToString(cal_patro);
            }
            catch
            {
                // laboral = "";
            }
            return op;
            seguridad.Conexion.DesconectarODBC();
        }

        public string fecha_inicial_empleados(string id_empleado)
        {
            string id_emp;
            try
            {
                DataTable dt = new DataTable();
                String query = "select fecha_de_alta_emp from empleado where id_empleado_pk='" + id_empleado + "'";
                OdbcCommand cmd = new OdbcCommand(query, seguridad.Conexion.ObtenerConexionODBC());
                OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
                adap.Fill(dt);
                id_emp = Convert.ToString(dt.Rows[0][0]);


            }
            catch (Exception ex)
            {
                id_emp = "error";
            }
            return id_emp;
            seguridad.Conexion.DesconectarODBC();
        }
        public int PorcentajeSeguroSocial(int Renta_imponible)
        {
            try
            {
                OdbcCommand cmd = new OdbcCommand("select porcentaje,minimo_sueldo,maximo_sueldo from tasa_impuesto", seguridad.Conexion.ObtenerConexionODBC());
                DataTable dt = new DataTable();
                OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
                adp.Fill(dt);
                int p;
                foreach (DataRow row in dt.Rows)
                {
                    int mini = Convert.ToInt32(row[1]);
                    int maxi = Convert.ToInt32(row[2]);
                    if (Renta_imponible >= mini && Renta_imponible < maxi)
                    {
                        p = Convert.ToInt32(row[0]);
                        return p;
                    }
                }
                return 31;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            seguridad.Conexion.DesconectarODBC();
        }
        public void llenar_cbo_horas_extra(ComboBox cb)
        {

            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd;
                DataTable dt = new DataTable();

                cmd = new OdbcCommand("select descripcion, porcentaje from tasa_hora_extra where estado='ACTIVO'", con);
                OdbcDataAdapter adaptador = new OdbcDataAdapter(cmd);
                adaptador.Fill(dt);

                cb.DataSource = dt;
                cb.DisplayMember = "descripcion";
                cb.ValueMember = "porcentaje";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            seguridad.Conexion.DesconectarODBC();
        }

        public double comision(string fecha_inicio, string fecha_fin, string id_empleado)
        {
            double resultado;
            try
            {
                OdbcCommand cmd = new OdbcCommand("call comision('" + fecha_inicio + "','" + fecha_fin + "','" + id_empleado + "')", seguridad.Conexion.ObtenerConexionODBC());
                cmd.CommandType = CommandType.StoredProcedure;
                OdbcDataAdapter da = new OdbcDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                resultado = Convert.ToDouble(dt.Rows[0][0]);


            }
            catch
            {
                resultado = 0;
            }
            return resultado;
            seguridad.Conexion.DesconectarODBC();
        }

        public double calculo_extra(string fecha_inicio, string fecha_fin, string id_empleado, string calculo_Extra)
        {
            double resultado;
            try
            {
                OdbcCommand cmd = new OdbcCommand("select sum(cantidad_devengado) as TOTAL from devengos where id_empleado_pk= '"+id_empleado+"' and fecha between '"+fecha_inicio+"' and '"+fecha_fin+"' and nombre_devengo = '"+calculo_Extra+"'", seguridad.Conexion.ObtenerConexionODBC());
                OdbcDataAdapter da = new OdbcDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                resultado = Convert.ToDouble(dt.Rows[0][0]);

            }
            catch
            {
                resultado = 0;
            }
            return resultado;
            seguridad.Conexion.DesconectarODBC();
        }
        public double deduccion_extra(string fecha_inicio, string fecha_fin, string id_empleado, string horas_descontadas)
        {
            double resultado;
            try
            {
                OdbcCommand cmd = new OdbcCommand("select sum(cantidad_deduccion) as TOTAL from deducciones where id_empleado_pk= '" + id_empleado + "' and fecha between '" + fecha_inicio + "' and '" + fecha_fin + "' and nombre_deduccion = '" + horas_descontadas + "'", seguridad.Conexion.ObtenerConexionODBC());
                OdbcDataAdapter da = new OdbcDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                resultado = Convert.ToDouble(dt.Rows[0][0]);

            }
            catch
            {
                resultado = 0;
            }
            return resultado;
            seguridad.Conexion.DesconectarODBC();
        }

        public int validar_nomina(string fecha_inicio, string fecha_fin, string id_empresa)
        {
            int resultado;
            try
            {
                OdbcCommand cmd = new OdbcCommand("call validar_nomina('"+fecha_inicio+"','"+fecha_fin+"','"+id_empresa+"');", seguridad.Conexion.ObtenerConexionODBC());
                cmd.CommandType = CommandType.StoredProcedure;
                OdbcDataAdapter da = new OdbcDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                resultado = Convert.ToInt32(dt.Rows[0][0]);


            }
            catch
            {
                resultado = 0;
            }
            return resultado;
            seguridad.Conexion.DesconectarODBC();
        }
    


        public int procedimiento_dias(string fecha_inicio, string fecha_hoy)
        {
            int resultado;
            try
            {
                OdbcCommand cmd = new OdbcCommand("select timestampdiff(DAY,'"+fecha_inicio+"','"+fecha_hoy+"');", seguridad.Conexion.ObtenerConexionODBC());
                OdbcDataAdapter da = new OdbcDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                resultado = Convert.ToInt32(dt.Rows[0][0]);
                
            }
            catch
            {
                resultado = 0;
            }
            return resultado;
            seguridad.Conexion.DesconectarODBC();
        }

     
    }
    
  
   
   
}
