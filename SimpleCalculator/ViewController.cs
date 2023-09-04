using System;
using System.Globalization;

using AppKit;
using Foundation;

namespace SimpleCalculator
{
	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

		private float getNumber(NSTextField x)
		{
			return float.Parse(x.StringValue, CultureInfo.InvariantCulture.NumberFormat);
        }

        partial void clearButton(NSObject sender)
		{
			num1.StringValue = @"";
			num2.StringValue = @"";
			result.StringValue = @"";
        }

        partial void divButton(NSObject sender)
		{
			float ans = getNumber(num1) / getNumber(num2);
			result.StringValue = ans.ToString();
        }

        partial void minButton(NSObject sender)
		{
            float ans = getNumber(num1) - getNumber(num2);
            result.StringValue = ans.ToString();
        }

        partial void plusButton(NSObject sender)
		{
            float ans = getNumber(num1) + getNumber(num2);
            result.StringValue = ans.ToString();
        }

        partial void timesButton(NSObject sender)
		{
            float ans = getNumber(num1) * getNumber(num2);
            result.StringValue = ans.ToString();
        }
    }
}
