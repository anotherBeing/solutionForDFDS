using Application.Data;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence.Extension;

public static class IServiceCollectionExtension
{
    public static IServiceCollection AddPersitence(
        this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>();

        services.AddScoped<IApplicationDbContext>(x =>
            x.GetRequiredService<ApplicationDbContext>());

        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        return services;
    }
}
