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
using System.Text.RegularExpressions;

namespace contrato_trabajo
{
    public partial class frm_medio_distribucion : Form
    {
        #region variables - Otto Hernandez
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String Codigo;
        String atributo;
        DataGridView dg;
        #endregion

        #region Inicializar form - Otto Hernandez
        public frm_medio_distribucion()
        {
            InitializeComponent();
        }

        public frm_medio_distribucion(DataGridView gb, String id_medio_distribucion, String nombre_medio, String correo_medio, String telefono_medio, String url_medio, Boolean Editar1)
        {
            try
            {
                this.dg = gb;
                this.Editar = Editar1;
                InitializeComponent();
                atributo = "id_medio_distribucion";
                this.Codigo = id_medio_distribucion;
                if (Editar == true)
                {
                    this.txt_correo_medio.Text = correo_medio;
                    this.txt_nombre_medio.Text = nombre_medio;
                    this.txt_telefono_medio.Text = telefono_medio;
                    this.txt_url_medio.Text = url_medio;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_medio_distribucion_Load(object sender, EventArgs e)
        {
            try
            {
                fn.InhabilitarComponentes(gpb_medio_distribucion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Nuevo - Otto Hernandez
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                txt_correo_medio.Enabled = true; txt_nombre_medio.Enabled = true; txt_telefono_medio.Enabled = true; txt_url_medio.Enabled = true;
                txt_correo_medio.Text = ""; txt_nombre_medio.Text = ""; txt_telefono_medio.Text = ""; txt_url_medio.Text = "";
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
                TextBox[] textbox = { txt_correo_medio, txt_estado_medio, txt_nombre_medio, txt_telefono_medio, txt_url_medio };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "medio_distribucion";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /*bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_dep.Text, "documento");
                        if (insertar == 0)
                        {
                            btn_guardar.Enabled = false;
                        }*/
                        txt_correo_medio.Text = ""; txt_nombre_medio.Text = ""; txt_telefono_medio.Text = ""; txt_url_medio.Text = "";
                        txt_correo_medio.Enabled = false; txt_nombre_medio.Enabled = false; txt_telefono_medio.Enabled = false; txt_url_medio.Enabled = false;
                        fn.ActualizarGrid(this.dg, "Select * from medio_distribucion WHERE estado <> 'INACTIVO' ", tabla);
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_correo_medio.Text = ""; txt_nombre_medio.Text = ""; txt_telefono_medio.Text = ""; txt_url_medio.Text = "";
                        txt_correo_medio.Enabled = false; txt_nombre_medio.Enabled = false; txt_telefono_medio.Enabled = false; txt_url_medio.Enabled = false;
                        fn.ActualizarGrid(this.dg, "Select * from medio_distribucion WHERE estado <> 'INACTIVO' ", tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Editar - Otto Hernandez
        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_correo_medio.Enabled = true; txt_nombre_medio.Enabled = true; txt_telefono_medio.Enabled = true; txt_url_medio.Enabled = true;
                Editar = true;
                atributo = "id_medio_distribucion";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_medio.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_correo_medio.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_telefono_medio.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_url_medio.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
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
                String atributo2 = "id_medio_distribucion";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "medio_distribucion";
                    fn.eliminar(tabla, atributo2, codigo2);
                    fn.ActualizarGrid(this.dg, "Select * from medio_distribucion WHERE estado <> 'INACTIVO' ", tabla);
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //bita.Eliminar("Eliminacion de empresa con el numero: " + codigo2, "empresa");
                    txt_correo_medio.Text = ""; txt_nombre_medio.Text = ""; txt_telefono_medio.Text = ""; txt_url_medio.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton Buscar - Otto Hernandez
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "medio_distribucion";
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
                txt_correo_medio.Enabled = false; txt_nombre_medio.Enabled = false; txt_telefono_medio.Enabled = false; txt_url_medio.Enabled = false;
                txt_correo_medio.Text = ""; txt_nombre_medio.Text = ""; txt_telefono_medio.Text = ""; txt_url_medio.Text = "";
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
                string tabla = "medio_distribucion";
                fn.ActualizarGrid(this.dg, "Select * from medio_distribucion WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Botones de Navegacion - Otto Hernandez
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                TextBox[] textbox = { txt_correo_medio, txt_nombre_medio, txt_telefono_medio, txt_url_medio};
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
                TextBox[] textbox = { txt_correo_medio, txt_nombre_medio, txt_telefono_medio, txt_url_medio };
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
                TextBox[] textbox = { txt_correo_medio, txt_nombre_medio, txt_telefono_medio, txt_url_medio };
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
                TextBox[] textbox = { txt_correo_medio, txt_nombre_medio, txt_telefono_medio, txt_url_medio };
                fn.llenartextbox(textbox, dg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Reporteador- Otto Hernandez
        private void button1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Validaciones - Otto Hernandez
        public void validacion_solonumerocondosdecimales(KeyPressEventArgs e, TextBox textbox)
        {
            try
            {
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                    return;
                }


                bool IsDec = false;
                int nroDec1 = 0, nroDec = 0;

                for (int i = 0; i < textbox.Text.Length; i++)
                {
                    if (textbox.Text[i] != '.' && !IsDec)
                    {
                        nroDec++;
                    }
                    if (textbox.Text[i] == '.')
                        IsDec = true;
                    if (nroDec >= 7 || IsDec && nroDec1++ >= 2)
                    {
                        if (nroDec >= 7)
                        {
                            MessageBox.Show("El numero no puede ser mayor a 7 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            e.Handled = true;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("El numero no puede tener mas de dos numeros despues del punto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            e.Handled = true;
                            return;
                        }
                    }
                }

                if (e.KeyChar >= 48 && e.KeyChar <= 57)
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == 46)
                {
                    e.Handled = (IsDec) ? true : false;
                }
                else
                {
                    MessageBox.Show("Llene el campo con numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                }

            }
            catch
            {
                //MessageBox.Show("Llene el campo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


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
            catch
            {
                // MessageBox.Show("Llene el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void validacion_solonumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
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
                    MessageBox.Show("Llene el campo con numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                //MessageBox.Show("Llene el campo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        public static bool validarEmail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                { return true; }
                else
                { return false; }
            }
            else
            { return false; }
        }

        private void txt_correo_medio_Leave(object sender, EventArgs e)
        {
            if (validarEmail(txt_correo_medio.Text))
            {
            }
            else
            {
                MessageBox.Show("Direccion de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com," +
                "por favor seleccione un correo valido", "validacion de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_correo_medio.SelectAll();
                txt_correo_medio.Focus();
            }
        }
        #endregion

        #region Keypress de textbox - Otto Hernandez
        private void txt_nombre_medio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_telefono_medio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                validacion_solonumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

    }
}
