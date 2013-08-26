using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class LinearEquation
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();

            if(input.Contains(".")){
                input = input.Replace(".", ",");
            }

            String[] inputAsArray = input.Split(new char[] { ' ' });

            float a = float.Parse(inputAsArray[0]);
            float b = float.Parse(inputAsArray[1]);
            float c = float.Parse(inputAsArray[2]);


            if (a == 0f)
            {
                if (b == c)
                {
                    Console.WriteLine("NWR");
                }
                else
                {
                    Console.WriteLine("BR");
                }

            }
            else
            {
                decimal result =  new Decimal((c - b) / a);
                result = Math.Round(result, 2);

                Console.Write(result);
            }

        }
    }
}
