using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CQRSAndMediatrSampleApplication.Product
{
    public static class ProductModule
    {
        public static IServiceCollection AddProductModule(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            return serviceCollection;
        }
    }
}
