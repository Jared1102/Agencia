using System;
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
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
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
    }
}
