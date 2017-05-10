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
    public partial class frm_calificacion_evaluacion_grid : Form
    {
        String id_evaluacion_pk, descripcion, puntuacion,  id_candidato_pk, id_examen_evaluacion_fk;
        Boolean Editar1;
        CapaNegocio fn = new CapaNegocio();

        #region Boton Actualizar - Otto Hernandez
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "evaluacion";
                fn.ActualizarGrid(this.dgv_cal_ev_busq,"Select * from evaluacion WHERE estado <> 'INACTIVO' ", tabla);
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
                fn.Siguiente(dgv_cal_ev_busq);
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
                fn.Primero(dgv_cal_ev_busq);
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
                fn.Ultimo(dgv_cal_ev_busq);
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
                fn.Anterior(dgv_cal_ev_busq);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void txt_exa_busq_cal_ev_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string tabla = "evaluacion";
                fn.ActualizarGrid(this.dgv_cal_ev_busq, "select * from evaluacion where id_examen_evaluacion_fk like '" + txt_exa_busq_cal_ev.Text + "%' and estado <> 'INACTIVO'", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_cal_ev_busq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar1 = true;
                id_evaluacion_pk = this.dgv_cal_ev_busq.CurrentRow.Cells[0].Value.ToString();
                descripcion = this.dgv_cal_ev_busq.CurrentRow.Cells[1].Value.ToString();
                puntuacion = this.dgv_cal_ev_busq.CurrentRow.Cells[2].Value.ToString();
                id_candidato_pk = this.dgv_cal_ev_busq.CurrentRow.Cells[4].Value.ToString();
                id_examen_evaluacion_fk = this.dgv_cal_ev_busq.CurrentRow.Cells[5].Value.ToString();
                frm_calificacion_evaluacion a = new frm_calificacion_evaluacion(dgv_cal_ev_busq, id_evaluacion_pk, descripcion, puntuacion, id_candidato_pk, id_examen_evaluacion_fk, Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        #region Boton Buscar
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "evaluacion";
                //op.ejecutar(dgv_rec_busq, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        
        public frm_calificacion_evaluacion_grid()
        {
            InitializeComponent();
        }

        
        private void frm_calificacion_evaluacion_grid_Load(object sender, EventArgs e)
        {
            try
            {
                string tabla = "evaluacion";
                fn.ActualizarGrid(this.dgv_cal_ev_busq, "Select * from evaluacion WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Boton Nuevo - Otto Hernandez
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                frm_calificacion_evaluacion a = new frm_calificacion_evaluacion(dgv_cal_ev_busq, id_evaluacion_pk, descripcion, puntuacion, id_candidato_pk, id_examen_evaluacion_fk, Editar1);
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
