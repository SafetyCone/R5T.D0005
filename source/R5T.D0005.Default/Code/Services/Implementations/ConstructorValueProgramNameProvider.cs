using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0005.Default
{
    [ServiceImplementationMarker]
    public class ConstructorValueProgramNameProvider : IProgramNameProvider, IServiceImplementation
    {
        private string ProgramName { get; }


        public ConstructorValueProgramNameProvider(
            [NotServiceComponent] string programName)
        {
            this.ProgramName = programName;
        }

        public Task<string> GetProgramNameAsync()
        {
            return Task.FromResult(this.ProgramName);
        }
    }
}
