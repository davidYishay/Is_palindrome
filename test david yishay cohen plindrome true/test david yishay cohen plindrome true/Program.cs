using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_david_yishay_cohen_plindrome_true
{
    class Program
    {
        static void Main(string[] args)
        {
                int halfSring; 
            string input; 
            Console.WriteLine(" please write some string ");
            input = Console.ReadLine();

            halfSring=  input.Length / 2;

            bool pli =true;

            for(int z=input.Length-1,i = 0;i<halfSring && z >halfSring && pli==true ;i++,z--)
            {
                if (input[i] != input[z])                
                    pli = false;                
            }

            Console.WriteLine((pli==true ? "the sring " + input + " is plindrome" : "the string " + input + " is  not a plindrome"));

        }
    }
}
