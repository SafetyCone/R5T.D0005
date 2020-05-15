using System;
using System.Threading.Tasks;


namespace R5T.D0005.Default
{
    public class StaticValueProgramNameProvider : IProgramNameProvider
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
