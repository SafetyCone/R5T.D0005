using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0005.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ProgramNameProvider"/> implementation of <see cref="IProgramNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultProgramNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IProgramNameProvider, ProgramNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ProgramNameProvider"/> implementation of <see cref="IProgramNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IProgramNameProvider> AddDefaultProgramNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IProgramNameProvider>.New(() => services.AddDefaultProgramNameProvider());
            return serviceAction;
        }
    }
}
