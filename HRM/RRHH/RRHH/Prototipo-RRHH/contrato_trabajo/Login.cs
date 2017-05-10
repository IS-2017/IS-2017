﻿using System;
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
using seguridad;

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
            try
            {
                // OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionM();
                seguridad.SistemaUsuarioDatos ss = new seguridad.SistemaUsuarioDatos();
                string usuario = txt_usuario.Text.Trim();
                string contraseña = ss.Encriptar(txt_contraseña.Text.Trim());
                seguridad.ClaseTomaIp ip = new seguridad.ClaseTomaIp();
                string localIP = ip.direccion();

                /****LLama a una funciòn almacenada que valida la existencia del usuario y la integridad de la contraseña****/
                //  try
                // {
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
                    mdi_contenedor men_seg = new mdi_contenedor(usuario);
                    men_seg.ShowDialog();
                    txt_contraseña.Clear();
                    txt_usuario.Clear();
                    
                    this.Close();
                }
                else if (Convert.ToInt16(resultado) == 0)// contraseña incorrecta
                {
                    MessageBox.Show("Contraseña incorrecta"); //De lo contrario, si la contraseña es incorrecta o el usuario, nos devuelve el fallo
                                                              // txt_contraseña.Clear();
                                                              //txt_usuario.Clear();
                }
                else // usuario incorrecto
                {
                    MessageBox.Show("Usuario incorrecto");
                }

                // }
                //catch
                //{
                //    txt_contraseña.Clear();
                //    txt_usuario.Clear();
                //    txt_usuario.Focus();
                //    MessageBox.Show("Usuario no existe");
                //}
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        

        private void Login_Load(object sender, EventArgs e)
        {
            seguridad.Conexion.DSN = "prueba2";



            txt_contraseña.PasswordChar = '*';
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

      

