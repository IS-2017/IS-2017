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
    public partial class frm_area_grid : Form
    {
        public frm_area_grid()
        {
            InitializeComponent();
        }
        Boolean Editar1;
        CapaNegocio fn = new CapaNegocio();
        String id_area_trabajo_pk, puesto, descripcion, fecha;
        #region Boton Nuevo - Cristian Estrada
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try {
                Editar1 = false;
                frm_area a = new frm_area(dataGridView1, id_area_trabajo_pk, puesto, descripcion, fecha, Editar1);
                a.StartPosition = FormStartPosition.CenterScreen;
                a.MdiParent = this.ParentForm;
                a.Show(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Actualizar - Cristian Estrada
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try {
                string tabla = "area_trabajo";
                fn.ActualizarGrid(this.dataGridView1, "Select * from area_trabajo where estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton anterior - Cristian Estrada
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dataGridView1);
        }
        #endregion

        #region Carga de datos en el listado al form- Cristian Estrada
        private void frm_area_grid_Load(object sender, EventArgs e)
        {
            try {
                string tabla = "area_trabajo";
                fn.ActualizarGrid(this.dataGridView1, "Select * from area_trabajo WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Carga de datos al from de area de trabajo - Cristian Estrada

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            id_area_trabajo_pk = this.dataGridView1.CurrentRow.Cells[0].Value.ToString(); 
            puesto = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            descripcion = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fecha = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm_area a = new frm_area(dataGridView1, id_area_trabajo_pk, puesto, descripcion, fecha, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }
        #endregion

        #region Boton Siguiente - Crisitian Estrada
        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try {
                fn.Siguiente(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Boton Primero - Cristian Estrada
        private void btn_primero_Click(object sender, EventArgs e)
        {
            try {
                fn.Primero(dataGridView1);
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
                fn.Ultimo(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
