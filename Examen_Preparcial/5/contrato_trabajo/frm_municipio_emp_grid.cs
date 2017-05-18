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
using dllconsultas;


namespace contrato_trabajo
{
    public partial class frm_municipio_emp_grid : Form
    {
        frm_empleado ownerForm = null;
        public frm_municipio_emp_grid(frm_empleado ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
        }
        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar1;
        Boolean tipo_accion;
        String id_municipio_pk, nombre_municipio, ciudad_municipio, ppueblo_municipio, aldea_municipio;

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                tipo_accion = false;
                frm_municipio_emp municip = new frm_municipio_emp(dgv_lista_municipio, id_municipio_pk, nombre_municipio, ciudad_municipio, ppueblo_municipio, aldea_municipio, Editar1, tipo_accion);
                municip.MdiParent = this.ParentForm;
                municip.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "emp_municipio";
                op.ejecutar(dgv_lista_municipio, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_municipio_emp_grid_Load(object sender, EventArgs e)
        {
            try
            {
                string tabla = "emp_municipio";
                fn.ActualizarGrid(this.dgv_lista_municipio, "Select `id_municipio_pk`, `nombre_municipio`, `ciudad_municipio`, `ppueblo_municipio`,`aldea_municipio`, `id_zona_emp_pk` from emp_municipio WHERE estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "emp_municipio";
                fn.ActualizarGrid(this.dgv_lista_municipio, "Select `id_municipio_pk`, `nombre_municipio`, `ciudad_municipio`, `ppueblo_municipio`,`aldea_municipio`, `id_zona_emp_pk` from emp_municipio WHERE estado = 'ACTIVO'", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = true;
                tipo_accion = true;
                id_municipio_pk = this.dgv_lista_municipio.CurrentRow.Cells[0].Value.ToString();
                nombre_municipio = this.dgv_lista_municipio.CurrentRow.Cells[1].Value.ToString();
                ciudad_municipio = this.dgv_lista_municipio.CurrentRow.Cells[2].Value.ToString();
                ppueblo_municipio = this.dgv_lista_municipio.CurrentRow.Cells[3].Value.ToString();
                aldea_municipio = this.dgv_lista_municipio.CurrentRow.Cells[4].Value.ToString();
                frm_municipio_emp zona = new frm_municipio_emp(dgv_lista_municipio, id_municipio_pk, nombre_municipio, ciudad_municipio, ppueblo_municipio, aldea_municipio, Editar1, tipo_accion);
                zona.MdiParent = this.ParentForm;
                zona.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_lista_municipio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           /* try
            {
                id_municipio_pk = this.dgv_lista_municipio.CurrentRow.Cells[0].Value.ToString();
                nombre_municipio = this.dgv_lista_municipio.CurrentRow.Cells[1].Value.ToString();
                ciudad_municipio = this.dgv_lista_municipio.CurrentRow.Cells[2].Value.ToString();
                ppueblo_municipio = this.dgv_lista_municipio.CurrentRow.Cells[1].Value.ToString();
                aldea_municipio = this.dgv_lista_municipio.CurrentRow.Cells[1].Value.ToString();

                txt_id_muni.Text = id_municipio_pk;
                txt_nombre_muni.Text = nombre_municipio;
                this.ownerForm.PassValue2(txt_id_muni.Text, txt_nombre_muni.Text, ciudad_municipio);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } */
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_lista_municipio);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_lista_municipio);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_lista_municipio);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_lista_municipio);
        }
    }
}
