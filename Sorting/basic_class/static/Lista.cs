namespace Sorting.basic_class.@static
{
    class Lista
    {
        public int[] lista;
        public int cont;

        public Lista(int n)
        {
            lista = new int[n];
            cont = 0;
        }

        public bool InserirFim(int item)
        {
            if (cont < lista.Length)
            {
                lista[cont] = item;
                cont++;
                return true;
            }
            else
            {
                Console.WriteLine("Lista está cheia, não é possível inserir " + item);
                return false;
            }
        }

        public bool InserirInicio(int item)
        {
            lista[0] = item;

            return true;
        }

        public bool InserirPosicao(int pos)
        {
            if (pos < 0 || pos >= lista.Length)
            {
                // posição inválida
                return false;
            }

            lista[pos] = 1;

            return true;
        }

        public int RemoverFim()
        {
            if (cont > 0)
            {
                lista[cont] = 0;
                cont--;

                return lista[cont + 1];
            }
            else
            {
                return -1;
            }       
        }

        public int RemoverInicio()
        {
            lista[0] = 0;

            return -1;
        }

        public int RemoverPosicao(int pos)
        {
            if (pos < 0 || pos >= lista.Length)
            {
                // posição inválida
                return 0;
            }

            lista[pos] = 0;

            return -1; // implemente
        }

    }
}
