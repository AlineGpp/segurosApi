using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SegurosApi.Domain.Interfaces;
using SegurosApi.Infrastructure.Context;
using SegurosApi.Infrastructure.Repositories;


namespace SegurosApi.Infrastructure.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<SegurosApiDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection")
            ));

        services.AddScoped<IClienteRepository, ClienteRepository>();

        return services;
    }
}