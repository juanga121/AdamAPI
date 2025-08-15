using AdamApplication.Repositories;
using AdamInfrastructure.Repositories;

namespace AdamBestAPI.Configurations
{
    public static class Injections
    {
        public static IServiceCollection AddRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            return services;
        }
    }
}
