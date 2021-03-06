using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc2.Data;
using SalesWebMvc2.Services;

namespace SalesWebMvc2
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
            services.AddControllersWithViews();

            services.AddDbContext<SalesWebMvc2Context>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("SalesWebMvc2Context"), builder =>
                    builder.MigrationsAssembly("SalesWebMvc2")));
          
            //Classe SeedingService registrada aqui no sistema de injeção de dependencia no startup. Isso permite que o meu serviço possa
            //ser injetado em outros e que ele também receba outros injetados nele.

            services.AddScoped<SeedingServices>();
            services.AddScoped<SellerService>();
            services.AddScoped<SalesRecordService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, SeedingServices seedingServices)
        {

            //Perfil de desenvolvimento
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                seedingServices.Seed(); //Popula base de dados
            }
            //Perfil de produção (app publicado)
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
