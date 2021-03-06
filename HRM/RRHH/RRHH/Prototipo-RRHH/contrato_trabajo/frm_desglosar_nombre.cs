﻿using System;
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
    public partial class frm_desglosar_nombre : Form
    {
        frm_empleado ownerForm = null;

        public frm_desglosar_nombre(frm_empleado ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
        }

        public void frm_desglosar_nombre_Load(object sender, EventArgs e)
        {
            txt_nom_completo.Text = txt_primer_nombre.Text.Trim() + txt_segundo_nombre.Text.Trim() + txt_primer_apellido.Text.Trim() + txt_segundo_apellido.Text.Trim();
        }

        

        public void txt_primer_nombre_TextChanged(object sender, EventArgs e)
        {
            txt_nom_completo.Text = txt_primer_nombre.Text.Trim() + " " + txt_segundo_nombre.Text.Trim() + " " + txt_primer_apellido.Text.Trim() + " " + txt_segundo_apellido.Text.Trim();
        }

        public void txt_segundo_nombre_TextChanged(object sender, EventArgs e)
        {
            txt_nom_completo.Text = txt_primer_nombre.Text.Trim() + " " + txt_segundo_nombre.Text.Trim() + " " + txt_primer_apellido.Text.Trim() + " " + txt_segundo_apellido.Text.Trim();
        }

        public void txt_primer_apellido_TextChanged(object sender, EventArgs e)
        {
            txt_nom_completo.Text = txt_primer_nombre.Text.Trim() + " " + txt_segundo_nombre.Text.Trim() + " " + txt_primer_apellido.Text.Trim() + " " + txt_segundo_apellido.Text.Trim();
        }

        public void txt_segundo_apellido_TextChanged(object sender, EventArgs e)
        {
            txt_nom_completo.Text = txt_primer_nombre.Text.Trim() + " " + txt_segundo_nombre.Text.Trim() + " " + txt_primer_apellido.Text.Trim() + " " + txt_segundo_apellido.Text.Trim();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.ownerForm.PassNombre(txt_primer_nombre.Text + " " + txt_segundo_nombre.Text);
            this.ownerForm.PassApellido(txt_primer_apellido.Text + " " + txt_segundo_apellido.Text);
            this.Close();
        }

        #region Validaciones
        //=======================================================================================================================
        //--------------------------------------Navegacion--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public void Validacion_LetrasNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar))
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

        public void txt_primer_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_LetrasNumeros(e);
        }

        private void txt_segundo_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_LetrasNumeros(e);
        }

        private void txt_primer_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_LetrasNumeros(e);
        }

        private void txt_segundo_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_LetrasNumeros(e);
        }

        #endregion


    }
}
