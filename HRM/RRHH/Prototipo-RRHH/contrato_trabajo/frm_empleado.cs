using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesNavegador;
using dllconsultas;
using System.Data.Odbc;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Data;
using System.Threading;
using System.IO;

namespace contrato_trabajo
{
    public partial class frm_empleado : Form
    {
        public frm_empleado(DataGridView dgv, String id_empleado_pk, String nombre_emp, String apellido_emp, String dpi_emp, String telefono_hogar_emp, String telefono_movil_emp, String no_afiliacionIGSS_emp, String fecha_de_alta_emp, String fecha_de_baja_emp, String estadolaboral, Boolean Editar, Boolean tipo_accion)
        {
            this.dg = dgv;
            this.Editar1 = Editar;
            InitializeComponent();
            atributo = "id_empleado_pk";
            this.Codigo = id_empleado_pk;
            try
            {
                if(tipo_accion == true)
                {
                   /* this.txt_nomb_emp.Text = nombre;
                    this.txt_telef_emp.Text = telefono;
                    this.txt_direc_emp.Text = direccion;
                    this.cbo_gener_emp.Text = genero;
                    this.txt_dtp_fecha_nacim.Text = fecha_nacimiento; dtp_fecha_nacim.Text = txt_dtp_fecha_nacim.Text;
                    this.txt_dtp_fecha_ingr_emp.Text = fecha_ingreso; dtp_fecha_ingr_emp.Text = txt_dtp_fecha_ingr_emp.Text;
                    this.txt_dtp_fecha_egre_emp.Text = fecha_egreso; dtp_fecha_egre_emp.Text = txt_dtp_fecha_egre_emp.Text;
                    this.txt_dpi_emp.Text = dpi;
                    this.txt_carne_igss_emp.Text = no_afiliacion_igss;
                    this.txt_edad_emp.Text = edad;
                    this.txt_cbo_nacional_emp.Text = nacionalidad; cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
                    this.txt_cbo_estad_civ_emp.Text = estado_civil; cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
                    this.txt_cbo_cargo_emp.Text = cargo; cbo_cargo_emp.Text = txt_cbo_cargo_emp.Text;
                    this.txt_sueldo_emp.Text = sueldo;
                    this.txt_tipo_sueldo.Text = tipo_sueldo;
                    this.fn.ActivarControles(gpb_regist_emp); */
                }
                else
                {
                    fn.ActivarControles(tbc_datos_emp);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string imgLoc;
        string imgname;
        String Codigo;
        Boolean Editar1;
        String atributo;
        MySqlCommand comand;
        CapaNegocio fn = new CapaNegocio();
        DataGridView dg;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(tbc_datos_emp);
            fn.InhabilitarComponentes(this);
        }

        private void lbl_centro_trabajo_emp_Click(object sender, EventArgs e)
        {

        }

        private void btn_examinar_pic_emp_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Selecciones su foto de perfil";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    imgname = dlg.SafeFileName.ToString();
                    txt_nom_img.Text = imgname;
                    pic_empleado.ImageLocation = imgLoc;
                    txt_direc_img.Text = imgLoc;
                    string targetPath = @"C:/empleados";
                    string sourceFile = System.IO.Path.Combine(imgLoc);
                    string destFile = System.IO.Path.Combine(targetPath, imgname);
                    if (!System.IO.Directory.Exists(targetPath))
                    {
                        System.IO.Directory.CreateDirectory(targetPath);
                    }
                    System.IO.File.Copy(sourceFile, destFile, true);
                    txt_img_final.Text = destFile;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
