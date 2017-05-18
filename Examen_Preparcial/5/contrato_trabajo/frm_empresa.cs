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
    public partial class frm_empresa : Form
    {
        #region Variables - Otto Hernandez
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String Codigo;
        String atributo;
        DataGridView dg;
        #endregion

        #region load form - Otto Hernandez
        public frm_empresa()
        {
            InitializeComponent();
        }

        public frm_empresa(DataGridView gb, String id_empresa_pk, String nombre_empresa, String direccion_empresa, String NIT_empresa, String telefono_empresa, String correo_empresa,Boolean Editar1)
        {
            this.dg = gb;
            this.Editar = Editar1;
            InitializeComponent();
            atributo = "id_empresa_pk";
            this.Codigo = id_empresa_pk;
            if(Editar == true)
            {
                this.txt_direccion_empresa.Text = direccion_empresa;
                this.txt_email_empresa.Text = correo_empresa;
                this.txt_nit_empresa.Text = NIT_empresa;
                this.txt_nombre_empresa.Text = nombre_empresa;
                this.txt_telefono_empresa.Text = telefono_empresa;
            }
        }

        private void frm_empresa_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_datos_empresa);
        }
        #endregion

        #region boton nuevo - Otto Hernandez
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                txt_direccion_empresa.Enabled = true; txt_email_empresa.Enabled = true; txt_nit_empresa.Enabled = true; txt_nombre_empresa.Enabled = true; txt_telefono_empresa.Enabled = true;
                txt_direccion_empresa.Text = ""; txt_email_empresa.Text = ""; txt_nit_empresa.Text = ""; txt_nombre_empresa.Text = ""; txt_telefono_empresa.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Guardar - Otto Hernandez
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox[] textbox = { txt_direccion_empresa,txt_email_empresa,txt_nit_empresa,txt_nombre_empresa,txt_telefono_empresa,txt_estado };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "empresa";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /*bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_dep.Text, "documento");
                        if (insertar == 0)
                        {
                            btn_guardar.Enabled = false;
                        }*/
                        fn.ActualizarGrid(this.dg, "Select id_empresa_pk, id_area_trabajo_pk, nombre_empresa, direccion_empresa, NIT_empresa, telefono_empresa, correo_empresa from empresa WHERE estado <> 'INACTIVO' ", tabla);
                        txt_direccion_empresa.Enabled = false; txt_email_empresa.Enabled = false; txt_nit_empresa.Enabled = false; txt_nombre_empresa.Enabled = false; txt_telefono_empresa.Enabled = false;
                        txt_direccion_empresa.Text = ""; txt_email_empresa.Text = ""; txt_nit_empresa.Text = ""; txt_nombre_empresa.Text = ""; txt_telefono_empresa.Text = "";

                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fn.ActualizarGrid(this.dg, "Select id_empresa_pk, id_area_trabajo_pk, nombre_empresa, direccion_empresa, NIT_empresa, telefono_empresa, correo_empresa from empresa WHERE estado <> 'INACTIVO' ", tabla);
                        txt_direccion_empresa.Enabled = false; txt_email_empresa.Enabled = false; txt_nit_empresa.Enabled = false; txt_nombre_empresa.Enabled = false; txt_telefono_empresa.Enabled = false;
                        txt_direccion_empresa.Text = ""; txt_email_empresa.Text = ""; txt_nit_empresa.Text = ""; txt_nombre_empresa.Text = ""; txt_telefono_empresa.Text = "";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton Editar - Otto Hernandez
        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_direccion_empresa.Enabled = true; txt_email_empresa.Enabled = true; txt_nit_empresa.Enabled = true; txt_nombre_empresa.Enabled = true; txt_telefono_empresa.Enabled = true;
                Editar = true;
                atributo = "id_empresa_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_empresa.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_direccion_empresa.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_nit_empresa.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_telefono_empresa.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
                this.txt_email_empresa.Text = this.dg.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a modificar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton Eliminar - Otto Hernandez
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_empresa_pk";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "empresa";
                    fn.eliminar(tabla, atributo2, codigo2);
                    fn.ActualizarGrid(this.dg, "Select id_empresa_pk, id_area_trabajo_pk, nombre_empresa, direccion_empresa, NIT_empresa, telefono_empresa, correo_empresa from empresa WHERE estado <> 'INACTIVO' ", tabla);
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //bita.Eliminar("Eliminacion de empresa con el numero: " + codigo2, "empresa");
                    txt_direccion_empresa.Enabled = false; txt_email_empresa.Enabled = false; txt_nit_empresa.Enabled = false; txt_nombre_empresa.Enabled = false; txt_telefono_empresa.Enabled = false;
                    txt_direccion_empresa.Text = ""; txt_email_empresa.Text = ""; txt_nit_empresa.Text = ""; txt_nombre_empresa.Text = ""; txt_telefono_empresa.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Botones de Navegacion - Otto Hernandez
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                TextBox[] textbox = { txt_direccion_empresa, txt_email_empresa, txt_nit_empresa, txt_nombre_empresa, txt_telefono_empresa };
                fn.llenartextbox(textbox, dg);
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
                TextBox[] textbox = { txt_direccion_empresa, txt_email_empresa, txt_nit_empresa, txt_nombre_empresa, txt_telefono_empresa };
                fn.llenartextbox(textbox, dg);
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
                TextBox[] textbox = { txt_direccion_empresa, txt_email_empresa, txt_nit_empresa, txt_nombre_empresa, txt_telefono_empresa };
                fn.llenartextbox(textbox, dg);
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
                TextBox[] textbox = { txt_direccion_empresa, txt_email_empresa, txt_nit_empresa, txt_nombre_empresa, txt_telefono_empresa };
                fn.llenartextbox(textbox, dg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Boton Buscar - Otto Hernandez
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "empresa";
                //op.ejecutar(this.dg, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Cancelar - Otto Hernandez
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                txt_direccion_empresa.Enabled = false; txt_email_empresa.Enabled = false; txt_nit_empresa.Enabled = false; txt_nombre_empresa.Enabled = false; txt_telefono_empresa.Enabled = false;
                txt_direccion_empresa.Text = ""; txt_email_empresa.Text = ""; txt_nit_empresa.Text = ""; txt_nombre_empresa.Text = ""; txt_telefono_empresa.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Actualizar - Otto Hernandez
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "empresa";
                fn.ActualizarGrid(this.dg, "Select id_empresa_pk, id_area_trabajo_pk, nombre_empresa, direccion_empresa, NIT_empresa, telefono_empresa, correo_empresa from empresa WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        #region validar letras - Otto Hernandez
        public void validacion_sololetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Llene el campo con letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_nombre_empresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                validacion_sololetras(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
