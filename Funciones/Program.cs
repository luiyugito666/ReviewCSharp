
using System;
using System.Threading.Channels;

namespace Funciones
{
    class Program { 
        static void Main(string[] args)
        {
            Show();
            Sum(1, 4);
            int m=Multiplicar(2, 4);
            Console.WriteLine(m);
        }

        static int Multiplicar(int num1, int num2) {
            int prod = num1 * num2;
            return prod;
        }

        static void Sum(int numero1,int numero2) 
        {
           
            int numero3=numero1 + numero2;
            Console.WriteLine(numero3);
        }

        static void Show()
        {

            Console.WriteLine("prueba");
        } 

    }
}