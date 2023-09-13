using System;
using System.Collections.Generic;
using System.Linq;
//using es un conjunto de clases que estan organizadas en un solo paquete
namespace LINQ {

    class Program { 
    
        static void Main(string[] args)
        {
            List<Beer> beers = new List<Beer>() {

            new Beer() {Name="pilsen",Country="peru"},
            new Beer() {Name="cristal",Country="chile"},
            new Beer() {Name="dorcher",Country="alemania"}
        };

            foreach (var i in beers) { 
            Console.WriteLine(i.ToString());
            }

            Console.WriteLine("-----------------");
            //select
            var beersName = from b in beers
                            select new
                            {
                                Name = b.Name,
                                Letters = b.Name.Length,
                                a = 1
                            };

            foreach(var b in beersName)
                Console.WriteLine($"{b.Name} - {b.Letters} - {b.a}");



        }
    
    }

    public class Beer { 
    public string Name { get; set; }
    public string Country { get; set; }
    

    public override string ToString()
        {
            return $"Name: {Name} - Country: {Country}";
        }

    }


}