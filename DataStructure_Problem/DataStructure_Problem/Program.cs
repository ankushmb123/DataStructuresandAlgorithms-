using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Problems");
            Console.WriteLine("Press 5 for Permutation Problem");
            int option = Convert.ToInt32(Console.ReadLine());

            Permutation permutation = new Permutation();
            String str = "Ankush";
            int Outputs = str.Length;
            Permutation.Permute(str, 0, Outputs - 1);
            Console.ReadKey();
        }
    }
}