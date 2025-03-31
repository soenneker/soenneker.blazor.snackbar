using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Blazor.Snackbar.Abstract;

namespace Soenneker.Blazor.Snackbar.Registrars;

/// <summary>
/// SnackbarUtil allows for easy Snackbar usage throughout your Blazor application
/// </summary>
public static class SnackbarUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="ISnackbarUtil"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddSnackbarUtilAsScoped(this IServiceCollection services)
    {
        services.TryAddScoped<ISnackbarUtil, SnackbarUtil>();

        return services;
    }
}
