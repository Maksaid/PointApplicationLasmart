using Application.Services;
using Application.Services.Implementations;
using DataAccess.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<ICommentService, CommentService>();
        collection.AddScoped<IPointService, PointService>();

        return collection;
    }
}