using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COJR_Prueba
{
    public partial class COJR_Form3 : Form
    {
        public COJR_Lista COJR_Lista3 = new COJR_Lista();
        public COJR_Form3()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            dgvCadena.DataSource = COJR_Lista3.Cadena(mtxtCadena.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mtxtCadena.Text = " ";
            dgvCadena.DataSource = " ";
        }
    }
}
