

Operation mySum = Functions.Sum;
Console.WriteLine(mySum(4,2));
mySum=Functions.Mult;
Console.WriteLine(mySum(4,2));
Show cw=Console.WriteLine;
cw += Functions.Consol;
//cw("hola");
//agregando comentarios


Functions.Some("lui", "yucra", cw);


delegate int Operation(int a, int b);
public delegate void Show(string message);



public class Functions {

    //public static int Sum(int x, int y) { 
    //return x + y;
    //}
    //
    public static int Sum(int x, int y) => x + y;
    public static int Mult(int x, int y) => x * y;

    public static void Consol(string m)=>Console.WriteLine(m.ToUpper());

    //funcion de orden superior
    public static void Some(string name, string lastName, Show fn) {
        Console.WriteLine("antes de ejecucion del fn");
    fn($"hola { name}  { lastName}");
        Console.WriteLine("despues de la ejecucion del fn");
    }

}