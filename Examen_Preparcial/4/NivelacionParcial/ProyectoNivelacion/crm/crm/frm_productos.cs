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
    public partial class frm_productos : Form
    {
        public frm_productos()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_descripcion.Text.Trim() == "" || txt_producto.Text == "" || cmb_cate.Text == "" || cmb_medida.Text == "" )
            {

                MessageBox.Show("Proveedor no ingresado, Uno o más campos estan vacíos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                CapaDatosPersonas inserta = new CapaDatosPersonas();
                inserta.InsertarNuevoProducto(txt_producto.Text.Trim(),cmb_cate.Text,cmb_medida.Text,txt_descripcion.Text.Trim(),txt_precio.Text.Trim());
                inserta.InsertarNuevoRegistroInventario(txt_producto.Text.Trim(),"0", cmb_cate.Text, cmb_medida.Text, txt_descripcion.Text.Trim());




                MessageBox.Show("Producto ingresado existosamente", "Ingreso correcto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
