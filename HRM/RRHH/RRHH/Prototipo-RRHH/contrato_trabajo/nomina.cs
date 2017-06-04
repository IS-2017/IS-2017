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
using System.Data.Odbc;

namespace contrato_trabajo
{
    public partial class nomina : Form
    {
        public nomina()
        {
            InitializeComponent();
        }
        capa_datos ca = new capa_datos();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Nominas_Enter(object sender, EventArgs e)
        {

        }

        private void nomina_Load(object sender, EventArgs e)
        {
            ca.llenar_id_empresa(cbo_empresa);
            cbo_empresa.SelectedIndex = -1;
            

        }

        void empresa()
        {
            try
            {
                DataTable dt = ca.cargar("select id_empleado_pk, nombre_emp, apellido_emp from empleado where fecha_de_alta_emp < '" + dtp_hasta.Value.ToString("yyyy-MM-dd") + "' and id_empresa_pk = '" + cbo_empresa.SelectedValue.ToString() + "' order by id_empleado_pk;");
                int cont = 0;
                foreach (DataRow row in dt.Rows)
                {
                    dgv_nonimas.Rows.Add(1);
                    String id_empleado = row[0].ToString();
                    String nombre_empleado = row[1].ToString();
                    String apellido_empleado = row[2].ToString();
                    dgv_nonimas.Rows[cont].Cells[0].Value = cbo_empresa.SelectedValue.ToString();
                    dgv_nonimas.Rows[cont].Cells[1].Value = id_empleado;
                    dgv_nonimas.Rows[cont].Cells[2].Value = nombre_empleado;
                    dgv_nonimas.Rows[cont].Cells[3].Value = apellido_empleado;
                    cont++;
                }
                conexion.DesconectarConexion();

            }
            catch
            {
                MessageBox.Show("Debe seleccionar una empresa");
            }
        }

        public void validar_repetidos()
        {
            int id;

            OdbcDataReader consultar2;
            OdbcCommand comando = new OdbcCommand();
            comando.Connection = seguridad.Conexion.ObtenerConexionODBC();
            comando.CommandText = "select id_empleado_pk from nomina where fecha_inicio_pago between '"+dtp_desde.Value.ToString("yyyy-MM-dd")+"' and '"+dtp_hasta.Value.ToString("yyyy-MM-dd")+"'and estado != 'inactivo' order by id_empleado_pk; ";
            consultar2 = comando.ExecuteReader();
            while (consultar2.Read())
            {

                id = consultar2.GetInt32(0);
                for (int fila = 0; fila < dgv_nonimas.RowCount ; fila++)
                {
                    if (Convert.ToInt32(dgv_nonimas.Rows[fila].Cells[1].Value) == id)
                    {
                        int fil = dgv_nonimas.CurrentRow.Index;
                        dgv_nonimas.Rows.RemoveAt(fil);
                    }
                }
            }

        }

        void sueldo_base()
        {
            try
            {
                int cont = 0;

                for (int fila = 0; fila < dgv_nonimas.RowCount; fila++)
                {
                    string id_empleado = Convert.ToString(dgv_nonimas.Rows[fila].Cells[1].Value);
                    string fecha_inicio = ca.fecha_inicial_empleados(id_empleado);
                    string fecha_fin = dtp_hasta.Value.ToString("yyyy-MM-dd");
                    int x = ca.procedimiento_dias(fecha_inicio, fecha_fin); //si es el primer mes o no 
                    int y = ca.procedimiento_dias(dtp_desde.Value.ToString("yyyy-MM-dd"), dtp_hasta.Value.ToString("yyyy-MM-dd"));
                    double salario_base = ca.ObtenerSueldo(id_empleado);
                    double salario_diario = salario_base / 30;
                    double salario_diario_redondeado = Math.Round(salario_diario, 2);
                    //  MessageBox.Show(x + " " + salario_base + "  " + fecha_inicio + "  "+ salario_diario_redondeado);


                    if (x < y)
                    {
                        double cantidad_pago = salario_diario_redondeado * x;

                        dgv_nonimas.Rows[cont].Cells[4].Value = cantidad_pago.ToString();
                        dgv_nonimas.Rows[cont].Cells[20].Value = x;
                        
                    }
                    else
                    {
                        double cantidad_pagar = y * salario_diario_redondeado;
                        dgv_nonimas.Rows[cont].Cells[4].Value = cantidad_pagar.ToString();         ////// SUELDO BASE
                        dgv_nonimas.Rows[cont].Cells[20].Value = y;
                    } 
                    cont++;
                }
                conexion.DesconectarConexion();
            }
            catch
            {

            }
        }

