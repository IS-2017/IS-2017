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
    public partial class Frm_nomina_mantenimiento_grid : Form
    {
        public Frm_nomina_mantenimiento_grid()
        {
            InitializeComponent();
        }
        capa_datos ca = new capa_datos();
        private void Frm_nomina_mantenimiento_grid_Load(object sender, EventArgs e)
        {
            dgv_nominas.DataSource = ca.cargar("select * from nomina where estado = 'procesada';");
            btn_solo_una.Enabled = false;
            btn_todas.Enabled = false;
            btn_eliminar_solo_una.Enabled = false;
            btn_eliminar_todas.Enabled = false;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btn_solo_una.Enabled = true;
            btn_todas.Enabled = true;
            btn_eliminar_solo_una.Enabled = false;
            btn_eliminar_todas.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btn_eliminar_solo_una.Enabled = true;
            btn_eliminar_todas.Enabled = true;
            btn_solo_una.Enabled = false;
            btn_todas.Enabled = false;
        }

        private void btn_solo_una_Click(object sender, EventArgs e)
        {
            try
            {
                string id_nomina = dgv_nominas.CurrentRow.Cells[0].Value.ToString();
                int resultado = ca.Ejecutar_Mysql("update nomina set estado = 'finalizado' where id_nomina_pk = '" + id_nomina + "'");
                if (resultado == 1)
                {
                    MessageBox.Show("Nomina Finalizada con éxito ");
                    btn_actualizar.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al Finalizar nómina");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_nominas.DataSource = ca.cargar("select * from nomina where estado = 'procesada';");
        }

        private void btn_eliminar_solo_una_Click(object sender, EventArgs e)
        {
            try
            {
                string id_nomina = dgv_nominas.CurrentRow.Cells[0].Value.ToString();
                int resultado = ca.Ejecutar_Mysql("update nomina set estado = 'inactivo' where id_nomina_pk = '" + id_nomina + "'");
                if (resultado == 1)
                {
                    MessageBox.Show("Nomina Eliminada con éxito ");
                    btn_actualizar.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al Eliminar nómina");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_todas_Click(object sender, EventArgs e)
        {
            try
            {
                int cont = 0;

                for (int fila = 0; fila < dgv_nominas.RowCount; fila++)
                {
                    string id_nomina = Convert.ToString(dgv_nominas.Rows[fila].Cells[0].Value);
                    ca.Ejecutar_Mysql("update nomina set estado = 'finalizado' where id_nomina_pk = '" + id_nomina+"'");
                   
                    cont++;
                }
                MessageBox.Show("Nominas Finalizadas con éxito");
                btn_actualizar.PerformClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        private void btn_eliminar_todas_Click(object sender, EventArgs e)
        {
            try
            {
                int cont = 0;

                for (int fila = 0; fila < dgv_nominas.RowCount; fila++)
                {
                    string id_nomina = Convert.ToString(dgv_nominas.Rows[fila].Cells[0].Value);
                    ca.Ejecutar_Mysql("update nomina set estado = 'inactivo' where id_nomina_pk = '" + id_nomina + "'");

                    cont++;
                }
                MessageBox.Show("Nominas Eliminadas con éxito");
                btn_actualizar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

    }
}


