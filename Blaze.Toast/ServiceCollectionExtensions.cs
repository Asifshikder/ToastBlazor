using Blaze.Toast.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Blaze.Toast
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazeToast(this IServiceCollection services)
        {
            return services.AddScoped<IToastService, ToastService>();
        }
    }
}
