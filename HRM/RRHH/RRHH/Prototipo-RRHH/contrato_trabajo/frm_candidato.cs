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
using System.Data.Odbc;

namespace contrato_trabajo
{
    public partial class frm_candidato : Form
    {
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar;
        String Codigo;
        String atributo;
        DataGridView dg;

        public frm_candidato()
        {
            InitializeComponent();
        }

        public frm_candidato(DataGridView gb, String id_candidato_pk, String nombre_candidato, String apellido_candidato, String cv_candidato, String id_reclutamiento_candidato,Boolean Editar1)
        {
            this.dg = gb;
            this.Editar = Editar1;
            InitializeComponent();
            atributo = "id_candidato_pk";
            this.Codigo = id_candidato_pk;
            if (Editar == true)
            {
                this.txt_apellido_candidato.Text = apellido_candidato;
                this.txt_nombre_candidato.Text = nombre_candidato;
                this.txt_cv_candidato.Text = cv_candidato;
                this.txt_reclutamiento_candidato.Text = id_reclutamiento_candidato; cbo_reclutamiento_candidato.Text = txt_reclutamiento_candidato.Text;
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_apellido_candidato.Enabled = true; txt_cv_candidato.Enabled = true; txt_nombre_candidato.Enabled = true; cbo_reclutamiento_candidato.Enabled = true; btn_guardar_ruta.Enabled = true;
            txt_apellido_candidato.Text = ""; txt_cv_candidato.Text = ""; txt_nombre_candidato.Text = ""; txt_reclutamiento_candidato.Text = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_reclutamiento_candidato.Text = cbo_reclutamiento_candidato.SelectedValue.ToString();
                TextBox[] textbox = { txt_apellido_candidato, txt_cv_candidato, txt_estado_reclutamiento, txt_nombre_candidato, txt_reclutamiento_candidato };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "candidato";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        //MessageBox.Show("Se modifico el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /*bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_dep.Text, "documento");
                        if (insertar == 0)
                        {
                            btn_guardar.Enabled = false;
                        }*/
                        txt_apellido_candidato.Text = ""; txt_cv_candidato.Text = ""; txt_nombre_candidato.Text = ""; txt_reclutamiento_candidato.Text = "";
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //MessageBox.Show("Se Inserto el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_apellido_candidato.Text = ""; txt_cv_candidato.Text = ""; txt_nombre_candidato.Text = ""; txt_reclutamiento_candidato.Text = "";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "id_candidato_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nombre_candidato.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_apellido_candidato.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_cv_candidato.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_reclutamiento_candidato.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); cbo_reclutamiento_candidato.Text = txt_reclutamiento_candidato.Text;
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a modificar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_candidato_pk";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "candidato";
                    fn.eliminar(tabla, atributo2, codigo2);
                    //MessageBox.Show("Se elimino el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //bita.Eliminar("Eliminacion de empresa con el numero: " + codigo2, "empresa");
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "candidato";
            //op.ejecutar(this.dg, tabla);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_apellido_candidato.Enabled = false; txt_cv_candidato.Enabled = false; txt_nombre_candidato.Enabled = false; cbo_reclutamiento_candidato.Enabled = false; btn_guardar_ruta.Enabled = false;
            txt_apellido_candidato.Text = ""; txt_cv_candidato.Text = ""; txt_nombre_candidato.Text = ""; txt_reclutamiento_candidato.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "candidato";
            fn.ActualizarGrid(this.dg, "Select * from candidato WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dg);
                TextBox[] textbox = { txt_apellido_candidato, txt_cv_candidato, txt_nombre_candidato, txt_reclutamiento_candidato };
                fn.llenartextbox(textbox, dg);
                cbo_reclutamiento_candidato.Text = txt_reclutamiento_candidato.Text;
            }
            catch
            {
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Siguiente(dg);
                TextBox[] textbox = { txt_apellido_candidato, txt_cv_candidato, txt_nombre_candidato, txt_reclutamiento_candidato };
                fn.llenartextbox(textbox, dg);
                cbo_reclutamiento_candidato.Text = txt_reclutamiento_candidato.Text;
            }
            catch
            {
            }
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Primero(dg);
                TextBox[] textbox = { txt_apellido_candidato, txt_cv_candidato, txt_nombre_candidato, txt_reclutamiento_candidato };
                fn.llenartextbox(textbox, dg);
                cbo_reclutamiento_candidato.Text = txt_reclutamiento_candidato.Text;
            }
            catch
            {
            }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Ultimo(dg);
                TextBox[] textbox = { txt_apellido_candidato, txt_cv_candidato, txt_nombre_candidato, txt_reclutamiento_candidato };
                fn.llenartextbox(textbox, dg);
                cbo_reclutamiento_candidato.Text = txt_reclutamiento_candidato.Text;
            }
            catch
            {
            }
        }

        public void llenarCboCandidato()
        {
            //se realiza la conexión a la base de datos
            Ayuda.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_reclutamiento_pk, nombre_reclutamiento from reclutamiento";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "reclutamiento");
            cbo_reclutamiento_candidato.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_reclutamiento_candidato.ValueMember = ("id_reclutamiento_pk");
            //se indica el valor a desplegar en el combobox
            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["nombre_reclutamiento"] = dr["id_reclutamiento_pk"].ToString() + "|" + dr["nombre_reclutamiento"].ToString();
            }
            cbo_reclutamiento_candidato.DataSource = dt;
            cbo_reclutamiento_candidato.DisplayMember = "nombre_reclutamiento";
        }

        private void frm_candidato_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_candidato);
            llenarCboCandidato();
        }

        private void btn_guardar_ruta_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            txt_cv_candidato.Text = openFileDialog1.FileName.ToString();
            /*saveFileDialog1.Filter = "Pdf file|*.pdf|Word file|*.docx";
            saveFileDialog1.Title = "Ruta de CV";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.btn_guardar_ruta..Save(fs,
                           System.Drawing..GetPixelFormatSize.Jpeg);
                        break;

                    case 2:
                        this.btn_guardar_ruta.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.button2.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }*/
        }
    }
}
