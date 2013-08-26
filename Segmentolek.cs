using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class Segmentolek
    {
        public int CalculateAge(String inputData){
            String[] inputDataAsArray = inputData.Split(new char[] { ' ' });
            int age = 0;

            int numberOfSegments = int.Parse(inputDataAsArray[0]);
            if (hasOneSegment(numberOfSegments))
            {
                age = int.Parse(inputDataAsArray[1]);
                return age;
            }

            age = numberOfSegments - 1;
            for(int i = 1; i <= numberOfSegments; i++){
                age += int.Parse(inputDataAsArray[i]);
            }


            return age;
        }



        private Boolean hasOneSegment(int numberOfSegments)
        {
            if (numberOfSegments == 1)
            {
                return true;
            }

            return false;
        }


        static void Main(string[] args)
        {
            String numberOfInputs =  Console.ReadLine();
            String inputValues;
            int loopCounter = 0;

            Segmentolek testSegmentolek = new Segmentolek();

            while (loopCounter != int.Parse(numberOfInputs))
            {
                inputValues = Console.ReadLine();
                int segmentolekAge = testSegmentolek.CalculateAge(inputValues);
                Console.WriteLine(segmentolekAge);
                loopCounter++;
            }

        }
    }
}
