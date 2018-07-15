using System.Threading;
using System.Threading.Tasks;

namespace XamarinConfig.Configuration
{
    public interface IConfigurationManager
    {
        Task<Configuration> GetAsync(CancellationToken cancellationToken);
    }
}