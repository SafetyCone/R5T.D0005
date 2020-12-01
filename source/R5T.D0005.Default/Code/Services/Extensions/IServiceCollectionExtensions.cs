using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0005.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="EntryAssemblyBasedProgramNameProvider"/> implementation of <see cref="IProgramNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddEntryAssemblyBasedProgramNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IProgramNameProvider, EntryAssemblyBasedProgramNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="EntryAssemblyBasedProgramNameProvider"/> implementation of <see cref="IProgramNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IProgramNameProvider> AddEntryAssemblyBasedProgramNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IProgramNameProvider>.New(() => services.AddEntryAssemblyBasedProgramNameProvider());
            return serviceAction;
        }
    }
}
