using System;
using System.IO;
using System.Linq.Expressions;

namespace Excepciones {

    class Program{

        static void Main(string[] args) {
            try
            {
                string content = File.ReadAllText(@"F:\pruebax\prueba.txt");
                Console.WriteLine(content);


                //  string content2 = File.ReadAllText(@"F:\pruebax\prueba2.txt");
                //  Console.WriteLine(content);

                // generamos un error intencional con throw

                throw new Exception("ocurrio un error programado");

            }
            catch (FileNotFoundException ex) {
                Console.WriteLine("el archivo no existe");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                Console.WriteLine("se ejecutó, pase lo que pase");
            }

            Console.WriteLine("se sigue ejecutando");
           
        }
    
    
    }



}