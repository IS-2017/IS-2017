using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seguridad;
using System.Data.Odbc;

namespace proyecto_ventas
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                seguridad.Conexion.DSN = "proyectos";
                txt_pass.PasswordChar = '*';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                // OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionM();
                seguridad.SistemaUsuarioDatos ss = new seguridad.SistemaUsuarioDatos();
                string usuario = txt_usuario.Text.Trim();
                string contraseña = ss.Encriptar(txt_pass.Text.Trim());
                seguridad.ClaseTomaIp ip = new seguridad.ClaseTomaIp();
                string localIP = ip.direccion();
                /****LLama a una funciòn almacenada que valida la existencia del usuario y la integridad de la contraseña****/
                string consulta = "select ValidarContrasena('" + usuario + "', '" + contraseña + "','" + localIP + "') ";
                OdbcCommand comando = new OdbcCommand(consulta, con);
                object resultado = comando.ExecuteScalar();
                if (Convert.ToInt16(resultado) == 1) //esto nos indica que la validaciòn ha sido correcta por parte de la funciòn almacenada
                {
                    // seguridad.LlegarSeguridad.EstablecerUsuario(usuario);
                    seguridad.Conexion.User = usuario;
                    seguridad.Conexion.PassWord = contraseña;
                    MessageBox.Show("¡Bienvenido!: " + usuario);
                    this.Hide();
                    //Contenedor_MDI men_seg = new Contenedor_MDI();
                    // Contenedor_MDI.Usuario = usuario;
                    Contenedor_MDI men = new Contenedor_MDI(usuario);

                    men.ShowDialog();
                    txt_pass.Clear();
                    txt_usuario.Clear();
                    this.Close();
                }
                else if (Convert.ToInt16(resultado) == 0)// contraseña incorrecta
                {
                    MessageBox.Show("Contraseña incorrecta"); //De lo contrario, si la contraseña es incorrecta o el usuario, nos devuelve el fallo
                }
                else // usuario incorrecto
                {
                    MessageBox.Show("Usuario incorrecto");
                }
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
