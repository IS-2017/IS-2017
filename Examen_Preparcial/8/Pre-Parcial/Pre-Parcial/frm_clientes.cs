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
    public partial class frm_clientes : Form
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

        public frm_clientes(DataGridView dgv, String id_cliente_pk, String nombre_cliente, String direccion_cliente, String telefono_cliente, String dpi_cliente, String nit_cliente, String estado, Boolean Editar1, Boolean tipo_accion)
        {
            this.dg = dgv;
            this.Editar = Editar1;
            InitializeComponent();
            atributo = "id_cliente_pk";
            this.Codigo = id_cliente_pk;
            if (tipo_accion == true)
            {
                txt_nombre_client.Text = nombre_cliente;
                txt_direccion_cliente.Text = direccion_cliente;
                txt_telefono_cliente.Text = telefono_cliente;
                txt_dpi.Text = dpi_cliente;
                txt_nit.Text = nit_cliente;
            }
            else
            {
                fn.ActivarControles(gpb_datos);
            }
        }

        private void frm_clientes_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_datos);
            fn.InhabilitarComponentes(this);
        }

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
            fn.ActivarControles(gpb_datos);
            fn.LimpiarComponentes(gpb_datos);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_estado.Text = "ACTIVO";
                TextBox[] textbox = { txt_nombre_client, txt_direccion_cliente, txt_telefono_cliente, txt_dpi, txt_nit, txt_estado };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "cliente";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fn.InhabilitarComponentes(gpb_datos);
                        Actualizar_grid_cliente();
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fn.InhabilitarComponentes(gpb_datos);
                        Conexionmysql.ObtenerConexion();
                        Actualizar_grid_cliente();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Actualizar_grid_cliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Actualizar_grid_cliente()
        {
            try
            {
                string tabla = "cliente";
                fn.ActualizarGrid(this.dg, "SELECT id_cliente_pk, nombre_cliente, direccion_cliente, telefono_cliente, dpi_cliente, nit_cliente FROM `cliente` WHERE estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "id_cliente_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_client.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_direccion_cliente.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_telefono_cliente.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_dpi.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_nit.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
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
                String atributo2 = "id_cliente_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string tabla = "cliente";
                    fn.eliminar(tabla, atributo2, codigo2);
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar_grid_cliente();
                    Editar = false;
                    fn.InhabilitarComponentes(gpb_datos);
                    fn.LimpiarComponentes(gpb_datos);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_client.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_direccion_cliente.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_telefono_cliente.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_dpi.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_nit.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
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
                this.txt_nombre_client.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_direccion_cliente.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_telefono_cliente.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_dpi.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_nit.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Primero(dg);
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_client.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_direccion_cliente.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_telefono_cliente.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_dpi.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_nit.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
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
                this.txt_nombre_client.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_direccion_cliente.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_telefono_cliente.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_dpi.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_nit.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
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
                frm_reporte_clientes cliente = new frm_reporte_clientes();
                cliente.MdiParent = mdi_contenedor_Preparcial.ActiveForm.ParentForm;
                cliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
