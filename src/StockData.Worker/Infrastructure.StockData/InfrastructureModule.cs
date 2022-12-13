using Autofac;
using Infrastructure.StockData.Buisness_Object;
using Infrastructure.StockData.Entityrepository;
using Infrastructure.StockData.ORM;
using Infrastructure.StockData.Service;
using Infrastructure.StockData.UnifOfWork;

namespace Infrastructure.StockData
{
    public class InfrastructureModule : Module
    {
        private string ConnectionString { get; set; }
        private string AssemblyName { get; set; }
        public InfrastructureModule(string conncetionstring, string assemblyname)
        {
            ConnectionString = conncetionstring;
            AssemblyName = assemblyname;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>()
                .WithParameter("conncetionstring", ConnectionString)
                .WithParameter("assemblyname", AssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationDbContext>().AsSelf()
                .WithParameter("conncetionstring", ConnectionString)
                .WithParameter("assemblyname", AssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationUniofWork>().As<IApplicationUnitofWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<BCompany>().As<IBCompany>()
                .InstancePerLifetimeScope();

            builder.RegisterType<BStokePrice>().As<IBStokePrice>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CompanyService>().As<ICompanyService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CompnayRepository>().As<ICompanyRepository>()
               .InstancePerLifetimeScope();

            builder.RegisterType<StockPriceRerpository>().As<IStockPriceRepository>()
              .InstancePerLifetimeScope();

            builder.RegisterType<StokePriceService>().As<IStockPriceService>()
              .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
