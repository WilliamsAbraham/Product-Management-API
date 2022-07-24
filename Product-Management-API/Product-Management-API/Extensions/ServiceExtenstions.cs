using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Product_Management_API.Extensions
{
    public static class ServiceExtenstions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
         services.Configure<IISOptions>(options =>
         {
         });
        //public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
        //    services.AddDbContext<RepositoryContext>(opts =>
        //    opts.UseMySql(configuration.GetConnectionString("SqlConnection"), new MySqlServerVersion(new Version(8, 0, 11)), b => b.MigrationsAssembly("CompanyEmployee")));

        //public static void ConfigureRepositoryManager(this IServiceCollection services) =>
        //    services.AddScoped<IRepositoryManager, RepositoryManager>();
    }
}
