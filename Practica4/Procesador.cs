using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procesador
{
    public class Procesador
    {
        public int ContarPalabras(string texto)
        {
            return texto.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        /* Funcionalidad 1,  red
        public int ContarPalabras(string texto)
        {
            throw new Exception("Función no implementada"); 
        }

        Funcionalidad 1  green y Funcionalidad 2 red
        public int ContarPalabras(string texto)
        {
            return texto.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
         * 
         * 
         */
    }
}
