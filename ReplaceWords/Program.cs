using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceWords
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = "I love pizza more than Candies";
            Console.WriteLine("Pizza to Candies");
            Console.WriteLine(input);

            string output = "I prefer Donner Instead";
           output = input.Replace(input, output);
            Console.WriteLine(output);
            
       

        }
    }
}
