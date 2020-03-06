using System;
using System.Collections.Generic;
using System.Linq;
using FFImageLoading;
using FFImageLoading.Forms.Platform;
using FFImageLoading.Svg.Forms;
using Foundation;
using UIKit;

namespace XF_Monettelli.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.SetFlags("Shell_Experimental", "Visual_Experimental", "CollectionView_Experimental", "FastRenderers_Experimental");

            global::Xamarin.Forms.Forms.Init();

            // ADD Init() Material Visual
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            global::Xamarin.Forms.FormsMaterial.Init();
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // SECTOR1 FFImageLoading
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            CachedImageRenderer.Init();
            CachedImageRenderer.InitImageSourceHandler();
            var ignore = typeof(SvgCachedImage);

            var config = new FFImageLoading.Config.Configuration()
            {
                VerboseLogging = false,
                VerbosePerformanceLogging = false,
                VerboseMemoryCacheLogging = false,
                VerboseLoadingCancelledLogging = false,
                Logger = new CustomLogger(),
            };

            ImageService.Instance.Initialize(config);
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
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
