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
    public partial class frm_grid_medio_distribucion : Form
    {
        #region variables - Otto Hernandez
        String id_medio_distribucion, nombre_medio, correo_medio, telefono_medio, url_medio;
        Boolean Editar1;
        CapaNegocio fn = new CapaNegocio();
        #endregion

        #region Inicializar - Otto Hernandez
        public frm_grid_medio_distribucion()
        {
            InitializeComponent();
        }

        private void frm_grid_medio_distribucion_Load(object sender, EventArgs e)
        {
            try
            {
                string tabla = "medio_distribucion";
                fn.ActualizarGrid(this.dgv_medio_busq, "Select * from medio_distribucion WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Botones Navegacion - Otto Hernandez
        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Siguiente(dgv_medio_busq);
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
                fn.Primero(dgv_medio_busq);
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
                fn.Ultimo(dgv_medio_busq);
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
                fn.Anterior(dgv_medio_busq);
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
                string tabla = "medio_distribucion";
                //op.ejecutar(dgv_rec_busq, tabla);
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
                frm_medio_distribucion a = new frm_medio_distribucion(dgv_medio_busq, id_medio_distribucion, nombre_medio, correo_medio, telefono_medio, url_medio, Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region KeyUp busqueda - Otto Hernandez
        private void txt_nombre_busq_medio_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string tabla = "medio_distribucion";
                fn.ActualizarGrid(this.dgv_medio_busq, "select * from medio_distribucion where nombre_medio like '" + txt_nombre_busq_medio.Text + "%' and estado <> 'INACTIVO'", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Doble Click DataGrid - Otto Hernandez
        private void dgv_medio_busq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar1 = true;
                id_medio_distribucion = this.dgv_medio_busq.CurrentRow.Cells[0].Value.ToString();
                nombre_medio = this.dgv_medio_busq.CurrentRow.Cells[1].Value.ToString();
                correo_medio = this.dgv_medio_busq.CurrentRow.Cells[2].Value.ToString();
                telefono_medio = this.dgv_medio_busq.CurrentRow.Cells[3].Value.ToString();
                url_medio = this.dgv_medio_busq.CurrentRow.Cells[4].Value.ToString();
                frm_medio_distribucion a = new frm_medio_distribucion(dgv_medio_busq, id_medio_distribucion, nombre_medio, correo_medio, telefono_medio, url_medio, Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
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
                fn.ActualizarGrid(this.dgv_medio_busq, "Select * from medio_distribucion WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

    }
}
