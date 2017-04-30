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
    public partial class frm_ubicacion : Form
    {
        #region Inicio - Cristian Estrada
        public frm_ubicacion()
        {
            InitializeComponent();
        }
        #endregion
        #region Variables - Cristian Estrada
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar = false;
        String Codigo;
        String atributo;
        #endregion

        #region Boton Nuevo - Cristian Estrada
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_ubicaciones);
                fn.LimpiarComponentes(gpb_ubicaciones);
                dgv_ubicacion.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Cancelar- Cristian Estrada
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                fn.ActivarControles(gpb_ubicaciones);
               
                fn.LimpiarComponentes(gpb_ubicaciones);
                fn.InhabilitarComponentes(gpb_ubicaciones);
                dgv_ubicacion.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Guardar - Cristian Estrada

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
               

                TextBox[] textbox = { txt_cuidad, txt_estable, txt_pais, txt_ubi };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "ubicacion";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);


                    }
                    else
                    {
                        fn.insertar(datos, tabla);

                    }
                    fn.LimpiarComponentes(gpb_ubicaciones);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton Eiditar - Cristian Estrada
        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                fn.ActivarControles(gpb_ubicaciones);
                atributo = "id_ubicacion_pk";
                Codigo = dgv_ubicacion.CurrentRow.Cells[0].Value.ToString();
                txt_estable.Text = dgv_ubicacion.CurrentRow.Cells[5].Value.ToString();
                txt_ubi.Text = dgv_ubicacion.CurrentRow.Cells[3].Value.ToString();
                txt_cuidad.Text = dgv_ubicacion.CurrentRow.Cells[1].Value.ToString();
                txt_pais.Text = dgv_ubicacion.CurrentRow.Cells[2].Value.ToString();

            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a modificar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton Eliminar - Cristian Estrada

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = dgv_ubicacion.CurrentRow.Cells[0].Value.ToString(); ;
                String atributo2 = "id_ubicacion_pk";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "ubicacion";
                    fn.eliminar(tabla, atributo2, codigo2);
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

        #region Boton Actualizar - Cristian Estrada
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "ubicacion";
            fn.ActualizarGrid(dgv_ubicacion, "Select * from ubicacion where estado <> 'INACTIVO' ", tabla);
        }
        #endregion

        #region Cargar datos en el form - Cristian Estrada
        private void frm_ubicacion_Load(object sender, EventArgs e)
        {
            string tabla = "ubicacion";
            fn.ActualizarGrid(dgv_ubicacion, "Select * from ubicacion where estado <> 'INACTIVO' ", tabla);
            fn.InhabilitarComponentes(gpb_ubicaciones);
            dgv_ubicacion.Columns[4].Visible = false;
        }
        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        #endregion

        #region  Boton anterior - Cristian Estrada
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_ubicacion);
            TextBox[] textbox = { txt_cuidad,txt_pais, txt_ubi, txt_estable};
            fn.llenartextbox(textbox, dgv_ubicacion);
           
        }
        #endregion

        #region Boton Siguiente - Cristian Estrada
        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_ubicacion);
            TextBox[] textbox = { txt_cuidad, txt_pais, txt_ubi, txt_estable };
            fn.llenartextbox(textbox, dgv_ubicacion);
        }
        #endregion

        #region Boton Primero - Cristian Estrada
        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_ubicacion);
            TextBox[] textbox = { txt_cuidad, txt_pais, txt_ubi, txt_estable };
            fn.llenartextbox(textbox, dgv_ubicacion);
        }
        #endregion

        #region Ultimo - Cristian Estrada
        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_ubicacion);
            TextBox[] textbox = { txt_cuidad, txt_pais, txt_ubi, txt_estable };
            fn.llenartextbox(textbox, dgv_ubicacion);
        }
        #endregion
    }
}
