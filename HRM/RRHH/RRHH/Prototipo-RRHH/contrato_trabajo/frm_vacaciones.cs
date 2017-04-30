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
using MySql.Data.MySqlClient;
using System.Globalization;



//Programado por Gladis Cruz frm_vacaciones
namespace contrato_trabajo
{
    public partial class frm_vacaciones : Form
    {
        public frm_vacaciones()
        {
            InitializeComponent();
        }
        #region Atributos
        Boolean continuar = false;
        Boolean consulta = false;
        CapaNegocio fn = new CapaNegocio();
        #endregion

        private void datag_indem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_vacaciones_Load(object sender, EventArgs e)
        {
            Capa_de_datos2 cd2 = new Capa_de_datos2();
            cd2.llenar_cbx(cbx_empresa_vac);
            cbx_empresa_vac.SelectedIndex = -1;

            //    txt_dias.Text = "17";
            llenarGrid();
        }

        private void gpb_indemnizar_Enter(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiar();

        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Confirmamos transacción
            if (MessageBox.Show("Confirma que desea guardar el registro?", "RECURSOS HUMANOS",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question)
      == DialogResult.Yes)
            {
                //Insertando
                string fecha_ansi = "";
                string mes = "";
                string dia = "";

                fecha_ansi = DateTime.Parse(dtp_fecha_salida.Text).Year.ToString() + "/";
                mes = DateTime.Parse(dtp_fecha_salida.Text).Month.ToString();

                if (mes.Length == 1)
                {
                    mes = "0" + mes;
                }
                dia = DateTime.Parse(dtp_fecha_salida.Text).Day.ToString();
                if (dia.Length == 1)
                {
                    dia = "0" + dia;
                }
                fecha_ansi += mes + "/" + dia;
                string script = "";
                string strFecha_inicio = "";
                DateTime fecha_inicio = DateTime.Parse(dtp_fecha_salida.Text);
                fecha_inicio = fecha_inicio.AddMonths(-6);
                strFecha_inicio = fecha_inicio.Year.ToString () + "/";
                mes = fecha_inicio.Month.ToString() + "/";
                dia = fecha_inicio.Day.ToString();
                strFecha_inicio += mes + dia;
                //2017-04-23

                script += "INSERT INTO vacaciones(fecha_de_inicio, fecha_salida, salario_mensual, id_empleado_pk, dev_vacaciones)";
                script += " VALUES('" + strFecha_inicio + "','" + fecha_ansi + "',";
                script +=  double.Parse(txt_sal_mensual.Text) + ",'" + txt_cod_empleado.Text + "',";
                script += double.Parse(txt_vacaciones.Text) + ")";


              
                try
                {
                    //insertando vacaciones
                    Conexionmysql.ObtenerConexion();
                    Conexionmysql.EjecutarMySql(script);
                    Conexionmysql.Desconectar();
                    //obteniendo ID de vacaciones calculadas
                    script = "SELECT max(id_vacaciones) as id_vacaciones FROM vacaciones WHERE id_empleado_pk='" + txt_cod_empleado.Text + "'";
                    Conexionmysql.ObtenerConexion();
                    DataSet ds = new DataSet();
                    OdbcDataAdapter dad = new OdbcDataAdapter(script, Conexionmysql.ObtenerConexion());
                    dad.Fill(ds, "vacaciones");
                    string id_vacaciones = "";
                    id_vacaciones = ds.Tables["vacaciones"].Rows[0]["id_vacaciones"].ToString();

                    ////Actualizando datos del empleado
                    //script = "UPDATE empleado SET ";
                    //script += "id_vacaciones=" + id_vacaciones + "";
                    //script += " WHERE id_empleado_pk='" + txt_cod_empleado.Text + "'";
                    //Conexionmysql.ObtenerConexion();
                    //Conexionmysql.EjecutarMySql(script);
                    //Conexionmysql.Desconectar();

                    limpiar();
                    llenarGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void txt_cod_empleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                ObtenerDatosEmpleado();


            }
                 private void ObtenerDatosEmpleado() {
            { 
            
                //obteniendo datos del empleado

                Conexionmysql.ObtenerConexion();
                DataSet ds = new DataSet();
                string script = "";
                script = " SELECT empleado.id_empleado_pk, ";
                script = script + " empleado.id_puesto_laboral_pk,  ";
                script = script + " empleado.nombre_emp,  ";
                script = script + " empleado.fecha_de_alta_emp,  ";
                script = script + " puesto_laboral.salario_base ";
                script = script + " FROM empleado, puesto_laboral ";
                script = script + " WHERE ";
                script = script + "  puesto_laboral.id_puesto_laboral_pk = empleado.id_puesto_laboral_pk";
                script = script + "  AND estadolaboral='Alta' and  id_empleado_pk='" + txt_cod_empleado.Text + "'";

                OdbcDataAdapter dad = new OdbcDataAdapter(script, Conexionmysql.ObtenerConexion());
                dad.Fill(ds, "empleado");
                int totReg = 0;
                totReg = ds.Tables["empleado"].Rows.Count;
                if (totReg > 0)
                {
                    this.dtp_fecha_inicio.Enabled = false;
                    this.dtp_fecha_inicio.Text = ds.Tables["empleado"].Rows[0]["fecha_de_alta_emp"].ToString();
                    double salario = double.Parse(ds.Tables["empleado"].Rows[0]["salario_base"].ToString());
                    this.txt_sal_mensual.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", salario);
                    continuar = true;
                    vacacion();

                }
                else
                {
                    continuar = false;
                    MessageBox.Show("No se encontró el empleado solicitado, verifique.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void vacacion()
        {
            //Calculando vacaciones

            if (txt_dias.Text == "")
            {
                MessageBox.Show("Indique los días de vacaciones");
                return;
            }
         
            double salario = double.Parse(txt_sal_mensual.Text);
            DateTime d1 = DateTime.Parse(this.dtp_fecha_inicio.Text);
            DateTime d2 = DateTime.Parse(this.dtp_fecha_salida.Text);
            TimeSpan ts = d2 - d1;
            DateTime d = DateTime.MinValue + ts;
            int dias = d.Day - 1;
            int meses = d.Month - 1;
            int anios = d.Year - 1;

            this.lbl_vacaciones.Text = "Vacaciones devengadas:  " + anios +  " Años"  + meses +  " Meses " + dias +  " Días ";
            double dia;
            DataTable dtInd = new DataTable();
            dtInd.Columns.Add("DESCRIPCION");
            dtInd.Columns.Add("VALOR");
            dia = Convert.ToDouble(txt_dias.Text);
            
            
                double vacaciones = 0;
                vacaciones += (salario / 30) * dia;
            dtInd.Rows.Add(" 1 dia ", (salario / 30));
            dtInd.Rows.Add(" Dia Estimado ", dia);
            dtInd.Rows.Add(" Vacaciones", (salario / 30) * dia);
           
            this.txt_vacaciones.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", vacaciones);
            data_mostrar_calculo.DataSource = dtInd;

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (continuar)
            {
                vacacion();
      
            }
        }
        private void limpiar()
        {
            continuar = false;
            txt_cod_empleado.Text = "";
            txt_sal_mensual.Text = "";
            txt_vacaciones.Text = "";
             dtp_fecha_inicio.Text = DateTime.Now.ToString();
            dtp_fecha_salida.Text = DateTime.Now.ToString();

            gpb_vacaciones.Enabled = true;
            this.txt_cod_empleado.Focus();
            this.btn_calcular.Visible = true;
            consulta = false;

        }
        private void llenarGrid()
        {
            //datag_vacaciones
            try
            {
                

                String Query = "SELECT empleado.id_empleado_pk as CODIGO,";
                Query += " empleado.nombre_emp as NOMBRE,apellido_emp as APELLIDO, nombre_puesto,";
                Query += " vacaciones.fecha_de_inicio as FECHA_INICIO,";
                Query += " vacaciones.fecha_salida as FECHA_SALIDA,";
                Query += " vacaciones.dev_vacaciones as VACACIONES, puesto_laboral.salario_base as SALARIO_BASE";
                Query += " FROM empleado, vacaciones, puesto_laboral";
                Query += " WHERE vacaciones.id_empleado_pk = empleado.id_empleado_pk";
                Query += " AND puesto_laboral.id_puesto_laboral_pk = empleado.id_puesto_laboral_pk";
               
                Conexionmysql.ObtenerConexion();
                //crear DataSet
                System.Data.DataSet MiDataSet = new System.Data.DataSet();
                //Crear Adaptador de datos
                OdbcDataAdapter MiDataAdapter = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //LLenar el DataSet
                MiDataAdapter.Fill(MiDataSet, "vacaciones");
                //Asignarle el valor adecuado a las propiedades del DataGrid
                datag_vaca.DataSource = MiDataSet;
                datag_vaca.DataMember = "vacaciones";
                //nos desconectamos de la base de datos...
                Conexionmysql.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ObtenerRegistro()
        {
            int codigo = this.datag_vaca.CurrentRow.Index; var dataIndexNo = datag_vaca.Rows[codigo].Index.ToString();
            txt_cod_empleado.Text = datag_vaca.Rows[codigo].Cells["CODIGO"].Value.ToString();
            txt_sal_mensual.Text = datag_vaca.Rows[codigo].Cells["SALARIO_BASE"].Value.ToString();
            txt_vacaciones.Text = datag_vaca.Rows[codigo].Cells["VACACIONES"].Value.ToString();
            dtp_fecha_inicio.Text = datag_vaca.Rows[codigo].Cells["FECHA_INICIO"].Value.ToString();

            dtp_fecha_salida.Text = datag_vaca.Rows[codigo].Cells["FECHA_SALIDA"].Value.ToString();
            btn_calcular.Visible = false;
            consulta = true;
            gpb_vacaciones.Enabled = false;
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void datag_indem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obteniendo los datos seleccionados
            var dataIndexNo = datag_vaca.Rows[e.RowIndex].Index.ToString();
            txt_cod_empleado.Text = datag_vaca.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
            txt_sal_mensual.Text = datag_vaca.Rows[e.RowIndex].Cells["SALARIO_BASE"].Value.ToString();
            txt_vacaciones.Text = datag_vaca.Rows[e.RowIndex].Cells["VACACIONES"].Value.ToString();
            dtp_fecha_inicio.Text = datag_vaca.Rows[e.RowIndex].Cells["FECHA_INICIO"].Value.ToString();
            dtp_fecha_salida.Text = datag_vaca.Rows[e.RowIndex].Cells["FECHA_SALIDA"].Value.ToString();
            btn_calcular.Visible = false;
            consulta = true;
            gpb_vacaciones.Enabled = false;
        }

            private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea ELIMINAR el registro?", "RECURSOS HUMANOS",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Eliminando registros
                string script = "";

                script += "DELETE FROM vacaciones WHERE id_empleado_pk='" + txt_cod_empleado.Text + "'";

                try
                {
                    //insertando vacaciones
                    Conexionmysql.ObtenerConexion();
                    Conexionmysql.EjecutarMySql(script);
                    Conexionmysql.Desconectar();

                                       limpiar();
                    llenarGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }//end sub
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(datag_vaca);
            ObtenerRegistro();
        }
        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(datag_vaca);
            ObtenerRegistro();
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(datag_vaca);
            ObtenerRegistro();
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo (datag_vaca);
            ObtenerRegistro();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void txt_cod_empleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void double_dia(object sender, KeyPressEventArgs e)
        {

        }

        private void cbx_empresa_vac_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Capa_de_datos2 cd2 = new Capa_de_datos2();
                string id_empresa = cbx_empresa_vac.SelectedValue.ToString();
                cbx_nom_empleado_vac.DataSource = cd2.llenar_cbo_empleado(id_empresa);
                cbx_nom_empleado_vac.DisplayMember = "nombre_emp";
                cbx_nom_empleado_vac.ValueMember = "id_empleado_pk";
               // MessageBox.Show(id_empresa);
                txt_cod_empleado.Text = cbx_nom_empleado_vac.SelectedValue.ToString();
                ObtenerDatosEmpleado();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }



        private void cbx_nom_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt64(cbx_nom_empleado_vac.SelectedValue) > 0)
            {
                txt_cod_empleado.Text = cbx_nom_empleado_vac.SelectedValue.ToString();
                ObtenerDatosEmpleado();

            }
                 }
    }
}
