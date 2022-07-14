using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;

namespace DapperDemo
{
    public class DbConnectionFactory
    {
        private  ConnConfig _connConfig;
        public DbConnectionFactory(IOptions<ConnConfig> connConfig)
        {
            _connConfig = connConfig.Value;
        }

        public IDbConnection GetDbConn(SqlTypeEnum connType)
        {
            IDbConnection dbConnection;
            switch(connType)
            {
                case SqlTypeEnum.SqlServer:
                    dbConnection = new SqlConnection(_connConfig.ConnMapList.FirstOrDefault(f=>f.ConnType==(int)SqlTypeEnum.SqlServer)?.ConnectString);
                    break;
                default:
                    dbConnection = new SqlConnection(_connConfig.ConnMapList.FirstOrDefault(f => f.ConnType == (int)SqlTypeEnum.SqlServer)?.ConnectString);
                    break;
            }
            return dbConnection;
        }
    }
}
