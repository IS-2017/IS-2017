using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Miercoles_17_de_Mayo
{
    public partial class Contenedor_MDI : Form
    {

        Frm_examen_grid examen;
        Facturación fact;

        //public static string usuario;

        //public static string Usuario
        //{
        //    get
        //    {
        //        return usuario;

        //    }
        //    set
        //    {
        //        usuario = value;
        //    }
        //}

        String usuario;



        public Contenedor_MDI(String user)
        {
           usuario = user;
           InitializeComponent();
        }

        private void contratosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }


        void examensito_FormClosed(object sender, EventArgs e)
        {
             examen = null;
        }

        void fact_FormClosed(object sender, EventArgs e)
        {
            examen = null;
        }

        private void Contenedor_MDI_Load(object sender, EventArgs e)
        {

                String espacio = "";
             //   ActiveForm.Text = "Modulo Recursos Humanos" + espacio + "Usuario: " + usuario;
                MdiClient Chld;
                foreach (Control crtl in this.Controls)
                {
                    try
                    {
                        Chld = (MdiClient)crtl;
                        Chld.BackColor = this.BackColor;
                    }
                    catch (InvalidCastException exe)
                    { }
                
               
            }
        }

        private void nombreDelGridToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fact == null)
            {
                fact = new Facturación();
                fact.MdiParent = this;
                fact.FormClosed += new FormClosedEventHandler(fact_FormClosed);
                fact.Show();
            }
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (examen == null)
            {
                examen = new Frm_examen_grid();
                examen.MdiParent = this;
                examen.FormClosed += new FormClosedEventHandler(examensito_FormClosed);
                examen.Show();
            }
        }
    }
}
