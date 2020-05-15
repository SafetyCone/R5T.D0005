using System;
using System.Threading.Tasks;


namespace R5T.D0005.Default
{
    public class ConstructorValueProgramNameProvider : IProgramNameProvider
    {
        private string ProgramName { get; }


        public ConstructorValueProgramNameProvider(string programName)
        {
            this.ProgramName = programName;
        }

        public Task<string> GetProgramNameAsync()
        {
            return Task.FromResult(this.ProgramName);
        }
    }
}
