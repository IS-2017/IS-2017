﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crm
{
    public partial class FormNegociaciones : Form
    {
        public FormNegociaciones()
        {
            InitializeComponent();
        }

        private void FormNegociaciones_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
           
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FormNuevoNegocio f = new FormNuevoNegocio();
            f.MdiParent = this.MdiParent;
            f.Show();
            
        }


    }
}
