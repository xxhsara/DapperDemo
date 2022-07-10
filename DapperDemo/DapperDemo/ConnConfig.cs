namespace DapperDemo
{
    public class ConnConfig
    {
       public List<ConnMap> ConnMapList { get; set; }
    }

    public class ConnMap
    {
        public string ConnectString { get; set; }

        public int ConnType { get; set; }
    }
}
