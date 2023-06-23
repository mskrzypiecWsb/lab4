using System;

int[] tab = { 5, 2, 9, 1, 7, 3 };

int min = tab[0];

for (int i = 1; i < tab.Length; i++)
{
    if (tab[i] < min)
    {
        min = tab[i];
    }
}

int max = tab[0];

for (int i = 1; i < tab.Length; i++)
{
    if (tab[i] > max)
    {
        max = tab[i];
    }
}

Console.WriteLine("Najmniejszy element: " + min);
Console.WriteLine("Największy element: " + max);