        void bonificacion()
        {
            try
            {
                int cont = 0;
                for (int fila = 0; fila < dgv_nonimas.RowCount; fila++)
                {
                    DataTable dt = ca.cargar("select valor from bonificacion where id_bono_pk= '1';");
                    string bono = dt.Rows[0][0].ToString();
                    dgv_nonimas.Rows[cont].Cells[5].Value = bono;                                  //////// BONIFICACIÓN
                    cont++;
                }
                conexion.DesconectarConexion();
            }
            catch
            {

            }
        }
        void comision()
        {
            try
            {
                int cont = 0;
                for (int fila = 0; fila < dgv_nonimas.RowCount; fila++)
                {
                    string id_empleado = Convert.ToString(dgv_nonimas.Rows[fila].Cells[1].Value);
                    double comision = ca.comision(dtp_desde.Value.ToString("yyyy-MM-dd"), dtp_hasta.Value.ToString("yyyy-MM-dd"), id_empleado);    ///////// COMISION 
                    dgv_nonimas.Rows[cont].Cells[6].Value = comision.ToString();
                    cont++;
                }
                conexion.DesconectarConexion();
            }
            catch
            {

            }
        }
        void igss()
        {
            try
            {
                int cont = 0;

                for (int fila = 0; fila < dgv_nonimas.RowCount; fila++)
                {
                    string id_empleado = Convert.ToString(dgv_nonimas.Rows[cont].Cells[1].Value);
                    double sueldo_base = Convert.ToDouble(dgv_nonimas.Rows[cont].Cells[4].Value);
                    DataTable dt = ca.CalculoIGSS(id_empleado, sueldo_base);
                    Double igss_laboral = Convert.ToDouble(dt.Rows[0][0]);
                    Double igss_laboral_redondeado = Math.Round(igss_laboral, 2);
                    Double igss_patronal = Convert.ToDouble(dt.Rows[0][1]);
                    Double igss_patronal_redondeado = Math.Round(igss_patronal, 2);                                                             /////////IGSS
                    dgv_nonimas.Rows[cont].Cells[10].Value = igss_laboral_redondeado.ToString();
                    dgv_nonimas.Rows[cont].Cells[11].Value = igss_patronal_redondeado.ToString();
                    cont++;
                }
                conexion.DesconectarConexion();
            }

            catch
            {

            }
        }
        void CalculoSocial()
        {
            try
            {
                int cont = 0;

                for (int fila = 0; fila < dgv_nonimas.RowCount; fila++)
                {
                    string id_empleado = Convert.ToString(dgv_nonimas.Rows[fila].Cells[1].Value);
                    double salario_base = ca.ObtenerSueldo(id_empleado);
                    double sal_anual = (salario_base + bonoIn) * 12;
                    double aguinaldo = salario_base;
                    double bono = salario_base;
                    double total_devengo = sal_anual + aguinaldo + bono;
                    if ((salario_base + 250) >= 6126)
                    {                                                                                                                        /////ISR
                        DataTable dt = ca.CalculoIGSS(id_empleado, salario_base);
                        double igss = Convert.ToDouble(dt.Rows[0][0]);
                        double igss_anual = igss * 12;
                        double deduccion_total = aguinaldo + bono + deduccion_legal + igss_anual;

                        double renta_imponible = total_devengo - deduccion_total;
                        int p = ca.PorcentajeSeguroSocial(Convert.ToInt32(renta_imponible));
                        double iva = (ivaPorcentaje * total_devengo) * descuentoIva;
                        //MessageBox.Show(renta_imponible.ToString());
                        double calc = renta_imponible * (Convert.ToDouble(p) / 100);
                        double renta_anual = calc - iva;
                        double renta_mensual = renta_anual / 12;
                        double renta_mensual_redondeado = Math.Round(renta_mensual, 2);
                        //MessageBox.Show("devengo=" + total_devengo.ToString() + " deduccion=" + deduccion_total.ToString()+" iva="+iva+" renta="+renta_anual.ToString()+" anual="+calc.ToString());
                        dgv_nonimas.Rows[cont].Cells[12].Value = renta_mensual_redondeado.ToString();
                    }
                    else
                    {
                        dgv_nonimas.Rows[cont].Cells[12].Value = 0;
                    }
                    //MessageBox.Show(total_devengo.ToString() + " " + sal_anual.ToString());
                    cont++;
                }
                conexion.DesconectarConexion();
            }
            catch
            {

            }


        }
        void horas_extra()
        {
            try
            {
                int cont = 0;

                for (int fila = 0; fila < dgv_nonimas.RowCount; fila++)                                                         ///////  HORAS EXTRA
                {
                    string id_empleado = Convert.ToString(dgv_nonimas.Rows[fila].Cells[1].Value);
                    double calculo_extra = ca.calculo_extra(dtp_desde.Value.ToString("yyyy-MM-dd"), dtp_hasta.Value.ToString("yyyy-MM-dd"), id_empleado, "horas extra");

                    dgv_nonimas.Rows[cont].Cells[7].Value = calculo_extra.ToString();

                    cont++;
                }
            }
            catch
            {

            }
        }

