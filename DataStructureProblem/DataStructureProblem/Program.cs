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
               
                string[] arrword = { "hello", "hi", "how", "are", "you" };
                Console.WriteLine("Unsorted array");

                BinarySearch binary = new BinarySearch();
                binary.Display(arrword);
                Console.WriteLine("Sorted array");
                string[] sortedArr = binary.SortingArray(arrword);
                binary.Display(sortedArr);
                binary.Binary_search(sortedArr);

                 
              
            }
      }
  }
}

