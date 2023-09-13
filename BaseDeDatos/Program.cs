using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Channels;

namespace BaseDeDatos {
    class Program { 
         static void Main(string[] args)
         {
            try
            {
                BeerDB beerDB = new BeerDB(@"DESKTOP-06L6DDL", "CSharpDB", "sa", "123456");
                //haremos un pequeña implentacion de menu
                //creamos una variable solo para llevar si estamos en el progama o queremos terminar el programa
                bool again = true;
                int op = 0;

                do 
                {

                    ShowMenu();
                    Console.WriteLine("elige una opcion");

                    op=int.Parse(Console.ReadLine());

                    switch (op)
                    {

                        case 1:
                            Show(beerDB);
                            break;
                        case 2:
                            Add(beerDB);
                            break;
                        case 3:
                            Edit(beerDB);
                            break;
                        case 4:
                            Delete(beerDB);
                            break;
                        case 5:
                            again = false;
                            break;
                    }


                } while(again);




            }

             catch (SqlException ex)
             {
                      Console.WriteLine("base de datos no conectado");
             }




           }
        //creamos una pequeña interfaz de menu
        public static void ShowMenu() {

            Console.WriteLine("\n --------- Menu ----------");
            Console.WriteLine("1: - Mostrar");
            Console.WriteLine("2: - Agreagar");
            Console.WriteLine("3: - Editar");
            Console.WriteLine("4: - Eliminar");
            Console.WriteLine("5: - Salir");
          

        }


        //obtener lista de Beer
        public  static void Show(BeerDB beerDB) {

            Console.Clear();
            Console.WriteLine("Cervezas de la base de datos");

            //se regresa una lista de Beer
            List<Beer> beers = beerDB.GetAll();

            foreach (var beer in beers)
            {
                Console.WriteLine($"id: {beer.Id} - name: {beer.Name}");
            }


        }

        //ingresar elementos a la lista de Beer
        public static void Add(BeerDB beerDB2) {
            Console.Clear();
            Console.WriteLine("Aagreagar Nueva Cerveza");
            Console.WriteLine("Escriba el nombre");
            string name=Console.ReadLine();
            Console.WriteLine("ingrese Id de Marca");
            int brandId=int.Parse(Console.ReadLine());

            // creamos un bojeto cerveza

            Beer beer = new Beer(name, brandId);
            beerDB2.Add(beer);


        }

        public static void Edit(BeerDB beerDB) {

            Console.Clear();
            Show(beerDB);
            Console.WriteLine("Editar Cerveza");
            Console.WriteLine("ingrese Id de cerveza a modificar");
            int id = int.Parse(Console.ReadLine());

            Beer beer =beerDB.Get(id);

            if (beer != null) {
                Console.WriteLine("Ingrese nombre de cerveza");
                string name = Console.ReadLine();
                Console.WriteLine("Ingrese id de la marca de cerveza");
                int brandId = int.Parse(Console.ReadLine());

                beer.Name = name;
                beer.BrandId= brandId;
                beerDB.Edit(beer);
            }
            else {
                Console.WriteLine("cerceza no existe");
            }




          


        }

        public static void Delete(BeerDB beerDB)
        {

            Console.Clear();
            Show(beerDB);
            Console.WriteLine("eliminar Cerveza");
            Console.WriteLine("ingrese Id de cerveza a eliminar");
            int id = int.Parse(Console.ReadLine());

            Beer beer = beerDB.Get(id);

            if (beer != null)
            {

               
                beerDB.Delete(beer.Id);
            }
            else
            {
                Console.WriteLine("cerceza no existe");
            }

        }



        }



 }