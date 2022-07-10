using DapperDemo.Dto;

namespace DapperDemo
{
    public interface IDbService
    {
        AccountDto GetData(string name);
    }
}
