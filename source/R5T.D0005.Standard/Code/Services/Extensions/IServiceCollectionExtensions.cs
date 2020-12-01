using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0005.Default;


namespace R5T.D0005.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IProgramNameProvider"/> service.
        /// </summary>
        public static IServiceCollection AddProgramNameProvider(this IServiceCollection services)
        {
            services.AddEntryAssemblyBasedProgramNameProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IProgramNameProvider"/> service.
        /// </summary>
        public static ServiceAction<IProgramNameProvider> AddProgramNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IProgramNameProvider>.New(() => services.AddProgramNameProvider());
            return serviceAction;
        }
    }
}
