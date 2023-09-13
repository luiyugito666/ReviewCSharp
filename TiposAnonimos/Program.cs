using System;
namespace TiposAnonimos
{
    class Program
    {

        static void Main(string[] args)
        {
            var lui = new
            {

                name = "lui",
                country = "peru"

            };

            Console.WriteLine($"{lui.name}-{lui.country}");

            var people = new[] {
                new{ Name="red",Brand="da"},
                new{ Name="blue",Brand="xx"},
            };

            foreach (var a in people) {
                Console.WriteLine(a.Name);
            }


        }
    }
}