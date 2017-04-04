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
    public partial class Reporte_espefico : Form
    {
        public Reporte_espefico()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cbo_empresa.Visible = true;
            cbo_puesto.Visible = true;
            cbo_joranda.Visible = true;
            l_puesto.Visible = true;
            l_jornada.Visible = true;
            l_contratacion.Visible = false;
            l_mes.Visible = false;
            cbo_mes.Visible = false;
            dtp_inicio.Visible = false;
           
        }

        private void Reporte_espefico_Load(object sender, EventArgs e)
        {
            l_contratacion.Visible = false;
            l_jornada.Visible = false;
            l_mes.Visible = false;
            l_puesto.Visible = false;
            cbo_empresa.Visible = false;
            label1.Visible = false;
            cbo_joranda.Visible = false;
            cbo_mes.Visible = false;
            cbo_puesto.Visible = false;
            dtp_inicio.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cbo_empresa.Visible = true;
            dtp_inicio.Visible = true;
            l_contratacion.Visible = true;
            cbo_joranda.Visible = false;
            cbo_puesto.Visible = false;
            l_puesto.Visible = false;
            l_jornada.Visible = false;
            l_mes.Visible = false;
            cbo_mes.Visible = false;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cbo_empresa.Visible = true;
            l_mes.Visible = true;
            cbo_mes.Visible = true;
            cbo_joranda.Visible = false;
            cbo_puesto.Visible = false;
            l_puesto.Visible = false;
            l_jornada.Visible = false;
            dtp_inicio.Visible = false;
            l_contratacion.Visible = false;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cbo_empresa.Visible = true;
            l_mes.Visible = true;
            cbo_mes.Visible = true;
            cbo_joranda.Visible = false;
            cbo_puesto.Visible = false;
            l_puesto.Visible = false;
            l_jornada.Visible = false;
            dtp_inicio.Visible = false;
            l_contratacion.Visible = false;
        }
    }
}
