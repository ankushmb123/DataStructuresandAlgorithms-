using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Problem
{
    /// claaa for permutation
    class Permutation
    {
        // method for permute with string str int left and iint right
        // permutation function
        // str string to
        //calculate permutation for
        // l starting index r end index
       
        public static void Permute(String str, int startingIndex, int endIndex)
        {
            //if startindex ==  endindex print str
            if (startingIndex == endIndex)
                Console.WriteLine(str);
            else
            {

                for (int var_i = startingIndex; var_i <= endIndex; var_i++)
                {
                    str = Swap(str, startingIndex, var_i);
                    Permute(str, startingIndex + 1, endIndex);
                    str = Swap(str, startingIndex, var_i);
                }
            }
        }
        // Swap Characters at position
        // inputForWord string value
        // left position 1
        // var_i position 2
        public static string Swap(string inputForWord, int left, int var_i)
        {
            char temp;
            char[] charArray = inputForWord.ToCharArray();
            temp = charArray[left];
            charArray[left] = charArray[var_i];
            charArray[var_i] = temp;
            string Output = new string(charArray);
            return Output;
        }
    }
}