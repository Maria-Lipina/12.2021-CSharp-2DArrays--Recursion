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

WriteLine("66. Показать натуральные числа от 1 до N, N задано");

string From1toN (int n)
{
string output = String.Empty;
for (int i = 0; i <= n; i++)
{
   output = output + i + " ";
}
return output;
}

WriteLine(From1toN(10));

string From1toNRec (int n)
{
if (n != 0)
return n + " " + From1toNRec(n-1);
else return string.Empty;
}

WriteLine(From1toNRec(10));

// double Fibonacci (int n)
// {
//     if(n == 1 || n == 0) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 0; i < 40; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }

string FromNto1Rec (int n)
{
if (n != 0)
return n + " " + FromNto1Rec(n-1);
else return string.Empty;
}

WriteLine(FromNto1Rec(10));