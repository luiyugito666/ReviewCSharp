using System;
namespace Interfacev2{


    class Program {

        static void Main(string[] args) {


            Teacher teacher = new Teacher("private","padre","jorge","docente");

            Teacher[] teach = new Teacher[] { 
                
                new Teacher("public","padre","Juan","docente"),
                 new Teacher("private","padre","Luis","docente"),

            };

            
            IProfesion[] prof = new IProfesion[] {
                new Teacher("private","hermano","raul","docente xx")
            };


            Console.WriteLine(teacher.institute);
            Console.WriteLine($"{teach[0].institute} y {teach[1].institute}");
            Console.WriteLine(prof[0].Profesion);


        }
   



    }

    interface IProfesion {
        public string Profesion { get; set; }
        public int numberColegiature { get; set; }
          }
 


    interface IFamily {
        public string Rol { get; set; }
        

    }

    interface IPerson { 
        public string Name { get; set; }
        public int Age { get; set; }
        

    
    }


    public class Teacher : IPerson, IProfesion,IFamily
    {
        public string Name { get ; set; }
        public int Age { get; set; }
        public string Profesion { get; set; }
        public int numberColegiature { get; set; }
        public string institute { get; set; }
        public string Rol { get; set; }

        public Teacher(string institute, string rol, string name,string profesion) {
            this.institute = institute;
            Rol = rol;
            Name= name;
            Profesion = profesion;

        }

    }

}