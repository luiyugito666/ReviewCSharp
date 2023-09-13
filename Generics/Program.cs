using System;
namespace Generics {
    class Program {
        static void Main(string[] args) {

            MyList<int> mylist = new MyList<int>(4);
            mylist.Add(4);
            mylist.Add(5);

            MyList<string> strings = new MyList<string>(5);
            strings.Add("luis");

            MyList<People> people = new MyList<People>(3);
            people.Add(new People() { Name="jorge",Country="lima"});
            people.Add(new People() { Name = "luis", Country = "Ayacucho" });



            Console.WriteLine(mylist.GetElement(-5));
            Console.WriteLine(strings.GetElement(0));

            Console.WriteLine(strings.GetString());
            Console.WriteLine(mylist.GetString());

            Console.WriteLine(people.GetElement(0));

            Console.WriteLine(people.GetString());


        }



    }

    public class People:Object { 
    public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"nombre: {Name}, Country: {Country}";
        }

    }

    public class MyList<T>{

        private T[] _elements;
        private int _index = 0;

        public MyList(int n)
        {
            _elements = new T[n];

        }

        public void Add(T e) {

            if (_index < _elements.Length) {
                _elements[_index] = e;
                _index++;
            
            }


        }
        public T GetElement(int i) {

            if (i<=_index && i>=0) {
                return _elements[i];
            
            }
            return default(T);
        
        }

        public string GetString() {
            int i=0;
            string result = "";

            while (i < _index) { 
            
                result += _elements[i].ToString()+" | ";
                i++;
            }
            return result;


        
        }
    
    
    }

}