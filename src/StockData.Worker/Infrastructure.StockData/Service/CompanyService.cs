using AutoMapper;
using Infrastructure.StockData.Buisness_Object;
using Infrastructure.StockData.Entiies;
using Infrastructure.StockData.Entityrepository;
using Infrastructure.StockData.UnifOfWork;

namespace Infrastructure.StockData.Service
{
    public class CompanyService:ICompanyService
    {
        public CompanyService(IBCompany company, IMapper mapper, ICompanyRepository companyRepository,
            IApplicationUnitofWork _applicationUnitofWork)
        {
            Company = company;
            Mapper = mapper;
            CompanyRepository = companyRepository;
            applicationUnitofWork = _applicationUnitofWork;
        }

        public IBCompany Company { get; }
        public IMapper Mapper { get; }
        public ICompanyRepository CompanyRepository { get; }
        public IApplicationUnitofWork applicationUnitofWork { get; }

        public void Add(BCompany argCompany)
        {
            var company = Mapper.Map<Company>(argCompany);
            CompanyRepository.Add(company);
            applicationUnitofWork.Save();


        }
    }
}
