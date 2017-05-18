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
using dllconsultas;
using System.Data.Odbc;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Data;
using System.Threading;
using System.IO;

namespace contrato_trabajo
{
    public partial class frm_jornada : Form
    {
        #region Variables del Form Jornada
        //=======================================================================================================================
        //--------------------------------------Variables--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        String Codigo;
        Boolean Editar;
        String atributo;
        CapaNegocio fn = new CapaNegocio();
        DataGridView dg;
        #endregion

        #region Visualizar Form Jornada
        //=======================================================================================================================
        //--------------------------------------Form Jornada--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public frm_jornada(DataGridView dgv,String id_jornadatrabajo_pk, String forma_cobro, String nombre_jornada, String horas_trabajo, String jdiaria_dias, String jhora_diario, String estado, Boolean Editar1, Boolean tipo_accion)
        {
            this.dg = dgv;
            this.Editar = Editar1;
            InitializeComponent();
            atributo = "id_jornadatrabajo_pk";
            this.Codigo = id_jornadatrabajo_pk;
            if (tipo_accion == true)
            {
                this.txt_cbo_forma_cobro.Text = forma_cobro; cbo_forma_cobro.Text = txt_cbo_forma_cobro.Text;
                this.txt_cbo_tipo_jornada.Text = nombre_jornada; cbo_tipo_jornada.Text = txt_cbo_tipo_jornada.Text;
                this.txt_nmup_horas_trabajo.Text = horas_trabajo; nmup_horas_trabajo.Value = Convert.ToUInt32(txt_nmup_horas_trabajo.Text);
                if (string.IsNullOrEmpty(txt_nmup_dias_trabajo.Text.Trim()))
                {
                    nmup_dias_trabajo.Value = 0;
                }
                else
                {
                    this.txt_nmup_dias_trabajo.Text = jdiaria_dias; nmup_dias_trabajo.Value = Convert.ToUInt32(txt_nmup_dias_trabajo.Text);
                }
                if (string.IsNullOrEmpty(txt_nmup_hora_diario.Text.Trim()))
                {
                    nmup_hora_diario.Value = 0;
                }
                else
                {
                    this.txt_nmup_hora_diario.Text = jhora_diario; nmup_hora_diario.Value = Convert.ToUInt32(txt_nmup_hora_diario.Text);
                }
                    

                this.fn.ActivarControles(gpb_jornadas);
            }
            else
            {
                fn.ActivarControles(gpb_jornadas);
            }

        }
        #endregion

        #region Cargar Componentes del Form
        //=======================================================================================================================
        //--------------------------------------Load del Form--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void frm_jornada_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_jornadas);
            fn.InhabilitarComponentes(this);
        }
        #endregion

        #region Boton Nuevo
        //=======================================================================================================================
        //---------------------------------------------- Nuevo ------------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar_Componentes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Limpiar_Componentes()
        {
            Editar = false;
            fn.ActivarControles(gpb_jornadas);
            nmup_dias_trabajo.Enabled = false;
            nmup_hora_diario.Enabled = false;
            fn.LimpiarComponentes(gpb_jornadas);
            txt_nmup_dias_trabajo.Text = "0";
            txt_nmup_horas_trabajo.Text = "0";
            txt_nmup_hora_diario.Text = "0";
            txt_cbo_forma_cobro.Text = cbo_forma_cobro.SelectedItem.ToString();
            txt_cbo_tipo_jornada.Text = cbo_tipo_jornada.SelectedItem.ToString();
        }
        #endregion

