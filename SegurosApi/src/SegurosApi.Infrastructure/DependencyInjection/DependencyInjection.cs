using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SegurosApi.Domain.Interfaces;
using SegurosApi.Infrastructure.Context;
using SegurosApi.Infrastructure.Repositories;
using SegurosApi.Application;
using SegurosApi.Application.Services;
using SegurosApi.Application.Interfaces;

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

        services.AddScoped<IApoliceRepository, ApoliceRepository>();

        services.AddScoped<ISeguroRepository, SeguroRepository>();

        services.AddScoped<IClienteService, ClienteService>();

        services.AddScoped<IApoliceService, ApoliceService>();
        
        services.AddScoped<ISeguroService, SeguroService>();

        return services;
    }
}