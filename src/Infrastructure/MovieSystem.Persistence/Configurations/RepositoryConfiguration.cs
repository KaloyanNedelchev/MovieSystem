using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MovieSystem.Application.Interfaces;
using MovieSystem.Application.IRepository;
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
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRepository<Director>, DirectorRepository>();
            services.AddScoped<IRepository<Rating>, RatingRepository>();
            services.AddScoped<IRepository<Movie>, MovieRepository>();
        }
    }
}
