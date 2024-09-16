using API.Configuration;
using Database;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Repository;

namespace API.Extentions
{
    public static class ServiceExtentions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Usuario>, Repository<Usuario>>();
            services.AddScoped<IRepository<Feedback>, Repository<Feedback>>();

            return services;
        }

        public static IServiceCollection AddContext(this IServiceCollection services, APIConfiguration apiConfiguration)
        {
            //Oracle
            services.AddDbContext<OracleDbContext>(options =>
            {
                options.UseOracle(apiConfiguration.Oracle.ConnectionString);
            });

            return services;
        }

        public static IServiceCollection AddSwagger(this IServiceCollection services, APIConfiguration apiConfiguration)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = $"{apiConfiguration.Swagger.Title} {DateTime.Now.Year} ",
                    Version = "v1",
                    Description = apiConfiguration.Swagger.Description,
                    Contact = new OpenApiContact() { Name = apiConfiguration.Swagger.Name, Email = apiConfiguration.Swagger.Email }
                });
            });

            return services;
        }
    }
}
