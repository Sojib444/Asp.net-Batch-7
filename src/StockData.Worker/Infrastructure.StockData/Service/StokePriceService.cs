using AutoMapper;
using Infrastructure.StockData.Buisness_Object;
using Infrastructure.StockData.Entiies;
using Infrastructure.StockData.Entityrepository;
using Infrastructure.StockData.UnifOfWork;

namespace Infrastructure.StockData.Service
{
    public class StokePriceService:IStockPriceService
    {
        public StokePriceService(IBStokePrice company, IMapper mapper, IStockPriceRepository companyRepository,
            IApplicationUnitofWork _applicationUnitofWork)
        {
            Company = company;
            Mapper = mapper;
            CompanyRepository = companyRepository;
            applicationUnitofWork = _applicationUnitofWork;
        }
        public IBStokePrice Company { get; }
        public IMapper Mapper { get; }
        public IStockPriceRepository CompanyRepository { get; }
        public IApplicationUnitofWork applicationUnitofWork { get; }

        public void Add(BStokePrice argCompany)
        {
            var company = Mapper.Map<StockPrice>(argCompany);
            CompanyRepository.Add(company);
            applicationUnitofWork.Save();


        }
    }
}
