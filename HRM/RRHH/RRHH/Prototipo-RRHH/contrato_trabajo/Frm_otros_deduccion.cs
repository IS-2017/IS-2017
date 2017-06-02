using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contrato_trabajo
{
    public partial class Frm_otros_deduccion : Form
    {
        public Frm_otros_deduccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        nomina nomina = new nomina();
        private void button3_Click(object sender, EventArgs e)
        {
            {


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_cant_pagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_Otros_Load(object sender, EventArgs e)
        {
           
        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String codigo;
        DataGridView dg;
        capa_datos ca = new capa_datos();

        public Frm_otros_deduccion(DataGridView gb, String id_deduccion_pk, String fecha, String nombre_deduccion, String descripcion, String cantidad_deduccion, String id_empleado_pk, Boolean Editar1)
        {
            this.dg = gb;
            this.Editar = Editar1;
            this.codigo = id_deduccion_pk;
            InitializeComponent();
            if (Editar == true)
            {
                this.cbo_cod_Empleado.Text = id_empleado_pk;
                this.Fecha.Text = fecha;
                this.descripcion.Text = descripcion;
                this.txt_nombre.Text = nombre_deduccion;
                this.cantidad.Text = cantidad_deduccion;
            }
            else
            {
                this.txt_nombre.Text = nombre_deduccion;
                ca.llenar_id_empleado(cbo_cod_Empleado);
                cbo_cod_Empleado.SelectedIndex = -1;
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                ca.llenar_id_empleado(cbo_cod_Empleado);
                cbo_cod_Empleado.SelectedIndex = -1;
            }

            fn.ActivarControles(groupbox_deduccion);
            descripcion.Enabled = true;
        }
        capa_datos cr = new capa_datos();
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Editar)
                {
                   cr.Ejecutar_Mysql("update deducciones set fecha= '"+Fecha.Value.ToString("yyyy-MM-dd")+"',nombre_deduccion ='"+txt_nombre.Text+"',descripcion='"+descripcion.Text+"',cantidad_deduccion='"+cantidad.Text+"' where id_deduccion_pk = '"+codigo+"'");
                    MessageBox.Show("Modificación de Deducción Realizada con Exito");
                }
                else
                {
                    string estado = "activo";
                    cr.Ejecutar_Mysql("insert into deducciones(id_deduccion_pk, fecha, nombre_deduccion, descripcion, cantidad_deduccion,estado, id_empleado_pk) values (null,'" + Fecha.Value.ToString("yyyy-MM-dd") + "','" + txt_nombre.Text + "','" + descripcion.Text + "','" + cantidad.Text + "','" +estado+"','"+cbo_cod_Empleado.SelectedValue.ToString() + "');");
                    MessageBox.Show("Inserción de Deducción Ingresada con Exito");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                //String atributo2 = "id_empresa_pk";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    string estado = "inactivo";
                    ca.Ejecutar_Mysql("update deducciones set estado ='" + estado + "' where id_deduccion_pk = '"+codigo2+"';");
                    MessageBox.Show("Eliminación de Deducción realizada con exito");

                    dg.DataSource = ca.cargar("select id_deduccion_pk, fecha, nombre_deduccion, descripcion, cantidad_deduccion, id_empleado_pk from deducciones where nombre_deduccion = 'deduccion extra' and estado = 'activo';");
                    dg.Columns[0].HeaderText = "ID deducción";
                    dg.Columns[1].HeaderText = "Fecha";
                    dg.Columns[2].HeaderText = "Nombre Deducción";
                    dg.Columns[3].HeaderText = "Descripción";
                    dg.Columns[4].HeaderText = "Cantidad Deducción";
                    dg.Columns[5].HeaderText = "Id Empleado";

                    Fecha.Text = ""; txt_nombre.Text = ""; descripcion.Text = ""; cantidad.Text = ""; cbo_cod_Empleado.SelectedIndex = -1; 
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //bita.Eliminar("Eliminacion de empresa con el numero: " + codigo2, "empresa");
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dg);
            TextBox[] textbox = {txt_nombre,txt_cod , txt_fecha, cantidad, txt_nombre, txt_descripcion };
            fn.llenartextbox(textbox, dg);
            cbo_cod_Empleado.Text = txt_cod.Text;
            Fecha.Text = txt_fecha.Text;
            descripcion.Text = txt_descripcion.Text;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dg);
            TextBox[] textbox = { txt_nombre, txt_cod, txt_fecha, cantidad, txt_nombre, txt_descripcion };
            fn.llenartextbox(textbox, dg);
            cbo_cod_Empleado.Text = txt_cod.Text;
            Fecha.Text = txt_fecha.Text;
            descripcion.Text = txt_descripcion.Text;
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dg);
            TextBox[] textbox = { txt_nombre, txt_cod, txt_fecha, cantidad, txt_nombre, txt_descripcion };
            fn.llenartextbox(textbox, dg);
            cbo_cod_Empleado.Text = txt_cod.Text;
            Fecha.Text = txt_fecha.Text;
            descripcion.Text = txt_descripcion.Text;
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dg);
            TextBox[] textbox = { txt_nombre, txt_cod, txt_fecha, cantidad, txt_nombre, txt_descripcion };
            fn.llenartextbox(textbox, dg);
            cbo_cod_Empleado.Text = txt_cod.Text;
            Fecha.Text = txt_fecha.Text;
            descripcion.Text = txt_descripcion.Text;
        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;

                this.codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.Fecha.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_nombre.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.descripcion.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.cantidad.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.cbo_cod_Empleado.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
           
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a modificar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.InhabilitarComponentes(groupbox_deduccion);
                txt_descripcion.Enabled = false;
                cbo_cod_Empleado.Enabled = false;
                cbo_cod_Empleado.SelectedIndex = -1;

                Fecha.Text = ""; txt_nombre.Text = ""; descripcion.Text = ""; cantidad.Text = ""; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                dg.DataSource = ca.cargar("select id_deduccion_pk, fecha, nombre_deduccion, descripcion, cantidad_deduccion, id_empleado_pk from deducciones where nombre_deduccion = 'deduccion extra' and estado = 'activo' order by id_deduccion_pk;");
                dg.Columns[0].HeaderText = "ID deducción";
                dg.Columns[1].HeaderText = "Fecha";
                dg.Columns[2].HeaderText = "Nombre Deducción";
                dg.Columns[3].HeaderText = "Descripción";
                dg.Columns[4].HeaderText = "Cantidad Deducción";
                dg.Columns[5].HeaderText = "Id Empleado";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar v = new Validar();
            v.validacion_solonumeros(e);
        }
    }
    }

