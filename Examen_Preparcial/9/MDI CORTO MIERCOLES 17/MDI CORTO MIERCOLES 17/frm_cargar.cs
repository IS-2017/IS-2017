using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_CORTO_MIERCOLES_17
{
    public partial class frm_cargar : Form
    {
        public frm_cargar()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int x = validar();
            if (x == 1)
            {

               int y= validarBienYBodega(Convert.ToInt32(cbo_bien.SelectedValue),cbo_bien.Text,cbo_bodega.Text, Convert.ToInt32(cbo_bodega.SelectedValue), Convert.ToInt32(txt_cantidad.Text));
                if (y == 1)
                {
                    dgv_cargar.Rows.Add(cbo_bien.SelectedValue.ToString(),cbo_bien.Text, cbo_bodega.SelectedValue.ToString(),cbo_bodega.Text, txt_cantidad.Text);
                    txt_cantidad.Text = "";
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int fila = 0; fila < dgv_cargar.RowCount; fila++)
                {
                    int bien = Convert.ToInt32(dgv_cargar.Rows[fila].Cells[0].Value);
                    int bodega = Convert.ToInt32(dgv_cargar.Rows[fila].Cells[2].Value);
                    int cantidad = Convert.ToInt32(dgv_cargar.Rows[fila].Cells[4].Value);
                    DataTable dt = cd.cargar("select existencia from producto_bodega where id_bien_pk='" + bien + "' and id_bodega_pk='" + bodega + "'");
                    if (dt.Rows.Count != 0)
                    {
                        int existienciaAcutal = Convert.ToInt32(dt.Rows[0][0].ToString());
                        int nuevaExistencia = existienciaAcutal + cantidad;
                        cd.Ejecutar_Mysql("update producto_bodega set existencia='" + nuevaExistencia + "' where id_bien_pk='" + bien + "' and id_bodega_pk='" + bodega + "'");
                    }
                    else
                    {
                        cd.Ejecutar_Mysql("insert into producto_bodega values('" + bien + "','" + bodega + "','" + cantidad + "')");
                    }
                }
                MessageBox.Show("Ingreso a Inventario Exitoso");
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        int validarBienYBodega(int Bi,string BIEN,string BODEGA, int Bo,int C)
        {
          
            for (int fila = 0; fila < dgv_cargar.RowCount; fila++)
            {
                int bien = Convert.ToInt32(dgv_cargar.Rows[fila].Cells[0].Value);
                int bodega = Convert.ToInt32(dgv_cargar.Rows[fila].Cells[2].Value);
                int cantiad = Convert.ToInt32(dgv_cargar.Rows[fila].Cells[4].Value);
                if(Bi==bien && Bo==bodega)
                {
                    int sumar = cantiad + C;
                    dgv_cargar.Rows[fila].Cells[4].Value = sumar.ToString();
                    txt_cantidad.Text = "";
                    return 0;
                }
            }
                return 1;
        }
         int validar()
        {
            int a = 0;
            if(txt_cantidad.Text =="" || txt_cantidad.Text == null)
            {
                MessageBox.Show("debe Ingresar una cantidad");
                return a;
            }
            if (cbo_bien.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Debe Seleccionar un Bien");
                return a;
            }
            if (cbo_bodega.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Debe Seleccionar una Bodega");
                return a;
            }
            return 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow entrada = new DataGridViewRow();
            entrada = dgv_cargar.Rows[dgv_cargar.CurrentRow.Index];
            dgv_cargar.Rows.Remove(entrada);
        }
        capa_datos cd = new capa_datos();
        private void frm_cargar_Load(object sender, EventArgs e)
        {
            cbo_bien.DataSource = cd.cargar("select id_bien_pk,bien_nom from bien");
            cbo_bien.DisplayMember = "bien_nom";
            cbo_bien.ValueMember = "id_bien_pk";
            cbo_bien.SelectedIndex = -1;

            cbo_bodega.DataSource = cd.cargar("select id_bodega_pk,bodega_nom from bodega");
            cbo_bodega.DisplayMember = "bodega_nom";
            cbo_bodega.ValueMember = "id_bodega_pk";
            cbo_bodega.SelectedIndex = -1;
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Llene el campo con numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
