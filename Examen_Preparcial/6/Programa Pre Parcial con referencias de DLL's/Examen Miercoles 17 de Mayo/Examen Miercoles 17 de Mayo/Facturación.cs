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
    public partial class Facturación : Form
    {
        public Facturación()
        {
            InitializeComponent();
        }
        capa_datos ca = new capa_datos();
        private void Facturación_Load(object sender, EventArgs e)
        {
            try
            {
                ca.llenar_id_bien(comboBox1);
                comboBox1.SelectedIndex = -1;
                DataColumn columna;
                //primera columna
                columna = new DataColumn();
                columna.DataType = System.Type.GetType("System.Int32");
                columna.ColumnName = "ID Producto";
                dt.Columns.Add(columna);

                //2 columna
                columna = new DataColumn();
                columna.DataType = System.Type.GetType("System.String");
                columna.ColumnName = "Decripción";
                dt.Columns.Add(columna);
                //3 columna
                columna = new DataColumn();
                columna.DataType = System.Type.GetType("System.Double");
                columna.ColumnName = "Precio";
                dt.Columns.Add(columna);
                //4 columna
                columna = new DataColumn();
                columna.DataType = System.Type.GetType("System.Double");
                columna.ColumnName = "Cantidad";
                dt.Columns.Add(columna);
                //5 columna
                

                dt.Columns.Add("Sub Total", Type.GetType("System.Double"), "Precio* Cantidad");
            }
            catch
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        double precio;
        String descripcion;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ca.cargar("select precio_venta from bien where id_bien_pk = '" + comboBox1.SelectedValue.ToString() + "';");
                precio = Convert.ToDouble(dt.Rows[0][0]);
                txt_precio.Text = precio.ToString();
                DataTable dtt = ca.cargar("select id_bien_pk from bien where id_bien_pk = '" + comboBox1.SelectedValue.ToString() + "';");
                int codigo = Convert.ToInt32(dtt.Rows[0][0]);
                txt_id_producto.Text = codigo.ToString();
                DataTable dpp = ca.cargar("select descripcion from bien where id_bien_pk = '" + comboBox1.SelectedValue.ToString() + "';");
                descripcion = dpp.Rows[0][0].ToString();
                txt_descripcion.Text = descripcion;


            }
            catch
            {

            }

        }
        DataTable dt = new DataTable();
        double totaaa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              
                {

                    DataRow row;
                    row = dt.NewRow();
                    row[0] = txt_id_producto.Text;
                    row[1] = txt_descripcion.Text;
                    row[2] = txt_precio.Text;
                    row[3] = txt_cantidad.Text;
                    double totalito = Convert.ToDouble(txt_total.Text);
                    double total = Convert.ToDouble(txt_total.Text);
                    totaaa += total;
                    textBox4.Text = totaaa.ToString();
                    double IVA= Convert.ToDouble(totaaa * 0.12);
                    textBox5.Text = IVA.ToString();

                    dt.Rows.Add(row);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_id_producto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_cantidad.Text != null)
                {
                    int cantidad = Convert.ToInt16(txt_cantidad.Text);
                    double total = precio * cantidad;
                    txt_total.Text = total.ToString();
                }
                else
                {
                    txt_total.Text = "0";
                }
            }
            catch
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtp = ca.cargar("Select CONCAT(nombre_cliente, ' ', apellido_cliente) From cliente where NIT = '" + txt_NIT.Text + "';");
                String resultado = Convert.ToString(dtp.Rows[0][0]);
                if (resultado == null)
                {
                    textBox1.Text = "";
                    textBox1.Enabled = false;
                }
                else
                {
                    textBox1.Text = resultado;

                }
            }

            catch
            {

            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
           
                ca.Ejecutar_Mysql("insert into factura (id_factura_pk, fecha_emision, id_cliente_pk) values (null,'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + "1" + "');");
                foreach (DataRow row in dt.Rows)
                {
                    String activo = "activo";
                    DataTable dtttt = ca.cargar("select max(id_factura_pk) from factura ");
                    int fact = Convert.ToInt32(dtttt.Rows[0][0]);
                    ca.Ejecutar_Mysql("insert into factura_detalle(id_detalle_factura, id_bien_pk, id_factura_pk, Descripción, Precio, Cantidad, estado) values (null,'" + row[0].ToString() + "','" + fact + "','" + row[1].ToString() + "','" + row[2].ToString() + "','" + row[3].ToString() + "','" + activo + "');");
                   

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}


            
      

