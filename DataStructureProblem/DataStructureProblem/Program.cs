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
               
                //Bubble Sort
                var Output = new BubbleSort(10);
                Random random = new Random(20);
                for (int i = 0; i < 10; i++)
                    Output.InsertNumbers((int)(random.NextDouble() * 10));
                Console.WriteLine("Before sorting:");
                Output.DisplayElements();
                Console.WriteLine("During sorting:");
                Output.BubbleSorts();
                Console.WriteLine("After sorting:");
                Output.DisplayElements();
                Console.ReadKey();
            }
      }
  }
}

