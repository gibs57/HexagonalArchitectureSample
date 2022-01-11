using HexaArchitecture.Domain;
using HexaArchitecture.DomainApi.Model;
using HexaArchitecture.DomainApi.Services;
using HexaArchitecture.Extension;
using HexaArchitecture.Persistence.Adapter;
using HexaArchitecture.Persistence.Adapter.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace HexaArchitecture
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        private AppSettings AppSettings { get; set; }

        public Startup(IConfiguration configuration)
        {
            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();
            Configuration = configuration;

            AppSettings = new AppSettings();
            Configuration.Bind(AppSettings);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddPersistence();


            services.AddDomain();

            services.AddSwaggerOpenAPI(AppSettings);

            services.AddApiVersion();

            services.AddHealthCheck();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory log)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseSwaggerConfig();

            app.UseHealthCheck();

            log.AddSerilog();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //Add Fake Data
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            AddTestData(context);
        }

        private static void AddTestData(ApplicationDbContext dbContext)
        {
            dbContext.Deals.Add(new Deal() { Id = 1, Name = "ABC", Description = "ABC deal 123" });
            dbContext.SaveChanges();
        }
    }
}
