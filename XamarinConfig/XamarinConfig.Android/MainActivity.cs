using Android.App;
using Android.Content.PM;
using Android.OS;
using XamarinConfig.Configuration;
using XamarinConfig.Android.Configuration;

namespace XamarinConfig.Droid
{
    [Activity(Label = "XamarinConfig", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            ConfigurationManager.Initialize(new AndroidConfigurationStreamProviderFactory(() => this));
            LoadApplication(new App());
        }
    }
}

