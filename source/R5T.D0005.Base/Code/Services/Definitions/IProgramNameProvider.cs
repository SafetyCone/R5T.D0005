using System;
using System.Threading.Tasks;


namespace R5T.D0005
{
    public interface IProgramNameProvider
    {
        Task<string> GetProgramNameAsync();
    }
}
