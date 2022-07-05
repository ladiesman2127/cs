using System;
using System.IO;

class Test
{
    public static void print()
    {
        System.Console.WriteLine("Ez");
    }
    public static void Main()
    {
        Thread th = new Thread(print);
        th.Start();
        Console.WriteLine(Math.Pow(0,0));
        th.Join();

    }
}