using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Supermercado_BE
{
    public class Mercaderia
    {
        public string NombredelaMercaderia { get; set; }
        public string Codigo { get; set; }
        public string MetodoDePago { get; set; }

        public void Agregar(string aNombredelaMercaderia,
            string acodigo,
            string aMetodoDePago)
        {
            NombredelaMercaderia = aNombredelaMercaderia;
            Codigo = acodigo;
            MetodoDePago = aMetodoDePago;
        }
    }
}
