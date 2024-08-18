using Microsoft.Extensions.DependencyInjection;
using MovieSystem.Application.Interfaces;
using MovieSystem.Application.Services;
using MovieSystem.Domain.Entities;

namespace MovieSystem.Application.Extensions
{
    public static class Serviceconfiguration
    {
        public static void RegisteredServices( this IServiceCollection service)
        {
            service.AddScoped<IService<User>, UserService>();
        }
    }
}
