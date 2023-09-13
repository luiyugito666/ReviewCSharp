using System;
using System.IO;

namespace ExcepcionesPersonalizados{
    class Program {

        static void Main(string[] args  ) {

            try
            {
                Berr beer = new Berr()
                {
                    //Name = "",
                    Brand = "xxx"
                };
                Console.WriteLine(beer.ToString());
            }
            catch (InvalidBerrException e) {

                Console.WriteLine(e.Message);

            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    
    
    }

    public class InvalidBerrException:Exception {


        public InvalidBerrException() : base ( "la cerveza no tiene nombre o marca") { }
      
    }


    public class Berr { 
    
    public string Name { get; set; }
    public string Brand { get; set; }

        public override string ToString()
        {
            if (Name == null || Brand == null) {

                throw new InvalidBerrException();
            }

            return $"Cerveza: {Name} - Marca: {Brand}";
        }
    }


}