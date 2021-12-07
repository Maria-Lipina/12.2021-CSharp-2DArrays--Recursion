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