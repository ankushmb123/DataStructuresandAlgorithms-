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
                Console.WriteLine("Enter Program number to get executed \n5.Permutation");
                int option = Convert.ToInt32(Console.ReadLine());
                
                //Permutation
                Permutation permutation = new Permutation();
                String str = "Ankush";
                int Outputs = str.Length;
                Permutation.Permute(str, 0, Outputs - 1);
                Console.ReadKey();
            }
      }
  }
}

