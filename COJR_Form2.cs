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
    public partial class COJR_Form2 : Form
    {
        public COJR_Lista COJR_Lista2 = new COJR_Lista();
        public COJR_Form2()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            dgvLista.DataSource = COJR_Lista2.Celulares;
        }
    }
}
