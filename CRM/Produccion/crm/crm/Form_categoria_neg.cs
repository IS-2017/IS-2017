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
    public partial class Form_categoria_neg : Form
    {
        public Form_categoria_neg()
        {
            InitializeComponent();
        }

        private void Form_categoria_neg_Load(object sender, EventArgs e)
        {
            OpBD o = new OpBD();
            DataTable dt = OpBD.SeleccionarCategorias();
            grid_cat.DataSource = dt;
            gridView1.Columns[0].Caption = "Categoría";


        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string categoria = txt_cat.Text.Trim();
            OpBD o = new OpBD();
            int result = o.InsertarCategoria(categoria);
            if (result == 1)
            {
                MessageBox.Show("Categoria registrada exitosamente!");
            }
              else
               {
                MessageBox.Show("Categoria no ingresada");
               }
            grid_cat.DataSource = OpBD.SeleccionarCategorias();
            gridView1.Columns[0].Caption = "Categoría";
        }
    }
}
