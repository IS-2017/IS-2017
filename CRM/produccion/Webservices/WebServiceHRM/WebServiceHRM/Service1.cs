using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Odbc;

namespace WebServiceHRM
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public DataSet ObtenerCobrador()
        {
            DataSet ds2 = new DataSet();
            DataTable dt2 = new DataTable();
            Conexionmysql.ObtenerConexion();
            String Query = "SELECT e.id_empleado_pk, e.dpi_emp, e.no_afiliacionIGSS_emp, e.estadolaboral, e.fecha_de_alta_emp, e.fecha_de_baja_emp, e.nombre_emp, e.apellido_emp, e.telefono_hogar_emp, e.telefono_movil_emp, e.fotografia_emp, e.direccion_emp, e.nacionalidad_emp, e.periodo_pago, e.estado, e.id_empresa_pk, e.id_jornadatrabajo_pk, e.id_puesto_laboral_pk, e.id_area_trabajo_pk, e.porcentaje FROM empleado e, puesto_laboral p WHERE (P.nombre_puesto = 'COBRADOR') AND e.id_puesto_laboral_pk = p.id_puesto_laboral_pk ORDER BY e.id_empleado_pk";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            dad.Fill(dt2);
            ds2.Tables.Add(dt2);
            Conexionmysql.Desconectar();
            return ds2;
        }

        public DataSet ObtenerEmpleados()
        {
            DataSet ds1 = new DataSet();
            DataTable dt1 = new DataTable();
            Conexionmysql.ObtenerConexion();
            String Query = "SELECT e.id_empleado_pk, e.dpi_emp, e.no_afiliacionIGSS_emp, e.estadolaboral, e.fecha_de_alta_emp, e.fecha_de_baja_emp, CONCAT(e.nombre_emp,' ', e.apellido_emp) as NOMBRE, e.telefono_hogar_emp, e.telefono_movil_emp, e.fotografia_emp, e.direccion_emp, e.nacionalidad_emp, e.periodo_pago, e.estado, e.id_empresa_pk, e.id_jornadatrabajo_pk, e.id_puesto_laboral_pk, e.id_area_trabajo_pk, e.porcentaje FROM empleado e, puesto_laboral p WHERE (P.nombre_puesto = 'VENDEDOR') AND e.id_puesto_laboral_pk = p.id_puesto_laboral_pk ORDER BY e.id_empleado_pk";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            dad.Fill(dt1);
            ds1.Tables.Add(dt1);
            Conexionmysql.Desconectar();
            return ds1;
        }
    }
}
