using Microsoft.Extensions.DependencyInjection;
using MovieSystem.Application.Interfaces;
using MovieSystem.Domain.Entities;
using MovieSystem.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Persistence.Configurations
{
    public static class RepositoryConfiguration
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<User>, UserRepository>();

            services.AddScoped<IMovieRepository, MovieRepository>();
        }
    }
}
