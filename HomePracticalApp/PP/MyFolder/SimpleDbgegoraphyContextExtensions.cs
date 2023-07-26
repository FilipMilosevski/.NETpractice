using Filip;
using Microsoft.EntityFrameworkCore; // UseSqlServer
using Microsoft.Extensions.DependencyInjection; // IServiceCollection
using Project1Empty;
namespace Filip;

public static class SimpleDbgegoraphyContextExtensions
{
    /// <summary>
    /// Adds NorthwindContext to the specified IServiceCollection. Uses the SqlServer database provider.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="connectionString">Set to override the default.</param>
    /// <returns>An IServiceCollection that can be used to add more services.</returns>
    public static IServiceCollection AddSimpleDbgegoraphyContext(
        this IServiceCollection services,
        string connectionString = "Data Source=.;Initial Catalog= SimpleDBGegoraphy;Integrated Security=true;TrustServerCertificate=True;MultipleActiveResultsets=true;Encrypt=false")
    {
        services.AddDbContext<SimpleDbgegoraphyContext>(options =>
        {
            options.UseSqlServer(connectionString);
            options.LogTo(Console.WriteLine, // Console
            new[] {
            Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.CommandExecuting });
        });
        return services;
    }
}