using Autofac;
using Autofac.Extensions.DependencyInjection;
using Infrastructure.StockData;
using Infrastructure.StockData.ORM;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;
using StockData.Worker;
using StockData.Worker.WebModule;

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", false)
                .AddEnvironmentVariables()
                .Build();

var connectionstring = "Server=.\\SQLEXPRESS;Database=Scraping;Trusted_Connection=True;TrustServerCertificate=true;";
var assemblyName = typeof(Worker).Assembly.FullName;

Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                 .MinimumLevel.Override("Microsof", LogEventLevel.Warning)
                 .WriteTo.File("E:\\Software Enginering\\Devskill\\Project\\Asp.net-Batch-7\\src/Logs/log.log", rollingInterval: RollingInterval.Day)
                 .CreateLogger();

try
{
    Log.Write(LogEventLevel.Information, "Application Starting");
    IHost host = Host.CreateDefaultBuilder(args)
        .ConfigureServices(services =>
        {
            services.AddHostedService<Worker>();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connectionstring, e => e.MigrationsAssembly(assemblyName));
            });
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        })
        .UseWindowsService()
        .UseSerilog()
        .UseServiceProviderFactory(new AutofacServiceProviderFactory())
        .ConfigureContainer<ContainerBuilder>(optios =>
        {
            optios.RegisterModule(new InfrastructureModule(connectionstring, assemblyName));
            optios.RegisterModule(new WorkerServiceModule());
        })
        .Build();

    await host.RunAsync();
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
