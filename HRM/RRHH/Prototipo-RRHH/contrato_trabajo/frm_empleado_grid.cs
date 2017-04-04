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
    public partial class frm_empleado_grid : Form
    {
        public frm_empleado_grid()
        {
            InitializeComponent();
        }

        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar;
        Boolean tipo_accion;
        String id_empleado_pk, nombre_emp, apellido_emp, dpi_emp, telefono_hogar_emp, telefono_movil_emp, no_afiliacionIGSS_emp, fecha_de_alta_emp, fecha_de_baja_emp, estadolaboral;

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Ultimo(dgv_lista_emps);
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
                fn.Primero(dgv_lista_emps);
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
                fn.Siguiente(dgv_lista_emps);
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
                fn.Anterior(dgv_lista_emps);
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
                string tabla = "empleado";
                op.ejecutar(dgv_lista_emps, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                frm_empleado empleados = new frm_empleado(dgv_lista_emps, id_empleado_pk, nombre_emp, apellido_emp, dpi_emp, telefono_hogar_emp, telefono_movil_emp, no_afiliacionIGSS_emp, fecha_de_alta_emp, fecha_de_baja_emp, estadolaboral, Editar, tipo_accion);
                empleados.MdiParent = this.ParentForm;
                empleados.Show();
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
                string tabla = "empleado";
                //fn.ActualizarGrid(this.dgv_lista_emps, "Select `id_empleado_pk`, `nombre_emp`, `apellido_emp`, `dpi_emp`, `telefono_hogar_emp`, `telefono_movil_emp`, `no_afiliacionIGSS_emp`, `fecha_de_alta_emp`, `fecha_de_baja_emp`, `estadolaboral`  from empleado WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_lista_emps_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar = true;
                tipo_accion = true;


               /* id_empleado_pk = this.dgv_lista_emps.CurrentRow.Cells[0].Value.ToString();
                nombre_emp = this.dgv_lista_emps.CurrentRow.Cells[1].Value.ToString();
                apellido_emp = this.dgv_lista_emps.CurrentRow.Cells[2].Value.ToString();
                dpi_emp = this.dgv_lista_emps.CurrentRow.Cells[3].Value.ToString();
                telefono_hogar_emp = this.dgv_lista_emps.CurrentRow.Cells[4].Value.ToString();
                telefono_movil_emp = this.dgv_lista_emps.CurrentRow.Cells[5].Value.ToString();
                no_afiliacionIGSS_emp = this.dgv_lista_emps.CurrentRow.Cells[6].Value.ToString();
                fecha_de_alta_emp = this.dgv_lista_emps.CurrentRow.Cells[7].Value.ToString();
                fecha_de_baja_emp = this.dgv_lista_emps.CurrentRow.Cells[8].Value.ToString();
                estadolaboral = this.dgv_lista_emps.CurrentRow.Cells[9].Value.ToString();
                */
                frm_empleado empleado = new frm_empleado(dgv_lista_emps, id_empleado_pk, nombre_emp, apellido_emp, dpi_emp, telefono_hogar_emp, telefono_movil_emp, no_afiliacionIGSS_emp, fecha_de_alta_emp, fecha_de_baja_emp, estadolaboral, Editar, tipo_accion);
                empleado.MdiParent = this.ParentForm;
                empleado.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_empleado_grid_Load(object sender, EventArgs e)
        {
            try
            {
                string tabla = "empleado";
                //fn.ActualizarGrid(this.dgv_lista_emps, "Select `id_empleado_pk`, `nombre_emp`, `apellido_emp`, `dpi_emp`, `telefono_hogar_emp`, `telefono_movil_emp`, `no_afiliacionIGSS_emp`, `fecha_de_alta_emp`, `fecha_de_baja_emp`, `estadolaboral`  from empleado WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
