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
    public partial class frm_reclutamiento_grid : Form
    {
        #region variables - Otto Hernandez
        String id_reclutamiento, id_perfil_reclutamiento, nombre, medio_distribucion;
        CapaNegocio fn = new CapaNegocio();
        Boolean Editar1;
        #endregion

        #region Inicializar - Otto Hernandez
        private void frm_reclutamiento_grid_Load(object sender, EventArgs e)
        {
            try
            {
                string tabla = "reclutamiento";
                fn.ActualizarGrid(this.dgv_principal, "Select * from reclutamiento WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public frm_reclutamiento_grid()
        {
            InitializeComponent();
        }
        #endregion

        #region Boton Buscar - Otto Hernandez
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "reclutamiento";
                //op.ejecutar(dgv_rec_busq, tabla);
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
                string tabla = "reclutamiento";
                fn.ActualizarGrid(this.dgv_principal, "Select * from reclutamiento WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Botones Navegacion - Otto Hernandez
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dgv_principal);
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
                fn.Siguiente(dgv_principal);
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
                fn.Primero(dgv_principal);
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
                fn.Ultimo(dgv_principal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Doble Click DataGrid - Otto Hernandez
        private void dgv_principal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar1 = true;
                id_reclutamiento = this.dgv_principal.CurrentRow.Cells[0].Value.ToString();
                nombre = this.dgv_principal.CurrentRow.Cells[1].Value.ToString();
                id_perfil_reclutamiento = this.dgv_principal.CurrentRow.Cells[3].Value.ToString();
                medio_distribucion = this.dgv_principal.CurrentRow.Cells[4].Value.ToString();
                frm_reclutamiento a = new frm_reclutamiento(dgv_principal, id_reclutamiento, id_perfil_reclutamiento, nombre, medio_distribucion, Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
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
                frm_reclutamiento a = new frm_reclutamiento(dgv_principal, id_reclutamiento, id_perfil_reclutamiento, nombre, medio_distribucion, Editar1);
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
