using Foundation;
using UIKit;
using LeanplumBindings;

namespace Colorizer
{
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public override UIWindow Window { get; set; }

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
			Leanplum.SetDevelopmentAppId("your-app-id", "your-access-key");
			Leanplum.Start();

			return true;
		}
	}
}