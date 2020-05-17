using System;
using System.Reflection;
using System.Threading.Tasks;


namespace R5T.D0005.Default
{
    public class ProgramNameProvider : IProgramNameProvider
    {
        public Task<string> GetProgramNameAsync()
        {
            var entryAssembly = Assembly.GetEntryAssembly();

            var programName = entryAssembly.GetName().Name;
            return Task.FromResult(programName);
        }
    }
}
