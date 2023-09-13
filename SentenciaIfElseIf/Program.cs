using System;
namespace SentenciaIfElseIf {

    class Program { 
    
    static void Main(string[] args)
     {
            bool areYouHungry = true;
            bool areYouMoney = true;

            if (areYouHungry && areYouMoney && IsOpenRestaurant("lui",9)) Console.WriteLine("Come");
            else Console.WriteLine("no come");
       
     }

        static bool IsOpenRestaurant(string name, int hour = 0) {

            if (name == "lui" && hour > 8 && hour < 23)
            {
                return true;
            }
            else if (name == "wi")
            {
                return true;

            }
            else { 
                return false;
            
            }

        }
    
    


    
    }




}