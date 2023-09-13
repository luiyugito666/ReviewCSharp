using System;
using System.IO;
using System.Linq;


namespace LINQ2 {

    class Program
    {

        static void Main(string[] args) { 

        List<Person> person = new List<Person>() {
           new Person(){ Name="jorge",Address="lima",Age=37},
           new Person(){ Name="withney", Address="huanta", Age=30},
           new Person(){ Name="cari",Address="lima",Age=47},
           new Person(){ Name="ken", Address="huanta", Age=30},
           new Person(){ Name="andre", Address="ayacucho", Age=23},
           };

            foreach(var p in person)
            Console.WriteLine(p.ToString());
            Console.WriteLine("-------*******************-------");
            Console.WriteLine("-------***utilizando LINQ***-------");
            Console.WriteLine("-------*******************-------");

            Console.WriteLine("-------lista completa-------");

            var personFull = from per in person
                             select new
                             {
                                 name = per.Name,
                                 address = per.Address,
                                 age = per.Age
                             };
            foreach(var p in personFull)
                Console.WriteLine($"{p.name} - {p.address} - {p.age}");

            Console.WriteLine("-------ordenar por edad-------");
           

            var orderByAge = from ag in person
                             orderby ag.Age
                             select ag;


            foreach(var a in orderByAge)
                Console.WriteLine(a);

           Console.WriteLine("-------mostrar por mayores de 35 años-------");

            var orderMajor= from o in person
                            where o.Age>30
                            select o;


            foreach(var or in orderMajor)
                Console.WriteLine(or);

            Console.WriteLine("-------ordenar por addres huanta-------");

            var orderAddres = from oa in person
                              where oa.Address == "huanta" || oa.Address == "ayacucho"
                              select oa;


            foreach(var ad in orderAddres)
                Console.WriteLine(ad);

        }





    
    }


    public class Person { 
    
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"name: {Name} - Direccion: {Address} - Edad: {Age} ";

        }
    }


}