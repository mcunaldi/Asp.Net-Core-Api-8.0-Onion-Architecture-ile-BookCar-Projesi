using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace UdemyCarBook.Application.Services;
public static class ServiceRegistiration
{
    public static IServiceCollection AddApplicationService(
        this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        return services;
    }
}
