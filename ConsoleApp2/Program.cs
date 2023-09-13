using System;
namespace Herencia
{

    class Program
    {
        static void Main(string[] args)
        {

            Doctor doctor = new Doctor("jorge", 37, "cardiologo");
            Dev person1 = new Dev("lui", 37, "C#");
            Console.WriteLine(person1.GetInfo());
            Console.WriteLine(person1.GetData());
            Console.WriteLine(doctor.GetInfo());
            Console.WriteLine(doctor.GetData());

        }






    }

    class Person
    {
        private string _name;
        private int _age;
        public Person(string name, int age)
        {

            _name = name;
            _age = age;

        }

        public string GetInfo()
        {

            return _name + " - " + _age;
        }



    }
    class Doctor : Person
    {
        private string _speciality;
        public Doctor(string name, int age, string speciality) : base(name, age)
        {
            _speciality = speciality;

        }

        public string GetData()
        {

            return GetInfo() + "- " + _speciality;
        }

    }

    class Dev : Person
    {
        private string _language;

        public Dev(string name, int age, string language) : base(name, age)
        {
            _language = language;
        }

        public string GetData()
        {
            return GetInfo() + "  -  " + _language;

        }

    }
}