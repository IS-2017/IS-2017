﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using FuncionesNavegador;

namespace Inventario
{
    public partial class FormNuevoProducto : Form
    {
        public FormNuevoProducto()
        {
            InitializeComponent();
        }
        string id_form = "10111";
        int cont = 0;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        public Boolean Editar;

        private void Producto_terminado_Load(object sender, EventArgs e)
        {
           
            try
            {
                CapaNegocio fn = new CapaNegocio();
                DataTable seg = seguridad.ObtenerPermisos.Permisos(seguridad.Conexion.User, id_form);
                if (seg.Rows.Count > 0)
                {
                    fn.desactivarPermiso(seg, btn_guardar, btn_eliminar, btn_editar, btn_nuevo, btn_cancelar, btn_actualizar, btn_buscar, btn_anterior, btn_siguiente, btn_primero, btn_ultimo);
                }

                SistemaInventarioDatos ds = new SistemaInventarioDatos();
                cbo_Categoria.DataSource = ds.ObtenerCategorias();
                cbo_Categoria.ValueMember = "id_categoria_pk";
                cbo_Categoria.DisplayMember = "tipo_categoria";

                cbo_marca.DataSource = ds.ObtenerMarcastodo();
                cbo_marca.ValueMember = "id_marca_pk";
                cbo_marca.DisplayMember = "nombre_marca";

                cbo_medida.DataSource = ds.ObtenerMedidastodo();
                cbo_medida.ValueMember = "id_medida_pk";
                cbo_medida.DisplayMember = "abreviatura";
                

            }
            catch (Exception ex) { MessageBox.Show("No posee los permisos necesarios!", "¡Seguridad!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void btn_categoria_Click(object sender, EventArgs e)
        {

            Categoria f = new Categoria();
            f.MdiParent = this.MdiParent;
            f.Show();

        }

       

        private void cbo_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbo_marca_TextChanged(object sender, EventArgs e)
        {
            int index = cbo_marca.FindString(cbo_marca.Text.Trim());
            cbo_marca.SelectedIndex = index;
        }

        private void cbo_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cont++;
            if (cont >3)
            {
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                int x = sd.ObtenerCorrelativoBien(cbo_Categoria.SelectedValue.ToString().Trim());
                lbl_codigo.Text = cbo_Categoria.SelectedValue.ToString().Trim() + "-" + x.ToString();
                //***********************************************************************************
                DataTable dt = sd.LineasporCat(cbo_Categoria.SelectedValue.ToString().Trim());
                cbo_linea.Text = "";
                cbo_linea.DataSource = dt;
                cbo_linea.ValueMember = "id_linea_pk";
                cbo_linea.DisplayMember = "nombre_linea";
               
                  
                
            }
        }

        public string id_bien;
        public string id_categria;
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Editar)
                {
                    SistemaInventarioDatos sid = new SistemaInventarioDatos();
                    sid.Modificacion("update bien set precio = "+txt_precio.Text.Trim()+", costo = "+txt_costo.Text.Trim()+" , descripcion = '"+txt_desc.Text.Trim()+"', id_linea_pk = "+cbo_linea.SelectedValue.ToString()+", id_medida_pk = "+cbo_medida.SelectedValue.ToString()+", porcentaje_comision = "+txt_comision.Text.Trim()+", id_marca_pk = "+cbo_marca.SelectedValue.ToString()+" where id_bien_pk = "+id_bien+" and id_categoria_pk = '"+id_categria+"' ");
                    SistemaInventarioDatos sd = new SistemaInventarioDatos();
                    
                    Editar = false;
                }
                else
                {
                    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                    if (!String.IsNullOrEmpty(txt_desc.Text.Trim()) && !String.IsNullOrEmpty(txt_costo.Text.Trim()) && !String.IsNullOrEmpty(txt_precio.Text.Trim()) && cbo_Categoria.SelectedIndex != -1 && cbo_linea.SelectedIndex != -1)
                    {
                        SistemaInventarioDatos sd = new SistemaInventarioDatos();
                        int x = sd.AgregarBien(cbo_Categoria.SelectedValue.ToString().Trim(), Convert.ToDecimal(txt_precio.Text.Trim()), Convert.ToDecimal(txt_costo.Text.Trim()), txt_desc.Text.Trim(), Convert.ToInt32(cbo_linea.SelectedValue), Convert.ToInt32(cbo_medida.SelectedValue), Convert.ToInt32(cbo_marca.SelectedValue), Convert.ToDecimal(txt_comision.Text.Trim()));

                        if (x == 1)
                        {
                            MessageBox.Show("Bien registrado exitosamente!");

                        }
                        else { MessageBox.Show("no se pudo ingresar el bien!"); }
                    }
                    else { MessageBox.Show("hay campos importantes que debe llenar"); }
                    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                }
            }
            catch { MessageBox.Show("No se pudo guardar con exito"); }
        }

        private void btn_marca_Click(object sender, EventArgs e)
        {
            marca f = new marca();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btn_medida_Click(object sender, EventArgs e)
        {
            FormMedidas f = new FormMedidas();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void cbo_medida_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cbo_marca_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos ds = new SistemaInventarioDatos();
            cbo_marca.DataSource = ds.ObtenerMarcastodo();
            cbo_marca.ValueMember = "id_marca_pk";
            cbo_marca.DisplayMember = "nombre_marca";

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Editar = false;
        }
    }
}
