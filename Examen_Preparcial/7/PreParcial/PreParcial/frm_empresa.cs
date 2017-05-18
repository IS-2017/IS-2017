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

namespace PreParcial
{
    public partial class frm_empresa : Form
    {
        public frm_empresa()
        {
            InitializeComponent();
        }
        CapaNegocio fn = new CapaNegocio();
        String Codigo;
        Boolean Editar;
        String atributo;
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(groupBox1);
                fn.LimpiarComponentes(groupBox1);

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


                TextBox[] textbox = { txt_dire,txt_nom,txt_tel };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "empresa";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);


                    }
                    else
                    {
                        fn.insertar(datos, tabla);

                    }
                    fn.LimpiarComponentes(groupBox1);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                fn.ActivarControles(groupBox1);
                atributo = "id_empresa_pk";
                this.Codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.txt_nom.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txt_dire.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.txt_tel.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();


            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a modificar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_empresa_pk";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "empresa";
                    fn.eliminar(tabla, atributo2, codigo2);
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //bita.Eliminar("Eliminacion de empresa con el numero: " + codigo2, "empresa");
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                fn.ActivarControles(groupBox1);
                Editar = true;
                fn.LimpiarComponentes(groupBox1);
                fn.InhabilitarComponentes(groupBox1);
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
                string tabla = "empresa";
                fn.ActualizarGrid(this.dataGridView1, "Select * from empresa where estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dataGridView1);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dataGridView1);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dataGridView1);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dataGridView1);
        }

        private void frm_empresa_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(groupBox1);
        }
    }
}
