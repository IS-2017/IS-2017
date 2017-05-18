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
    public partial class frm_proveedor_grid : Form
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
        String id_provedor, nombre_prov, direccion_prov, telefono_prov, correo_prov, estado;
        #endregion

        #region Botones Navegacion
        //=======================================================================================================================
        //-----------------------------------------------Navegacion--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dgv_proveedor);
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
                fn.Siguiente(dgv_proveedor);
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
                fn.Primero(dgv_proveedor);
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
                fn.Ultimo(dgv_proveedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_proveedor_grid_Load(object sender, EventArgs e)
        {
            Actualizar_grid_proveedor();
        }

        private void dgv_proveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar1 = true;
                tipo_accion = true;
                id_provedor = this.dgv_proveedor.CurrentRow.Cells[0].Value.ToString();
                nombre_prov = this.dgv_proveedor.CurrentRow.Cells[1].Value.ToString();
                direccion_prov = this.dgv_proveedor.CurrentRow.Cells[2].Value.ToString();
                telefono_prov = this.dgv_proveedor.CurrentRow.Cells[3].Value.ToString();
                correo_prov = this.dgv_proveedor.CurrentRow.Cells[4].Value.ToString();

                frm_proveedor jornada = new frm_proveedor(dgv_proveedor, id_provedor, nombre_prov, direccion_prov, telefono_prov, correo_prov, estado, Editar1, tipo_accion);
                jornada.MdiParent = this.ParentForm;
                jornada.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                frm_reporte_proveedor prov = new frm_reporte_proveedor();
                prov.MdiParent = mdi_contenedor_Preparcial.ActiveForm.ParentForm;
                prov.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Boton Actualizar
        //=======================================================================================================================
        //-----------------------------------------------Actualizar--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Actualizar_grid_proveedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        public void Actualizar_grid_proveedor()
        {
            try
            {
                string tabla = "proveedor";
                fn.ActualizarGrid(this.dgv_proveedor, "SELECT id_proveedor_pk, nombre_proveedor, direccion_proveedor, telefono_proveedor, correo_proveedor FROM `proveedor` WHERE estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region Boton Buscar
        //=======================================================================================================================
        //-----------------------------------------------Buscar--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "emp_jornadatrabajo";
                op.ejecutar(dgv_proveedor, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Form Inicio
        //=======================================================================================================================
        //----------------------------------------------- Form --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public frm_proveedor_grid()
        {
            InitializeComponent();
        }
        #endregion

        #region Boton Nuevo
        //=======================================================================================================================
        //----------------------------------------------- Nuevo --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                frm_proveedor jornada = new frm_proveedor(dgv_proveedor, id_provedor, nombre_prov, direccion_prov, telefono_prov, correo_prov, estado, Editar1, tipo_accion);
                jornada.MdiParent = this.ParentForm;
                jornada.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
