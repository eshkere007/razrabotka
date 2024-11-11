public class Servers
{
    private static readonly Lazy<Servers> instance = new Lazy<Servers>(() => new Servers());
    private readonly HashSet<string> _serverList;
    private Servers()
    {
        _serverList = new HashSet<string>();
    }
    public static Servers GetInstance() => instance.Value;

    public bool AddServer(string server)
    {
        if (!server.StartsWith("http://") && !server.StartsWith("https://"))
        {
            return false;
        }
        return _serverList.Add(server);
    }

    public List<string> GetHttp()
    {
        return new List<string>(_serverList.Where(s => s.StartsWith("http://", StringComparison.OrdinalIgnoreCase)));
    }

    public List<string> GetHttps()
    {
        return new List<string>(_serverList.Where(s => s.StartsWith("https://", StringComparison.OrdinalIgnoreCase)));
    }
}