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
string PrintMyArray(int[] collect)
{
    string outputString = String.Empty;
    for (int pos = 0; pos < collect.Length; pos++) outputString += $"{collect[pos]} ";
    return outputString;
}

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
WriteLine();
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

WriteLine();
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

WriteLine();
WriteLine("53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет");
int [,] ab = Create2DArray(6, 10); //keep it simple, stupid
Fill2DArray(ab, 0, 10);
WriteLine(Print2DArray(ab));

string FindIndexes(int N, int[,] array)
{
    string found = $"Индексы {N} в массиве: ";
    int startLen = found.Length;
    string notfound = "-1";

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] == N) found = found + $"{i}, {j}; ";
    }   
}
if (found.Length > startLen) return found;
else return notfound;
}

WriteLine(
    FindIndexes(
        ToInt32(ReadLine()), ab)); //или это было в антипаттернах?


WriteLine();
WriteLine("54. В матрице чисел найти сумму элементов главной диагонали");

int [,] cd = Create2DArray (20, 20);
Fill2DArray(cd, 10, 100);
WriteLine(Print2DArray(cd));

int sum = 0;
for (int i = 0; i < cd.GetLength(1); i++)
{
sum = sum + cd [i, i];   
}
WriteLine(sum);

WriteLine();
WriteLine("55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.");

int [] ColumnAverage (int [,] arr)
{
int [] result = new int [arr.GetLength(1)];
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
    result [j] = (result [j] + arr [i,j]);
}
}
for (int i = 0; i < result.Length; i++) result[i] = result[i] / arr.GetLength(0);

return result;
}

string CutOff (int [,] arr)
{
string line = string.Empty;
for (int i = 0; i < arr.GetLength(1); i++)
{
    line += $"-- | ";
}
return line;
}

int [,] ef = Create2DArray(7, 12);
Fill2DArray(ef, 10, 100);
WriteLine(Print2DArray(ef));
WriteLine(CutOff(ef));
WriteLine(
    PrintMyArray(
        ColumnAverage(ef)));


WriteLine();
WriteLine("56. Написать программу, которая обменивает элементы первой строки и последней строки");

void Change1stLastRows (int [,] array)
{
int[,] firstRow = new int[1, array.GetLength(1)];
int[,] lastRow = new int[1, array.GetLength(1)];

Array.Copy(array, 0, firstRow, 0, array.GetLength(1));
Array.Copy(array, array.Length - array.GetLength(1), lastRow, 0, array.GetLength(1));
Array.Copy(lastRow, 0, array, 0, lastRow.Length);
Array.Copy(firstRow, 0, array, array.Length - array.GetLength(1), firstRow.Length);
}


int[,] fg = Create2DArray(7, 12);
Fill2DArray(fg, 10, 100);
WriteLine(Print2DArray(fg));
Change1stLastRows(fg);
WriteLine(Print2DArray(fg));


WriteLine();
WriteLine("57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.");

void SortinRow (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            int temporary = array [i,j-1];
            if (array[i,j] > temporary) 
            {
                array [i, j-1] = array[i,j]; 
                array [i, j] = temporary;
            }
        }
    }
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 1; j < array.GetLength(1); j++)
    {
        if (array [i, j-1] < array [i,j]) SortinRow(array); //TODO: как можно решить эту задачу без рекурсии? И не запутаться в индексах?
    }
}
}


int [,] ih = Create2DArray(10, 17);
Fill2DArray(ih, 0, 100);
WriteLine("Первоначальный массив");
WriteLine(Print2DArray(ih));

WriteLine("Иизмененный массив");
SortinRow(ih);
WriteLine(Print2DArray(ih));

WriteLine();
WriteLine("58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).");

int [,] Transpose (int [,] array)
{
    if (array.GetLength(0) != array.GetLength(1)) return new int [,] {{-1}, {-1}};
    else 
    {
        int [,] result = new int [array.GetLength(0),array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result[j,i] = array[i, j];
            }
        }
    return result;
    }
}

int [,] jk = Create2DArray(5, 8);
Fill2DArray(jk, 0, 100);
WriteLine(Print2DArray(jk));

int [,] kj = Transpose(jk);
WriteLine(Print2DArray(kj));