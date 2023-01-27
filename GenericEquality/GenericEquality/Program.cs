namespace GenericEquality;
class Program
{
    public static bool Equals(int m, int n)
    {
        return m == n;
    }

    public static bool Equals(string s, string t)
    {
        return s == t;
    }

    public static bool Equals(double x, double y)
    {
        return x == y;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Usando métodos com sobrecarga");
        Console.WriteLine($"1.2 é igual a 3.1? {(Equals(1.2, 3.1) ? "Sim" : "Nao")}");
        Console.WriteLine($"3 é igual a 3? {(Equals(3, 3) ? "Sim" : "Nao")}");
        Console.WriteLine($"A string oi é igual a oi? {(Equals("oi", "oi") ? "Sim" : "Nao")}");

        Console.WriteLine();

        Console.WriteLine("Usando método genérico");
        Console.WriteLine($"1.2 é igual a 1.2? {(GenericEqualityClass.Equals<double>(1.2, 1.2) ? "Sim" : "Nao")}");
        Console.WriteLine($"3 é igual a 9? {(GenericEqualityClass.Equals<int>(3, 9) ? "Sim" : "Nao")}");
        Console.WriteLine($"A string oi é igual a olá? {(Equals("oi", "olá") ? "Sim" : "Nao")}");

    }
}

