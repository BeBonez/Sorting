using Sorting.basic_class.@static;

public class Program
{
    public static void Main(string[] args)
    {
        // https://github.com/accj1990/Sorting.git
        // https://pt.overleaf.com/read/kptbxrwtrzch#8b9776


        //int[] _vet = ManagerFileReader.Arquivo10TXT();

        // Crie um menu que solicite ao usuário qual é o arquivo que será lido e qual algoritmo deverá ser executado

        Console.WriteLine("Digite um número para definir um algoritmo de ordenação");
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


        // Fila, Pilha e Lista em alocação estática
        Fila f = new Fila(5);

        f.Inserir(1);
        f.Inserir(2);
        f.Inserir(3);
        f.Inserir(4);
        f.Inserir(5);

        f.Mostrar();

        f.Inserir(6); // não consigo inserir pois a fila está cheia

        f.Remover();

        f.Mostrar();

        f.Inserir(6);

        f.Mostrar();

        f.Remover();

        f.Remover();

        f.Remover();

        f.Mostrar();

        // Pilha
        Pilha p = new Pilha(5);

        p.Inserir(1);
        p.Inserir(2);
        p.Inserir(3);
        p.Inserir(4);
        p.Inserir(5);

        p.Mostrar();
        p.Inserir(6);

        p.Remover();
        p.Remover();

        p.Mostrar();

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