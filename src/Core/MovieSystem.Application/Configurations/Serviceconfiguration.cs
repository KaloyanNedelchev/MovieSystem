using Microsoft.Extensions.DependencyInjection;
using MovieSystem.Application.Interfaces;
using MovieSystem.Application.Services;
using MovieSystem.Domain.Entities;
using System.Reflection;

namespace MovieSystem.Application.Extensions
{
    public static class Serviceconfiguration
    {
        public static void RegisteredServices( this IServiceCollection service)
        {
            service.AddScoped<IDirectorService, DirectorService>();
            service.AddScoped<IMovieService, MovieService>();
            service.AddScoped<IRatingService, RatingService>();
            service.AddScoped<IUserService, UserService>();

            var assembly = Assembly.GetExecutingAssembly();
            service.AddAutoMapper(assembly);
        }
    }
}
