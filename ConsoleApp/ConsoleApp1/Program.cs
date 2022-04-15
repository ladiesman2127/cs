using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Program {
        static void Main (string[] args) {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            while (n > 0) {
                n /= 2;
                cnt++;  
            }
            Console.WriteLine(cnt);
            Console.ReadKey();
        }
    }
}
