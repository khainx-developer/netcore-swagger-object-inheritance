using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using NetcoreSwaggerObjectInheritance.Repositories;
using NetcoreSwaggerObjectInheritance.Repositories.Interfaces;

namespace NetcoreSwaggerObjectInheritance
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
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.UseAllOfForInheritance();
                c.UseOneOfForPolymorphism();
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "NetcoreSwaggerObjectInheritance", Version = "v1"});
            });

            services.AddSingleton<InMemoryDatabase>();
            services.AddTransient<IPetRepository, PetRepository>();
            services.AddTransient<IDogRepository, DogRepository>();
            services.AddTransient<ICatRepository, CatRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "NetcoreSwaggerObjectInheritance v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}