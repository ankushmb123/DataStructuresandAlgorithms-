using System;

namespace DataStructureProblem
{
    class Program
    {
      static void Main(string[] args)
      {
         bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Program number to get executed \n1.Binary search \n2. Insertion sort \n3.Bubble sort   \n4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                InsertionSort.sort();
                Console.ReadKey();

            }
      }
  }
}

