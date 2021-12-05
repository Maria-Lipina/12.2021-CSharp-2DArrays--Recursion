using static System.Console;
using static System.Convert;
using System;
/*using System.Diagnostics;

DateTime DT = DateTime.Now; // Колхозный секундомер времени, за которое выполняется программа, от Сергея
Console.WriteLine(SumNA(1_000_000_000));
System.Console.WriteLine((DateTime.Now - DT).TotalMilliseconds);

long SumNAProg(long A)
{
    return ((1 + A) * A) / 2;
}

//DateTime DTProg = DateTime.Now;
Stopwatch sw = new Stopwatch();
sw.Start(); // Более точный и применяемый секундомер для тех же целей.
Console.WriteLine(SumNAProg(1_000_000_000));
//System.Console.WriteLine((DateTime.Now - DTProg).TotalMilliseconds);
sw.Stop();
System.Console.WriteLine(sw.ElapsedMilliseconds);
*/

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int [,] collection, int minValue, int maxValue)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
       collection[i, j] = new Random().Next(minValue, maxValue + 1);  
        }
        
    }
}

string Print2DArray(int [,] collection)
{
    string outputString = String.Empty;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
    for (int j = 0; j < collection.GetLength(1); j++) // И помни, что длина строки определяется количеством столбцов. И наоборот длина столбца определяется количеством строк.
    {
    outputString += $"{collection[i, j]} | ";
    }
    outputString += "\n";
    }
    return outputString;
}

WriteLine("51. Задать двумерный массив следующим правилом: Aₘₙ = m+n");


void FillIndexSums (int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = i + j;
    }
}
}
int[,] mn = Create2DArray(6, 10);
FillIndexSums(mn);
WriteLine(Print2DArray(mn));

WriteLine("52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты");

int [,] EvenIndQuadrat (int [,] array)
{
for (int i = 0; i < array.GetLength(0); i+=2)
{
    for (int j = 0; j < array.GetLength(1); j+=2)
    {
        array [i,j] = array [i,j] * array [i,j];
    }
}
return array;
}

WriteLine("Изначальный массив");
int [,] ln = Create2DArray(7, 11);
Fill2DArray(ln, 0, 20);
WriteLine(Print2DArray(ln));

WriteLine("Измененный массив");
int [,] nl = EvenIndQuadrat(ln);
WriteLine(Print2DArray(ln));


// WriteLine("53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет");
int [,] ab = Create2DArray(6, 10);
Fill2DArray(ab, 0, 10);
WriteLine(Print2DArray(ab));

