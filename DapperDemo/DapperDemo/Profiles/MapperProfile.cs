using AutoMapper;
using DapperDemo.Dto;
using DapperDemo.Entity;

namespace DapperDemo.Profiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Account, AccountDto>();
        }
    }
}
