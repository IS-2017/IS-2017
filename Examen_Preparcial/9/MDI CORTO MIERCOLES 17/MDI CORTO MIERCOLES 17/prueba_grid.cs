using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI_CORTO_MIERCOLES_17
{
    public partial class prueba_grid : Form
    {
        public prueba_grid()
        {
            InitializeComponent();
        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_prueba);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_prueba);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_prueba);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_prueba);
        }
        capa_datos cd = new capa_datos();
        private void prueba_grid_Load(object sender, EventArgs e)
        {
            dgv_prueba.DataSource = cd.cargar("select id_planilla_igss_pk,porcentaje_igss_laboral,porcentaje_igss_patronal,fecha,id_empresa_pk from planilla_igss where estado='ACTIVO'");
            dgv_prueba.Columns[0].HeaderText = "ID Seguro";
            dgv_prueba.Columns[1].HeaderText = "Porc. Laboral";
            dgv_prueba.Columns[2].HeaderText = "Porc. Patronal";
            dgv_prueba.Columns[3].HeaderText = "Fecha";
            dgv_prueba.Columns[4].HeaderText = "ID Empresa";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            prueba a = new prueba(dgv_prueba, id_social, p_laboral, p_patronal, fecha, id_empresa, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }
        String id_social, p_patronal, p_laboral, fecha, id_empresa;
        Boolean Editar1;
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_prueba.DataSource = cd.cargar("select id_planilla_igss_pk,porcentaje_igss_laboral,porcentaje_igss_patronal,fecha,id_empresa_pk from planilla_igss where estado='ACTIVO'");
        }

        
        private void dgv_prueba_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            id_social = this.dgv_prueba.CurrentRow.Cells[0].Value.ToString();
            p_laboral = this.dgv_prueba.CurrentRow.Cells[1].Value.ToString();
            p_patronal = this.dgv_prueba.CurrentRow.Cells[2].Value.ToString();
            fecha = this.dgv_prueba.CurrentRow.Cells[3].Value.ToString();
            id_empresa = this.dgv_prueba.CurrentRow.Cells[4].Value.ToString();
            prueba a = new prueba(dgv_prueba, id_social, p_laboral, p_patronal, fecha, id_empresa, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }
    }
}
