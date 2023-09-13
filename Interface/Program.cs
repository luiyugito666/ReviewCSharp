using System;
using System.Security.Cryptography.X509Certificates;

namespace Interface
{
    class Program
    {

        static void Main(string[] args)
        {
            Shark[] shark = new Shark[] {

                new Shark("tibu",23),
                new Shark("hi",4)

            }; 
            IFish[] siren = new IFish[]
            {
                new Siren(34)
            };

            IFish[] siren2 = new IFish[]
           {
                new Siren(34),
                new Shark("d",7)
           };

            ShowFish(shark);
            ShowAnimal(shark);
            ShowFish(siren);
            ShowFish(siren2);





        }

        public static void ShowFish(IFish[] fish) {
            Console.WriteLine("---informacion de peces---");
            for (int i = 0; i < fish.Length; i++)
            {
                Console.WriteLine( fish[i].Swim());
            }
        
        
        }

        public static void ShowAnimal(IAnimal[] animal)
        {
            Console.WriteLine("---informacion de Animales---");

            for (int i = 0; i < animal.Length; i++)
            {
                Console.WriteLine(animal[i].Name);
            }


        }


    }


    public class Siren : IFish {
        public int Speed { get; set; }
        public Siren(int Speed) {
            this.Speed = Speed;
        }
        public string Swim() {
            return $" --{Speed}";
         }
    
    }

    public class Shark : IAnimal, IFish {

        public string Name { get; set; }
        public int Speed { get; set; }


        public Shark(string Name, int Spedd) {
            this.Name = Name;
            this.Speed = Spedd;
        }  



        public string Swim() {

            return $"{Name} nada a {Speed} por mimuto";
        }
    
    
    
    
    }


    public interface IAnimal { 
        public string Name { get; set; }
    
    }

    public interface IFish{
        public int Speed { get; set; }
        public string Swim();

        
    }


}
