using Application.Common.Filters;
using Application.Common.Validators.EntityValidators;
using Application.Repositories;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class DependencyInjection
    {
        // Adding services dependency injection of DbContext and migrating database.
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Adding repository services.
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IPersonRepository, PersonRepository>();

            services.AddMediatR(typeof(DependencyInjection).GetTypeInfo().Assembly);
            services.AddAutoMapper(typeof(DependencyInjection));

            services.AddMvc(options =>
            {
                options.Filters.Add<ValidationFilter>();
            })
           .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreatePersonCommandValidator>());

            return services;
        }
    }
}
