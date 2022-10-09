﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionAgencia
{
    public partial class FrmSesion : Form
    {
        public FrmSesion()
        {
            InitializeComponent();
        }

        #region Componentes

        private void Cerrar()
        {
            this.Close();
        }

        #endregion

        private void btnrCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void lnklRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro frm = new FrmRegistro();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
