using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Reporteador
{
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();
        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ofp_rpt.Title = "Selecione el Crystal Report";
                this.ofp_rpt.Filter = "RTP Files(*.rpt)|*.rpt|rpt Files(*.RPT)|*.RPT)|ALL Files(*.*)|*.*";
                this.ofp_rpt.ShowDialog();
                if (!string.IsNullOrEmpty(this.ofp_rpt.FileName))
                {
                    txt_ubicacion.Text = this.ofp_rpt.FileName;
                 
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Datos_Load(object sender, EventArgs e)
        {

        }
        private void limpiar()
        {
            txt_nombre.Text = "";
            txt_ubicacion.Text = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Reporte mm = new Reporte();
                if (string.IsNullOrEmpty(txt_ubicacion.Text))
                {
                    MessageBox.Show("Debe Especificar una ubicacion....");
                }
                else
                {
                    txt_ubicacion.Text = txt_ubicacion.Text.Replace("\\", "\\\\");
                    mm.insertarRPT(txt_nombre.Text, txt_ubicacion.Text);

                    limpiar();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_ubicacion.Text))
                {
                    MessageBox.Show("Debe Especificar una ubicacion....");
                }
                else
                {
                    txt_ubicacion.Text = txt_ubicacion.Text.Replace("\\", "\\\\");
                    string quey = "update reporteador set nombre=  '" + txt_nombre.Text + "' , ubicacion='" + txt_ubicacion.Text + "' where id_reporteador = '" + lb_codigo.Text + "';";
                    OdbcCommand comando = new OdbcCommand(quey, seguridad.Conexion.ConexionPermisos());
                    OdbcDataReader dr;
                    dr = comando.ExecuteReader();
                    MessageBox.Show("Actualizacion Exitosa");
                }

            }
            catch
            {
                MessageBox.Show("Error en modificar");
            }
        }
    }
}
