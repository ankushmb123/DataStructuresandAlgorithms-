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
            Console.WriteLine("Press 6 for Primenumber Problem");
            int option = Convert.ToInt32(Console.ReadLine());

            Primenumber pnum = new Primenumber();
            pnum.Prime();
        }
    }
}