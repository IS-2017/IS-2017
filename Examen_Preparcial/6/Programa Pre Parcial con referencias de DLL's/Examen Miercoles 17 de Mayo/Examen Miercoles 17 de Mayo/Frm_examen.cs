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

namespace Examen_Miercoles_17_de_Mayo
{
    public partial class Frm_examen : Form
    {
        public Frm_examen()
        {
            InitializeComponent();
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void Frm_examen_Load(object sender, EventArgs e)
        {
            capa_datos ca = new capa_datos();

            fn.InhabilitarComponentes(groupBox1);


        }


        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String codigo;
        DataGridView dg;
        public Frm_examen(DataGridView gb, String Id_bien, String Descripcion, String Precio, String marca, String id_proveedor, Boolean Editar1)
        {
            this.dg = gb;
            this.Editar = Editar1;
            this.codigo = Id_bien;
            InitializeComponent();
            if (Editar == true)
            {
                // this.txt_fecha.Enabled = false;
               // this.txt_id_bien.Text = Id_bien;
                this.txt_descripcion.Text = Descripcion;
                this.txt_precio.Text = Precio;
                this.txt_marca.Text = marca;
                this.cbo_proveedor.Text = id_proveedor;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        capa_datos ca = new capa_datos();
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            //   txt_id_bien.Enabled = true;
            ca.llenar_proveedor(cbo_proveedor);
            cbo_proveedor.SelectedIndex = -1;
            txt_descripcion.Enabled = true;
            txt_precio.Enabled = true;
            txt_marca.Enabled = true;
            cbo_proveedor.Enabled = true;

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                TextBox[] textbox = { txt_descripcion, txt_precio, txt_marca, txt_proveedor };
                cbo_proveedor.Text = txt_proveedor.Text;
                fn.llenartextbox(textbox, dg);
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
                fn.Siguiente(dg);
                TextBox[] textbox = { txt_descripcion, txt_precio, txt_marca, txt_proveedor };
                cbo_proveedor.Text = txt_proveedor.Text;
                fn.llenartextbox(textbox, dg);
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
                fn.Primero(dg);
                TextBox[] textbox = { txt_descripcion, txt_precio, txt_marca, txt_proveedor };
                cbo_proveedor.Text = txt_proveedor.Text;
                fn.llenartextbox(textbox, dg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Ultimo(dg);
                TextBox[] textbox = { txt_descripcion, txt_precio, txt_marca, txt_proveedor };
                cbo_proveedor.Text = txt_proveedor.Text;
                fn.llenartextbox(textbox, dg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_proveedor_TextChanged(object sender, EventArgs e)
        {

        }
        capa_datos cd = new capa_datos();
        capa_negocio cn = new capa_negocio();
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Editar)
                {
                    
                    cn.Modificar_producto(codigo, txt_precio.Text, txt_descripcion.Text, txt_marca.Text);
                    
                }
                else
                {
                    cn.Insertar_producto(txt_precio.Text, txt_descripcion.Text, txt_marca.Text, txt_proveedor.Text);
                   
                }
            }
        catch(Exception ex)
        {
                MessageBox.Show(ex.Message);
        }
        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
  


