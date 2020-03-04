#define MAIN2
using System;  // This isn't used, delete it
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

#if MAIN2
namespace ConfigSample
{
    public class Program2
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.AddEnvironmentVariables();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
#endif

/*https://itnesweb.com/article/from-sandbox-how-configuration-in-net-core-works
   public IConfiguration Configuration {get;  set;  }
 public IHostingEnvironment Environment {get;  set;  }

 public Startup (IConfiguration configuration, IHostingEnvironment environment)
 {
  Environment = environment;
  Configuration = new ConfigurationBuilder ()
  .AddJsonFile ("appsettings.json")
  .AddJsonFile ($ "appsettings. {Environment.EnvironmentName} .json")
  .Build ();
 } 

    */