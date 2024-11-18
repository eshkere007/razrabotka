namespace ProxyPatternLib
{
    public class RealSubject : ISubject
    {
        public string Request(string request)
        {
            Console.WriteLine("RealSubject: Запрос: " + request);
            Thread.Sleep(1000); // Имитация задержки
            return "Обработано: " + request;
        }
    }
}
