using System;
namespace Sobrecarga{
    class Program {

        static void Main(string[] args) {


            Math operation = new Math();
            Console.WriteLine(operation.suma(2,3));
            Console.WriteLine(operation.suma("4", "5"));
            int[] num = new int[] { 1, 3, 5, 7 };
            Console.WriteLine(operation.suma(num));





        }

        class Math {
          
            public int suma(int number1, int number2) {
            
                return number1 + number2;
            }


            public int suma(string number1, string number2) {

                return int.Parse(number1) + int.Parse(number2);
            }

            public int suma(int[] number) {
                int sum = 0;
                for(int i=0;i<number.Length;i++)
                    sum += number[i];



                return sum;
            
            }

        }


    
    
    }

    

}