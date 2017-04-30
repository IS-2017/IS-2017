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
    public partial class frm_area : Form
    {
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String Codigo;
        String atributo;
        DataGridView dg;

        #region Carga de datos al form - Cristian Estrada
        public frm_area(DataGridView gb, String id_area_trabajo_pk, String puesto, String descripcion, string date, Boolean Editar1)
        {
            InitializeComponent();
            this.dg = gb;
            this.Editar = Editar1;
            Codigo = id_area_trabajo_pk;
            atributo = "id_area_trabajo_pk";
            this.Codigo = id_area_trabajo_pk;
            
            this.txt_puesto.Text = puesto;
            this.txt_descrip.Text = descripcion;
            this.txt_fecha.Text = date; dtp_fecha.Text = txt_fecha.Text;
               
            
        }
        #endregion

        #region Boton Nuevo - Cristian Estrada
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_areas);
                fn.LimpiarComponentes(gpb_areas);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Carga de datos en el Form - Cristian Estrada
        private void frm_area_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_areas);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_fecha.Text = dtp_fecha.Value.ToString("yyyy-MM-dd");
               
                TextBox[] textbox = { txt_puesto,txt_descrip, txt_fecha};
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "area_trabajo";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                       
                      
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        
                    }
                    fn.LimpiarComponentes(gpb_areas);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton Editar - Cristian Estrada
        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                fn.ActivarControles(gpb_areas);
                atributo = "id_area_trabajo_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_puesto.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_descrip.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                
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
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_area_trabajo_pk";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "area_Trabajo";
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

        #region Boton Cancelar - Cristian Estrada
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                fn.ActivarControles(gpb_areas);
                Editar = true;
                fn.LimpiarComponentes(gpb_areas);
                fn.InhabilitarComponentes(gpb_areas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Anterior - Cristian Estrada
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try {
                fn.Anterior(dg);
                TextBox[] textbox = { txt_descrip, txt_fecha, txt_puesto };
                fn.llenartextbox(textbox, dg);
                dtp_fecha.Text = txt_fecha.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Siguiente - Cristian Estrada
        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try {
                fn.Siguiente(dg);
                TextBox[] textbox = { txt_descrip, txt_fecha, txt_puesto };
                fn.llenartextbox(textbox, dg);
                dtp_fecha.Text = txt_fecha.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Primer - Cristian Estrada
        private void btn_primero_Click(object sender, EventArgs e)
        {
            try {
                fn.Primero(dg);
                TextBox[] textbox = { txt_descrip, txt_fecha, txt_puesto };
                fn.llenartextbox(textbox, dg);
                dtp_fecha.Text = txt_fecha.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Ultimo - Cristian Estrada
        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            try {
                fn.Ultimo(dg);
                TextBox[] textbox = { txt_descrip, txt_fecha, txt_puesto };
                fn.llenartextbox(textbox, dg);
                dtp_fecha.Text = txt_fecha.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