        #region Boton Editar
        //=======================================================================================================================
        //---------------------------------------------- Editar ------------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "id_jornadatrabajo_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_cbo_forma_cobro.Text = this.dg.CurrentRow.Cells[1].Value.ToString(); cbo_forma_cobro.Text = txt_cbo_forma_cobro.Text;
                this.txt_cbo_tipo_jornada.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); cbo_tipo_jornada.Text = txt_cbo_tipo_jornada.Text;
                this.txt_nmup_horas_trabajo.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); nmup_horas_trabajo.Value = Convert.ToInt32(txt_nmup_horas_trabajo.Text);
                this.txt_nmup_dias_trabajo.Text = this.dg.CurrentRow.Cells[4].Value.ToString(); nmup_dias_trabajo.Value = Convert.ToInt32(txt_nmup_dias_trabajo.Text);
                this.txt_nmup_hora_diario.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); nmup_hora_diario.Value = Convert.ToInt32(txt_nmup_hora_diario.Text);
                fn.ActivarControles(gpb_jornadas);    
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton Eliminar
        //=======================================================================================================================
        //---------------------------------------------- Eliminar ------------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_jornadatrabajo_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string tabla = "emp_jornadatrabajo";
                    fn.eliminar(tabla, atributo2, codigo2);
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_grid_jornada();
                    Editar = false;
                    fn.InhabilitarComponentes(gpb_jornadas);
                    nmup_dias_trabajo.Enabled = false;
                    nmup_hora_diario.Enabled = false;
                    fn.LimpiarComponentes(gpb_jornadas);
                    txt_nmup_dias_trabajo.Text = "0";
                    txt_nmup_horas_trabajo.Text = "0";
                    txt_nmup_hora_diario.Text = "0";
                    txt_cbo_forma_cobro.Text = cbo_forma_cobro.SelectedItem.ToString();
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton Cancelar
        //=======================================================================================================================
        //---------------------------------------------- Cancelar ------------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(gpb_jornadas);
                fn.InhabilitarComponentes(gpb_jornadas);
                nmup_hora_diario.Value = 0;
                nmup_horas_trabajo.Value = 0;
                nmup_dias_trabajo.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Actualizar
        //=======================================================================================================================
        //---------------------------------------------- Actualizar ------------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Cargar_grid_jornada();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Cargar_grid_jornada()
        {
            string tabla = "emp_jornadatrabajo";
            fn.ActualizarGrid(this.dg, "SELECT id_jornadatrabajo_pk, forma_cobro, nombre_jornada, horas_trabajo, jdiaria_dias, jhora_diario, estado FROM `emp_jornadatrabajo` WHERE estado = 'ACTIVO' ", tabla);
        }
        #endregion

        #region Boton Guardar
        //=======================================================================================================================
        //---------------------------------------------- Guardar ------------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_estado.Text = "ACTIVO";
                TextBox[] textbox = { txt_cbo_forma_cobro, txt_cbo_tipo_jornada, txt_nmup_horas_trabajo, txt_nmup_dias_trabajo, txt_nmup_hora_diario, txt_estado };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "emp_jornadatrabajo";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fn.InhabilitarComponentes(gpb_jornadas);
                        Cargar_grid_jornada();
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nmup_dias_trabajo.Enabled = false;
                        nmup_hora_diario.Enabled = false;
                        fn.LimpiarComponentes(gpb_jornadas);
                        txt_nmup_dias_trabajo.Text = " ";
                        txt_nmup_horas_trabajo.Text = " ";
                        txt_nmup_hora_diario.Text = " ";
                        fn.InhabilitarComponentes(gpb_jornadas);
                        Conexionmysql.ObtenerConexion();
                        Cargar_grid_jornada();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Funciones del Form
        //=======================================================================================================================
        //------------------------------------------- Funciones del Form --------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void cbo_forma_cobro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cbo_forma_cobro.Text = cbo_forma_cobro.Text;
            if (cbo_forma_cobro.SelectedItem.ToString() == "DIARIO")
            {
                nmup_horas_trabajo.Enabled = false;
                nmup_horas_trabajo.Value = 0;
                nmup_dias_trabajo.Enabled = true;
                nmup_hora_diario.Enabled = false;
                nmup_hora_diario.Value = 0;
            }
            if (cbo_forma_cobro.SelectedItem.ToString() == "HORA")
            {
                nmup_horas_trabajo.Enabled = false;
                nmup_horas_trabajo.Value = 0;
                nmup_dias_trabajo.Enabled = false;
                nmup_dias_trabajo.Value = 0;
                nmup_hora_diario.Enabled = true;
            }
            if (cbo_forma_cobro.SelectedItem.ToString() == "MENSUAL" || cbo_forma_cobro.SelectedItem.ToString() == "QUINCENAL")
            {
                nmup_horas_trabajo.Enabled = true;
                nmup_dias_trabajo.Enabled = false;
                nmup_dias_trabajo.Value = 0;
                nmup_hora_diario.Enabled = false;
                nmup_hora_diario.Value = 0;
            }
        }

        private void nmup_horas_trabajo_ValueChanged(object sender, EventArgs e)
        {
            txt_nmup_horas_trabajo.Text = nmup_horas_trabajo.Value.ToString();
        }

        private void nmup_dias_trabajo_ValueChanged(object sender, EventArgs e)
        {
            txt_nmup_dias_trabajo.Text = nmup_dias_trabajo.Value.ToString();
        }

        private void nmup_hora_diario_ValueChanged(object sender, EventArgs e)
        {
            txt_nmup_hora_diario.Text = nmup_hora_diario.Value.ToString();
        }

        private void cbo_tipo_jornada_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_cbo_tipo_jornada.Text = cbo_tipo_jornada.SelectedItem.ToString();
        }
        #endregion

        #region Botones de Navegacion
        //=======================================================================================================================
        //------------------------------------------- Navegacion --------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dg);
            this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
            this.txt_cbo_forma_cobro.Text = this.dg.CurrentRow.Cells[1].Value.ToString(); cbo_forma_cobro.Text = txt_cbo_forma_cobro.Text;
            this.txt_cbo_tipo_jornada.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); cbo_tipo_jornada.Text = txt_cbo_tipo_jornada.Text;
            this.txt_nmup_horas_trabajo.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); nmup_horas_trabajo.Value = Convert.ToInt32(txt_nmup_horas_trabajo.Text);
            this.txt_nmup_dias_trabajo.Text = this.dg.CurrentRow.Cells[4].Value.ToString(); nmup_dias_trabajo.Value = Convert.ToInt32(txt_nmup_dias_trabajo.Text);
            this.txt_nmup_hora_diario.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); nmup_hora_diario.Value = Convert.ToInt32(txt_nmup_hora_diario.Text);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dg);
            this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
            this.txt_cbo_forma_cobro.Text = this.dg.CurrentRow.Cells[1].Value.ToString(); cbo_forma_cobro.Text = txt_cbo_forma_cobro.Text;
            this.txt_cbo_tipo_jornada.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); cbo_tipo_jornada.Text = txt_cbo_tipo_jornada.Text;
            this.txt_nmup_horas_trabajo.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); nmup_horas_trabajo.Value = Convert.ToInt32(txt_nmup_horas_trabajo.Text);
            this.txt_nmup_dias_trabajo.Text = this.dg.CurrentRow.Cells[4].Value.ToString(); nmup_dias_trabajo.Value = Convert.ToInt32(txt_nmup_dias_trabajo.Text);
            this.txt_nmup_hora_diario.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); nmup_hora_diario.Value = Convert.ToInt32(txt_nmup_hora_diario.Text);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dg);
            this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
            this.txt_cbo_forma_cobro.Text = this.dg.CurrentRow.Cells[1].Value.ToString(); cbo_forma_cobro.Text = txt_cbo_forma_cobro.Text;
            this.txt_cbo_tipo_jornada.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); cbo_tipo_jornada.Text = txt_cbo_tipo_jornada.Text;
            this.txt_nmup_horas_trabajo.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); nmup_horas_trabajo.Value = Convert.ToInt32(txt_nmup_horas_trabajo.Text);
            this.txt_nmup_dias_trabajo.Text = this.dg.CurrentRow.Cells[4].Value.ToString(); nmup_dias_trabajo.Value = Convert.ToInt32(txt_nmup_dias_trabajo.Text);
            this.txt_nmup_hora_diario.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); nmup_hora_diario.Value = Convert.ToInt32(txt_nmup_hora_diario.Text);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dg);
            this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
            this.txt_cbo_forma_cobro.Text = this.dg.CurrentRow.Cells[1].Value.ToString(); cbo_forma_cobro.Text = txt_cbo_forma_cobro.Text;
            this.txt_cbo_tipo_jornada.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); cbo_tipo_jornada.Text = txt_cbo_tipo_jornada.Text;
            this.txt_nmup_horas_trabajo.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); nmup_horas_trabajo.Value = Convert.ToInt32(txt_nmup_horas_trabajo.Text);
            this.txt_nmup_dias_trabajo.Text = this.dg.CurrentRow.Cells[4].Value.ToString(); nmup_dias_trabajo.Value = Convert.ToInt32(txt_nmup_dias_trabajo.Text);
            this.txt_nmup_hora_diario.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); nmup_hora_diario.Value = Convert.ToInt32(txt_nmup_hora_diario.Text);
        }
        #endregion

        
    }
}
