using System;
using System.Net.Cache;
using System.Threading.Channels;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            People person = new People() { 
            Name="luis",
            Age= 37
            };
            
            Console.WriteLine(person.Name);
            Console.WriteLine(People.GetCount()); 

        }

        

        public class People
        {
            public static int Count=0;
            public string Name { get; set; }
            public int Age { get; set; }

            public People() { 
            Count++;
            }

            public static string GetCount() {

                return $"la clase fue invocada {Count} veces";
            }

        }





    }

}