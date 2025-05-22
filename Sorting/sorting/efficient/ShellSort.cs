namespace Sorting.sorting.efficient
{
    class ShellSort
    {
       public static int[] Sorting(int[] vet)
       {
            int comparacoes = 0;
            int atribuicoes = 0;
            int trocas = 0;

            int n = vet.Length;

            int j, h, x, nn;
            for (h = 1; h <= n; h = (3 * h + 1)) ;
            while (h > 1)
            {
                comparacoes++;
                h /= 3;
                for (int k = 0; k < h; k++)
                {
                    comparacoes++;
                    atribuicoes++;
                    nn = (n / h) + ((n % h > k) ? 1 : 0);
                    for (int i = 1; i < nn; i++)
                    {
                        comparacoes++;
                        atribuicoes++;
                        x = vet[(i * h) + k];
                        j = i - 1;
                        while (j >= 0 && vet[j * h + k] > x)
                        {
                            comparacoes++;
                            atribuicoes++;
                            vet[((j + 1) * h) + k] = vet[(j * h) + k];
                            j--;
                        }
                        atribuicoes++;
                        vet[((j + 1) * h) + k] = x;
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
