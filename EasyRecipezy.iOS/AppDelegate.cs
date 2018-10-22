using EasyRecipezy.Core;
using Foundation;
using MvvmCross.Platforms.Ios.Core;
using UIKit;

namespace EasyRecipezy.iOS
{
    //https://www.mvvmcross.com/documentation/tutorials/tipcalc/a-xamarinios-ui-project?scroll=1720
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {
        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var result = base.FinishedLaunching(application, launchOptions);

            return result;
        }
    }
}

