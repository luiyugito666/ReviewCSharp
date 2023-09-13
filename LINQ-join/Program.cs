using System;
using System.IO;
using System.Linq;


namespace LINQ2
{

    class Program
    {

        static void Main(string[] args){

            List<Beer> beers = new List<Beer>() {

            new Beer() {Name="pilsen",Country="peru"},
            new Beer() {Name="mamarta",Country="chile"},
            new Beer() {Name="dorcher",Country="alemania"}
            };


            List<Country> countries = new List<Country>()
            {
                new Country(){ Name="peru",Continent="america"  },
                new Country(){ Name="chile",Continent="america"  },
                new Country(){ Name="eipto",Continent="africa"  },
                new Country(){ Name="alemania",Continent="europa"  },
            };

            //realizar el innor join donde muestre los continentes con la cerveza

            var beersWithContinent = from berr in beers
                                     join country in countries
                                     on berr.Country equals country.Name
                                     select new {
                                         name = berr.Name,
                                         country = berr.Country,
                                         continent = country.Continent,
                                     };
            foreach (var beer in beersWithContinent)
                Console.WriteLine($"{beer.name} - {beer.country} - {beer.continent}" );

        }



    }

    public class Beer {
    
        public string Name { get; set; }
        public string Country { get; set; }
        }

    public class Country {
        public string Name { get; set; }
        public string Continent { get; set; }

    }




}
