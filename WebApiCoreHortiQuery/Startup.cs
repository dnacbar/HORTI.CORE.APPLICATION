using DataCoreHortiQuery.DBHORTICONTEXT;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.OpenApi.Models;

namespace WebApiCoreHortiQuery
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
            services.AddDbContext<DBHortiContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("DBHortiContext")));

            services.AddControllers();

            services.AddSwaggerGen(opt => opt.SwaggerDoc("v1", new OpenApiInfo
            {
                Description = "WS REST - WEB API HORTI QUERY",
                Title = "WS REST - WEB API HORTI",
                Version = "V1",
            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint("/swagger/v1/swagger.json", "WS REST - WEB API HORTI V1");
                opt.RoutePrefix = string.Empty;
            });

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
