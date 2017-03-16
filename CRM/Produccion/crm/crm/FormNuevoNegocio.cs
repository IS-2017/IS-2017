using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crm
{
    public partial class FormNuevoNegocio : Form
    {
        public FormNuevoNegocio()
        {
            InitializeComponent();
        }

        private void FormNuevoNegocio_Load(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Normal;
            //LLENAR MONEDA
            cbo_moneda.Properties.DataSource = OpBD.SeleccionarMonedas();
            cbo_moneda.Properties.ValueMember = "id_moneda";
            cbo_moneda.Properties.DisplayMember = "Moneda";
            cbo_moneda.Properties.PopulateColumns();
            cbo_moneda.Properties.Columns[0].Visible = false;
            //LLENAR CATEGORIAS
            cbo_cat.DataSource = OpBD.SeleccionarCategoriascbo();
            cbo_cat.ValueMember = "id_cat";
            cbo_cat.DisplayMember = "nombre_cat";
            //LLENAR EMPLEADOS
            cbo_empleado.DataSource = OpBD.SeleccionarEmpleados();
            cbo_empleado.ValueMember = "id_empleado";
            cbo_empleado.DisplayMember = "Empleado";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Persona")
            {
                cbo_perem.DataSource = OpBD.SeleccionarClientes();
                cbo_perem.ValueMember = "id_cliente";
                cbo_perem.DisplayMember = "nom";
            }
            else if (comboBox1.SelectedItem.ToString() == "Empresa")
              {
                cbo_perem.DataSource = OpBD.SeleccionarEmpresas();
                cbo_perem.ValueMember = "id_empresa";
                cbo_perem.DisplayMember = "nombre";
            }
        }

        private void btn_nueva_mon_Click(object sender, EventArgs e)
        {
            //frm_moneda f = new frm_moneda();
            //f.MdiParent = this.MdiParent;
            //f.Show();

            frm_moneda f = new frm_moneda();
            f.Show();

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            Form_categoria_neg f = new Form_categoria_neg();
           // f.MdiParent = this.MdiParent;
            //f.WindowState = FormWindowState.Normal;
            f.Show();
        }

        private void btn_refesh_cat_Click(object sender, EventArgs e)
        {
            cbo_cat.DataSource = OpBD.SeleccionarCategoriascbo();
            cbo_cat.ValueMember = "id_cat";
            cbo_cat.DisplayMember = "nombre_cat";
        }

        private void btn_nuevo_emp_Click(object sender, EventArgs e)
        {
            frm_NuevoEmpleado f = new frm_NuevoEmpleado();
             f.MdiParent = this.MdiParent;
            
            f.Show();
        }

        private void btn_actualizar_emp_Click(object sender, EventArgs e)
        {
            cbo_empleado.DataSource = OpBD.SeleccionarEmpleados();
            cbo_empleado.ValueMember = "id_empleado";
            cbo_empleado.DisplayMember = "Empleado";
        }

        private void btn_actualizar_mon_Click(object sender, EventArgs e)
        {
            cbo_moneda.Properties.DataSource = OpBD.SeleccionarMonedas();
            cbo_moneda.Properties.ValueMember = "id_moneda";
            cbo_moneda.Properties.DisplayMember = "Moneda";
            cbo_moneda.Properties.PopulateColumns();
            cbo_moneda.Properties.Columns[0].Visible = false;
        }

        private void btn_nuevo_perem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1) {
                if (comboBox1.SelectedItem.ToString() == "Persona")
                {
                    frm_cliente f = new frm_cliente();
                    f.MdiParent = this.MdiParent;

                    f.Show();
                } else if (comboBox1.SelectedItem.ToString() == "Empresa")
                {
                    frm_empresa f = new frm_empresa();
                    f.MdiParent = this.MdiParent;

                    f.Show();
                }
            }
        }

        private void btn_refresh_perem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            {
                if (comboBox1.SelectedItem.ToString() == "Persona")
                {
                    cbo_perem.DataSource = OpBD.SeleccionarClientes();
                    cbo_perem.ValueMember = "id_cliente";
                    cbo_perem.DisplayMember = "nom";
                }
                else if (comboBox1.SelectedItem.ToString() == "Empresa")
                {
                    cbo_perem.DataSource = OpBD.SeleccionarEmpresas();
                    cbo_perem.ValueMember = "id_empresa";
                    cbo_perem.DisplayMember = "nombre";
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string titulo = txt_titulo.Text.Trim();
            int perem = Convert.ToInt32(cbo_perem.SelectedValue);
            string detalles = txt_detalles.Text.Trim();
            int moneda = Convert.ToInt32(cbo_moneda.EditValue);
            decimal valor = Convert.ToDecimal(txt_valor.Text.Trim());
            int cat = Convert.ToInt32(cbo_cat.SelectedValue);
            int empleado = Convert.ToInt32(cbo_empleado.SelectedValue);
            int etapa = tb_etapa.Value;
            DateTime fecha = dtp_fecha_cierre.DateTime;

            int res = 3;
            OpBD o = new OpBD();
            if (comboBox1.SelectedItem.ToString()=="Persona")
            {
              res =  o.InsertarNegocioClie(titulo, perem, detalles, moneda, valor, cat, empleado, etapa, fecha.ToString("yyyy-MM-dd"));
            } else if (comboBox1.SelectedItem.ToString()=="Empresa")
                    {
                    res =  o.InsertarNegocioEmp(titulo, perem, detalles, moneda, valor, cat, empleado, etapa, fecha.ToString("yyyy-MM-dd"));
                    }

            if (res == 1)
            {
                MessageBox.Show("Ingreso Exitoso!");
            }
            else if (res == 0)
            {
                MessageBox.Show("Ingreso fallido!");
            }
            else {
                MessageBox.Show("Ingrese con quien será la negociación!");
                 }

        }
    }
}
