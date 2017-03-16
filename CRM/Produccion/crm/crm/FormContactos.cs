using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;


namespace crm
{
    public partial class FormContactos : Form
    {
        public FormContactos()
        {
            InitializeComponent();
        }

        private void FormContactos_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            //btn_opciones.Enabled = false;
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionM();
                OdbcCommand comando = new OdbcCommand("select * from contacto", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                gridControl1.DataSource = dt;

            }catch (Exception ex) { MessageBox.Show(ex.Message); }



        }

      
    }
}
