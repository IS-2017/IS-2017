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
    public partial class frm_zona_emp_grid : Form
    {
        frm_empleado ownerForm = null;
        public frm_zona_emp_grid(frm_empleado ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;

        }
        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar1;
        Boolean tipo_accion;
        String id_zona_emp_pk, nombre_zona_emp, descripcion_zona_emp;
        public string nombre, codigo;



        public void frm_zona_emp_grid_Load(object sender, EventArgs e)
        {
            try
            {
                string tabla = "emp_zona";
                fn.ActualizarGrid(this.dgv_lista_zonas, "Select `id_zona_emp_pk`, `nombre_zona_emp`, `descripcion_zona_emp` from emp_zona WHERE estado <> 'INACTIVO' ", tabla);

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
                string tabla = "emp_zona";
                op.ejecutar(dgv_lista_zonas, tabla);
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
                string tabla = "emp_zona";
                fn.ActualizarGrid(this.dgv_lista_zonas, "Select `id_zona_emp_pk`, `nombre_zona_emp`, `descripcion_zona_emp` from emp_zona WHERE estado <> 'INACTIVO' ", tabla);
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
                fn.Anterior(dgv_lista_zonas);
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
                fn.Siguiente(dgv_lista_zonas);
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
                fn.Primero(dgv_lista_zonas);
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
                fn.Ultimo(dgv_lista_zonas);
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
                id_zona_emp_pk = this.dgv_lista_zonas.CurrentRow.Cells[0].Value.ToString();
                nombre_zona_emp = this.dgv_lista_zonas.CurrentRow.Cells[1].Value.ToString();
                descripcion_zona_emp = this.dgv_lista_zonas.CurrentRow.Cells[2].Value.ToString();
                frm_zona_emp zona = new frm_zona_emp(dgv_lista_zonas, id_zona_emp_pk, nombre_zona_emp, descripcion_zona_emp, Editar1, tipo_accion);
                zona.MdiParent = this.ParentForm;
                zona.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_lista_zonas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                try
                {
                    Editar1 = true;
                    tipo_accion = true;
                    id_zona_emp_pk = this.dgv_lista_zonas.CurrentRow.Cells[0].Value.ToString();
                    nombre_zona_emp = this.dgv_lista_zonas.CurrentRow.Cells[1].Value.ToString();
                    descripcion_zona_emp = this.dgv_lista_zonas.CurrentRow.Cells[2].Value.ToString();
                    frm_zona_emp zona = new frm_zona_emp(dgv_lista_zonas, id_zona_emp_pk, nombre_zona_emp, descripcion_zona_emp, Editar1, tipo_accion);
                    zona.MdiParent = this.ParentForm;
                    zona.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
        private void dgv_lista_zonas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*try
            {
                id_zona_emp_pk = this.dgv_lista_zonas.CurrentRow.Cells[0].Value.ToString();
                nombre_zona_emp = this.dgv_lista_zonas.CurrentRow.Cells[1].Value.ToString();
                txt_id_zona_pasar.Text = id_zona_emp_pk;
                txt_nombre_zona_pasar.Text = nombre_zona_emp;
                this.ownerForm.PassValue(txt_nombre_zona_pasar.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                tipo_accion = false;
                frm_zona_emp zona = new frm_zona_emp(dgv_lista_zonas, id_zona_emp_pk, nombre_zona_emp, descripcion_zona_emp, Editar1, tipo_accion);
                zona.MdiParent = this.ParentForm;
                zona.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
