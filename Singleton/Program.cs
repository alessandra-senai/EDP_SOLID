// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// The client code.
var s1 =   Singleton.getInstance();
var s2 = Singleton.getInstance();

if (s1 == s2)
{
    Console.WriteLine("Singleton em execução com variáveis iguais à s1 e s2.");
}
else
{
    Console.WriteLine("Singleton em execução com variáveis distintas.");
}


public sealed class Singleton
{
    private Singleton() { }

    private static Singleton _instance;

    public static Singleton getInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }
}