using System;
int[] array = new int[] { 5, 52, -6, 14, -98, 16, -7, 46, 91 };
int currentMininum = int.MaxValue; // Otetaan suurin mahdollinen arvo oletukseksi.
foreach (char ch in array)
{
    if (array[ch] < currentMininum)
    {
        currentMininum = ch;
    }
}
Console.WriteLine("Minimiarvo: " + currentMininum);
int total = 0;
foreach (char ch in array)
{
    total += array[ch];
}
float average = (float)total / array.Length;
Console.WriteLine("Keskiarvo: " + average);