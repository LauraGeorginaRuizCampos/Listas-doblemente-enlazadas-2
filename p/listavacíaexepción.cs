using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p
{
    
    
        internal class ListaVaciaExcepcion : ApplicationException
    {
        public ListaVaciaExcepcion(string nombre)
            :base("La lista de nombre " + nombre + "esta vacía.")
        {

        }
    }
    
}