        void devengos_extra()
        {
            try
            {
                int cont = 0;

                for (int fila = 0; fila < dgv_nonimas.RowCount; fila++)                                                        /////DEVENGO EXTRA
                {
                    string id_empleado = Convert.ToString(dgv_nonimas.Rows[fila].Cells[1].Value);
                    double calculo_extra = ca.calculo_extra(dtp_desde.Value.ToString("yyyy-MM-dd"), dtp_hasta.Value.ToString("yyyy-MM-dd"), id_empleado, "devengo extra");

                    dgv_nonimas.Rows[cont].Cells[8].Value = calculo_extra.ToString();
               
                cont++;
            }
        }
            catch
            {

            }
}
        void deduccion_extra()
        {
            try
            {
                int cont = 0;
                                                                                            //////DEDUCCION EXTRA
                for (int fila = 0; fila < dgv_nonimas.RowCount; fila++)
                {
                    string id_empleado = Convert.ToString(dgv_nonimas.Rows[fila].Cells[1].Value);
                    double deduccion_extra = ca.deduccion_extra(dtp_desde.Value.ToString("yyyy-MM-dd"), dtp_hasta.Value.ToString("yyyy-MM-dd"), id_empleado, "deduccion extra");

                    dgv_nonimas.Rows[cont].Cells[13].Value = deduccion_extra.ToString();

                    cont++;
                }
            }
            catch
            {

            }
        }

        void igss_2()
        {
            try
            {
                int cont = 0;

                for (int fila = 0; fila < dgv_nonimas.RowCount; fila++)
                {
                   

                    dgv_nonimas.Rows[cont].Cells[10].Value = 0;

                    cont++;
                }
            }
            catch
            {

            }
        }
        void sumar_devengos()
        {
            try                                           ///// SUMA DEVENGOS
            {
                int cont = 0;
                double suma_devengos = 0;
                for (int fila = 0; fila < dgv_nonimas.RowCount; fila++)
                {
                    double devengos = Convert.ToDouble(dgv_nonimas.Rows[cont].Cells[4].Value) + Convert.ToDouble(dgv_nonimas.Rows[cont].Cells[5].Value) + Convert.ToDouble(dgv_nonimas.Rows[cont].Cells[6].Value) + Convert.ToDouble(dgv_nonimas.Rows[cont].Cells[7].Value)+ Convert.ToDouble(dgv_nonimas.Rows[cont].Cells[8].Value);
                    dgv_nonimas.Rows[cont].Cells[9].Value = devengos;
                    suma_devengos += devengos;
                    cont++;
                }
                txt_totaldevengos.Text = Convert.ToString(suma_devengos);
            }
            catch
            {

            }
        }

        void horas_descontadas()
        {
            try
            {
                int cont = 0;
                //////DEDUCCION EXTRA
                for (int fila = 0; fila < dgv_nonimas.RowCount; fila++)
                {
                    string id_empleado = Convert.ToString(dgv_nonimas.Rows[fila].Cells[1].Value);
                    double deduccion_extra = ca.deduccion_extra(dtp_desde.Value.ToString("yyyy-MM-dd"), dtp_hasta.Value.ToString("yyyy-MM-dd"), id_empleado, "horas descontadas");

                    dgv_nonimas.Rows[cont].Cells[14].Value = deduccion_extra.ToString();

                    cont++;
                }
            }
            catch
            {

            }
        }

