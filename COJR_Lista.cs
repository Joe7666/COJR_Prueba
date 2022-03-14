using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COJR_Prueba
{
    public class COJR_Lista
    {
        public List<COJR_Celular> Celulares = new List<COJR_Celular>();

        public COJR_Lista()
        {
            Celulares = new List<COJR_Celular>();
        }
        public void Aniadir(COJR_Celular Celular)
        {
            Celulares.Add(Celular);
        }
        public List<COJR_Celular> Cadena(string letra)
        {
            List<COJR_Celular> aux = new List<COJR_Celular>();
            foreach (COJR_Celular cOJR_Celular in Celulares)
            {
                if (cOJR_Celular.Marca.EndsWith(letra))
                {
                    aux.Add(cOJR_Celular);
                }
            }
            return aux;
        }   
        public List<COJR_Celular> Impar()
        {
            List<COJR_Celular> aux = new List<COJR_Celular>();
            foreach(COJR_Celular cOJR_Celular in Celulares)
            {
                if(cOJR_Celular.Precio%2==0)
                {
                    aux.Add(cOJR_Celular);
                }
            }
            return aux;
        }
    }
}
