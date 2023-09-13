using System;
using System.Security.Cryptography.X509Certificates;

namespace Tuplas {
    class Program {

        static void Main(string[] args) 
        {

            (int id, string name) product = (1, "cerveza");
            Console.WriteLine($"{product.id} -{product.name}");

            product.name = "pan";

            Console.WriteLine($"{product.id} -{product.name}");


            var person = (1, "luis");
            Console.WriteLine(person.Item1 + person.Item2);


            var people = new[]
            {
                (1,"lui"),
                (2,"wi")
            };

            foreach (var p in people) {
                Console.WriteLine(p.Item1+"-"+p.Item2);


            }

            (int id,string name)[] people2 = new[]
           {
                (1,"luis"),
                (2,"wit")
            };
            foreach(var p in people2) {
                Console.WriteLine(p.id + "-" + p.name);


            }

            var cityInfo = getLocation();
            Console.WriteLine(cityInfo.lat+cityInfo.lng+ cityInfo.name);

            var(_, lng, _) = getLocation();
            Console.WriteLine(lng);




        }
        public static (float lat, float lng, string name) getLocation() {

            float lat = 19.2f;
            float lng = 99.9f;
            string name = "lima";
            return (lat,lng,name);

        }

    }

}