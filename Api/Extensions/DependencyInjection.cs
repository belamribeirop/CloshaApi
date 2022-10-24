using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infra.Context;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Extensions;
public static class DependencyInjection
{
    public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("AppDbContext")));

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddScoped<IItemRepository, ItemRepository>();
        services.AddScoped<IItemService, ItemService>();

        return services;
    }
}