using Autofac;
using StockData.Worker.Model;

namespace StockData.Worker.WebModule
{
    public class WorkerServiceModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CompanyWeb>().As<ICompanyWeb>().
                InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
