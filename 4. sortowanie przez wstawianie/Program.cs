int[] tab = { 5, 2, 9, 1, 7, 3 };

InsertionSort(tab);

Console.WriteLine("Posortowana tablica:");
foreach (int num in tab)
{
    Console.Write(num + " ");
}

    static void InsertionSort(int[] tab) 
{
    int n = tab.Length;

    for (int i = 1; i < n; i++)
    {
        int key = tab[i];
        int j = i - 1;

        while (j >= 0 && tab[j] > key)
        {
            tab[j + 1] = tab[j];
            j--;
        }

        tab[j + 1] = key;
    }
}