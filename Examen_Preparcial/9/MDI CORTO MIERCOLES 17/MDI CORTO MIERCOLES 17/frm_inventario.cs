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
    public partial class frm_inventario : Form
    {
        public frm_inventario()
        {
            InitializeComponent();
        }
        capa_datos cd = new capa_datos();
        private void frm_inventario_Load(object sender, EventArgs e)
        {
            dgv_inventario.DataSource = cd.cargar("select bien.id_bien_pk as 'ID Bien', bien.bien_nom as Nombre, sum(producto_bodega.existencia) as Cantidad, id_bodega_pk as 'ID Bodega', bien.bien_precio as Precio, bien.id_proveedor_pk as 'ID Proveedor' from bien INNER JOIN producto_bodega on bien.id_bien_pk = producto_bodega.id_bien_pk where bien.estado = 'activo' group by bien.id_bien_pk;");
        }

        private void btn_bodega_Click(object sender, EventArgs e)
        {
            dgv_inventario.DataSource = cd.cargar("select bien.id_bien_pk as 'ID Bien', bien.bien_nom as Nombre, sum(producto_bodega.existencia) as Cantidad, producto_bodega.id_bodega_pk as 'ID Bodega', bien.bien_precio as Precio, bien.id_proveedor_pk as 'ID Proveedor',ubicacion as 'Ubicacion',bodega_nom as 'Nom. Bodega' from bien INNER JOIN producto_bodega on bien.id_bien_pk = producto_bodega.id_bien_pk INNER JOIN bodega on producto_bodega.id_bodega_pk = bodega.id_bodega_pk where bien.estado = 'activo' group by producto_bodega.id_bien_pk,producto_bodega.id_bodega_pk;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_inventario.DataSource = cd.cargar("select bien.id_bien_pk as 'ID Bien', bien.bien_nom as Nombre, sum(producto_bodega.existencia) as Cantidad, id_bodega_pk as 'ID Bodega', bien.bien_precio as Precio, bien.id_proveedor_pk as 'ID Proveedor' from bien INNER JOIN producto_bodega on bien.id_bien_pk = producto_bodega.id_bien_pk where bien.estado = 'activo' group by bien.id_bien_pk;");
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            frm_cargar cf = new frm_cargar();
            cf.Show();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {

        }
    }
}
