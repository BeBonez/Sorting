namespace Sorting.sorting.efficient
{
    class HeapSort
    {
        public static int[] Sorting(int[] vet)
        {
            int comparacoes = 0;
            int atribuicoes = 0;
            int trocas = 0;

            int size = vet.Length;

            for (int i = size / 2 - 1; i >= 0; i--)
            {
                comparacoes++;
                Heapify(vet, size, i); // criar a árvore binária
            }

            for (int i = size - 1; i >= 0; i--)
            {
                comparacoes++;
                trocas++;

                var tempVar = vet[0];
                vet[0] = vet[i];
                vet[i] = tempVar;

                Heapify(vet, i, 0); // reordenar a árvore binária
            }

            Price(comparacoes, atribuicoes, trocas);

            return vet;
        }

        private static void Heapify(int[] _vet, int _size, int index)
        {
            int comparacoes = 0;
            int atribuicoes = 0;
            int trocas = 0;

            int largest = index;
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            comparacoes += 3;
            if (left < _size && _vet[left] > _vet[largest]) // primeiro garantir que o filho exista! Ou seja, não pode ser maior que o tamanho do vetor.
                largest = left; atribuicoes++;
            if (right < _size && _vet[right] > _vet[largest])
                largest = right; atribuicoes++;
            if (largest != index) //  se o maior não for o próprio nó, então troque
            {
                trocas++;
                var tempVar = _vet[index];
                _vet[index] = _vet[largest];
                _vet[largest] = tempVar;
                Heapify(_vet, _size, largest);
            }

            Price(comparacoes, atribuicoes, trocas);
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
