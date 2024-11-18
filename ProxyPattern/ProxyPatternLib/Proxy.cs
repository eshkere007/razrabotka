namespace ProxyPatternLib
{
    public class Proxy : ISubject
    {
        private readonly RealSubject _realSubject;
        private readonly Dictionary<string, string> _cache;
        private readonly Dictionary<string, bool> _accessRights;
        private readonly TimeSpan _cacheDuration;
        private readonly DateTime _lastCacheClearTime;

        public Proxy()
        {
            _realSubject = new RealSubject();
            _cache = new Dictionary<string, string>();
            _accessRights = new Dictionary<string, bool>
        {
            { "admin", true },  // есть доступ
            { "guest", false }  // нет доступа
        };
            _cacheDuration = TimeSpan.FromSeconds(10);
            _lastCacheClearTime = DateTime.Now;
        }

        public string Request(string request)
        {
            string user = "guest";
            if (!_accessRights.ContainsKey(user) || !_accessRights[user])
            {
                return "Нет доступа";
            }

            if (_cache.ContainsKey(request) && DateTime.Now - _lastCacheClearTime < _cacheDuration)
            {
                Console.WriteLine("Proxy: Возвращение кэша: " + request);
                return _cache[request];
            }

            Console.WriteLine("Proxy: Передача запроса RealSubject...");
            string response = _realSubject.Request(request);

            _cache[request] = response;

            return response;
        }
    }
}
