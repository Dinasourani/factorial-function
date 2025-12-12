using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        
       static long factor(int a)
{
    if (a <= 1)
        return 1;
    return a * factor(a - 1);
}

static void Main(string[] args)
{
    int[] num = new int[6];
    for (int i = 0; i < 6; i++)
    {
        num[i] = int.Parse(Console.ReadLine());
    }

 
    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine("factorial = " + factor(num[i]));

    }

    Console.ReadKey();
}

    }
}
