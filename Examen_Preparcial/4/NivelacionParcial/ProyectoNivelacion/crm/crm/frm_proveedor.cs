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
    public partial class frm_proveedor : Form
    {
        public frm_proveedor()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            //if (txt_apellidos.Text == "" || txt_correo.Text.Trim() == "" || txt_movil.Text == "" || txt_nombres.Text == "" || txt_puesto.Text == "" || txt_telefono.Text == "")
            if (txt_correo.Text.Trim() == "" || txt_movil.Text == "" || txt_telefono.Text == "" || txt_nit.Text == "" || txt_empresa.Text == "")
            {

                MessageBox.Show("Proveedor no ingresado, Uno o más campos estan vacíos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                CapaDatosPersonas inserta = new CapaDatosPersonas();
                inserta.InsertarNuevoProveedor(txt_empresa.Text.Trim(), txt_movil.Text.Trim(), txt_telefono.Text.Trim(), txt_correo.Text.Trim(), txt_nit.Text.Trim());





                MessageBox.Show("Cliente ingresado existosamente", "Ingreso correcto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
    }
}
