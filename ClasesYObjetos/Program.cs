using System;
namespace ClasesYObjetos {

    class Program { 
    
        static void Main(string[] args)
        {

            Sale sale1=new Sale(100,DateTime.Now);

            Console.WriteLine(sale1.getInfo());


        }


        class Sale {


            int total;
            DateTime date;


           
            public Sale(int total, DateTime date)
            {
                this.total = total;
                this.date = date;
            } 
            public string getInfo() {
                return total + " - " + date.ToLongDateString();
            
            
            }

            public  void Show() {

                Console.WriteLine("saludos desde la clase Sale");
            }
        }

    }

}