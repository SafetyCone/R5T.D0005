using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.D0005.Default
{[ServiceImplementationMarker]
    public class StaticValueProgramNameProvider : IProgramNameProvider,IServiceImplementation
    {
        /// <summary>
        /// Note: not thread-safe.
        /// </summary>
        public static string ProgramName { get; }


        public Task<string> GetProgramNameAsync()
        {
            return Task.FromResult(StaticValueProgramNameProvider.ProgramName);
        }
    }
}
