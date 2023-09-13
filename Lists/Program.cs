using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Lists {

    class Program {

        static void Main(string[] args) {

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            Console.WriteLine(numbers.Count);

            List<int> number = new List<int>() {
            1,2,3,4,5,6,7};
            number.Add(11);
          
            Console.WriteLine(number.Count);

            number.Clear();
            Console.WriteLine(number.Count);
            List<string> countries = new List<string>()
            {
                "peru","chile"
            };
            Console.WriteLine(countries.Count);

        }

       
    
    }


}