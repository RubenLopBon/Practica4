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
    }
}
