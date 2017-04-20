using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Windows.Forms;
using FuncionesNavegador;
using CrystalDecisions.CrystalReports.Engine;

namespace Reporteador
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void rb_imp_CheckedChanged(object sender, EventArgs e)
        {
            Opciones.Opcion = "IMPRESORA";
        }
        private void rb_ver_CheckedChanged(object sender, EventArgs e)
        {
            Opciones.Opcion = "VISUALIZAR";
        }
        Reporte mm = new Reporte();
        private void Menu_Load(object sender, EventArgs e)
        {
            
            DataTable dt = mm.cargar("select * from reporteador");
            dgv_crystal.DataSource = dt;
            dgv_crystal.Columns[0].HeaderText = "ID";
            dgv_crystal.Columns[1].HeaderText = "Nombre";
            dgv_crystal.Columns[2].HeaderText = "Ubicacion";
            if (Opciones.Opcion == "IMPRESORA")
            {
                rb_imp.Checked = true;
            }
            if (Opciones.Opcion == "VISUALIZAR")
            {
                rb_ver.Checked = true;
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Datos d = new Datos();
                d.StartPosition = FormStartPosition.CenterScreen;
                d.Show();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Datos d = new Datos();
            d.btn_modificar.Visible = true;
            d.lb_codigo.Visible = true;
            d.lb_codigo.Text = Convert.ToString(dgv_crystal.CurrentRow.Cells[0].Value);
            d.txt_nombre.Text = Convert.ToString(dgv_crystal.CurrentRow.Cells[1].Value);
            d.txt_ubicacion.Text = Convert.ToString(dgv_crystal.CurrentRow.Cells[2].Value);
            d.StartPosition = FormStartPosition.CenterScreen;
            d.Show();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Convert.ToString(dgv_crystal.CurrentRow.Cells[0].Value);

                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar  el proyecto?", "Aceptar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    String cuery = "delete from reporteador where id_reporteador= '" + id + "'";

                    OdbcCommand comando = new OdbcCommand(cuery, seguridad.Conexion.ConexionPermisos());

                    comando.ExecuteNonQuery();

                    DataTable dtd = new DataTable();
                    string queryd = "Select * from reporteador";
                    OdbcCommand cmdd = new OdbcCommand(queryd, seguridad.Conexion.ConexionPermisos());
                    OdbcDataAdapter adapd = new OdbcDataAdapter(cmdd);
                    adapd.Fill(dtd);
                    dgv_crystal.DataSource = dtd;

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Errar al eliminar");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
               
                DataTable dt = mm.cargar("Select * from reporteador");
                dgv_crystal.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo refrescar el datagridview");
            }
        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_crystal);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_crystal);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_crystal);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_crystal);
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            try
            {
                Visualizar vz = new Visualizar();
                string ruta = Convert.ToString(dgv_crystal.CurrentRow.Cells[2].Value);
                vz.Menu_General(ruta);
                vz.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btn_imp_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult acpetar = MessageBox.Show("Enviar a Impresora Ahora?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (acpetar == DialogResult.OK)
                {
                    string ruta = Convert.ToString(dgv_crystal.CurrentRow.Cells[2].Value);
                    ReportDocument rDocument = new ReportDocument();

                    rDocument.Load(ruta);

                    
                    rDocument.PrintToPrinter(1, true, 1, 2);
                    //MessageBox.Show("Enviado Con Exito");
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
