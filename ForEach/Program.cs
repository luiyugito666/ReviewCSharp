using System;
using System.Collections.Generic;

namespace ForEach
{

    class Program
    {

        static void Main(string[] args)
        {

            // List<int> numbers =new List<int>() , utilizamos var, que solo se usa dentro de metodos

            var number = new List<int>()
            {
                2,23,4,5,57,3
            };


            foreach (int i in number)
            {
                Console.WriteLine(i);
            };

            //List<People> peoples = new List<People>()
            var students = new List<People>()
            {
                new People() {Name="jorge",Country="peru"},
                new People() {Name="lui",Country="irak"},
                new People() {Name="wi",Country="chile"},
            };

            Show(students);
            students.RemoveAt(0);
            Show(students);

        }

        static void Show(List<People> students) {
            Console.WriteLine("--personas--");
            foreach (var stu in students) {
                Console.WriteLine($"Nombre: {stu.Name}, Country: {stu.Country}");
            }

        }
    }

    class People { 
    public string Name { get; set; }
        public string Country { get; set; }
    
    }


}