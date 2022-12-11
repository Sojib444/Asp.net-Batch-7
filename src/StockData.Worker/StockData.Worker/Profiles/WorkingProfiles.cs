using AutoMapper;
using Infrastructure.StockData.Buisness_Object;
using Infrastructure.StockData.Entiies;
using StockData.Worker.Model;

namespace StockData.Worker.Profiles
{
    public class WorkingProfiles : Profile
    {
        public WorkingProfiles()
        {
            CreateMap<BCompany, Company>().ReverseMap();
            CreateMap<BStokePrice, StockPrice>().ReverseMap();
            CreateMap<CompanyWeb, BCompany>().ReverseMap();
        }
    }
}
