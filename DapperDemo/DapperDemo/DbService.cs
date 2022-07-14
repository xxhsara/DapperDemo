using AutoMapper;
using Dapper;
using DapperDemo.Dto;
using DapperDemo.Entity;

namespace DapperDemo
{
    public class DbService : IDbService
    {
        private IMapper _mapper;
        private DbConnectionFactory _dbFactory;
        public DbService(IMapper mapper, DbConnectionFactory dbFactory)
        {
            _mapper = mapper;
            _dbFactory= dbFactory;
        }
        public AccountDto GetData(string name)
        {
            var dbConnection = _dbFactory.GetDbConn(SqlTypeEnum.SqlServer);
            var account=dbConnection.QueryFirstOrDefault<Account>($"select * from account where name =@name", new { name = name });
            var dto = _mapper.Map<AccountDto>(account);
            return dto;
        }

    }
}
