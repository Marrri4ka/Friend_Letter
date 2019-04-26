using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extentions.DependencyInjection;


namespace FriendLetter
{
  public class Startup // class
  {
    public Startup (IHostingEnvironment env) // constructor
    {
      var builder = new ConfigurationBuilder()
      .SetBasePath(env.ContentRootPath)
      .AddEnvironmentVaribles();
    Configuration = builder.Build();
    }
    public IConfigurationRoot Configuration { get;}

    public void ConfigureServices (IServiceCollection services)
    {
      services.AddMvc();
    }

    public void Configure(IApplicationBuilder.app) // this method tells our app how to handle requesrs to the serverr
    {
      app.UseMvc (routes => //it will usr MVC framework
      {
        routes.MapRoute(
        name: "default",
        template: "{controller=Home}/{action=Index}/{id?}");
        });

        app.Run(async (context) =>
        {
          await context.Response.WriteAsync("Hello World!");
          });
    }
  }
}
