using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using FFImageLoading.Forms.Platform;
using FFImageLoading;
using FFImageLoading.Svg.Forms;
using Lottie.Forms.Droid;

namespace XF_Monettelli.Android
{
    [Activity(Label = "XF_Monettelli.Android", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.SetFlags("Shell_Experimental", "Visual_Experimental", "CollectionView_Experimental", "FastRenderers_Experimental");

            // SECTOR1 FFImageLoading
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            var config = new FFImageLoading.Config.Configuration()
            {
                VerboseLogging = false,
                VerbosePerformanceLogging = false,
                VerboseMemoryCacheLogging = false,
                VerboseLoadingCancelledLogging = false,
                Logger = new CustomLogger(),
            };
            ImageService.Instance.Initialize(config);

            // Inits of Xamarin.Forms and Essentials
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++

            // ADD Init() Lottie in Android
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            AnimationViewRenderer.Init();
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            CachedImageRenderer.Init(true);
            CachedImageRenderer.InitImageViewHandler();
            var ignore = typeof(SvgCachedImage);
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        // SECTOR2 FFImageLoading
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public class CustomLogger : FFImageLoading.Helpers.IMiniLogger
        {
            public void Debug(string message)
            {
                Console.WriteLine(message);
            }

            public void Error(string errorMessage)
            {
                Console.WriteLine(errorMessage);
            }

            public void Error(string errorMessage, Exception ex)
            {
                Error(errorMessage + System.Environment.NewLine + ex.ToString());
            }
        }
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    }
}