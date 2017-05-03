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


//Programado por Gladis Cruz frm_indemnizacion

namespace contrato_trabajo
{
    public partial class frm_indemnizacion : Form
    {
        public frm_indemnizacion()
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

        private void frm_indemnizacion_Load(object sender, EventArgs e)
        {
            Capa_de_datos2 cd2 = new Capa_de_datos2();
            cd2.llenar_cbx(cbx_empresa);
            cbx_empresa.SelectedIndex = -1;

           // llenarGrid();
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

                fecha_ansi = DateTime.Parse(dtp_fecha_retiro.Text).Year.ToString() + "/";
                mes = DateTime.Parse(dtp_fecha_retiro.Text).Month.ToString();

                if (mes.Length == 1)
                {
                    mes = "0" + mes;
                }
                dia = DateTime.Parse(dtp_fecha_retiro.Text).Day.ToString();
                if (dia.Length == 1)
                {
                    dia = "0" + dia;
                }
                fecha_ansi += mes + "/" + dia;
                string script = "";

                script += "INSERT INTO `indenmizacion`( `id_empleado_pk`, `fecha_retiro`, `salario_mensual`, `indemnizar`) ";
                script += " VALUES (";
                script += "'" + txt_cod_empleado.Text + "',";
                script += "'" + fecha_ansi + "',";
                script += double.Parse(txt_sal_mensual.Text) + ",";
                script += double.Parse(txt_indemnizacion.Text) + ")";

                try
                {
                    //insertando indemnizacion
                    Conexionmysql.ObtenerConexion();
                    Conexionmysql.EjecutarMySql(script);
                    Conexionmysql.Desconectar();
                  
                    script = "SELECT max(id_indemnizacion) as id_indemnizacion FROM indenmizacion WHERE id_empleado_pk='" + txt_cod_empleado.Text + "'";
                    Conexionmysql.ObtenerConexion();
                    DataSet ds = new DataSet();
                    OdbcDataAdapter dad = new OdbcDataAdapter(script, Conexionmysql.ObtenerConexion());
                    dad.Fill(ds, "indemnizacion");
                    string id_indemnizacion = "";
                    id_indemnizacion = ds.Tables["indemnizacion"].Rows[0]["id_indemnizacion"].ToString();

                   
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
        private void ObtenerDatosEmpleado()
        {
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
                    this.dtp_fecha_ingreso.Enabled = false;
                    this.dtp_fecha_ingreso.Text = ds.Tables["empleado"].Rows[0]["fecha_de_alta_emp"].ToString();
                    double salario = double.Parse(ds.Tables["empleado"].Rows[0]["salario_base"].ToString());
                    this.txt_sal_mensual.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", salario);
                    continuar = true;
                    idemnizar();

                }
                else
                {
                    continuar = false;
                    MessageBox.Show("No se encontró el empleado solicitado, verifique.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        private void idemnizar()
        {
            //Calculando indemnizacion
            double salario = double.Parse(txt_sal_mensual.Text);
            DateTime d1 = DateTime.Parse(this.dtp_fecha_ingreso.Text);
            DateTime d2 = DateTime.Parse(this.dtp_fecha_retiro.Text);
            TimeSpan ts = d2 - d1;
            DateTime d = DateTime.MinValue + ts;
            int dias = d.Day - 1;
            int meses = d.Month - 1;
            int anios = d.Year - 1;

            this.lbl_tiempo.Text = "Tiempo laborado: "  + anios +  " Años"   + meses +  " Meses "  + dias +  " Días ";
            DataTable dtInd = new DataTable ();
            dtInd.Columns.Add("DESCRIPCION");
            dtInd.Columns.Add("VALOR");

            double indemnizacion = 0;
            indemnizacion = anios * salario;
            dtInd.Rows.Add(anios + " Años", anios * salario);
            indemnizacion += (salario / 12) * meses;
            dtInd.Rows.Add(meses + " Meses", (salario / 12) * meses);
            indemnizacion += (salario / 365) * dias;
            dtInd.Rows.Add(dias + " Dias", (salario / 365) * dias);

            this.txt_indemnizacion.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", indemnizacion);
            data_mostrar_empleado.DataSource = dtInd;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (continuar)
            {
                idemnizar();
            }
        }
        private void limpiar()
        {
            continuar = false;
            txt_cod_empleado.Text = "";
            txt_sal_mensual.Text = "";
            txt_indemnizacion.Text = "";
            dtp_fecha_ingreso.Text = DateTime.Now.ToString();
            dtp_fecha_retiro.Text = DateTime.Now.ToString();

            gpb_indemnizar.Enabled = true;
            this.txt_cod_empleado.Focus();
            this.btn_calcular.Visible = true;
            consulta = false;

        }
        private void llenarGrid()
        {
            //datag_indem
            try
            {
                //Conexionmysql.ObtenerConexion();
                //DataSet ds = new DataSet();
                String Query = "SELECT empleado.id_empleado_pk as CODIGO,";
                Query += " empleado.nombre_emp as NOMBRE,apellido_emp as APELLIDO, nombre_puesto as PUESTO, ";
                Query += " empleado.fecha_de_alta_emp as FECHA_ALTA,  ";
                Query += " indenmizacion.fecha_retiro as FECHA_RETIRO,  ";
                Query += " indenmizacion.indemnizar as INDEMNIZACION, puesto_laboral.salario_base as SALARIO_BASE ";
                Query += " FROM empleado, indenmizacion, puesto_laboral ";
                Query += " WHERE indenmizacion.id_empleado_pk = empleado.id_empleado_pk ";
                Query += " AND puesto_laboral.id_puesto_laboral_pk = empleado.id_puesto_laboral_pk";

                Conexionmysql.ObtenerConexion();
                //crear DataSet
                System.Data.DataSet MiDataSet = new System.Data.DataSet();
                //Crear Adaptador de datos
                OdbcDataAdapter MiDataAdapter = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //LLenar el DataSet
                MiDataAdapter.Fill(MiDataSet, "indemnizacion");
                //Asignarle el valor adecuado a las propiedades del DataGrid
                datag_indem.DataSource = MiDataSet;
                datag_indem.DataMember = "indemnizacion";
                //nos desconectamos de la base de datos...
                Conexionmysql.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //private void llenarGrid2()
        //{
            

        //        }
        private void ObtenerRegistro()
        {
            int codigo = this.datag_indem.CurrentRow.Index; var dataIndexNo = datag_indem.Rows[codigo].Index.ToString();
            txt_cod_empleado.Text = datag_indem.Rows[codigo].Cells["CODIGO"].Value.ToString();
            txt_sal_mensual.Text = datag_indem.Rows[codigo].Cells["SALARIO_BASE"].Value.ToString();
            txt_indemnizacion.Text = datag_indem.Rows[codigo].Cells["INDEMNIZACION"].Value.ToString();
            dtp_fecha_ingreso.Text = datag_indem.Rows[codigo].Cells["FECHA_ALTA"].Value.ToString();

            dtp_fecha_retiro.Text = datag_indem.Rows[codigo].Cells["FECHA_RETIRO"].Value.ToString();
            btn_calcular.Visible = false;
            consulta = true;
            gpb_indemnizar.Enabled = false;
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void datag_indem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obteniendo los datos seleccionados
            var dataIndexNo = datag_indem.Rows[e.RowIndex].Index.ToString();
            txt_cod_empleado.Text = datag_indem.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
            txt_sal_mensual.Text = datag_indem.Rows[e.RowIndex].Cells["SALARIO_BASE"].Value.ToString();
            txt_indemnizacion.Text = datag_indem.Rows[e.RowIndex].Cells["INDEMNIZACION"].Value.ToString();
            dtp_fecha_ingreso.Text = datag_indem.Rows[e.RowIndex].Cells["FECHA_ALTA"].Value.ToString();
            dtp_fecha_retiro.Text = datag_indem.Rows[e.RowIndex].Cells["FECHA_RETIRO"].Value.ToString();
            btn_calcular.Visible = false;
            consulta = true;
            gpb_indemnizar.Enabled = false;
        }

            private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea ELIMINAR el registro?", "RECURSOS HUMANOS",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Eliminando registros
                string script = "";

                script += "DELETE FROM indenmizacion WHERE id_empleado_pk='" + txt_cod_empleado.Text + "'";

                try
                {
                    //insertando indemnizacion
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
            fn.Anterior(datag_indem);
            ObtenerRegistro();
        }
        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(datag_indem);
            ObtenerRegistro();
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(datag_indem);
            ObtenerRegistro();
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo (datag_indem);
            ObtenerRegistro();
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Capa_de_datos2 cd2 = new Capa_de_datos2();
                string id_empresa = cbx_empresa.SelectedValue.ToString();
                cbx_nom_empleado.DataSource = cd2.llenar_cbo_empleado(id_empresa);
                cbx_nom_empleado.DisplayMember = "nombre_emp";
                cbx_nom_empleado.ValueMember = "id_empleado_pk";
               // MessageBox.Show(id_empresa);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void cbx_nom_empleado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt64 (cbx_nom_empleado.SelectedValue) > 0)
            {
                txt_cod_empleado.Text = cbx_nom_empleado.SelectedValue.ToString();
                ObtenerDatosEmpleado();

            }
        }

        private void Empresa_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbx_nom_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void data_mostrar_empleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
