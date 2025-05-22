namespace Sorting.sorting.efficient
{
    class QuickSort
    {
        public static int[] Sorting(int[] _vet)
        {
            QuickSortIt(_vet, 0, _vet.Length - 1); // Call the sorting method with the entire array

            return _vet;
        }

        private static int[] QuickSortIt(int[] vet, int leftIndex, int rightIndex)
        {
            int comparacoes = 0;
            int atribuicoes = 0;
            int trocas = 0;

            var i = leftIndex;
            var j = rightIndex;
            var pivot = vet[leftIndex];
            while (i <= j)
            {
                comparacoes++;
                while (vet[i] < pivot) // skip the elements less than the pivot
                {
                    comparacoes++;
                    i++;
                }

                comparacoes++;
                while (vet[j] > pivot) // skip the elements greater than the pivot
                {
                    comparacoes++;
                    j--;
                }

                comparacoes++;
                if (i <= j) // swap the elements
                {
                    trocas++;
                    int temp = vet[i];
                    vet[i] = vet[j];
                    vet[j] = temp;
                    i++;
                    j--;
                }
            }

            comparacoes++;
            if (leftIndex < j)
                QuickSortIt(vet, leftIndex, j);
            comparacoes++;
            if (i < rightIndex)
                QuickSortIt(vet, i, rightIndex);

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
