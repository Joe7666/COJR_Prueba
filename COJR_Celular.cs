using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COJR_Prueba
{
    public class COJR_Celular
    {   
        public string Codigo { set; get; }
        public string Marca { set; get; }
        public string Modelo { set; get; }
        public int Precio { set; get; }

        public COJR_Celular()
        {
        }

        public COJR_Celular(string codigo, string marca, string modelo, int precio)
        {
            Codigo = codigo;
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
        }
    }
}
