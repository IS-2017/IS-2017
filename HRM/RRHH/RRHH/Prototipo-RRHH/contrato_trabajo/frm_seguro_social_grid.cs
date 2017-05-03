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
    public partial class frm_seguro_social_grid : Form
    {
        public frm_seguro_social_grid()
        {
            InitializeComponent();
        }
        String id_social, p_patronal,p_laboral, fecha,id_empresa;
        CapaNegocio fn = new CapaNegocio();

        private void dgv_social_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            id_social = this.dgv_social.CurrentRow.Cells[0].Value.ToString();
            p_laboral = this.dgv_social.CurrentRow.Cells[1].Value.ToString();
            p_patronal = this.dgv_social.CurrentRow.Cells[2].Value.ToString();
            fecha = this.dgv_social.CurrentRow.Cells[3].Value.ToString();
            id_empresa = this.dgv_social.CurrentRow.Cells[4].Value.ToString();
            frm_seguro_social a = new frm_seguro_social(dgv_social,id_social,p_laboral,p_patronal,fecha,id_empresa, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_social);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_social);
        }
    

        private void btn_primero_Click(object sender, EventArgs e)
        {
        fn.Primero(dgv_social);
    
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
          fn.Ultimo(dgv_social);

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            capa_datos cd = new capa_datos();
            dgv_social.DataSource = cd.cargar("select id_planilla_igss_pk,porcentaje_igss_laboral,porcentaje_igss_patronal,fecha,id_empresa_pk from planilla_igss where estado='ACTIVO'");
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            frm_seguro_social a = new frm_seguro_social(dgv_social, id_social,p_laboral, p_patronal,fecha,id_empresa, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        capa_datos cd = new capa_datos();
        Boolean Editar1;
        private void frm_seguro_social_grid_Load(object sender, EventArgs e)
        {
            dgv_social.DataSource = cd.cargar("select id_planilla_igss_pk,porcentaje_igss_laboral,porcentaje_igss_patronal,fecha,id_empresa_pk from planilla_igss where estado='ACTIVO'");
            dgv_social.Columns[0].HeaderText = "ID Seguro";
            dgv_social.Columns[1].HeaderText = "Porc. Laboral";
            dgv_social.Columns[2].HeaderText = "Porc. Patronal";
            dgv_social.Columns[3].HeaderText = "Fecha";
            dgv_social.Columns[4].HeaderText = "ID Empresa";
        }
    }
}
