using Autofac;
using Autofac.Extensions.DependencyInjection;
using Infrastructure.StockData;
using Infrastructure.StockData.ORM;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;
using StockData.Worker;
using StockData.Worker.WebModule;
using System.Reflection;

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", false)
                .AddEnvironmentVariables()
                .Build();

var connectionstring = "Server=DESKTOP-O5SR0H0\\SQLEXPRESS;Database=StokeAndExhange; User Id=sa; Password=1312659116;";
var assemblyName =typeof(Worker).Assembly.FullName;

Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                 .MinimumLevel.Override("Microsof", LogEventLevel.Warning)
                 .WriteTo.File("E:/Logs/log.log", rollingInterval: RollingInterval.Day)
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
