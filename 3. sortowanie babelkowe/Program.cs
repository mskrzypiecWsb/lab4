int[] tab = { 5, 2, 9, 1, 7, 3 };

BubbleSort(tab);

Console.WriteLine("Posortowana tablica:");
foreach (int num in tab)
{
    Console.Write(num + " ");
}

    static void BubbleSort(int[] tab)
{
    int n = tab.Length;
    bool swapped;

    for (int i = 0; i < n - 1; i++)
    {
        swapped = false;

        for (int j = 0; j < n - i - 1; j++)
        {
            if (tab[j] > tab[j + 1])
            {
                int temp = tab[j];
                tab[j] = tab[j + 1];
                tab[j + 1] = temp;

                swapped = true;
            }
        }

        if (!swapped)
        {
            break;
        }
    }
}
