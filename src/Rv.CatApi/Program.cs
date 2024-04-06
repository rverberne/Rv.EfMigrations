using Microsoft.EntityFrameworkCore;
using Npgsql;
using Rv.CatApi.Cats;

namespace Rv.CatApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var services = builder.Services;

        services.AddControllers();
        services.AddDbContext<CatsDbContext>(efOptions =>
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(builder.Configuration.GetConnectionString("Default"));
            dataSourceBuilder.UseNetTopologySuite();

            var dataSource = dataSourceBuilder.Build();

            efOptions.UseNpgsql(dataSource, pgOptions =>
                pgOptions
                    .UseNetTopologySuite()
                    .MigrationsHistoryTable("ef_migrations", "cats"));
        });

        var app = builder.Build();

        app.MapControllers();
        app.Run();
    }
}
