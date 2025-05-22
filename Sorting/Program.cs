using Sorting.basic_class.@static;
using Sorting.manager;
using Sorting.print;

public class Program
{
    public static void Main(string[] args)
    {
        // https://github.com/accj1990/Sorting.git
        // https://pt.overleaf.com/read/kptbxrwtrzch#8b9776

        int[] _vet = ManagerFileReader.Arquivo10TXT();
        int[] _vet2 = ManagerFileReader.Arquivo1000000TXT();

        // Crie um menu que solicite ao usuário qual é o arquivo que será lido e qual algoritmo deverá ser executado

        Console.WriteLine("Digite um número para definir um algoritmo de ordenação para um vetor pequeno");
        Console.WriteLine("default: - Bubble sort");
        Console.WriteLine("1 - Insertion sort");
        Console.WriteLine("2 - Heap sort");
        Console.WriteLine("3 - Merge sort");
        Console.WriteLine("4 - Quick sort");
        Console.WriteLine("5 - Shell sort");

        int escolha = int.Parse(Console.ReadLine()!);

        switch (escolha)
        {
            case 1: SelectInsertionSort(_vet); break;
            case 2: SelectHeapSort(_vet); break;
            case 3: SelectMergeSort(_vet); break;
            case 4: SelectQuickSort(_vet); break;
            case 5: SelectShellSort(_vet); break;
            default: SelectBubbleSort(_vet); break;
        }

        // por conta do meu método apressado sorts com múltiplas funções externas, demoram MUITO. Escolha algo commo bubble sort e evite merge sort, que leva uns 8 minutos.
        Console.WriteLine("Digite um número para definir um algoritmo de ordenação para um vetor grande");
        Console.WriteLine("default: - Bubble sort");
        Console.WriteLine("1 - Insertion sort");
        Console.WriteLine("2 - Heap sort");
        Console.WriteLine("3 - Merge sort");
        Console.WriteLine("4 - Quick sort");
        Console.WriteLine("5 - Shell sort");

        escolha = int.Parse(Console.ReadLine()!);

        switch (escolha)
        {
            case 1: SelectInsertionSort(_vet2); break;
            case 2: SelectHeapSort(_vet2); break;
            case 3: SelectMergeSort(_vet2); break;
            case 4: SelectQuickSort(_vet2); break;
            case 5: SelectShellSort(_vet2); break;
            default: SelectBubbleSort(_vet2); break;
        }

        Console.WriteLine("Respostas da Questão 5");
        Console.WriteLine("A) 7 8 6 2 4 3 5 e 10.\r\nB) 9, pois o quicksort realiza n - 1 chamadas no seu pior caso, que é o que ocorre.\r\nC) O(n^2), pois o quicksort precisa realizar n * (n - 1) comparações em seu pior caso.\r\n");


        int[] vet3 = ManagerFileReader.Arquivo100TXT();

        // Fila, Pilha e Lista em alocação estática
        Fila f = new Fila(100);
        for (int i = 0; i < 100; i++)
        {
            f.Inserir(vet3[i]);
        }

        f.Mostrar();
        f.Inserir(6);

        f.Remover();
        f.Mostrar();

        f.Inserir(6);
        f.Mostrar();

        f.Remover();
        f.Remover();
        f.Remover();
        f.Mostrar();

        // Pilha
        Pilha p = new Pilha(100);
        for (int i = 0; i < 100; i++)
        {
            p.Inserir(vet3[i]);
        }

        p.Mostrar();
        p.Inserir(6);

        p.Remover();
        p.Mostrar();

        p.Inserir(6);
        p.Mostrar();

        p.Remover();
        p.Remover();
        p.Remover();
        p.Mostrar();

        Console.WriteLine("Questão 8: esvantagem de alocação estática: Não ser capaz de adicionar mais informações que o limite de memória que foi dedicado à estrutura\r\n");

    }

    public static void SelectBubbleSort(int[] vet)
    {
        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.BUBBLESORT);

        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.BUBBLESORT, vet);

        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.BUBBLESORT);
    }

    public static void SelectInsertionSort(int[] vet)
    {
        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.INSERTIONSORT);

        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.INSERTIONSORT, vet);

        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.INSERTIONSORT);
    }

    public static void SelectHeapSort(int[] vet)
    {
        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.HEAPSORT);

        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.HEAPSORT, vet);

        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.HEAPSORT);
    }

    public static void SelectMergeSort(int[] vet)
    {
        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.MERGESORT);

        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.MERGESORT, vet);

        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.MERGESORT);
    }

    public static void SelectQuickSort(int[] vet)
    {
        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.QUICKSORT);

        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.QUICKSORT, vet);

        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.QUICKSORT);
    }

    public static void SelectShellSort(int[] vet)
    {
        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.SHELLSORT);

        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.SHELLSORT, vet);

        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.SHELLSORT);
    }
}