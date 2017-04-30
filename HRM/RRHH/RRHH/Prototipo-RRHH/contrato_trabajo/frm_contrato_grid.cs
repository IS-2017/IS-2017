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
    public partial class frm_contrato_grid : Form
    {
        public frm_contrato_grid()
        {
            InitializeComponent();
        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar1;
        string id_empleado, nombre, apellido, id_empresa, nombre_empresa, fecha_alta, periodo_pago, id_jornada_trabajo, nombre_jornada, id_puesto, puesto, salario;

        private void cbo_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                capa_datos ca = new capa_datos();
                dgv_contratos.DataSource = ca.cargar("select  empleado.id_empleado_pk, nombre_emp, apellido_emp, empleado.id_empresa_pk, empresa.nombre_empresa, estadolaboral, fecha_de_alta_emp, periodo_pago, emp_jornadatrabajo.id_jornadatrabajo_pk, nombre_jornada, puesto_laboral.id_puesto_laboral_pk, nombre_puesto, salario_base, id_datopersonal from empleado inner join empresa on empleado.id_empresa_pk = empresa.id_empresa_pk inner join emp_jornadatrabajo on empleado.id_jornadatrabajo_pk = emp_jornadatrabajo.id_jornadatrabajo_pk inner join puesto_laboral on empleado.id_puesto_laboral_pk = puesto_laboral.id_puesto_laboral_pk inner join emp_datopersonal on empleado.id_empleado_pk = emp_datopersonal.id_empleado_pk where empleado.estadolaboral = 'PRUEBA' and empleado.estado = 'ACTIVO ' and empresa.id_empresa_pk = '" + cbo_empresa.SelectedValue.ToString() + "';");
            }
            catch { }
        }

        private void cbo_empresa_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_contratos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = false;
            id_empleado = this.dgv_contratos.CurrentRow.Cells[0].Value.ToString();
            nombre = this.dgv_contratos.CurrentRow.Cells[1].Value.ToString();
            apellido = this.dgv_contratos.CurrentRow.Cells[2].Value.ToString();
            id_empresa = this.dgv_contratos.CurrentRow.Cells[3].Value.ToString();
            nombre_empresa = this.dgv_contratos.CurrentRow.Cells[4].Value.ToString();
            fecha_alta = this.dgv_contratos.CurrentRow.Cells[6].Value.ToString();
            periodo_pago = this.dgv_contratos.CurrentRow.Cells[7].Value.ToString();
            id_jornada_trabajo = this.dgv_contratos.CurrentRow.Cells[8].Value.ToString();
            nombre_jornada = this.dgv_contratos.CurrentRow.Cells[9].Value.ToString();
            id_puesto = this.dgv_contratos.CurrentRow.Cells[10].Value.ToString();
            puesto = this.dgv_contratos.CurrentRow.Cells[11].Value.ToString();
            salario = this.dgv_contratos.CurrentRow.Cells[12].Value.ToString();

            frm_contrato_trabajo a = new frm_contrato_trabajo(dgv_contratos, id_empleado, nombre, apellido, id_empresa, nombre_empresa, fecha_alta, periodo_pago, id_jornada_trabajo, nombre_jornada, id_puesto, puesto, salario, Editar1);
            a.MdiParent = this.ParentForm; //para mostrar el formulario junto al papa
            a.Show();
        }

        private void dgv_contratos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            capa_datos ca = new capa_datos();
            dgv_contratos.DataSource = ca.cargar("select  empleado.id_empleado_pk, nombre_emp, apellido_emp, empleado.id_empresa_pk, empresa.nombre_empresa, estadolaboral, fecha_de_alta_emp, periodo_pago, emp_jornadatrabajo.id_jornadatrabajo_pk, nombre_jornada, puesto_laboral.id_puesto_laboral_pk, nombre_puesto, salario_base, id_datopersonal from empleado inner join empresa on empleado.id_empresa_pk = empresa.id_empresa_pk inner join emp_jornadatrabajo on empleado.id_jornadatrabajo_pk = emp_jornadatrabajo.id_jornadatrabajo_pk inner join puesto_laboral on empleado.id_puesto_laboral_pk = puesto_laboral.id_puesto_laboral_pk inner join emp_datopersonal on empleado.id_empleado_pk = emp_datopersonal.id_empleado_pk where empleado.estadolaboral = 'PRUEBA' and empleado.estado = 'ACTIVO ';");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            id_empleado = this.dgv_contratos.CurrentRow.Cells[0].Value.ToString();
            nombre = this.dgv_contratos.CurrentRow.Cells[1].Value.ToString();
            apellido = this.dgv_contratos.CurrentRow.Cells[2].Value.ToString();

            capa_datos ca = new capa_datos();

            int respo = ca.Ejecutar_Mysql("update empleado set estadolaboral='BAJA' where id_empleado_pk ='" + id_empleado + "';");

            if (respo == 1)
            {
                MessageBox.Show("El empleado '" + nombre + ' ' + apellido + "'fue despedido con éxito");
                dgv_contratos.DataSource = ca.cargar("select  empleado.id_empleado_pk, nombre_emp, apellido_emp, empleado.id_empresa_pk, empresa.nombre_empresa, estadolaboral, fecha_de_alta_emp, periodo_pago, emp_jornadatrabajo.id_jornadatrabajo_pk, nombre_jornada, puesto_laboral.id_puesto_laboral_pk, nombre_puesto, salario_base, id_datopersonal from empleado inner join empresa on empleado.id_empresa_pk = empresa.id_empresa_pk inner join emp_jornadatrabajo on empleado.id_jornadatrabajo_pk = emp_jornadatrabajo.id_jornadatrabajo_pk inner join puesto_laboral on empleado.id_puesto_laboral_pk = puesto_laboral.id_puesto_laboral_pk inner join emp_datopersonal on empleado.id_empleado_pk = emp_datopersonal.id_empleado_pk where empleado.estadolaboral = 'PRUEBA' and empleado.estado = 'ACTIVO ';");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar al empleado");
            }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_contratos);
        }

        private void gpb_navegador_Enter(object sender, EventArgs e)
        {

        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_contratos);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_contratos);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_contratos);
        }

        private void frm_contrato_grid_Load(object sender, EventArgs e)
        {
            capa_datos cp = new capa_datos();
            cp.llenar_id_empresa(cbo_empresa);
            cbo_empresa.SelectedIndex = -1;




            cbo_empresa.AutoCompleteCustomSource = capa_datos.LoadAutoComplete();
            cbo_empresa.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbo_empresa.AutoCompleteSource = AutoCompleteSource.CustomSource;



            dgv_contratos.DataSource = cp.cargar("select  empleado.id_empleado_pk, nombre_emp, apellido_emp, empleado.id_empresa_pk, empresa.nombre_empresa, estadolaboral, fecha_de_alta_emp, periodo_pago, emp_jornadatrabajo.id_jornadatrabajo_pk, nombre_jornada, puesto_laboral.id_puesto_laboral_pk, nombre_puesto, salario_base, id_datopersonal from empleado inner join empresa on empleado.id_empresa_pk = empresa.id_empresa_pk inner join emp_jornadatrabajo on empleado.id_jornadatrabajo_pk = emp_jornadatrabajo.id_jornadatrabajo_pk inner join puesto_laboral on empleado.id_puesto_laboral_pk = puesto_laboral.id_puesto_laboral_pk inner join emp_datopersonal on empleado.id_empleado_pk = emp_datopersonal.id_empleado_pk where empleado.estadolaboral = 'PRUEBA' and empleado.estado = 'ACTIVO ';");
            dgv_contratos.Columns[0].HeaderText = "ID Empleado";
            dgv_contratos.Columns[1].HeaderText = "Nombre ";
            dgv_contratos.Columns[2].HeaderText = "Apellido";
            dgv_contratos.Columns[3].HeaderText = "ID Empresa";
            dgv_contratos.Columns[4].HeaderText = "Nombre Empresa";
            dgv_contratos.Columns[5].HeaderText = "Estado Laboral";
            dgv_contratos.Columns[6].HeaderText = "Fecha de alta Empleado";
            dgv_contratos.Columns[7].HeaderText = "Periodo Pago ";
            dgv_contratos.Columns[8].HeaderText = "Id Jornada de Trabajo";
            dgv_contratos.Columns[9].HeaderText = "Nombre Jornada";
            dgv_contratos.Columns[10].HeaderText = "Id puesto Laboral";
            dgv_contratos.Columns[11].HeaderText = "Puesto Laboral";
            dgv_contratos.Columns[12].HeaderText = "Salario Base";
            dgv_contratos.Columns[13].HeaderText = "Datos Empleado";
            dgv_contratos.Columns[6].Visible = false;
            dgv_contratos.Columns[7].Visible = false;
            dgv_contratos.Columns[8].Visible = false;
            dgv_contratos.Columns[9].Visible = false;
            dgv_contratos.Columns[10].Visible = false;
            dgv_contratos.Columns[11].Visible = false;
            dgv_contratos.Columns[12].Visible = false;
            dgv_contratos.Columns[13].Visible = false;



        }
    }
}
