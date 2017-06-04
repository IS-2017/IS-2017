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
    public partial class Frm_otros_deduccion_grif : Form
    {
        public Frm_otros_deduccion_grif()
        {
            InitializeComponent();
        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_deduccion);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_deduccion);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_deduccion);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_deduccion);
        }
        Boolean Editar1;
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            nombre_deduccion = "deduccion extra";
            Frm_otros_deduccion a = new Frm_otros_deduccion(dgv_deduccion, cod_deduccion, fecha, nombre_deduccion, descricpion, cantidad, id_Empleado, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }
        capa_datos ca = new capa_datos();
        private void Frm_otros_deduccion_grif_Load(object sender, EventArgs e)
        {
            dgv_deduccion.DataSource = ca.cargar("select id_deduccion_pk, fecha, nombre_deduccion, descripcion, cantidad_deduccion, id_empleado_pk from deducciones where nombre_deduccion = 'deduccion extra' and estado ='activo' order by id_deduccion_pk;");
            dgv_deduccion.Columns[0].HeaderText = "ID deducción";
            dgv_deduccion.Columns[1].HeaderText = "Fecha";
            dgv_deduccion.Columns[2].HeaderText = "Nombre Deducción";
            dgv_deduccion.Columns[3].HeaderText = "Descripción";
            dgv_deduccion.Columns[4].HeaderText = "Cantidad Deducción";
            dgv_deduccion.Columns[5].HeaderText = "Id Empleado";
          


        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_deduccion.DataSource = ca.cargar("select id_deduccion_pk, fecha, nombre_deduccion, descripcion, cantidad_deduccion, id_empleado_pk from deducciones where nombre_deduccion = 'deduccion extra' and estado = 'activo' order by id_deduccion_pk;");
            dgv_deduccion.Columns[0].HeaderText = "ID deducción";
            dgv_deduccion.Columns[1].HeaderText = "Fecha";
            dgv_deduccion.Columns[2].HeaderText = "Nombre Deducción";
            dgv_deduccion.Columns[3].HeaderText = "Descripción";
            dgv_deduccion.Columns[4].HeaderText = "Cantidad Deducción";
            dgv_deduccion.Columns[5].HeaderText = "Id Empleado";

        }

        string cod_deduccion, id_Empleado, fecha, descricpion, cantidad, nombre_deduccion;

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void dgv_deduccion_DoubleClick(object sender, EventArgs e)
        {
            Editar1 = true;
            cod_deduccion = this.dgv_deduccion.CurrentRow.Cells[0].Value.ToString();
            fecha = this.dgv_deduccion.CurrentRow.Cells[1].Value.ToString();
            nombre_deduccion = this.dgv_deduccion.CurrentRow.Cells[2].Value.ToString();
            descricpion = this.dgv_deduccion.CurrentRow.Cells[3].Value.ToString();
            cantidad = this.dgv_deduccion.CurrentRow.Cells[4].Value.ToString();
            id_Empleado = this.dgv_deduccion.CurrentRow.Cells[5].Value.ToString();
            Frm_otros_deduccion a = new Frm_otros_deduccion(dgv_deduccion,cod_deduccion,fecha,nombre_deduccion,descricpion,cantidad,id_Empleado,Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }
    }
}
