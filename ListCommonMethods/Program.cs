using System;
using System.Collections.Generic;

namespace ForEach
{

    class Program
    {

        static void Main(string[] args)
        {


            List<int> number = new List<int>() {
            1,2,3,4,5
            };

            Show(number);
            //insert- ingresa un elemento en una posicion determinada
            number.Insert(0, 144);
            Show(number);
            //Contains - evalua si el elemento existe
            if (number.Contains(2))
            {
                Console.WriteLine("existe");
            }
            else {
                Console.WriteLine("no existe");
            }

            //Indexof, devuelve la posicion del elemento, si elemento o existe, devuelve valor -1
            Console.WriteLine(number.IndexOf(500));


            //sort - para irdenar una lista, este metodo es mutable
            number.Sort();
            Show(number);

            //Add Range

            number.AddRange(new List<int>() {
            200,254});
            Show(number);
        }

        public static void Show(List<int> numbers) {

            Console.WriteLine("--numeros--");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);

            }
        }


    }
}