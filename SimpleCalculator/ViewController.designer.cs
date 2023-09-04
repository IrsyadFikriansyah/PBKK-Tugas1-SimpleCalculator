// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace SimpleCalculator
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField num1 { get; set; }

		[Outlet]
		AppKit.NSTextField num2 { get; set; }

		[Outlet]
		AppKit.NSTextField result { get; set; }

		[Action ("clearButton:")]
		partial void clearButton (Foundation.NSObject sender);

		[Action ("divButton:")]
		partial void divButton (Foundation.NSObject sender);

		[Action ("minButton:")]
		partial void minButton (Foundation.NSObject sender);

		[Action ("plusButton:")]
		partial void plusButton (Foundation.NSObject sender);

		[Action ("timesButton:")]
		partial void timesButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (num1 != null) {
				num1.Dispose ();
				num1 = null;
			}

			if (num2 != null) {
				num2.Dispose ();
				num2 = null;
			}

			if (result != null) {
				result.Dispose ();
				result = null;
			}
		}
	}
}
