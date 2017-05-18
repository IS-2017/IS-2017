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
    public partial class frm_proveedor_grid : Form
    {
        #region Variables - Otto Hernandez
        string id_proveedor, nombre_proveedor, correo_proveedor, telefono_proveedor;
        Boolean Editar1;
        CapaNegocio fn = new CapaNegocio();
        #endregion

        public frm_proveedor_grid()
        {
            InitializeComponent();
        }

        #region Boton Actualizar - Otto Hernandez
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "proveedor";
                fn.ActualizarGrid(this.dgv_proveedores, "Select * from proveedor WHERE estado <> 'INACTIVO' ", tabla);
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
                string tabla = "proveedor";
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
                frm_proveedor a = new frm_proveedor(dgv_proveedores, id_proveedor, nombre_proveedor, correo_proveedor, telefono_proveedor, Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton anterior - Otto Hernandez
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dgv_proveedores);
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
                fn.Siguiente(dgv_proveedores);
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
                fn.Primero(dgv_proveedores);
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
                fn.Ultimo(dgv_proveedores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Keyup busqueda - Otto Hernandez
        private void txt_busq_proveedor_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string tabla = "proveedor";
                fn.ActualizarGrid(this.dgv_proveedores, "select * from proveedor where nombre_producto like '" + txt_busq_proveedor.Text + "%' and estado <> 'INACTIVO'", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region doble click - Otto Hernandez
        private void dgv_proveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar1 = true;
                id_proveedor = this.dgv_proveedores.CurrentRow.Cells[0].Value.ToString();
                nombre_proveedor = this.dgv_proveedores.CurrentRow.Cells[1].Value.ToString();
                correo_proveedor = this.dgv_proveedores.CurrentRow.Cells[2].Value.ToString();
                telefono_proveedor = this.dgv_proveedores.CurrentRow.Cells[3].Value.ToString();
                frm_proveedor a = new frm_proveedor(dgv_proveedores, id_proveedor, nombre_proveedor, correo_proveedor, telefono_proveedor, Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Load form - Otto Hernandez
        private void frm_proveedor_grid_Load(object sender, EventArgs e)
        {
            try
            {
                string tabla = "proveedor";
                fn.ActualizarGrid(this.dgv_proveedores, "Select * from proveedor WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
