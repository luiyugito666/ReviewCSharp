using System;
namespace ClasesYObjetos
{

    class Program
    {

        static void Main(string[] args)
        {

            Sale mysale = new Sale(8, DateTime.Now);

            Console.WriteLine(mysale.Total);
            mysale.Total = 5;

            Console.WriteLine(mysale.Total);

        }

        class Sale
        {
            int total;
            DateTime date;

            public Sale(int total, DateTime date)
            {
                this.total = total;
                this.date = date;
            }

            public int Total { 
                get { return total; }
                set
                {
                    if (value < 0) value = 0;

                    total = value;
                }
            }

        }

    }

}