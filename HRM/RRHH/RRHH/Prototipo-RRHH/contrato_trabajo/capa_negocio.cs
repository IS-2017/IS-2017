using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contrato_trabajo
{
    class capa_negocio
    {
        capa_datos ca = new capa_datos();
        public void InsertarTasa(string mini, string max, string por)
        {
            int resultado = ca.Ejecutar_Mysql("insert into tasa_impuesto(id_tasa_pk,minimo_sueldo,maximo_sueldo,porcentaje,estado) values (null,'" + mini + "','" + max + "','" + por + "','ACTIVO');");

            if (resultado > 0)
            {
                MessageBox.Show("Insertado con exito");

            }
            else
            {
                MessageBox.Show("Error de Insercion");
            }
        }

        public void ModificarTasa(string id, string mini, string max, string por)
        {
            int resultado = ca.Ejecutar_Mysql("update tasa_impuesto set minimo_sueldo='" + mini + "'maximo_sueldo='" + max + "',porcentaje='" + por + "' where id_tasa_pk='" + id + "';");
            if (resultado > 0)
            {
                MessageBox.Show("Modificacion Exitosa");
            }
            else
            {
                MessageBox.Show("Error en modificacion");
            }
          
        }

        public void eliminarTasa(string id)
        {
            int resultado = ca.Ejecutar_Mysql("update tasa_impuesto set estado='INACTIVO' where id_tasa_pk ='" + id + "';");
            if (resultado > 0)
            {
                MessageBox.Show("Eliminacion Exitosa");
            }
            else
            {
                MessageBox.Show("Error en eliminacion");
            }
        }
        public void InsertarHora(string des, string por)
        {
            int resultado = ca.Ejecutar_Mysql("insert into tasa_hora_extra(id_hora_pk,descripcion,porcentaje,estado) values (null,'" + des + "','" + por + "','ACTIVO');");

            if (resultado > 0)
            {
                MessageBox.Show("Insertado con exito");

            }
            else
            {
                MessageBox.Show("Error de Insercion");
            }
        }

        public void ModificarHora(string id, string des, string por)
        {
            int resultado = ca.Ejecutar_Mysql("update tasa_hora_extra set nombre_impuesto='" + des + "',porcentaje='" + por + "' where id_hora_pk='" + id + "';");
            if (resultado > 0)
            {
                MessageBox.Show("Modificacion Exitosa");
            }
            else
            {
                MessageBox.Show("Error en modificacion");
            }
        }

        public void eliminarHora(string id)
        {
            int resultado = ca.Ejecutar_Mysql("update tasa_hora_extra set estado='INACTIVO' where id_hora_pk ='" + id + "';");
            if (resultado > 0)
            {
                MessageBox.Show("Eliminacion Exitosa");
            }
            else
            {
                MessageBox.Show("Error en eliminacion");
            }
        }

        public void InsertarSocial(string p_l, string p_p, string fe, string emp)
        {
            int resultado = ca.Ejecutar_Mysql("insert into planilla_igss values (null,'" + p_l + "','" + p_p + "','"+fe+"','ACTIVO','"+emp+"');");

            if (resultado > 0)
            {
                MessageBox.Show("Insertado con exito");

            }
            else
            {
                MessageBox.Show("Error de Insercion");
            }
        }

        public void ModificarSocial(string id, string p_l, string p_p,string f, string emp)
        {
            int resultado = ca.Ejecutar_Mysql("update planilla_igss set porcentaje_igss_laboral='" + p_l+ "',porcentaje_igss_patronal='" + p_p + "',fecha='"+f+"',id_empresa_pk='"+emp+"' where id_planilla_igss_pk='" + id + "';");
            if (resultado > 0)
            {
                MessageBox.Show("Modificacion Exitosa");
            }
            else
            {
                MessageBox.Show("Error en modificacion");
            }
        }

        public void eliminarSocial(string id)
        {
            int resultado = ca.Ejecutar_Mysql("update planilla_igss set estado='INACTIVO' where id_planilla_igss_pk ='" + id + "';");
            if (resultado > 0)
            {
                MessageBox.Show("Eliminacion Exitosa");
            }
            else
            {
                MessageBox.Show("Error en eliminacion");
            }
        }
        public void ingresar_contrato(string fecha_inicio, string fecha_fin, string puesto, string salario, string bonificacion, string periodo_pago, string estado, string id_empleado_pk, string jornada, string dato_personal, string id_Empresa)
        {
            int resultado = ca.Ejecutar_Mysql("insert into contrato (id_contrato_pk,fecha_inicio_servicio_empleado, fecha_fin_servicio_empleado, puesto_ocupa_empleado, salario_base_empleado, bonificacion_empleado, periodo_pago_empleado, estado, id_empleado_pk, id_jornadatrabajo_pk, id_datopersonal, id_empresa_pk)values (null,'" + fecha_inicio + "','" + fecha_fin + "','" + puesto + "','" + salario + "','" + bonificacion + "','" + periodo_pago + "','" + estado + "','" + id_empleado_pk + "','" + jornada + "','" + dato_personal + "','" + id_Empresa + "');");
            if (resultado > 0)
            {
               // MessageBox.Show("Contrato Ingresado con Exito");
            }
            else
            {
                MessageBox.Show("Error al insertar contrato ");
            }
        }
        public void actualizar_empleado_estado(string id_empleado_pk)
        {
            int resultado = ca.Ejecutar_Mysql("update empleado set estadolaboral = 'ALTA' where id_empleado_pk = '" + id_empleado_pk + "';");
           
        }
    }
}
