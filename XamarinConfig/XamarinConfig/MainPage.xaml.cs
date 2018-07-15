using System.Threading;
using Xamarin.Forms;
using XamarinConfig.Configuration;

namespace XamarinConfig
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            using (var cts = new CancellationTokenSource())
            { 
                var config = await ConfigurationManager.Instance.GetAsync(cts.Token);
                MyLabel.Text = config.BaseUrl;
            }
        }
    }
}
