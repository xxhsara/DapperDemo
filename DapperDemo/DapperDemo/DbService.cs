using AutoMapper;
using Dapper;
using DapperDemo.Dto;
using DapperDemo.Entity;

namespace DapperDemo
{
    public class DbService : IDbService
    {
        private IMapper _mapper;
        public DbService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public AccountDto GetData(string name)
        {
            var dbConnection = DbConnectionFactory.GetDbConn(SqlTypeEnum.SqlServer);
            var account=dbConnection.Query<Account>($"select * from account where name =@name", new { name = name });
            var dto = _mapper.Map<AccountDto>(account);
            return dto;
        }

    }
}
