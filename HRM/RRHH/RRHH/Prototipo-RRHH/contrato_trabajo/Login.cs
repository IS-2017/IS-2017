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

namespace contrato_trabajo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pb_hsc_Click(object sender, EventArgs e)
        {

        }

        private void btn_logear_Click(object sender, EventArgs e)
        {
            /*
            try {
                // OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcConnection con = Conexion.ConexionPermisos();
                seguridad.SistemaUsuarioDatos ss = new SistemaUsuarioDatos();
                string usuario = txt_usuario.Text.Trim();
                string contraseña = ss.Encriptar(txt_contraseña.Text.Trim());
                ClaseTomaIp ip = new ClaseTomaIp();
                string localIP = ip.direccion();

                //LLama a una funciòn almacenada que valida la existencia del usuario y la integridad de la contraseña
                string consulta = "select ValidarContrasena('" + usuario + "', '" + contraseña + "','" + localIP + "') ";
                OdbcCommand comando = new OdbcCommand(consulta, con);
                object resultado = comando.ExecuteScalar();
                if (Convert.ToInt16(resultado) == 1) //esto nos indica que la validaciòn ha sido correcta por parte de la funciòn almacenada
                {
                    // seguridad.LlegarSeguridad.EstablecerUsuario(usuario);
                    seguridad.Conexion.User = usuario;
                    seguridad.Conexion.PassWord = contraseña;

                    MessageBox.Show("¡Bienvenido!: " + usuario);
                    mdi_contenedor men_mdi = new mdi_contenedor();
                    men_mdi.FormClosed += new FormClosedEventHandler(mdi_FormClosed);
                    men_mdi.Show();
                    txt_contraseña.Clear();
                    txt_usuario.Clear();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña invàlidos"); //De lo contrario, si la contraseña es incorrecta o el usuario, nos devuelve el fallo
                    txt_contraseña.Clear();
                    //txt_usuario.Clear();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }
        

        private void Login_Load(object sender, EventArgs e)
        {
           // seguridad.Conexion.DSN = "prueba2";



            txt_contraseña.PasswordChar = '*';
        }

        void mdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            this.Close();
            Application.Exit();
        }

        private void txt_contraseña_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_logear.PerformClick();
            }
        }

        public void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

      

