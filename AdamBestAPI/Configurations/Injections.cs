using AdamApplication.Repositories;
using AdamApplication.Services;
using AdamInfrastructure.Repositories;

namespace AdamBestAPI.Configurations
{
    public static class Injections
    {
        public static IServiceCollection AddRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            services.AddScoped<UsuariosChatService>();
            services.AddScoped<MensajesChatService>();
            services.AddScoped<IMensajesRepository, MensajesPorUsuarioRepository>();
            services.AddScoped<ProductosService>();
            return services;
        }
    }
}
