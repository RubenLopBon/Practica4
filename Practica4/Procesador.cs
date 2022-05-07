namespace procesador
{
    public class Procesador
    {
        public int ContarPalabras(string texto)
        {
            if (texto.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length == 0)
            {
                throw new Exception("No existe ninguna palabra");
            }

            int num = 0, aux = 0;
            string[] frases = texto.Split('.', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < frases.Length; i++)
            {
                aux = frases[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
                if (aux > num) num = aux;
            }

            return num;
        }

        /* 
        *********************************** Funcionalidad 1 RED ***********************************
        public int ContarPalabras(string texto)
        {
            throw new Exception("Función no implementada"); 
        }

        *********************** Funcionalidad 1 GREEN | Funcionalidad 2 RED ***********************
        public int ContarPalabras(string texto)
        {
            return texto.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        ********************* Funcionalidad 1 y 2 GREEN | Funcionalidad 3 RED *********************
        public int ContarPalabras(string texto)
        {
            if (texto.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length == 0) return 0;

            int num = 0;
            string[] frases = texto.Split('.', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < frases.Length; i++)
            {
                num = frases[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            }

            return num;
        }

        ********************* Funcionalidad 1 y 3 GREEN | Funcionalidad 2 RED *********************
        * Funcionalidad 2 RED: Cuando la última frase no es la más larga da error, se contradice
        * con devolver la funcionalidad 1 de devolver el número de palabras de la última frase
        * ¿Habrá que añadir una doble comprobación?
        public int ContarPalabras(string texto)
        {
            if (texto.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length == 0) return 0;

            int num = 0, aux = 0;
            string[] frases = texto.Split('.', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < frases.Length; i++)
            {
                aux = frases[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
                if (aux > num) num = aux;
            }

            return num;
        }

        ******************* Funcionalidad 3 y 4 GREEN | Funcionalidad 1 y 2 RED *******************
        *Funcionalidad 1 RED: Existen pruebas de contenido vacío con resultado 0 en vez de
        *saltar una excepción, se contradicen
        *Funcionalidad 2 RED: MISMO ERROR ANTERIOR
        public int ContarPalabras(string texto)
        {
            if (texto.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length == 0)
            {
                throw new Exception("No existe ninguna palabra");
            }

            int num = 0, aux = 0;
            string[] frases = texto.Split('.', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < frases.Length; i++)
            {
                aux = frases[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
                if (aux > num) num = aux;
            }

            return num;
        } 
         */
    }
}
