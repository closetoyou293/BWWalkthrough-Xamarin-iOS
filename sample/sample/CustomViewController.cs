// This file has been autogenerated from a class added in the UI designer.

using System;
using BWWalkthrough;
using CoreAnimation;
using Foundation;
using UIKit;

namespace sample
{
	public partial class CustomViewController : UIViewController, IBWWalkthroughPage
	{
		public CustomViewController (IntPtr handle) : base (handle)
		{
		}

		public void WalkThroughDidScroll(float position, float offset)
		{
			var tr = CATransform3D.Identity;

			tr.m34 = (System.nfloat)(-1 / 500.0);

			titleLabel.Layer.Transform = CATransform3D.MakeRotation((System.nfloat)(Math.PI * (1.0 - offset)), 1, 1, 1);
			textLabel.Layer.Transform = CATransform3D.MakeRotation((System.nfloat)(Math.PI * (1.0 - offset)), 1, 1, 1);


			var tmpOffset = offset;

			if (tmpOffset > 1.0)
			{
				tmpOffset = (float)(1.0 + (1.0 - tmpOffset));
			}
			imageView.Layer.Transform = CATransform3D.MakeTranslation(0, (System.nfloat)((1.0 - tmpOffset) * 200), 0);

		}
	}
}
