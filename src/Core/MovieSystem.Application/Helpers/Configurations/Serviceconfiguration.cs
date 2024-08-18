using Microsoft.Extensions.DependencyInjection;
using MovieSystem.Application.Interfaces;
using MovieSystem.Application.Services;
using MovieSystem.Domain.Entities;
using System.Reflection;

namespace MovieSystem.Application.Helpers.Configurations
{
    public static class Serviceconfiguration
    {
        public static void RegisteredServices(this IServiceCollection service)
        {
            var assembly = Assembly.GetExecutingAssembly();
            service.AddAutoMapper(assembly);

            service.AddScoped<IService<User>, UserService>();
            service.AddScoped<IMovieService, MovieService>();
        }
    }
}
