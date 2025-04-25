namespace Sorting.sorting.efficient
{
    class HeapSort
    {
        public static int[] Sorting(int[] vet)
        {
            int size = vet.Length;

            for (int i = size / 2 - 1; i >= 0; i--)
            {
                Heapify(vet, size, i); // criar a árvore binária
            }

            for (int i = size - 1; i >= 0; i--)
            {
                var tempVar = vet[0];
                vet[0] = vet[i];
                vet[i] = tempVar;

                Heapify(vet, i, 0); // reordenar a árvore binária
            }

            return vet;
        }

        private static void Heapify(int[] _vet, int _size, int index)
        {
            int largest = index;
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            if (left < _size && _vet[left] > _vet[largest]) // primeiro garantir que o fillho exista! Ou seja, não pode ser maior que o tamanho do vetor.
                largest = left;
            if (right < _size && _vet[right] > _vet[largest])
                largest = right;
            if (largest != index) //  se o maior não for o próprio nó, então troque
            {
                var tempVar = _vet[index];
                _vet[index] = _vet[largest];
                _vet[largest] = tempVar;
                Heapify(_vet, _size, largest);
            }
        }
    }
}
