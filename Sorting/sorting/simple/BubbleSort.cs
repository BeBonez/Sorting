namespace Sorting.sorting.simple
{
    class BubbleSort
    {
        public static int[] Sorting(int[] vet)
        {
            int comparacoes = 0;
            int atribuicoes = 0;
            int trocas = 0;

            int n = vet.Length;

            for (int i = 0; i < n; i++)
            {
                comparacoes++;
                for (int j = n - 1; j > i; j--)
                {
                    comparacoes++;
                    if (vet[j] < vet[j - 1])
                    {
                        trocas++;
                        int tmp = vet[j];
                        vet[j] = vet[j - 1];
                        vet[j - 1] = tmp;
                    }
                }
            }

            Price(comparacoes, atribuicoes, trocas);

            return vet;
        }

        private static void Price(int comp, int atrib, int troc)
        {
            Console.WriteLine("preço:");
            Console.WriteLine("Comparações: " + comp);
            Console.WriteLine("Atribuições:" + atrib);
            Console.WriteLine("Trocas: " + troc);    
        }
    }
}
