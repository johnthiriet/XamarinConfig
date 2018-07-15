using System;
using System.IO;
using System.Threading.Tasks;

namespace XamarinConfig.Configuration
{
    public interface IConfigurationStreamProvider : IDisposable
    {
        Task<Stream> GetStreamAsync();
    }
}