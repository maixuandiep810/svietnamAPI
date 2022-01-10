using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using svietnamAPI.StartupConfig.ServiceCollectionConfig;
using svietnamAPI.StartupConfig.ApplicationBuilderConfig;

namespace svietnamAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(Configuration);

            services.AddServerSetting(Configuration);
            services.AddInfras(Configuration);
            services.AddModels(Configuration);

            services.AddSwagger(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.CheckStatusOfServices();

            app.DevEnvUseDeveloperExceptionPage(env);
            app.DevEnvUseSwagger(env);

            // 
            // app.UseUnhandledException();
            //

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAppStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
