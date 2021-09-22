using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.SpaServices;
using Microsoft.EntityFrameworkCore;
using ProtectedAreas.Data;
using ProtectedAreas.Data.Repositories;
using ProtectedAreas.Data.Repositories.Interfaces;
using VueCliMiddleware;

namespace ProtectedAreas
{
    public class Startup
    {
        private readonly string _spaSourcePath;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _spaSourcePath = Configuration.GetValue<string>("SPA:SourcePath");
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(context => context.UseInMemoryDatabase("ProtectedAreaDB"));
            services.AddTransient<IProtectedAreaRepository, ProtectedAreaRepository>();

            services.AddControllers();
            services.AddMvc(options => options.SuppressAsyncSuffixInActionNames = false);
            services.AddSpaStaticFiles(opt => opt.RootPath = $"{_spaSourcePath}/dist");
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseSpaStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                endpoints.MapToVueCliProxy(
                    "{*path}",
                    new SpaOptions { SourcePath = _spaSourcePath },
                    npmScript: System.Diagnostics.Debugger.IsAttached ? "serve" : null,
                    regex: "Compiled successfully",
                    forceKill: true
                );
            });
        }
    }
}
