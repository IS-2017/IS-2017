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
        }

        private void item_negocios_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FormNegociaciones f = new FormNegociaciones();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void item_contactos_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FormContactos f = new FormContactos();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void item_calendario_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FormActividadesCalendario f = new FormActividadesCalendario();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void item_clientes_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_estadistica_empresa f = new frm_estadistica_empresa();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void item_personal_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_estadistica_personal f = new frm_estadistica_personal();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void item_pronosticos_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_pronostico f = new frm_pronostico();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void item_productos_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }
    }
}
