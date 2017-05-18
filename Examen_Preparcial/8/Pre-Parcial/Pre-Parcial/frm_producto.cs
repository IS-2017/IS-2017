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

namespace Pre_Parcial
{
    public partial class frm_producto : Form
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

        public frm_producto(DataGridView dgv, String id_producto_pk, String nombre_producto, String precio_producto, String descripcion_producto, String fecha_registro_producto, String id_proveedor_pk, String estado, Boolean Editar1, Boolean tipo_accion)
        {
            this.dg = dgv;
            this.Editar = Editar1;
            InitializeComponent();
            atributo = "id_cliente_pk";
            this.Codigo = id_producto_pk;
            if (tipo_accion == true)
            {
                this.txt_nombre.Text = nombre_producto;
                this.txt_nmup_precio.Text = precio_producto; nmup_precio.Value = Convert.ToDecimal(txt_nmup_precio.Text);
                this.txt_descripcion.Text = descripcion_producto;
                this.txt_dtp_fecha.Text = fecha_registro_producto; dtp_fecha.Text = txt_dtp_fecha.Text;
                this.txt_cbo_id_prov.Text = id_proveedor_pk; cbo_id_prov.SelectedValue = txt_cbo_id_prov.Text;
            }
            else
            {
                fn.ActivarControles(gpb_datos);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar_Componentes();
                txt_cbo_id_prov.Text = cbo_id_prov.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Limpiar_Componentes()
        {
            Editar = false;
            fn.ActivarControles(gpb_datos);
            fn.LimpiarComponentes(gpb_datos);
            nmup_precio.Value = 1;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Actualizar_grid_producto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Actualizar_grid_producto()
        {
            try
            {
                string tabla = "producto";
                fn.ActualizarGrid(this.dg, "SELECT id_producto_pk, nombre_producto, precio_producto, descripcion_producto, fecha_registro_producto, id_proveedor_pk FROM `producto` WHERE estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_estado.Text = "ACTIVO";
                TextBox[] textbox = { txt_nombre, txt_nmup_precio, txt_descripcion, txt_dtp_fecha, txt_cbo_id_prov, txt_estado };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "producto";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fn.InhabilitarComponentes(gpb_datos);
                        Actualizar_grid_producto();
                        Limpiar_Componentes();
                        txt_cbo_id_prov.Text = cbo_id_prov.SelectedValue.ToString();
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fn.InhabilitarComponentes(gpb_datos);
                        Conexionmysql.ObtenerConexion();
                        Actualizar_grid_producto();
                        Limpiar_Componentes();
                        txt_cbo_id_prov.Text = cbo_id_prov.SelectedValue.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "id_producto_pk";

                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_nmup_precio.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); nmup_precio.Value = Convert.ToDecimal(txt_nmup_precio.Text);
                this.txt_descripcion.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_dtp_fecha.Text = this.dg.CurrentRow.Cells[4].Value.ToString(); dtp_fecha.Text = txt_dtp_fecha.Text;
                this.txt_cbo_id_prov.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); cbo_id_prov.SelectedValue = txt_cbo_id_prov.Text;
                fn.ActivarControles(gpb_datos);
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_producto_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string tabla = "producto";
                    fn.eliminar(tabla, atributo2, codigo2);
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar_grid_producto();
                    Editar = false;
                    fn.InhabilitarComponentes(gpb_datos);
                    nmup_precio.Enabled = false;
                    fn.LimpiarComponentes(gpb_datos);
                    txt_nmup_precio.Text = "1";
                    txt_cbo_id_prov.Text = cbo_id_prov.SelectedItem.ToString();
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(gpb_datos);
                fn.InhabilitarComponentes(gpb_datos);
                nmup_precio.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nmup_precio_ValueChanged(object sender, EventArgs e)
        {
            //txt_nmup_precio.Text = nmup_precio.Value.ToString();
        }

        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            txt_dtp_fecha.Text = dtp_fecha.Text;
        }

        private void cbo_id_prov_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cbo_id_prov.Text = cbo_id_prov.SelectedValue.ToString();
        }

        public void Llenar_proveedor()
        {
            Conexionmysql.ObtenerConexion();
            DataSet ds = new DataSet();
            String Query = "SELECT id_proveedor_pk, nombre_proveedor FROM proveedor WHERE estado ='ACTIVO'";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            dad.Fill(ds, "proveedor");
            cbo_id_prov.DataSource = ds.Tables[0].DefaultView;
            cbo_id_prov.ValueMember = ("id_proveedor_pk");
            cbo_id_prov.DisplayMember = ("nombre_proveedor");
            Conexionmysql.Desconectar();
        }

        private void frm_producto_Load(object sender, EventArgs e)
        {
            Llenar_proveedor();
            fn.InhabilitarComponentes(gpb_datos);
            fn.InhabilitarComponentes(this);
            txt_cbo_id_prov.Text = cbo_id_prov.SelectedValue.ToString();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_nmup_precio.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); //nmup_precio.Value = Convert.ToDecimal(txt_nmup_precio.Text);
                this.txt_descripcion.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_dtp_fecha.Text = this.dg.CurrentRow.Cells[4].Value.ToString(); dtp_fecha.Text = txt_dtp_fecha.Text;
                this.txt_cbo_id_prov.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); cbo_id_prov.SelectedValue = txt_cbo_id_prov.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Siguiente(dg);
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_nmup_precio.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); //nmup_precio.Value = Convert.ToDecimal(txt_nmup_precio.Text);
                this.txt_descripcion.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_dtp_fecha.Text = this.dg.CurrentRow.Cells[4].Value.ToString(); dtp_fecha.Text = txt_dtp_fecha.Text;
                this.txt_cbo_id_prov.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); cbo_id_prov.SelectedValue = txt_cbo_id_prov.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nmup_precio_ValueChanged_1(object sender, EventArgs e)
        {
            txt_nmup_precio.Text = nmup_precio.Value.ToString();
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Primero(dg);
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_nmup_precio.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); //nmup_precio.Value = Convert.ToDecimal(txt_nmup_precio.Text);
                this.txt_descripcion.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_dtp_fecha.Text = this.dg.CurrentRow.Cells[4].Value.ToString(); dtp_fecha.Text = txt_dtp_fecha.Text;
                this.txt_cbo_id_prov.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); cbo_id_prov.SelectedValue = txt_cbo_id_prov.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Ultimo(dg);
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_nmup_precio.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); //nmup_precio.Value = Convert.ToDecimal(txt_nmup_precio.Text);
                this.txt_descripcion.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_dtp_fecha.Text = this.dg.CurrentRow.Cells[4].Value.ToString(); dtp_fecha.Text = txt_dtp_fecha.Text;
                this.txt_cbo_id_prov.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); cbo_id_prov.SelectedValue = txt_cbo_id_prov.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                frm_reporte_producto producto = new frm_reporte_producto();
                producto.MdiParent = mdi_contenedor_Preparcial.ActiveForm.ParentForm;
                producto.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
