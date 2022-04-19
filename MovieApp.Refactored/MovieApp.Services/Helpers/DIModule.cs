using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.DataAccess;
using MovieApp.DataAccess.Repositories;
using MovieApp.DataAccess.Repositories.CacheRepositories;
using MovieApp.DataAccess.Repositories.EntityRepositories;
using MovieApp.Domain.Models;

namespace MovieApp.Services.Helpers
{
    public static class DIModule
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            services.AddDbContext<MovieDbContext>(x =>
               x.UseSqlServer(
                  "Server=localhost\\SQLEXPRESS; Database=master; Trusted_Connection=True"));

            // Register repositories that communicate with actual database
            services.AddTransient<IRepository<Genre>, GenreEntityRepository>();
            services.AddTransient<IRepository<Movie>, MovieEntityRepository>();
            services.AddTransient<IRepository<Person>, PersonEntityRepository>();

            // Cache DB example (repositories)
            //services.AddTransient<IRepository<Genre>, GenreRepository>();
            //services.AddTransient<IRepository<Movie>, MovieRepository>();
            //services.AddTransient<IRepository<Person>, PersonRepository>();

            return services;
        }
    }
}