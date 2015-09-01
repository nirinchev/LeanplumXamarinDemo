using System;
using UIKit;
using LeanplumBindings;
using Foundation;

namespace Colorizer
{
	public partial class ViewController : UIViewController
	{
		private static readonly LPVar buttonTitle = LPVar.Define ("ButtonTitle", "Boring Button");
		private static readonly LPVar buttonColor = LPVar.Define ("ButtonColor", UIColor.Black);

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			Leanplum.OnVariablesChanged(() =>
			{
				this.BoringButton.SetTitle(buttonTitle.StringValue, UIControlState.Normal);
				this.BoringButton.SetTitleColor(buttonColor.ColorValue, UIControlState.Normal);
			});
		}

		partial void OnBoringButtonTouchUpInside(NSObject sender)
		{
			Leanplum.Track("Boring button clicked");
		}
	}
}