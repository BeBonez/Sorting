using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Sorting.sorting.efficient
{
    class MergeSort
    {
        // utilizei um site em inglês para entender o algoritmo ; )
        // fui comentando o código para entender melhor
        public static int[] Sorting(int[] vet)
        {
            DividirVetor(vet, 0, vet.Length - 1); // Call the splitting method with the entire array

            return vet;
        }

        private static int[] DividirVetor(int[] vet, int esquerda, int direita) 
        {
            int comparacoes = 0;
            int atribuicoes = 0;
            int trocas = 0;

            // Check if the array is empty or has only one element. If so, return the array as it is already sorted.
            comparacoes++;
            if (vet.Length == 0 || vet.Length == 1)
                return vet;
            
            comparacoes++;
            if (esquerda < direita)
            // Note right = array.Length - 1.
            // because the right index is inclusive, so we need to subtract 1 from the length of the array to get the last index.
            {
                atribuicoes++;
                int meio = esquerda + (direita - esquerda) / 2; // middle index

                // Use recursion to divide the array into two halves until we can't divide it anymore. 
                DividirVetor(vet, esquerda, meio);
                DividirVetor(vet, meio + 1, direita);

                // Step 3: Merge the arrays into a new array whose values are sorted.
                MergeArray(vet, esquerda, meio, direita); // merge the two halves
            }

            Price(comparacoes, atribuicoes, trocas); // Print the price of the algorithm

            return vet;
        }

        private static void MergeArray(int[] _vet, int _esquerda, int _meio, int _direita)
        {
            int comparacoes = 0;
            int atribuicoes = 0;
            int trocas = 0;

            // Create temporary arrays to hold the left and right halves of the array
            var leftArrayLength = _meio - _esquerda + 1;
            var rightArrayLength = _direita - _meio;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;

            // Copy data to temporary arrays
            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = _vet[_esquerda + i]; atribuicoes++;
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = _vet[_meio + 1 + j]; atribuicoes++;

            i = 0;
            j = 0;
            int k = _esquerda;

            // Merge the temporary arrays back into the original array
            while (i < leftArrayLength && j < rightArrayLength)
            {
                comparacoes++;
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    _vet[k++] = leftTempArray[i++];
                }
                else
                {
                    _vet[k++] = rightTempArray[j++];
                }
            }

            // Copy the remaining elements of leftTempArray, if any
            while (i < leftArrayLength)
            {
                atribuicoes++;
                _vet[k++] = leftTempArray[i++];
            }

            // Copy the remaining elements of rightTempArray, if any
            while (j < rightArrayLength)
            {
                atribuicoes++;
                _vet[k++] = rightTempArray[j++];
            }

            Price(comparacoes, atribuicoes, trocas); // Print the price of the algorithm
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
