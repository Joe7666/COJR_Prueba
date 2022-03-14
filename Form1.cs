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
    public partial class Form1 : Form
    {
        COJR_Lista COJR_lista1 = new COJR_Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            COJR_Celular celular = new COJR_Celular();
            celular.Codigo = mtxtCodigo.Text;
            celular.Marca = mtxtMarca.Text;
            celular.Modelo = mtxtModelo.Text;
            celular.Precio = Convert.ToInt32(txtPrecio.Text);
            COJR_lista1.Aniadir(celular);
            MessageBox.Show("Ingresado correctamente");

        }


        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            COJR_Form2 COJR_Form2 = new COJR_Form2();
            COJR_Form2.Show();
            COJR_Form2.COJR_Lista2 = COJR_lista1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mtxtCodigo.Text = " ";
            mtxtMarca.Text = " ";
            mtxtModelo.Text = " ";
            txtPrecio.Text = " ";
        }

        private void btnCadena_Click(object sender, EventArgs e)
        {
            COJR_Form3 cOJR_Form3 = new COJR_Form3();
            cOJR_Form3.Show();
            cOJR_Form3.COJR_Lista3 = COJR_lista1;
        }

        private void btnImpar_Click(object sender, EventArgs e)
        {
            COJR_Form4 cOJR_Form4 = new COJR_Form4();
            cOJR_Form4.Show();
            cOJR_Form4.COJR_Lista4 = COJR_lista1;
        }
    }
}
