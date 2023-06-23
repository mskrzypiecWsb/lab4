int[] tab = { 5, 2, 9, 1, 7, 3 };

SelectionSort(tab);

Console.WriteLine("Posortowana tablica:");
foreach (int num in tab)
{
    Console.Write(num + " ");
}

    static void SelectionSort(int[] tab)
{
    int n = tab.Length;

    for (int i = 0; i < n - 1; i++)
    {
        int minIndex = i;

        for (int j = i + 1; j < n; j++)
        {
            if (tab[j] < tab[minIndex])
            {
                minIndex = j;
            }
        }

        int temp = tab[minIndex];
        tab[minIndex] = tab[i];
        tab[i] = temp;
    }
}