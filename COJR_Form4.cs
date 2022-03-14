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
    public partial class COJR_Form4 : Form
    {
        public COJR_Lista COJR_Lista4 = new COJR_Lista();
        public COJR_Form4()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvImpar.DataSource = COJR_Lista4.Impar();
        }
    }
}
