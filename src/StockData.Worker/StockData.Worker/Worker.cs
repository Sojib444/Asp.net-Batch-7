using Autofac;
using AutoMapper;
using Infrastructure.StockData.Buisness_Object;
using Infrastructure.StockData.Service;
using StockData.Worker.Model;

namespace StockData.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;
        private readonly ICompanyWeb web;
        private readonly ILifetimeScope _scope;

        public Worker(ILogger<Worker> logger,ICompanyService companyService,IMapper mapper,
            ICompanyWeb web,ILifetimeScope scope)
        {
            _logger = logger;
            _companyService = companyService;
            _mapper = mapper;
            this.web = web;
            _scope = scope;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var bCompany=_mapper.Map<BCompany>(web);
            _companyService.Add(bCompany);
            
            //while (!stoppingToken.IsCancellationRequested)
            //{
            //    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            //    await Task.Delay(1000, stoppingToken);
            //}
        }
    }
}