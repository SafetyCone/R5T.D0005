using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0005
{
    [ServiceDefinitionMarker]
    public interface IProgramNameProvider : IServiceDefinition
    {
        Task<string> GetProgramNameAsync();
    }
}
