using XamarinConfig.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;

namespace XamarinConfig.UWP.Configuration
{
    public class UwpConfigurationStreamProvider : IConfigurationStreamProvider
    {
        private IRandomAccessStreamWithContentType _inputStream;
        private Stream _readingStream;

        private const string ConfigurationFilePath = "ms-appx:///Assets/config.json";

        public async Task<Stream> GetStreamAsync()
        {
            ReleaseUnmanagedResources();

            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri(ConfigurationFilePath));

            _inputStream = await file.OpenReadAsync();
            _readingStream = _inputStream.AsStreamForRead();

            return _readingStream;
        }

        private void ReleaseUnmanagedResources()
        {
            _inputStream?.Dispose();
            _readingStream?.Dispose();

            _inputStream = null;
            _readingStream = null;
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        ~UwpConfigurationStreamProvider()
        {
            ReleaseUnmanagedResources();
        }
    }
}
