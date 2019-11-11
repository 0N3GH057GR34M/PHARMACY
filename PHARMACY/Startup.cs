using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PHARMACY.Context;

namespace PHARMACY
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }
    public IConfiguration Configuration { get; }
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<PharmacyContext>(options =>
      options.UseSqlServer(Configuration.GetConnectionString("PharmacyContext")));
      services.AddMvc();
    }
    public void Configure(IApplicationBuilder app)
    {
      app.UseMvc(routes =>
      {
        routes.MapRoute(
        name: "default",
        template: "{controller}/{action}",
        defaults: new { controller = "Pharmacy", action = "Start" });
      });
    }
  }
}
