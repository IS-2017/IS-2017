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
    public partial class frm_empresa_grid : Form
    {
        #region Variables - Otto Hernandez
        String id_empresa_pk, nombre_empresa, direccion_empresa, correo_empresa, telefono_empresa, NIT_empresa;
        Boolean Editar1;
        CapaNegocio fn = new CapaNegocio();
        #endregion

        #region Boton Actualizar - Otto Hernandez
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "empresa";
                fn.ActualizarGrid(this.dgv_empresa, "Select id_empresa_pk, id_area_trabajo_pk, nombre_empresa, direccion_empresa, NIT_empresa, telefono_empresa, correo_empresa from empresa WHERE estado <> 'INACTIVO' ", tabla);
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
                fn.Anterior(dgv_empresa);
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
                fn.Siguiente(dgv_empresa);
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
                fn.Primero(dgv_empresa);
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
                fn.Ultimo(dgv_empresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Inicializar form - Otto Hernandez
        private void frm_empresa_grid_Load(object sender, EventArgs e)
        {
            try
            {
                string tabla = "empresa";
                fn.ActualizarGrid(this.dgv_empresa, "Select id_empresa_pk, id_area_trabajo_pk, nombre_empresa, direccion_empresa, NIT_empresa, telefono_empresa, correo_empresa from empresa WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public frm_empresa_grid()
        {
            InitializeComponent();
        }
        #endregion

        #region Doble clic - Otto Hernandez
        private void dgv_empresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar1 = true;
                id_empresa_pk = this.dgv_empresa.CurrentRow.Cells[0].Value.ToString();
                nombre_empresa = this.dgv_empresa.CurrentRow.Cells[2].Value.ToString();
                direccion_empresa = this.dgv_empresa.CurrentRow.Cells[3].Value.ToString();
                NIT_empresa = this.dgv_empresa.CurrentRow.Cells[4].Value.ToString();
                telefono_empresa = this.dgv_empresa.CurrentRow.Cells[5].Value.ToString();
                correo_empresa = this.dgv_empresa.CurrentRow.Cells[6].Value.ToString();
                frm_empresa a = new frm_empresa(dgv_empresa, id_empresa_pk, nombre_empresa, direccion_empresa, NIT_empresa, telefono_empresa, correo_empresa, Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
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
                //op.ejecutar(dgv_busqueda_documento, tabla);
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
                Editar1 = false;
                frm_empresa a = new frm_empresa(dgv_empresa,id_empresa_pk,nombre_empresa,direccion_empresa,NIT_empresa,telefono_empresa,correo_empresa,Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

    }
}
