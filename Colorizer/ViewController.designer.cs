// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Colorizer
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton BoringButton { get; set; }

		[Action ("OnBoringButtonTouchUpInside:")]
		partial void OnBoringButtonTouchUpInside (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (BoringButton != null) {
				BoringButton.Dispose ();
				BoringButton = null;
			}
		}
	}
}
