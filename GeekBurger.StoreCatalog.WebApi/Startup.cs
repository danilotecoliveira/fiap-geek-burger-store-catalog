using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using GeekBurger.StoreCatalog.Core;
using Swashbuckle.AspNetCore.Swagger;
using GeekBurger.StoreCatalog.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using GeekBurger.StoreCatalog.Infra.Interfaces;
using GeekBurger.StoreCatalog.WebApi.Controllers;
using GeekBurger.StoreCatalog.Infra.Repositories;

namespace GeekBurger.StoreCatalog.WebApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var mvcCoreBuilder = services.AddMvcCore();
            mvcCoreBuilder
                .AddFormatterMappings()
                .AddJsonFormatters()
                .AddCors();

            services.AddMvcCore().AddApiExplorer();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Geek Burger Store Catalog", Version = "v1" });
            });

            services.AddScoped<IProducts, Products>();
            services.AddScoped<IProductCore, ProductCore>();
            services.AddSingleton(a => StoreController.GetAreas());
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Geek Burger Store Catalog");
            });

            app.UseMvc();
        }
    }
}
