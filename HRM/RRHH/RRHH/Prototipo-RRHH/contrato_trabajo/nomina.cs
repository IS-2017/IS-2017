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
            btn_horas_extra.Enabled = false;
            btn_otros.Enabled = false;
           

        }

        void empresa()
        {
            try
            {
                DataTable dt = ca.cargar("select id_empleado_pk, nombre_emp, apellido_emp from empleado where id_empresa_pk = '" + cbo_empresa.SelectedValue.ToString() + "';");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    int y = ca.procedimiento_dias(dtp_desde.Value.ToString("yyyy-MM-dd"),dtp_hasta.Value.ToString("yyyy-MM-dd"));
                    double salario_base = ca.ObtenerSueldo(id_empleado);
                    double salario_diario = salario_base / 30;
                    double salario_diario_redondeado = Math.Round(salario_diario, 2);
                    //  MessageBox.Show(x + " " + salario_base + "  " + fecha_inicio + "  "+ salario_diario_redondeado);
                    if (x < y)
                    {
                        double cantidad_pago = salario_diario_redondeado * x;

                        dgv_nonimas.Rows[cont].Cells[4].Value = cantidad_pago.ToString();
                    }
                    else
                    {
                        double cantidad_pagar = y * salario_diario_redondeado;
                        dgv_nonimas.Rows[cont].Cells[4].Value = cantidad_pagar.ToString();
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
                    dgv_nonimas.Rows[cont].Cells[5].Value = bono;
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
                    double comision = ca.comision(dtp_desde.Value.ToString("yyyy-MM-dd"), dtp_hasta.Value.ToString("yyyy-MM-dd"), id_empleado);
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
                    Double igss_patronal = Convert.ToDouble(dt.Rows[0][1]);
                    dgv_nonimas.Rows[cont].Cells[7].Value = igss_laboral.ToString();
                    dgv_nonimas.Rows[cont].Cells[8].Value = igss_patronal.ToString();
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
                    if ((salario_base+250) >= 6126)
                    {
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
                        //MessageBox.Show("devengo=" + total_devengo.ToString() + " deduccion=" + deduccion_total.ToString()+" iva="+iva+" renta="+renta_anual.ToString()+" anual="+calc.ToString());
                        dgv_nonimas.Rows[cont].Cells[9].Value = renta_mensual.ToString();
                    }
                    else
                    {
                        dgv_nonimas.Rows[cont].Cells[9].Value = 0;
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

        
        private void Agregar_Click(object sender, EventArgs e)
        {
            dgv_nonimas.Rows.Clear();
            dgv_nonimas.Refresh();
            empresa();
            sueldo_base();
            bonificacion();
            comision();
            int cant = ca.Validar_IGSS(cbo_empresa.SelectedValue.ToString());
            if(cant>=3)
            {
                igss();
            }
            CalculoSocial();
            btn_horas_extra.Enabled = true;
            btn_otros.Enabled = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            frm_horas_extras frm = new frm_horas_extras();
            string id_empleado= Convert.ToString(dgv_nonimas.CurrentRow.Cells[1].Value);
            frm.txt_cod_empleado.Text = id_empleado;
            string nombre_jornada = ca.nombre_jornada(id_empleado);
            double sueldo =  ca.ObtenerSueldo(id_empleado);
            double precio_dia = sueldo / 30;


            if (nombre_jornada == "matutina")
            {
                double precio_hora_matutina = precio_dia / 8;
                double precio_aproximado_matutina = Math.Round(precio_hora_matutina, 2);
                frm.txt_precio_hora.Text = precio_aproximado_matutina.ToString();

            }
            if (nombre_jornada == "vespertina")
            {
                double precio_hora_vespertina = precio_dia / 6;
                double precio_aproximado_vespertina = Math.Round(precio_hora_vespertina, 2);
                frm.txt_precio_hora.Text = precio_aproximado_vespertina.ToString();
            }
            if (nombre_jornada == "mixta")
            {
                double precio_hora_mixta = precio_dia / 7;
                double precio_aproximado_mixta = Math.Round(precio_hora_mixta, 2);
                frm.txt_precio_hora.Text = precio_aproximado_mixta.ToString();

            }

            frm.Show();
            

        }

        private void btn_otros_Click(object sender, EventArgs e)
        {
            frm_Otros otros = new frm_Otros();
            otros.txt_id_empleado.Text = dgv_nonimas.CurrentRow.Cells[1].Value.ToString();
            otros.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string fechainicio = dtp_desde.Value.ToString("yyyy-MM-dd");
                string fechafin = dtp_hasta.Value.ToString("yyyy-MM-dd");
                string fecha_hoy = DateTime.Today.ToString("yyyy-MM-dd");
                int resultado = ca.validar_nomina(fechainicio, fechafin, cbo_empresa.SelectedValue.ToString());
                string descripcion = "generación de nóminas";
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
                        if(dias_trabajados>=dias)
                        {
                            dias_nomina = dias;
                        }
                        else
                        {
                            dias_nomina = dias_trabajados;
                        }
                        
                        string bonificacion = Convert.ToString(dgv_nonimas.Rows[fila].Cells[5].Value);
                        string comision = Convert.ToString(dgv_nonimas.Rows[fila].Cells[6].Value);
                        string igss = Convert.ToString(dgv_nonimas.Rows[fila].Cells[7].Value);
                        string igss_patronal = Convert.ToString(dgv_nonimas.Rows[fila].Cells[8].Value);
                        string ISR = Convert.ToString(dgv_nonimas.Rows[fila].Cells[9].Value);
                        string horas_extra = Convert.ToString(dgv_nonimas.Rows[fila].Cells[10].Value);
                        string devengo_extra = Convert.ToString(dgv_nonimas.Rows[fila].Cells[12].Value);
                        string descuento_extra = Convert.ToString(dgv_nonimas.Rows[fila].Cells[13].Value);
                        string can_horas_extra = Convert.ToString(dgv_nonimas.Rows[fila].Cells[15].Value); 

                        ca.Ejecutar_Mysql("insert into nomina (id_nomina_pk, descripcion, fecha_inicio_pago, fecha_fin_pago,dias_trabajados_mes, sueldo_base, estado, id_empleado_pk,id_empresa_pk,id_area_trabajo_pk ) values (null, '" + descripcion + "','" + fechainicio + "','" + fechafin + "','"+ dias_nomina+"','" + sueldo_base + "','" + estado + "','" + id_empleado + "','" + id_empresa + "','" + area + "');" );
                         DataTable dtt = ca.cargar("select max(id_nomina_pk)from nomina;");
                        string ultima_nomina = dtt.Rows[0][0].ToString();
                        

                        if (bonificacion == "0"|| bonificacion == null)
                        {

                        }
                        else
                        {
                            ca.Ejecutar_Mysql("insert into devengos (id_devengo_pk, fecha, nombre_devengo, cantidad_devengado, estado) values (null,'" + fecha_hoy + "','" + nombre_bono + "','" + bonificacion + "','" + nombre_estado+ "');");
                            DataTable dt_id_devengo = ca.cargar("select max(id_devengo_pk) from devengos;");
                            string ultimo_id_devengo = dt_id_devengo.Rows[0][0].ToString();

                            ca.Ejecutar_Mysql("insert into detalle_nomina(id_detalle_nomina_pk, total_a_pagar, estado, id_nomina_pk,id_devengo_pk) values (null,'" + bonificacion + "','" + nombre_estado + "','" + ultima_nomina + "','" + ultimo_id_devengo + "');");
                            conexion.DesconectarConexion();
                        }


                        if(comision == "0" || comision == null)
                        {
                      

                        }
                        else
                        {

                            ca.Ejecutar_Mysql("insert into devengos (id_devengo_pk, fecha, nombre_devengo, cantidad_devengado, estado) values (null,'" + fecha_hoy + "','" + nombre_comision + "','" + comision + "','" + nombre_estado + "');");
                            DataTable dt_id_devengo = ca.cargar("select max(id_devengo_pk) from devengos;");
                            string ultimo_id_devengo_comision = dt_id_devengo.Rows[0][0].ToString();
                            ca.Ejecutar_Mysql("insert into detalle_nomina(id_detalle_nomina_pk, total_a_pagar, estado, id_nomina_pk,id_devengo_pk) values (null,'" + comision + "','" + nombre_estado + "','" + ultima_nomina + "','" + ultimo_id_devengo_comision + "');");
                            conexion.DesconectarConexion();
                        }
                        if (igss == "0" || comision == null)
                        {

                        }
                        else
                        {

                            ca.Ejecutar_Mysql("insert into detalle_igss (id_detalle_igss_pk, id_empleado_pk,sueldo_base, iggs_a_pagar_laboral, iggs_a_pagar_patronal,estado , fecha) values (null,'" + id_empleado + "','" + sueldo_base + "','" + igss + "','" + igss_patronal + "','"+nombre_estado+"','"+fecha_hoy+ "');");
                            
                            DataTable dt_id_igss = ca.cargar("select max(id_detalle_igss_pk) from detalle_igss;");
                            string ultimo_id_igss = dt_id_igss.Rows[0][0].ToString();

                            ca.Ejecutar_Mysql("insert into deducciones (id_deduccion_pk, fecha, nombre_deduccion, cantidad_deduccion, estado, id_empleado_pk,id_detalle_igss_pk) values (null,'" + fecha_hoy + "','" + nombre_IGSS_laboral + "','" + igss + "','" + nombre_estado + "','"+ id_empleado+ "','"+ ultimo_id_igss + "');");
                            DataTable dt_id_deduccion = ca.cargar("select max(id_deduccion_pk) from deducciones;");
                            string ultimo_id_deduccion_igss = dt_id_deduccion.Rows[0][0].ToString();
                            ca.Ejecutar_Mysql("insert into detalle_nomina(id_detalle_nomina_pk, total_a_pagar, estado, id_nomina_pk,id_deduccion_pk) values (null,'" + igss + "','" + nombre_estado + "','" + ultima_nomina + "','" + ultimo_id_deduccion_igss + "');");
                            conexion.DesconectarConexion();
                        }

                        if (horas_extra == "0" || horas_extra == null)
                        {

                        }
                        else
                        {
                         
                            ca.Ejecutar_Mysql("insert into devengos (id_devengo_pk, fecha,nombre_devengo, cantidad_devengado, cantidad_horas_extra,estado) values (null,'" + fecha_hoy + "','" + nombre_horas_extra + "','" + horas_extra + "','" + can_horas_extra + "','" + nombre_estado + "');");
                            DataTable dt_ultimo_devengo = ca.cargar("select max(id_devengo_pk) from devengos;");
                            string ultimo_id_horas_extra = dt_ultimo_devengo.Rows[0][0].ToString();
                            ca.Ejecutar_Mysql("insert into detalle_nomina(id_detalle_nomina_pk, total_a_pagar, estado, id_nomina_pk,id_devengo_pk) values (null,'" + horas_extra + "','" + nombre_estado + "','" + ultima_nomina + "','" + ultimo_id_horas_extra + "');");
                            conexion.DesconectarConexion();
                        }
                        if (ISR == "0" || ISR == null)
                        { }
                        else
                        {
                            ca.Ejecutar_Mysql("insert into deducciones (id_deduccion_pk,fecha, nombre_deduccion, cantidad_deduccion, estado, id_empleado_pk) values (null,'" + fecha_hoy + "','" + nombre_ISR + "','" + ISR + "','" + nombre_estado + "','" + id_empleado + "');");
                            DataTable dt_ultimo_descuento = ca.cargar("select max(id_deduccion_pk) from deducciones;");
                            string ultimo_id_descuento = dt_ultimo_descuento.Rows[0][0].ToString();
                            ca.Ejecutar_Mysql("insert into detalle_nomina(id_detalle_nomina_pk, total_a_pagar, estado, id_nomina_pk,id_deduccion_pk) values (null,'" + ISR + "','" + nombre_estado + "','" + ultima_nomina + "','" + ultimo_id_descuento + "');");
                            conexion.DesconectarConexion();
                        }

                        if(devengo_extra == "0" || devengo_extra == null)
                        { }
                        else
                        {

                            ca.Ejecutar_Mysql("insert into devengos (id_devengo_pk, fecha,nombre_devengo, cantidad_devengado, estado) values (null,'" + fecha_hoy + "','" + nombre_devengo_extra + "','" + devengo_extra + "','"  + nombre_estado + "');");
                            DataTable dt_ultimo_devengo = ca.cargar("select max(id_devengo_pk) from devengos;");
                            string ultimo_id_devengo = dt_ultimo_devengo.Rows[0][0].ToString();
                            ca.Ejecutar_Mysql("insert into detalle_nomina(id_detalle_nomina_pk, total_a_pagar, estado, id_nomina_pk,id_devengo_pk) values (null,'" + devengo_extra + "','" + nombre_estado + "','" + ultima_nomina + "','" + ultimo_id_devengo + "');");
                            conexion.DesconectarConexion();
                        }
                        if (descuento_extra == "0" || descuento_extra == null)
                        { }
                        else
                        {
                            ca.Ejecutar_Mysql("insert into deducciones (id_deduccion_pk,fecha, nombre_deduccion, cantidad_deduccion, estado, id_empleado_pk) values (null,'" + fecha_hoy + "','" + nombre_deduccion_extra + "','" + descuento_extra + "','" + nombre_estado + "','" + id_empleado + "');");
                            DataTable dt_ultimo_descuento = ca.cargar("select max(id_deduccion_pk) from deducciones;");
                            string ultimo_id_descuento = dt_ultimo_descuento.Rows[0][0].ToString();
                            ca.Ejecutar_Mysql("insert into detalle_nomina(id_detalle_nomina_pk, total_a_pagar, estado, id_nomina_pk,id_deduccion_pk) values (null,'" + descuento_extra + "','" + nombre_estado + "','" + ultima_nomina + "','" + ultimo_id_descuento + "');");
                            conexion.DesconectarConexion();
                        }
                    }



                    conexion.DesconectarConexion();
                    MessageBox.Show("Calculo de nomina realizada con exito");
                    
                }
            }

            catch
            {

            }
        }
    }
    }

