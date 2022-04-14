using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.DevFound.FactCSApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int F = 1;
            for (int i = 1; i <= n; i++)
            {
                F *= i;
            }
            Console.WriteLine(F);
        }
    }
}
