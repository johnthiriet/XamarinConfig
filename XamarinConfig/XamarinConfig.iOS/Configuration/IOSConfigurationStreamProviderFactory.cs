using XamarinConfig.Configuration;

namespace XamarinConfig.iOS.Configuration
{
    public class IOSConfigurationStreamProviderFactory : IConfigurationStreamProviderFactory
    {
        public IConfigurationStreamProvider Create()
        {
            return new IOSConfigurationStreamProvider();
        }
    }
}