using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SPOJ
{
    class Noe
    {

        

        static void Main(string[] args)
        {
            
            Dictionary<String, int> data = new Dictionary<String, int>();
            String number = null;
            while(number != "")
            {
                number = Console.ReadLine();
                data = updateData(data, number);
            }
            String animalNumber;
            animalNumber = getMissingAnimalNumber(data);

            Console.WriteLine(animalNumber);
        }

        public static Dictionary<String, int> updateData(Dictionary<String, int> data, String key)
        {

            if (data.ContainsKey(key))
            {
                data[key] = data[key] + 1;
            }
            else
            {
                data.Add(key, 1);
            }
            return data;
        }

        public static String getMissingAnimalNumber(Dictionary<String,int> data)
        {
            if (data.ContainsValue(1))
            {
                return data.FirstOrDefault(value => value.Value == 1).Key;
            }
            else
            {
                return "No missing animal has been found";
            }
          
        }

       
    }
}
