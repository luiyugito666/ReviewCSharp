using System;
namespace SwitchCase
{
    class program {

        static void Main(string[] args) {

            int options = 7;
            switch (options) {

                case 1:
                    Console.WriteLine("seleccionaste opcion 1");
                    break;
                case 2:
                    Console.WriteLine("seleccionaste opcion 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("seleccionaste opcion 3 o 4");
                    break;
                case < 0:
                case > 10:
                    Console.WriteLine("numero fuera de rangooo");
                    break;

                case > 4 and < 10:
                    Console.WriteLine("numeros especiales");
                    break;
                default:
                    Console.WriteLine("opciones no encontradas");
                    break;


            }

        
        
        
        
        }
    
    
    
    
    }

}