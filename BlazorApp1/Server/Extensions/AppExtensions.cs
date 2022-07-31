using BlazorApp1.Server.Context;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.Extensions
{
    public static class AppExtensions
    {

      public static void SetupDatabaseContext(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnectionString");
            services.AddDbContext<BlazorApp1Context>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)), ServiceLifetime.Transient);

            using (var sp = services.BuildServiceProvider())
            {
                var context = sp.GetService<BlazorApp1Context>();
                if (context.Database.GetPendingMigrations().Any())
                    context.Database.Migrate();
            }
        }
    }
}
