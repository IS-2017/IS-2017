using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contrato_trabajo
{
    public partial class frm_proveedor : Form
    {
        #region Variables - Otto Hernandez
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String Codigo;
        String atributo;
        DataGridView dg;
        #endregion

        #region Inicializar - Otto Hernandez

        public frm_proveedor()
        {
            InitializeComponent();
        }

        public frm_proveedor(DataGridView gb, string id_proveedor, string nombre_proveedor, string correo_proveedor, string telefono_proveedor, Boolean Editar1)
        {
            try
            {
                InitializeComponent();
                this.dg = gb;
                this.Editar = Editar1;
                atributo = "id_proveedor";
                this.Codigo = id_proveedor;
                if (Editar == true)
                {
                    this.txt_correo.Text = correo_proveedor;
                    this.txt_nombre.Text = nombre_proveedor;
                    this.txt_telefono.Text = telefono_proveedor;
                }
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
                txt_correo.Enabled = true; txt_nombre.Enabled = true; txt_telefono.Enabled = true;
                txt_correo.Text = ""; txt_nombre.Text = ""; txt_telefono.Text = "";
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
                TextBox[] textbox = { txt_correo, txt_estado, txt_nombre, txt_telefono};
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "proveedor";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        fn.ActualizarGrid(this.dg, "Select * from proveedor WHERE estado <> 'INACTIVO' ", tabla);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /*bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_dep.Text, "documento");
                        if (insertar == 0)
                        {
                            btn_guardar.Enabled = false;
                        }*/
                        txt_correo.Text = ""; txt_nombre.Text = ""; txt_telefono.Text = "";
                        txt_correo.Enabled = false; txt_nombre.Enabled = false; txt_telefono.Enabled = false;
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        fn.ActualizarGrid(this.dg, "Select * from proveedor WHERE estado <> 'INACTIVO' ", tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_correo.Text = ""; txt_nombre.Text = ""; txt_telefono.Text = "";
                        txt_correo.Enabled = false; txt_nombre.Enabled = false; txt_telefono.Enabled = false;
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
                txt_correo.Enabled = true; txt_nombre.Enabled = true; txt_telefono.Enabled = true;
                Editar = true;
                atributo = "id_proveedor";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_correo.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_telefono.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
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
                String atributo2 = "id_proveedor";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "proveedor";
                    fn.eliminar(tabla, atributo2, codigo2);
                    fn.ActualizarGrid(this.dg, "Select * from proveedor WHERE estado <> 'INACTIVO' ", tabla);
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //bita.Eliminar("Eliminacion de empresa con el numero: " + codigo2, "empresa");
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
                string tabla = "proveedor";
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
                txt_correo.Enabled = false; txt_nombre.Enabled = false; txt_telefono.Enabled = false;
                txt_correo.Text = ""; txt_nombre.Text = ""; txt_telefono.Text = "";
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
                string tabla = "proveedor";
                fn.ActualizarGrid(this.dg, "Select * from proveedor WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Reporteador - Otto Hernandez
        private void button1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Botones de navegacion - Otto Hernandez
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                TextBox[] textbox = { txt_correo, txt_nombre, txt_telefono};
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
                TextBox[] textbox = { txt_correo, txt_nombre, txt_telefono };
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
                TextBox[] textbox = { txt_correo, txt_nombre, txt_telefono };
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
                TextBox[] textbox = { txt_correo, txt_nombre, txt_telefono };
                fn.llenartextbox(textbox, dg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region load form - Otto Hernandez
        private void frm_proveedor_Load(object sender, EventArgs e)
        {
            try
            {
                fn.InhabilitarComponentes(gpb_producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        
    }
}
