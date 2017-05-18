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

namespace Inventario
{
    public partial class FormDevolucionCompra : Form
    {
        public FormDevolucionCompra()
        {
            InitializeComponent();
        }
        string id_form = "10103";
        private void FormDevolucionCompra_Load(object sender, EventArgs e)
        {
            try
            {
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                cbo_bodega.DataSource = sd.ObtenerBodega();
                cbo_bodega.DisplayMember = "nombre_bodega";
                cbo_bodega.ValueMember = "id_bodega_pk";
                //***************************************************
                DataGridViewComboBoxColumn cbobienes = dgw_requisicion.Columns[1] as DataGridViewComboBoxColumn;
                cbobienes.DataSource = sd.ObtenerBien();
                cbobienes.DisplayMember = "descripcion";
                cbobienes.ValueMember = "CODIGO";

                dgw_requisicion.AutoGenerateColumns = false;


                //cbo_compra.DataSource = sd.ObtenerOrdendev();
                //cbo_compra.ValueMember = "id_factura_compra_pk";
                //cbo_compra.DisplayMember = "id_factura_compra_pk";

                //cbo_prov.DataSource = sd.ObtenerProveedor();
                //cbo_prov.ValueMember = "id_proveedor_pk";
                //cbo_prov.DisplayMember = "nombre_proveedor";
            }
            catch (Exception ex) { MessageBox.Show("No posee los permisos necesarios!", "¡Seguridad!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            DataGridViewRow entrada = new DataGridViewRow();
            dgw_requisicion.Rows.Add(entrada);
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (dgw_requisicion.CurrentRow.Index != dgw_requisicion.Rows.Count - 1)
            {

                DataGridViewRow entrada = new DataGridViewRow();
                entrada = dgw_requisicion.Rows[dgw_requisicion.CurrentRow.Index];
                dgw_requisicion.Rows.Remove(entrada);

            }
        }

        private void dgw_requisicion_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgw_requisicion.Columns[e.ColumnIndex].Name == "Descripcion")
                {

                    DataGridViewComboBoxCell CboBienes = dgw_requisicion.CurrentRow.Cells["Descripcion"] as DataGridViewComboBoxCell;
                    // DataGridViewComboBoxCell CboBienes = dgw_requisicion.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                    string codigo = CboBienes.Value.ToString();
                    dgw_requisicion.CurrentRow.Cells["Codigo"].Value = codigo;

                    string[] codigo_separado = codigo.Split('-');
                    string categoria = codigo_separado[0].Trim();
                    string id_bien = codigo_separado[1].Trim();

                    SistemaInventarioDatos sd = new SistemaInventarioDatos();
                   DataTable dt=  sd.SeleccionarPrecio(id_bien,categoria);
                    DataRow row = dt.Rows[0];
                    string precio = row[0].ToString();
                    dgw_requisicion.CurrentRow.Cells["Precio_prod"].Value = precio;

                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            //crear la venta, crear la factura y registrarlas
            //try
            //{
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                char delimitador = '-';
                string bodega = cbo_bodega.SelectedValue.ToString();

                bool y = ValidarExistenciaProd();


                if (y == true)
                {
                    bool x = ValidarCantidadDelProducto();

                    if (x == true)
                    {
                        foreach (DataGridViewRow fila in dgw_requisicion.Rows)
                        {

                            if (fila.Cells["Codigo"].Value != null)
                            {
                                //------------OBTENER  CANTIDAD Y BIEN
                                int cantidad = Convert.ToInt32(fila.Cells["Cant_devuelta"].Value);

                                DataGridViewComboBoxCell CboBienes = fila.Cells["Descripcion"] as DataGridViewComboBoxCell;
                                string codigo = CboBienes.Value.ToString();

                                string[] codigo_separado = codigo.Split(delimitador);
                                string categoria = codigo_separado[0].Trim();
                                string id_bien = codigo_separado[1].Trim();

                                int existencias = sd.ObtenerExistenciasEnBodega(id_bien, categoria, bodega);
                                int nueva_existencia = existencias - cantidad;
                                sd.ActualizarExistenciasEnBodega(id_bien, categoria, bodega, nueva_existencia);//0000000000000000000000000000000000000

                            }
                        }
                         SumarFactura();
                        MessageBox.Show("factura procesada con exito");
                        //----INSERTAR ENCABEZADO
                        string nit = txt_nit.Text.Trim();
                        DateTime f = Convert.ToDateTime(dtp_fecha_dev.Value);
                        string fecha = f.ToString("yyyy-MM-dd");
                        string nombre = txt_nom_cliente.Text.Trim();
                        string apellido = txt_apellido_cliente.Text.Trim();
                        string direccion = txt_direccion.Text.Trim();

                        sd.InsertarFacturaEncabezado(nit, nombre, apellido,direccion);
                        //--DETALLE
                        int id_fac = sd.ObtenerUltimaFact();
                        InsertarDetalleDevolucion(id_fac);

                        //--INSERTAR DOC INV
                        sd.InsertarDocInvDin(id_fac.ToString(), "-", "Factura", fecha, "-", "procesado","0");
                        //--DETALLE DOC INV
                        InsertarDetalleDocInv(id_fac);

                        //--REGISTRAR MOV
                        RegistrarMovimiento(id_fac);

                    }
                    else { MessageBox.Show("Hay menos existenicas de las que pretende vender"); }

                }
                else { MessageBox.Show("Alguno de los productos de la factura no existe en la bodega indicada"); }


            //}
            //catch { MessageBox.Show("No se pudo realizar la devolución"); }
        }


        decimal total;
        private void SumarFactura()
        {
            foreach (DataGridViewRow fila in dgw_requisicion.Rows)
            {

                if (fila.Cells["Codigo"].Value != null)
                {
                    //------------OBTENER  CANTIDAD Y BIEN
                    decimal cantidad = Convert.ToDecimal(fila.Cells["Cant_devuelta"].Value);
                    decimal precio = Convert.ToDecimal(fila.Cells["Precio_prod"].Value);

                    decimal total1 = cantidad * precio;
                    total = total + total1;
                    lbl_total.Text = total.ToString();

                }
            }
        }

        private void RegistrarMovimiento(int doc)
        {
            try
            {
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
            char delimitador = '-';
            foreach (DataGridViewRow fila in dgw_requisicion.Rows)
            {

                if (fila.Cells["Codigo"].Value != null)
                {
                    int cantidad = Convert.ToInt32(fila.Cells["Cant_devuelta"].Value);

                    string bodega = cbo_bodega.SelectedValue.ToString();

                    DataGridViewComboBoxCell CboBienes = fila.Cells["Descripcion"] as DataGridViewComboBoxCell;
                    string codigo = CboBienes.Value.ToString();

                    string[] codigo_separado = codigo.Split(delimitador);
                    string categoria = codigo_separado[0].Trim();
                    string id_bien = codigo_separado[1].Trim();
                    string documento = doc.ToString();
                    //-----------INSERTAR 
                    sd.RegistrarMovimientoInvDev("Venta", bodega, id_bien, categoria, cantidad, documento, "-", "Factura", "-");

                }



            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void InsertarDetalleDocInv(int id_dev)
        {
            try
            {
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                foreach (DataGridViewRow fila in dgw_requisicion.Rows)
                {

                    if (fila.Cells["Codigo"].Value != null)
                    {
                        //------------OBTENER  CANTIDAD Y BIEN
                        int cantidad = Convert.ToInt32(fila.Cells["Cant_devuelta"].Value);

                        DataGridViewComboBoxCell CboBienes = fila.Cells["Descripcion"] as DataGridViewComboBoxCell;
                        string codigo = CboBienes.Value.ToString();

                        string[] codigo_separado = codigo.Split('-');
                        string categoria = codigo_separado[0].Trim();
                        string id_bien = codigo_separado[1].Trim();


                        sd.InsertarDetalleDocInvDin(id_bien, cantidad, categoria, id_dev.ToString(), "-", "Factura", "-");

                    }
                }
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void InsertarDetalleDevolucion(int id_dev)
        {
            try
            {
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                foreach (DataGridViewRow fila in dgw_requisicion.Rows)
                {

                    if (fila.Cells["Codigo"].Value != null)
                    {
                        //------------OBTENER  CANTIDAD Y BIEN
                        int cantidad = Convert.ToInt32(fila.Cells["Cant_devuelta"].Value);

                        DataGridViewComboBoxCell CboBienes = fila.Cells["Descripcion"] as DataGridViewComboBoxCell;
                        string codigo = CboBienes.Value.ToString();

                        string[] codigo_separado = codigo.Split('-');
                        string categoria = codigo_separado[0].Trim();
                        string id_bien = codigo_separado[1].Trim();
                        string preciostring = fila.Cells["Precio_prod"].Value.ToString();
                        decimal precio = Convert.ToDecimal(preciostring);

                        sd.InsertarDetalleFact(cantidad, id_dev.ToString(), id_bien, categoria, precio);

                    }
                }


            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }



        private bool ValidarExistenciaProd()
        {

            string bodega = cbo_bodega.SelectedValue.ToString();
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            bool existente = true;

            foreach (DataGridViewRow fila in dgw_requisicion.Rows)
            {

                if (fila.Cells["Codigo"].Value != null)
                {

                    DataGridViewComboBoxCell CboBienes = fila.Cells["Descripcion"] as DataGridViewComboBoxCell;
                    string codigo = CboBienes.Value.ToString();

                    string[] codigo_separado = codigo.Split('-');
                    string categoria = codigo_separado[0].Trim();
                    string id_bien = codigo_separado[1].Trim();
                    //-----------VALIDAR SI YA EXISTE LA TUPLA
                    int y = sd.ValidarExistenciaDeProducto(id_bien, categoria, bodega);
                    if (y == 0)
                    {
                        existente = false;
                    }
                }
            }
            return existente;
        }


        private bool ValidarCantidadDelProducto()
        {
            string bodega = cbo_bodega.SelectedValue.ToString();
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            bool hay = true;

            foreach (DataGridViewRow fila in dgw_requisicion.Rows)
            {

                if (fila.Cells["Codigo"].Value != null)
                {
                    //------------OBTENER  CANTIDAD Y BIEN
                    int cantidad = Convert.ToInt32(fila.Cells["Cant_devuelta"].Value);

                    DataGridViewComboBoxCell CboBienes = fila.Cells["Descripcion"] as DataGridViewComboBoxCell;
                    string codigo = CboBienes.Value.ToString();

                    string[] codigo_separado = codigo.Split('-');
                    string categoria = codigo_separado[0].Trim();
                    string id_bien = codigo_separado[1].Trim();
              
                    int existencias = sd.ObtenerExistenciasEnBodega(id_bien, categoria, bodega);
                    int existencias_restantes = existencias - cantidad;
                  if(existencias_restantes < 0)
                    {
                        hay = false;
                    }

                }
            }
            return hay;
        }

        private void cbo_compra_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (cbo_compra.SelectedValue is int)
            //    {
            //        SistemaInventarioDatos sd = new SistemaInventarioDatos();
            //        DataTable dt = sd.ObtenerDetalleReq(cbo_compra.SelectedValue.ToString());
            //        dgw_requisicion.Rows.Clear();

            //        foreach (DataRow row in dt.Rows)
            //        {
            //            string categoria = row[0].ToString().Trim();
            //            string id_bien = row[1].ToString().Trim();
            //            string cantidad = row[2].ToString().Trim();
            //            string codigo = categoria + "-" + id_bien;
            //            DataGridViewRow entrada = new DataGridViewRow();
            //            dgw_requisicion.Rows.Add(entrada);

            //            DataGridViewComboBoxCell CboBienes = dgw_requisicion.Rows[dgw_requisicion.Rows.Count - 2].Cells["Descripcion"] as DataGridViewComboBoxCell;

            //            CboBienes.Value = codigo;
            //            //---------------------------------------
            //            dgw_requisicion.Rows[dgw_requisicion.Rows.Count - 2].Cells["Codigo"].Value = codigo;


            //            DataTable dtc = sd.ObtenerCosto(codigo);
            //            DataRow rowc = dtc.Rows[0];
            //            string costo = rowc[0].ToString();


            //            // dgw_requisicion.Rows[dgw_requisicion.Rows.Count - 2].Cells["Costo"].Value = costo;

            //            dgw_requisicion.Rows[dgw_requisicion.Rows.Count - 2].Cells["Cant_devuelta"].Value = cantidad;


            //        }
            //        //-----
            //        DataRow primera = dt.Rows[0];
            //        string cantidad_primera = primera[2].ToString();
            //        dgw_requisicion.Rows[0].Cells["Cant_devuelta"].Value = cantidad_primera;

            //        //-----
            //        // dgw_entradas.Refresh();
            //    }

            //}
            //catch(Exception ex) { MessageBox.Show(ex.Message); }
        }




    }
}
