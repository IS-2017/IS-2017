﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesNavegador;

namespace Inventario
{
    public partial class form_reporte_compras : Form
    {
        public form_reporte_compras()
        {
            InitializeComponent();
        }
    

   
        private void form_reporte_compras_Load(object sender, EventArgs e)
        {
            try
            {
                //CapaNegocio fn = new CapaNegocio();
                //DataTable seg = seguridad.ObtenerPermisos.Permisos(seguridad.Conexion.User, id_form);
                //if (seg.Rows.Count > 0)
                //{
                //    fn.desactivarPermiso(seg, btn_guardar, btn_eliminar, btn_editar, btn_nuevo, btn_cancelar, btn_actualizar, btn_buscar, btn_anterior, btn_siguiente, btn_primero, btn_ultimo);
                //}
                //----------------------------------------------------------
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                dgw_movimientos.DataSource = sd.TodosLosMovimientos();

                dgw_movimientos.Columns[0].HeaderText = "Mov.";
                dgw_movimientos.Columns[1].HeaderText = "Fecha";
                dgw_movimientos.Columns[2].HeaderText = "Codigo prod.";
                dgw_movimientos.Columns[3].HeaderText = "Descripción";
                dgw_movimientos.Columns[4].HeaderText = "Cant.";
                dgw_movimientos.Columns[5].HeaderText = "Transacción";
                dgw_movimientos.Columns[6].HeaderText = "Bodega";
                dgw_movimientos.Columns[7].HeaderText = "Doc.";
                dgw_movimientos.Columns[8].HeaderText = "Tipo doc.";


                dgw_movimientos.Columns[0].Width = 40;
                dgw_movimientos.Columns[1].Width = 70;
                dgw_movimientos.Columns[2].Width = 55;
                dgw_movimientos.Columns[3].Width = 290;
                dgw_movimientos.Columns[4].Width = 35;
                dgw_movimientos.Columns[5].Width = 70;
                dgw_movimientos.Columns[6].Width = 95;
                dgw_movimientos.Columns[7].Width = 42;
                dgw_movimientos.Columns[8].Width = 103;

                 dgw_movimientos.DataSource = sd.MovimientosCompras();
            }
            catch (Exception ex) { MessageBox.Show("No posee los permisos necesarios!", "¡Seguridad!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Abrir.Form1 hola = new Abrir.Form1();
            //hola.Crystal = @"C:\Users\Chrix\Desktop\cosas\03 - 11 -16\reporte_existencias\reporte_existencias\reporte_movimientos.rpt";
            //hola.Show();
            try
            {
                FormReporteMovimientos f = new FormReporteMovimientos();
                f.dgw_rep = dgw_movimientos;
                f.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_anterior_Click_1(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Anterior(dgw_movimientos);
        }

        private void btn_siguiente_Click_1(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Siguiente(dgw_movimientos);
        }

        private void btn_primero_Click_1(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Primero(dgw_movimientos);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Ultimo(dgw_movimientos);
        }

        private void dgw_movimientos_DoubleClick_1(object sender, EventArgs e)
        {
            FormDocumento f = new FormDocumento();
            f.MdiParent = this.MdiParent;

            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt_doc = new DataTable();
            DataRow row;
            DataRow row2;
            string doc = dgw_movimientos.CurrentRow.Cells[7].Value.ToString();
            string[] doc_separado = doc.Split('-');
            string no = doc_separado[0].Trim();
            string serie = doc_separado[1].Trim();
            DateTime fe = Convert.ToDateTime(dgw_movimientos.CurrentRow.Cells[1].Value);
            string fecha = fe.ToString("dd-MM-yyyy");
            string tipo_doc = dgw_movimientos.CurrentRow.Cells[8].Value.ToString().Trim();
            string prov;
            string cliente;

            f.lbl_fecha.Text = fecha;
            f.lbl_no.Text = no;
            f.lbl_serie.Text = serie;
            f.lbl_tipo.Text = tipo_doc;
            //------------------
            string transaccion = dgw_movimientos.CurrentRow.Cells[5].Value.ToString();
            if (transaccion == "Compra")
            {
                try
                {
                    dt = sd.ObtenerProvClieCom(no, "-", tipo_doc);
                    row = dt.Rows[0];
                    string id_prov = row[0].ToString();
                    dt2 = sd.Prov(id_prov);
                    row2 = dt2.Rows[0];
                    string nombre_prov = row2[0].ToString();
                    f.label7.Visible = true;
                    f.lbl_prov.Visible = true;
                    f.lbl_prov.Text = nombre_prov;
                    //------------------------------
                    dt_doc = sd.ObtenerDetalleDocInv(no, "-", tipo_doc);
                    f.dgw_det.DataSource = dt_doc;

                }
                catch { }

            }

            else if (transaccion == "Devolucion sobre compra")
            {
                try
                {
                    dt = sd.ObtenerProvClieCom(no, "-", tipo_doc);
                    row = dt.Rows[0];
                    string id_prov = row[0].ToString();
                    dt2 = sd.Prov(id_prov);
                    row2 = dt2.Rows[0];
                    string nombre_prov = row2[0].ToString();
                    f.label7.Visible = true;
                    f.lbl_prov.Visible = true;
                    f.lbl_prov.Text = nombre_prov;
                    //------------------------------
                    dt_doc = sd.ObtenerDetalleDocInv(no, "-", tipo_doc);
                    f.dgw_det.DataSource = dt_doc;
                }
                catch { }
            }
            else if (transaccion == "Venta")
            {
                try
                {
                    //dt = sd.ObtenerProvClieCom(no, "-", tipo_doc);
                    //row = dt.Rows[0];
                    //string id_prov = row[0].ToString();
                    //dt2 = sd.Prov(id_prov);
                    //row2 = dt2.Rows[0];
                    //string nombre_prov = row2[0].ToString();
                    //f.label7.Visible = true;
                    //f.lbl_prov.Visible = true;
                    //f.lbl_prov.Text = nombre_prov;
                    //------------------------------
                    dt_doc = sd.ObtenerDetalleDocInv(no, serie, tipo_doc);
                    f.dgw_det.DataSource = dt_doc;
                }
                catch { }
            }
            else if (transaccion == "Devolucion sobre venta")
            {



            }


            //---
            f.Show();
        }




    }
}
