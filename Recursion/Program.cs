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
WriteLine();
WriteLine("66. Показать натуральные числа от 1 до N, N задано");

string From1toN (int n)
{
if (n != 0)
return From1toN(n-1) + " " + n;
else return string.Empty;
}

WriteLine(From1toN(10));

WriteLine();
WriteLine("67. Показать натуральные числа от N до 1, N задано");

string FromNto1 (int n)
{
if (n != 0)
return n + " " + FromNto1(n-1);
else return string.Empty;
}

WriteLine(FromNto1(10));

WriteLine();
WriteLine("68. Показать натуральные числа от M до N, N и M заданы");

string FromMtoN (int m, int n)
{
if (n > m) return m + " " + FromMtoN(m + 1, n);
if (n < m) return m + " " + FromMtoN(m - 1, n);
return n.ToString();
}

WriteLine(FromMtoN(10, 30));
WriteLine(FromMtoN(30, 10));


WriteLine();
WriteLine("69. Найти сумму элементов от M до N, N и M заданы");

int SumFromMtoN(int m, int n)
{
    if (n < m)
    {     
       return m + SumFromMtoN(m - 1, n);
    }
    if (m < n)
    {
        return n + SumFromMtoN(m, n-1); 
    }
    return n;
}

WriteLine(SumFromMtoN(10, 30)); 
WriteLine(SumFromMtoN(30, 10));

WriteLine();
WriteLine("70. Найти сумму цифр числа");

int SumDig (int n)
{
    int dig = n % 10;
    n = n / 10;
    if (n != 0) return dig + SumDig(n);
    else return 1;
}

WriteLine(SumDig(123456789));


WriteLine();
WriteLine("71. Написать программу вычисления функции Аккермана");

double Ackerman (double m, double n)
{
    if (m == 0) return n + 1;
    if ((m > 0) && (n == 0)) return Ackerman (m-1, 1);
    return Ackerman (m-1, Ackerman(m, n-1));
}
WriteLine(Ackerman(0, 0));
WriteLine(Ackerman(2, 1));
WriteLine(Ackerman(2, 3));
WriteLine(Ackerman(3, 5));