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
            Console.WriteLine("Press 7 for Primenumber_palendrome Problem");
            int option = Convert.ToInt32(Console.ReadLine());

            Primenumber primeNumbers = new Primenumber();
            primeNumbers.PrimeNum();
            Console.ReadKey();
        }
    }
}