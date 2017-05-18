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
        #region Inicio del Form Login
        //=======================================================================================================================
        //---------------------------------------------- Form Login --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public Login()
        {
            InitializeComponent();
        }
        #endregion

        #region Boton Iniciar Sesion
        //=======================================================================================================================
        //---------------------------------------------- Form Load --------------------------------------------------------------
        //=======================================================================================================================
        //programador:María Gabriela Zimeri
        //Modificado por: Javier Figueroa Pereira
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
                }
                else // usuario incorrecto
                {
                    MessageBox.Show("Usuario incorrecto");
                }
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region Carga del Form
        //=======================================================================================================================
        //---------------------------------------------- Form Load --------------------------------------------------------------
        //=======================================================================================================================
        //programador:María Gabriela Zimeri
        //Modificado por: Javier Figueroa Pereira
        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                seguridad.Conexion.DSN = "prueba2";
                txt_contraseña.PasswordChar = '*';
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region Funciones a Realizar
        //=======================================================================================================================
        //---------------------------------------------- Form Load --------------------------------------------------------------
        //=======================================================================================================================
        //programador:María Gabriela Zimeri
        //Modificado por: Javier Figueroa Pereira
        private void txt_contraseña_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btn_logear.PerformClick();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
       
        public void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region Validaciones
        //=======================================================================================================================
        //--------------------------------------Navegacion--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public void Validacion_LetrasNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '_')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Llene el campo con caracteres permitidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_LetrasNumeros(e);
        }
    }
}

      

