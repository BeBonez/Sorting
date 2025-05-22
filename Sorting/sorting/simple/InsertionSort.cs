namespace Sorting.sorting.simple
{
    class InsertionSort
    {
        public static int[] Sorting(int[] vet)
        {
            int comparacoes = 0;
            int atribuicoes = 0;
            int trocas = 0;

            int j, x;
            int n = vet.Length;
            for (int i = 1; i < n; i++)
            {
                comparacoes++;
                x = vet[i]; atribuicoes++;
                j = i - 1; atribuicoes++;
                while (j >= 0 && vet[j] > x)
                {
                    comparacoes++;                    
                    vet[j + 1] = vet[j]; atribuicoes++;
                    j--;
                }
                vet[j + 1] = x; atribuicoes++;
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
