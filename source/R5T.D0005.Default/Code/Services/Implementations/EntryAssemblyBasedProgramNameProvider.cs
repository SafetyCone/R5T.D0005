using System;
using System.Reflection;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.D0005.Default
{[ServiceImplementationMarker]
    public class EntryAssemblyBasedProgramNameProvider : IProgramNameProvider,IServiceImplementation
    {
        public Task<string> GetProgramNameAsync()
        {
            var entryAssembly = Assembly.GetEntryAssembly();

            var programName = entryAssembly.GetName().Name;
            return Task.FromResult(programName);
        }
    }
}
