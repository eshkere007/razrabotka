public class Servers2
{
    private static readonly Servers2 instance = new Servers2();
    private readonly HashSet<string> _serverList;
    private readonly object _lock = new object();

    private Servers2()
    {
        _serverList = new HashSet<string>();
    }

    public static Servers2 GetInstance() => instance;

    public bool AddServer(string server)
    {
        if (!server.StartsWith("http://") && !server.StartsWith("https://"))
        {
            return false;
        }

        lock (_lock)
        {
            return _serverList.Add(server);
        }
    }

    public List<string> GetHttp()
    {
        lock (_lock)
        {
            return new List<string>(_serverList.Where(s => s.StartsWith("http://", StringComparison.OrdinalIgnoreCase)));
        }
    }

    public List<string> GetHttps()
    {
        lock (_lock)
        {
            return new List<string>(_serverList.Where(s => s.StartsWith("https://", StringComparison.OrdinalIgnoreCase)));
        }
    }
}