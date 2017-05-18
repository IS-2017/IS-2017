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

namespace contrato_trabajo
{
    public partial class frm_producto_grid : Form
    {
        #region Variables - Otto Hernandez
        string id_producto, nombre_producto, costo_producto, cantidad_producto, precio_producto, id_proveedor;
        Boolean Editar1;
        CapaNegocio fn = new CapaNegocio();
        #endregion

        #region Boton anterior - Otto Hernandez
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dgv_productos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Siguiente - Otto Hernandez
        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Siguiente(dgv_productos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Primero - Otto Hernandez
        private void btn_primero_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Primero(dgv_productos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Keyup busqueda - Otto Hernandez
        private void txt_busq_producto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string tabla = "producto";
                fn.ActualizarGrid(this.dgv_productos, "select * from producto where nombre_producto like '" + txt_busq_producto.Text + "%' and estado <> 'INACTIVO'", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Load form - Otto Hernandez
        private void frm_producto_grid_Load(object sender, EventArgs e)
        {
            try
            {
                string tabla = "producto";
                fn.ActualizarGrid(this.dgv_productos, "Select * from producto WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Ultimo - Otto Hernandez
        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Ultimo(dgv_productos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Actualizar - Otto Hernandez
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "producto";
                fn.ActualizarGrid(this.dgv_productos, "Select * from producto WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton buscar - Otto Hernandez
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "producto";
                //op.ejecutar(dgv_rec_busq, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Nuevo - Otto Hernandez
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                frm_producto a = new frm_producto(dgv_productos, id_producto, nombre_producto, costo_producto, cantidad_producto, precio_producto, id_proveedor, Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region doble click - Otto Hernandez
        private void dgv_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar1 = true;
                id_producto = this.dgv_productos.CurrentRow.Cells[0].Value.ToString();
                nombre_producto = this.dgv_productos.CurrentRow.Cells[1].Value.ToString();
                costo_producto = this.dgv_productos.CurrentRow.Cells[2].Value.ToString();
                cantidad_producto = this.dgv_productos.CurrentRow.Cells[3].Value.ToString();
                precio_producto = this.dgv_productos.CurrentRow.Cells[4].Value.ToString();
                id_proveedor = this.dgv_productos.CurrentRow.Cells[5].Value.ToString();
                frm_producto a = new frm_producto(dgv_productos, id_producto, nombre_producto, costo_producto, cantidad_producto, precio_producto, id_proveedor, Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        public frm_producto_grid()
        {
            InitializeComponent();
        }
    }
}
