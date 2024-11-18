using ProxyPatternLib;

class Program
{
    static void Main()
    {
        ISubject proxy = new Proxy();

        Console.WriteLine(proxy.Request("Request1"));

        Console.WriteLine(proxy.Request("Request1"));

        Console.WriteLine(proxy.Request("Request2"));

        Console.WriteLine(proxy.Request("Request3"));
    }
}