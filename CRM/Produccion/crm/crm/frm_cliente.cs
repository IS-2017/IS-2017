using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace crm
{
    public partial class frm_cliente : Form
    {
        public frm_cliente()
        {
            InitializeComponent();
            
        }
        string codigo_cliente = "";

       


        // load de formulario cliente
        private void frm_cliente_Load(object sender, EventArgs e)
        {
            try
            {
                CapaDatosPersonas inserta = new CapaDatosPersonas();
                DataTable contenedor = inserta.SeleccionarListaClientes();
                dgv_clientes.DataSource = contenedor;
            } catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }


            // ------------------- cargar combobox con empresas
            try
            {
                CapaDatosPersonas inserta = new CapaDatosPersonas();
                DataTable contenedor = inserta.SeleccionarEmpresas();
                cmb_empresa.DataSource = contenedor;
                cmb_empresa.DisplayMember = "nombre";
                cmb_empresa.ValueMember = "id_empresa";
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void dgv_clientes_Click(object sender, EventArgs e)
        {
            try { 
            // Crear vector:
            int[] vector = ((GridView)dgv_clientes.MainView).GetSelectedRows();
            // Seleccionar las areas que tomará el vector del grid
            DataRowView nombres = (DataRowView)(((GridView)dgv_clientes.MainView).GetRow(vector[0]));
            DataRowView apellidos = (DataRowView)(((GridView)dgv_clientes.MainView).GetRow(vector[0]));
            DataRowView empresa = (DataRowView)(((GridView)dgv_clientes.MainView).GetRow(vector[0]));
            DataRowView puesto = (DataRowView)(((GridView)dgv_clientes.MainView).GetRow(vector[0]));
            DataRowView movil = (DataRowView)(((GridView)dgv_clientes.MainView).GetRow(vector[0]));
            DataRowView telefono = (DataRowView)(((GridView)dgv_clientes.MainView).GetRow(vector[0]));
            DataRowView correo = (DataRowView)(((GridView)dgv_clientes.MainView).GetRow(vector[0]));
            DataRowView id_cliente = (DataRowView)(((GridView)dgv_clientes.MainView).GetRow(vector[0]));
            // asignacion de partes de vectores en cajas de texto
            txt_nombres.Text = nombres["nombres"].ToString();
            txt_apellidos.Text = apellidos["apellidos"].ToString();
            cmb_empresa.Text = nombres["id_empresa"].ToString();
            txt_puesto.Text = apellidos["puesto"].ToString();
            txt_movil.Text = nombres["movil"].ToString();
            txt_telefono.Text = apellidos["telefono"].ToString();
            txt_correo.Text = correo["correo"].ToString();
             codigo_cliente = id_cliente["id_cliente"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dgv_clientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                   
                

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        
        // Boton nuevo
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar cajas de texto
                txt_apellidos.Text = "";
                txt_correo.Text = "";
                txt_movil.Text = "";
                txt_nombres.Text = "";
                txt_puesto.Text = "";
                txt_telefono.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_apellidos.Text == "" || txt_correo.Text.Trim() == "" || txt_movil.Text == "" || txt_nombres.Text == "" || txt_puesto.Text == "" || txt_telefono.Text == "")
                {

                    MessageBox.Show("Usuario no ingresado, Uno o más campos estan vacíos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    // Iniciar grid (limpiarlo)
                    dgv_clientes.DataSource = "";

                    CapaDatosPersonas inserta = new CapaDatosPersonas();
                    inserta.InsertarNuevoCliente(txt_nombres.Text.Trim(), txt_apellidos.Text.Trim(),
                    cmb_empresa.SelectedValue.ToString(), txt_puesto.Text, txt_movil.Text, txt_telefono.Text, txt_correo.Text);

                    // carga de datagrid
                    DataTable contenedor = inserta.SeleccionarListaClientes();
                    dgv_clientes.DataSource = contenedor;



                    MessageBox.Show("Usuario Ingresado existosamente", "Ingreso correcto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //_____________________________ BOTOM MODIFICAR________________

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                var opcion = MessageBox.Show("¿Esta seguro de modificar el registro?", "Modificar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcion == DialogResult.Yes)
                {
                    // envio de parametros a ser modificados
                    CapaDatosPersonas modificar = new CapaDatosPersonas();
                    modificar.ModificarCliente(txt_nombres.Text.Trim(), txt_apellidos.Text.Trim(), cmb_empresa.Text
                    , txt_puesto.Text.Trim(), txt_movil.Text.Trim(), txt_telefono.Text.Trim(),
                    txt_correo.Text.Trim(), codigo_cliente);

                    // carga de datagrid
                    DataTable contenedor = modificar.SeleccionarListaClientes();
                    dgv_clientes.DataSource = contenedor;

                    // Limpiar cajas de texto
                    txt_apellidos.Text = "";
                    txt_correo.Text = "";
                    txt_movil.Text = "";
                    txt_nombres.Text = "";
                    txt_puesto.Text = "";
                    txt_telefono.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Boton eliminar (Cambio de estado [inactivo])

        private void button2_Click(object sender, EventArgs e)
        {
            var opcion = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                CapaDatosPersonas eliminar = new CapaDatosPersonas();
                eliminar.EliminarCliente(codigo_cliente);

                DataTable contenedor = eliminar.SeleccionarListaClientes();
                dgv_clientes.DataSource = contenedor;
            }
            

            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var opcion = MessageBox.Show("Hola Mundo Yo soy el Mensaje", "Yo soy el Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                MessageBox.Show("si");
            }
            else
            {
                MessageBox.Show("no");
            }
           
        }
    }
}
