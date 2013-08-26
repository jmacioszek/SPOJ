using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class Tablica
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] inputAsArray = input.Split(new char[]{' '});

            int numberOfInputs = inputAsArray.Length - 1;

            for (int i = numberOfInputs; i >= 0; i-- )
            {
                Console.Write(inputAsArray[i] + " ");
            }


        }
    }
}
