using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seguridad;

namespace crm
{
    public partial class Form_inicio : Form
    {
        public Form_inicio()
        {
            InitializeComponent();
        }

        private void Form_inicio_Load(object sender, EventArgs e)
        {
            //FONDO
            tile.BackgroundImage = Image.FromFile("azulf.jpg");
            tile.BackgroundImageLayout = ImageLayout.Stretch;

            //ITEM NEGOCIOS
            item_negocios.BackgroundImage = Image.FromFile("negocios2.png");
            //ITEM CONTACTOS
            item_contactos.BackgroundImage = Image.FromFile("contactos2.png");
            //ITEM CALENDARIO
            item_calendario.BackgroundImage = Image.FromFile("calendario2.png");
            //ITEM CLIENTES
            item_clientes.BackgroundImage = Image.FromFile("clientes.png");
            //ITEM PERSONAL
            item_personal.BackgroundImage = Image.FromFile("personal.png");
            //ITEM PRONOSTICOS
            item_pronosticos.BackgroundImage = Image.FromFile("pronosticos.png");
            //ITEM PRODUCTOS
            item_productos.BackgroundImage = Image.FromFile("productos.png");
            //ITEM VENTAS
            item_ventas.BackgroundImage = Image.FromFile("ventas.png");
            //ITEM CASOS
            itemcasos.BackgroundImage = Image.FromFile("casos.png");
            //ITEM COBROS
            item_cobros.BackgroundImage = Image.FromFile("cobros.png");
            //ITEM Cotizacion
            item_cotizacion.BackgroundImage = Image.FromFile("calculadora.png");
            //ITEM Balance
            item_balance.BackgroundImage = Image.FromFile("balance.png");

            //**********************************************************

            //string tipo = OpBD.VerificarTipoUsuario();
            //if (tipo != "administrador")
            //{
            //   // item_calendario.Enabled = false;
            //    //item_clientes.Enabled = false;
            //    //item_personal.Enabled = false;
            //    //item_pronosticos.Enabled = false;
            //}

            BloquearMenuInicio();
        }

        private void BloquearMenuInicio()
            {

            foreach (DevExpress.XtraEditors.TileGroup grupo in tile.Groups)
            {
                foreach (DevExpress.XtraEditors.TileItem item in grupo.Items)
                {
                    string tag=""; 
                    if (item.Tag != null)
                    { 
                    tag = item.Tag.ToString();
                    }
                    DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, tag);
                  
                    if (dt.Rows.Count > 0)
                    {
                        item.Enabled = true;
                    }
                    else { item.Enabled = false; }
                }
            }

            }

        private void item_negocios_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, "104");
            if (dt.Rows.Count > 0)
            {
               
            }
            else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

        private void item_contactos_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, "103");
            if (dt.Rows.Count > 0)
            {
               
            }
            else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

        private void item_calendario_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, "104");
            if (dt.Rows.Count > 0)
            {
               
            }
            else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

        private void item_clientes_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, "112");
            if (dt.Rows.Count > 0)
            {
                frm_cliente f = new frm_cliente();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

        private void item_personal_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, "113");
            if (dt.Rows.Count > 0)
            {
             
            }
            else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

        private void item_pronosticos_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, "114");
            if (dt.Rows.Count > 0)
            {
              
            }
            else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

        private void item_productos_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
           
        }

        private void itemcasos_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DataTable dt = ObtenerPermisos.Permisos(seguridad.Conexion.User, "102");
            if (dt.Rows.Count > 0)
            {
                //Form_Casos f = new Form_Casos();
                //f.MdiParent = this.MdiParent;
                //f.Show();
                frm_cliente f = new frm_cliente();
                f.MdiParent = this.MdiParent;
                f.Show();
                
            }
            else { MessageBox.Show("No posee los permisos necesarios para acceder al modulo"); }
        }

        private void item_ventas_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                
               
            }
            catch
            {
                MessageBox.Show("Error de llamada");
            }
        }

        private void item_cobros_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
           
        }

        private void item_cotizacion_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                
              


            }
            catch
            {
                MessageBox.Show("Para facturar necesita seleccionar un cliente");
            }
        }

        private void item_balance_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
           
        }
    }
}
