// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Bingo4iPhone
{
	[Register ("RootViewController")]
	partial class RootViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel userRoleLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (userRoleLabel != null) {
				userRoleLabel.Dispose ();
				userRoleLabel = null;
			}
		}
	}
}