        void sumar_deducciones()
        {
            try
            {
                int cont = 0;
                double suma_deducciones = 0;
                for (int fila = 0; fila < dgv_nonimas.RowCount; fila++)
                {
                    double deducciones = Convert.ToDouble(dgv_nonimas.Rows[cont].Cells[10].Value) + Convert.ToDouble(dgv_nonimas.Rows[cont].Cells[12].Value) + Convert.ToDouble(dgv_nonimas.Rows[cont].Cells[13].Value) + Convert.ToDouble(dgv_nonimas.Rows[cont].Cells[14].Value);
                    dgv_nonimas.Rows[cont].Cells[18].Value = deducciones;
                    suma_deducciones += deducciones;
                    cont++;
                }
                txt_totaldeducciones.Text = suma_deducciones.ToString();
            }
            catch
            {

            }
        }
        void suma_totales()
        {
            try
            {
                int cont = 0;
                double total_total = 0;
                for (int fila = 0; fila < dgv_nonimas.RowCount; fila++)
                {

                    double total = Convert.ToDouble(dgv_nonimas.Rows[cont].Cells[9].Value) - Convert.ToDouble(dgv_nonimas.Rows[cont].Cells[18].Value);
                    dgv_nonimas.Rows[cont].Cells[19].Value = total;
                    total_total += total;
                    cont++;
                }
                txt_total.Text = total_total.ToString();
            }
            catch
            {

            }
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_nonimas.Rows.Clear();
                dgv_nonimas.Refresh();
                empresa();
                validar_repetidos();
                sueldo_base();
                bonificacion();
                devengos_extra();
                deduccion_extra();
                comision();
                horas_extra();
                sumar_devengos();
                horas_descontadas();
                int cant = ca.Validar_IGSS(cbo_empresa.SelectedValue.ToString());
                if (cant >= 3)
                {
                    igss();
                }
                else
                {

                    igss_2();
                }
                CalculoSocial();
                sumar_deducciones();
                suma_totales();
               
            }
            catch
            {
                
            }
        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_nonimas);
        }
        double ivaPorcentaje = .50;
        double descuentoIva = .12;
        double bonoIn = 250;
        double deduccion_legal = 36000.00;

       

        

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_nonimas.Rows.Count == 0)
                {
                    MessageBox.Show("Debe generar nominas antes jejej");
                }
                else
                {
                    string fechainicio = dtp_desde.Value.ToString("yyyy-MM-dd");
                    string fechafin = dtp_hasta.Value.ToString("yyyy-MM-dd");
                    string fecha_hoy = DateTime.Today.ToString("yyyy-MM-dd");
                    int resultado = ca.validar_nomina(fechainicio, fechafin, cbo_empresa.SelectedValue.ToString());
                    string descripcion = "nóminas";
                    string estado = "procesada";
                    string nombre_bono = "bonificacion";
                    string nombre_ISR = "ISR";
                    string nombre_IGSS_laboral = "IGSS laboral";
                    string nombre_comision = "comision";
                    string nombre_horas_extra = "horas extra";
                    string nombre_devengo_extra = "devengo extra";
                    string nombre_deduccion_extra = "deduccion extra";
                    string nombre_estado = "ACTIVO";

                    if (resultado == 1)
                    {
                        MessageBox.Show("Ya existe una nomina para ese rango de fechas");
                    }
                    else
                    {
                        for (int fila = 0; fila < dgv_nonimas.RowCount; fila++)
                        {
                            string id_empresa = Convert.ToString(dgv_nonimas.Rows[fila].Cells[0].Value);
                            string id_empleado = Convert.ToString(dgv_nonimas.Rows[fila].Cells[1].Value);
                            string sueldo_base = Convert.ToString(dgv_nonimas.Rows[fila].Cells[4].Value); //SUELDO BASE
                            DataTable dt = ca.cargar("select id_area_trabajo_pk from empleado where id_empleado_pk = '" + id_empleado + "';");
                            string area = dt.Rows[0][0].ToString();
                            string fecha_inicio = ca.fecha_inicial_empleados(id_empleado); // FECHA INICIO EMPLEADO
                            int dias_trabajados = ca.procedimiento_dias(fechainicio, fechafin);
                            int dias = ca.procedimiento_dias(fechainicio, fechafin);


                            // para determinar cuantos dias trabajados tiene el empleado
                            int dias_nomina;
                            if (dias_trabajados >= dias)
                            {
                                dias_nomina = dias;
                            }
                            else
                            {
                                dias_nomina = dias_trabajados;
                            }

                            string bonificacion = Convert.ToString(dgv_nonimas.Rows[fila].Cells[5].Value);
                            string comision = Convert.ToString(dgv_nonimas.Rows[fila].Cells[6].Value);
                            string igss = Convert.ToString(dgv_nonimas.Rows[fila].Cells[10].Value);
                            string igss_patronal = Convert.ToString(dgv_nonimas.Rows[fila].Cells[11].Value);
                            string ISR = Convert.ToString(dgv_nonimas.Rows[fila].Cells[12].Value);
                            string horas_extra = Convert.ToString(dgv_nonimas.Rows[fila].Cells[7].Value);
                            string devengo_extra = Convert.ToString(dgv_nonimas.Rows[fila].Cells[8].Value);
                            string descuento_extra = Convert.ToString(dgv_nonimas.Rows[fila].Cells[13].Value);
                            string can_horas_extra = Convert.ToString(dgv_nonimas.Rows[fila].Cells[15].Value);
                            string horas_descontadas = Convert.ToString(dgv_nonimas.Rows[fila].Cells[14].Value);
                            string total_por_fila = Convert.ToString(dgv_nonimas.Rows[fila].Cells[19].Value);

                            ca.Ejecutar_Mysql("insert into nomina (id_nomina_pk, descripcion, fecha_inicio_pago, fecha_fin_pago,dias_trabajados_mes, sueldo_base, total, estado, id_empleado_pk,id_empresa_pk,id_area_trabajo_pk ) values (null, '" + descripcion + "','" + fechainicio + "','" + fechafin + "','" + dias_nomina + "','" + sueldo_base + "','" + total_por_fila + "','" + estado + "','" + id_empleado + "','" + id_empresa + "','" + area + "');");
                            DataTable dtt = ca.cargar("select max(id_nomina_pk)from nomina;");
                            string ultima_nomina = dtt.Rows[0][0].ToString();


                            if (bonificacion == "0" || bonificacion == null) { }
                            else
                            {
                                ca.Ejecutar_Mysql("insert into devengos (id_devengo_pk, fecha, nombre_devengo, cantidad_devengado, estado) values (null,'" + fecha_hoy + "','" + nombre_bono + "','" + bonificacion + "','" + nombre_estado + "');");
                                DataTable dt_id_devengo = ca.cargar("select max(id_devengo_pk) from devengos;");
                                string ultimo_id_devengo = dt_id_devengo.Rows[0][0].ToString();
                                string nombre = "bonificacion";
                                ca.Ejecutar_Mysql("insert into detalle_nomina(id_detalle_nomina_pk,nombre, total_a_pagar, estado, id_nomina_pk,id_devengo_pk) values (null,'" + nombre + "','" + bonificacion + "','" + nombre_estado + "','" + ultima_nomina + "','" + ultimo_id_devengo + "');");
                                conexion.DesconectarConexion();
                            }

                            if (comision == "0" || comision == null) { }
                            else
                            {
                                ca.Ejecutar_Mysql("insert into devengos (id_devengo_pk, fecha, nombre_devengo, cantidad_devengado, estado) values (null,'" + fecha_hoy + "','" + nombre_comision + "','" + comision + "','" + nombre_estado + "');");
                                DataTable dt_id_devengo = ca.cargar("select max(id_devengo_pk) from devengos;");
                                string ultimo_id_devengo_comision = dt_id_devengo.Rows[0][0].ToString();
                                string nombre = "comision";
                                ca.Ejecutar_Mysql("insert into detalle_nomina(id_detalle_nomina_pk,nombre, total_a_pagar, estado, id_nomina_pk,id_devengo_pk) values (null,'" + nombre + "','" + comision + "','" + nombre_estado + "','" + ultima_nomina + "','" + ultimo_id_devengo_comision + "');");
                                conexion.DesconectarConexion();
                            }
                            if (igss == "0" || igss == null) { }
                            else
                            {
                                ca.Ejecutar_Mysql("insert into detalle_igss (id_detalle_igss_pk, id_empleado_pk,sueldo_base, iggs_a_pagar_laboral, iggs_a_pagar_patronal,estado , fecha) values (null,'" + id_empleado + "','" + sueldo_base + "','" + igss + "','" + igss_patronal + "','" + nombre_estado + "','" + fecha_hoy + "');");

                                DataTable dt_id_igss = ca.cargar("select max(id_detalle_igss_pk) from detalle_igss;");
                                string ultimo_id_igss = dt_id_igss.Rows[0][0].ToString();
                                string nombre = "igss";
                                ca.Ejecutar_Mysql("insert into deducciones (id_deduccion_pk, fecha, nombre_deduccion, cantidad_deduccion, estado, id_empleado_pk,id_detalle_igss_pk) values (null,'" + fecha_hoy + "','" + nombre_IGSS_laboral + "','" + igss + "','" + nombre_estado + "','" + id_empleado + "','" + ultimo_id_igss + "');");
                                DataTable dt_id_deduccion = ca.cargar("select max(id_deduccion_pk) from deducciones;");
                                string ultimo_id_deduccion_igss = dt_id_deduccion.Rows[0][0].ToString();
                                ca.Ejecutar_Mysql("insert into detalle_nomina(id_detalle_nomina_pk, nombre, total_a_pagar, estado, id_nomina_pk,id_deduccion_pk) values (null,'" + nombre + "','" + igss + "','" + nombre_estado + "','" + ultima_nomina + "','" + ultimo_id_deduccion_igss + "');");
                                conexion.DesconectarConexion();
                            }

                            if (horas_extra == "0" || horas_extra == null) { }
                            else
                            {
                                string nombre = "horas extra";
                                ca.Ejecutar_Mysql("insert into detalle_nomina(id_detalle_nomina_pk, nombre, total_a_pagar, estado, id_nomina_pk) values (null,'" + nombre + "','" + horas_extra + "','" + nombre_estado + "','" + ultima_nomina + "');");
                                conexion.DesconectarConexion();
                            }
                            if (ISR == "0" || ISR == null) { }
                            else
                            {
                                string nombre = "isr";
                                ca.Ejecutar_Mysql("insert into deducciones (id_deduccion_pk,fecha, nombre_deduccion, cantidad_deduccion, estado, id_empleado_pk) values (null,'" + fecha_hoy + "','" + nombre_ISR + "','" + ISR + "','" + nombre_estado + "','" + id_empleado + "');");
                                DataTable dt_ultimo_descuento = ca.cargar("select max(id_deduccion_pk) from deducciones;");
                                string ultimo_id_descuento = dt_ultimo_descuento.Rows[0][0].ToString();
                                ca.Ejecutar_Mysql("insert into detalle_nomina(id_detalle_nomina_pk,nombre, total_a_pagar, estado, id_nomina_pk,id_deduccion_pk) values (null,'" + nombre + "','" + ISR + "','" + nombre_estado + "','" + ultima_nomina + "','" + ultimo_id_descuento + "');");
                                conexion.DesconectarConexion();
                            }

                            if (devengo_extra == "0" || devengo_extra == null) { }
                            else
                            {
                                string nombre = "devengo extra";
                                ca.Ejecutar_Mysql("insert into detalle_nomina(id_detalle_nomina_pk,nombre, total_a_pagar, estado, id_nomina_pk) values (null,'" + nombre + "','" + devengo_extra + "','" + nombre_estado + "','" + ultima_nomina + "');");
                                conexion.DesconectarConexion();
                            }
                            if (descuento_extra == "0" || descuento_extra == null) { }
                            else
                            {
                                string nombre = "deduccion extra";
                                ca.Ejecutar_Mysql("insert into detalle_nomina(id_detalle_nomina_pk, nombre, total_a_pagar, estado, id_nomina_pk) values (null,'" + nombre + "','" + descuento_extra + "','" + nombre_estado + "','" + ultima_nomina + "');");
                                conexion.DesconectarConexion();
                            }

                            if (horas_descontadas == "0" || horas_descontadas == null) { }
                            else
                            {
                                string nombre = "horas descontadas";
                                ca.Ejecutar_Mysql("insert into detalle_nomina(id_detalle_nomina_pk, nombre, total_a_pagar, estado, id_nomina_pk) values (null,'" + nombre + "','" + horas_descontadas + "','" + nombre_estado + "','" + ultima_nomina + "');");
                                conexion.DesconectarConexion();
                            }
                        }

                        conexion.DesconectarConexion();
                        MessageBox.Show("Calculo de nomina realizada con exito");

                    }
                }
            }
            catch
            {

            }
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
         
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }
    }
    }

