using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_CORTO_MIERCOLES_17
{
    public partial class frm_bien : Form
    {
        public frm_bien()
        {
            InitializeComponent();
        }
        capa_datos cd = new capa_datos();
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String codigo;
        DataGridView dg;
        public frm_bien(DataGridView gb, String id_bien, String nom, String des, String precio, String proveedor, Boolean Editar1)
        {
            this.dg = gb;
            this.Editar = Editar1;
            this.codigo = id_bien;
            InitializeComponent();
            if (Editar == true)
            {
                this.txt_nombre.Text = nom;
                this.txt_descripcion.Text = des;
                this.txt_precio.Text = precio;
                this.cbo_proveedor.Text = proveedor;
            }
            else
            {
               cd.llenar_id_proveedor(cbo_proveedor);
               cbo_proveedor.SelectedIndex = -1;
            }
        }

        private void frm_bien_Load(object sender, EventArgs e)
        {
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dg);
            TextBox[] textbox = { txt_nombre, txt_descripcion, txt_precio, txt_proveedor,txt_id_bien };
            fn.llenartextbox(textbox, dg);
            cbo_proveedor.Text = txt_proveedor.Text;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dg);
            TextBox[] textbox = { txt_nombre, txt_descripcion, txt_precio, txt_proveedor, txt_id_bien };
            fn.llenartextbox(textbox, dg);
            cbo_proveedor.Text = txt_proveedor.Text;
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dg);
            TextBox[] textbox = { txt_nombre, txt_descripcion, txt_precio, txt_proveedor, txt_id_bien };
            fn.llenartextbox(textbox, dg);
            cbo_proveedor.Text = txt_proveedor.Text;
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dg);
            TextBox[] textbox = { txt_nombre, txt_descripcion, txt_precio, txt_proveedor, txt_id_bien };
            fn.llenartextbox(textbox, dg);
            cbo_proveedor.Text = txt_proveedor.Text;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_nombre.Enabled = true; txt_descripcion.Enabled = true;txt_precio.Enabled = true;cbo_proveedor.Enabled = true;
            cd.llenar_id_proveedor(cbo_proveedor);
            cbo_proveedor.SelectedIndex = -1;
            txt_nombre.Text = ""; txt_descripcion.Text = "";txt_precio.Text = "";
        }
        capa_negocio cn = new capa_negocio();
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Editar)
            {
                cn.ModificarBien(codigo,txt_nombre.Text, txt_descripcion.Text, txt_precio.Text,cbo_proveedor.Text);
            }
            else
            {
                cn.InsertarBien(txt_nombre.Text, txt_descripcion.Text,txt_precio.Text, cbo_proveedor.SelectedValue.ToString());
                limpiar();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;

                this.codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_descripcion.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_precio.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.cbo_proveedor.Text = this.dg.CurrentRow.Cells[4].Value.ToString();

            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a modificar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    capa_negocio cn = new capa_negocio();
                    cn.eliminarBien(codigo2);       
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void limpiar()
        {
            txt_nombre.Text = ""; txt_descripcion.Text = ""; txt_precio.Text = ""; cbo_proveedor.SelectedIndex = -1;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_nombre.Enabled = false;txt_descripcion.Enabled = false;txt_precio.Enabled = false;cbo_proveedor.Enabled = false;
            txt_nombre.Text = "";txt_descripcion.Text = "";txt_precio.Text = "";cbo_proveedor.SelectedIndex = -1;
        }

        private void cbo_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString()==cc.NumberFormat.NumberDecimalSeparator)
                e.Handled = false;
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo puede ingresar numero con Un . ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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
                MessageBox.Show("Llene el campo con letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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
                MessageBox.Show("Llene el campo con letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
