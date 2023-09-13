using BD;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;


namespace EntityFrameworkSystem
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                //enviaremos la cadena de conexion de la siguietne forma con la clase DbContextOptionsBuilder

                DbContextOptionsBuilder<CsharpDbContext> optionsBuilder = new DbContextOptionsBuilder<CsharpDbContext>();
                optionsBuilder.UseSqlServer("Server=DESKTOP-06L6DDL; Database=CSharpDB; User Id=sa; Password=123456;TrustServerCertificate=True;");





                //esto realiza la conexion, colocando el obejto  en using, al final ejecurata el metodo dispose, el cual libera la memoria y/o cierra conexiones

                //using (CsharpDbContext context = new CsharpDbContext(optionsBuilder.Options)) { 

                //var beers = context.Beers.ToList();

                //    foreach (var beer in beers)
                //    {
                //        Console.WriteLine(beer.Name);
                //    }

                //}


                bool again = true;
                int op = 0;

                do
                {

                    ShowMenu();
                    Console.WriteLine("elige una opcion");

                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {

                        case 1:
                            Show(optionsBuilder);

                            break;
                        case 2:
                            Add(optionsBuilder);
                            break;
                        case 3:
                            Edit(optionsBuilder);

                            break;
                        case 4:
                            Delete(optionsBuilder);

                            break;
                        case 5:
                            again = false;
                            break;
                    }


                } while (again);

            }
            catch (Exception ex)
            {
                Console.WriteLine("base de datos no conectado");
            }


        }

        public static void Show(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
        {
            Console.Clear();
            Console.WriteLine("Cervezas de la base de datos");

            using (var context = new CsharpDbContext(optionsBuilder.Options))
            {
                // List<Beer> beers =  context.Beers.ToList();
                //List<Beer> beers = context.Beers.OrderBy(b=>b.Name).ToList();
                // List<Beer> beers = (from b in context.Beers where b.BrandId==2 orderby b.Name select b).Include(b=>b.Brand).ToList();
                List<Beer> beers = (from b in context.Beers orderby b.Name select b).Include(b => b.Brand).ToList();
                foreach (Beer beer in beers)
                {

                    Console.WriteLine($"{beer.Id}-- - -- {beer.Name}-- - --{beer.Brand.Name}");
                }

            }


        }

        public static void Add(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
        {

            Console.Clear();
            Console.WriteLine("Ingresa Nombre de cerveza");
            string name = Console.ReadLine();
            Console.WriteLine("Ingresa id de marca de cerveza");
            int id = int.Parse(Console.ReadLine());

            using (var context = new CsharpDbContext(optionsBuilder.Options))
            {

                Beer beer = new Beer()
                {
                    Name = name,
                    BrandId = id

                };
                //con el siguiente comando, se agrega el objeto
                context.Add(beer);
                //con el siguiente comando se agrega a la base de datos
                context.SaveChanges();

            }

        }

        public static void Edit(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
        {

            Console.Clear();
            Show(optionsBuilder);
            Console.WriteLine("Editar Cerveza");
            Console.WriteLine("Ingrese el Id de la cerveza editar");
            int id = int.Parse(Console.ReadLine());
            using (var context = new CsharpDbContext(optionsBuilder.Options))
            {

                Beer beers = context.Beers.Find(id);
                if (beers != null)
                {
                    Console.WriteLine("escriba el nombre de la cerveza");
                    string name = Console.ReadLine();
                    Console.WriteLine("ingrese Id de marca");
                    int idBrand = int.Parse(Console.ReadLine());
                    beers.Name = name;
                    beers.BrandId = idBrand;
                    context.Entry(beers).State = EntityState.Modified;
                    context.SaveChanges();




                }
                else
                {
                    Console.WriteLine("cerveza no encontrada");
                }

            }






        }



        public static void ShowMenu()
        {

            Console.WriteLine("\n --------- Menu ----------");
            Console.WriteLine("1: - Mostrar");
            Console.WriteLine("2: - Agreagar");
            Console.WriteLine("3: - Editar");
            Console.WriteLine("4: - Eliminar");
            Console.WriteLine("5: - Salir");


        }
        public static void Delete(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
        {

            Console.Clear();
            Show(optionsBuilder);
            Console.WriteLine("Eliminar Cerveza");
            Console.WriteLine("Ingrese el Id de la cerveza Eliminar");
            int id = int.Parse(Console.ReadLine());
            using (var context = new CsharpDbContext(optionsBuilder.Options))
            {

                Beer beers = context.Beers.Find(id);
                if (beers != null)
                {

                    context.Remove(beers);
                    context.SaveChanges();




                }
                else
                {
                    Console.WriteLine("cerveza no encontrada");
                }

            }

        }
    }

}