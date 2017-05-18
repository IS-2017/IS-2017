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
    public partial class frm_clientes_grid : Form
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
        String id_cliente_pk, nombre_cliente, direccion_cliente, telefono_cliente, dpi_cliente, nit_cliente, estado;
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
                Actualizar_grid_cliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Actualizar_grid_cliente()
        {
            try
            {
                string tabla = "proveedor";
                fn.ActualizarGrid(this.dgv_cliente, "SELECT id_cliente_pk, nombre_cliente, direccion_cliente, telefono_cliente, dpi_cliente, nit_cliente FROM `cliente` WHERE estado = 'ACTIVO' ", tabla);
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
                string tabla = "cliente";
                op.ejecutar(dgv_cliente, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_clientes_grid_Load(object sender, EventArgs e)
        {

            Actualizar_grid_cliente();
        }

        private void dgv_cliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar1 = true;
                tipo_accion = true;
                id_cliente_pk = this.dgv_cliente.CurrentRow.Cells[0].Value.ToString();
                nombre_cliente = this.dgv_cliente.CurrentRow.Cells[1].Value.ToString();
                direccion_cliente = this.dgv_cliente.CurrentRow.Cells[2].Value.ToString();
                telefono_cliente = this.dgv_cliente.CurrentRow.Cells[3].Value.ToString();
                dpi_cliente = this.dgv_cliente.CurrentRow.Cells[4].Value.ToString();
                nit_cliente = this.dgv_cliente.CurrentRow.Cells[5].Value.ToString();

                frm_clientes cliente = new frm_clientes(dgv_cliente, id_cliente_pk, nombre_cliente, direccion_cliente, telefono_cliente, dpi_cliente, nit_cliente, estado, Editar1, tipo_accion);
                cliente.MdiParent = this.ParentForm;
                cliente.Show();
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
                frm_reporte_clientes cliente = new frm_reporte_clientes();
                cliente.MdiParent = mdi_contenedor_Preparcial.ActiveForm.ParentForm;
                cliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Form Cliente Grid
        //=======================================================================================================================
        //--------------------------------------Form--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public frm_clientes_grid()
        {
            InitializeComponent();
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
                frm_clientes cliente = new frm_clientes(dgv_cliente, id_cliente_pk, nombre_cliente, direccion_cliente, telefono_cliente, dpi_cliente, nit_cliente, estado, Editar1, tipo_accion);
                cliente.MdiParent = this.ParentForm;
                cliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Botones de Navegacion
        //=======================================================================================================================
        //-------------------------------------- Navegacion--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira

        private void btn_primero_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Primero(dgv_cliente);
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
                fn.Ultimo(dgv_cliente);
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
                fn.Siguiente(dgv_cliente);
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
                fn.Anterior(dgv_cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

    }
}
