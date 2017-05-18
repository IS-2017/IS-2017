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
using dllconsultas;

namespace Pre_Parcial
{
    public partial class frm_producto_grid : Form
    {

        #region Variables del Form Jornada Grid
        //=======================================================================================================================
        //--------------------------------------Variables--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar1;
        Boolean tipo_accion;
        String id_producto_pk, nombre_producto, precio_producto, descripcion_producto, fecha_registro_producto, id_proveedor_pk, estado;
        #endregion

        #region Boton Actualizar
        //=======================================================================================================================
        //--------------------------------------Actualizar--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Actualizar_grid_producto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Actualizar_grid_producto()
        {
            try
            {
                string tabla = "proveedor";
                fn.ActualizarGrid(this.dgv_producto, "SELECT id_producto_pk, nombre_producto, precio_producto, descripcion_producto, fecha_registro_producto, id_proveedor_pk FROM `producto` WHERE estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region Boton Buscar
        //=======================================================================================================================
        //--------------------------------------Buscar--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "producto";
                op.ejecutar(dgv_producto, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        #endregion

        #region Form Producto Grid
        //=======================================================================================================================
        //--------------------------------------Form--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public frm_producto_grid()
        {
            InitializeComponent();
        }

        private void frm_producto_grid_Load(object sender, EventArgs e)
        {
            Actualizar_grid_producto();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                frm_reporte_producto producto = new frm_reporte_producto();
                producto.MdiParent = mdi_contenedor_Preparcial.ActiveForm.ParentForm;
                producto.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Nuevo
        //=======================================================================================================================
        //--------------------------------------Nuevo--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                frm_producto product = new frm_producto(dgv_producto, id_producto_pk, nombre_producto, precio_producto, descripcion_producto, fecha_registro_producto, id_proveedor_pk, estado, Editar1, tipo_accion);
                product.MdiParent = this.ParentForm;
                product.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Botones Navegacion
        //=======================================================================================================================
        //-------------------------------------- navegacion--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Siguiente(dgv_producto);
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
                fn.Primero(dgv_producto);
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
                fn.Ultimo(dgv_producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dgv_producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Funciones a Realizar
        //=======================================================================================================================
        //--------------------------------------  Funciones--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void dgv_producto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar1 = true;
                tipo_accion = true;
                id_producto_pk = this.dgv_producto.CurrentRow.Cells[0].Value.ToString();
                nombre_producto = this.dgv_producto.CurrentRow.Cells[1].Value.ToString();
                precio_producto = this.dgv_producto.CurrentRow.Cells[2].Value.ToString();
                descripcion_producto = this.dgv_producto.CurrentRow.Cells[3].Value.ToString();
                fecha_registro_producto = this.dgv_producto.CurrentRow.Cells[4].Value.ToString();
                id_proveedor_pk = this.dgv_producto.CurrentRow.Cells[5].Value.ToString();

                frm_producto product = new frm_producto(dgv_producto, id_producto_pk, nombre_producto, precio_producto, descripcion_producto, fecha_registro_producto, id_proveedor_pk, estado, Editar1, tipo_accion);
                product.MdiParent = this.ParentForm;
                product.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
