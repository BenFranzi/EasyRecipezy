// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace EasyRecipezy.iOS.Views.Cells
{
	[Register ("RecipeCell")]
	partial class RecipeCell
	{
		[Outlet]
		UIKit.UIImageView DurationIv { get; set; }

		[Outlet]
		UIKit.UILabel DurationLbl { get; set; }

		[Outlet]
		UIKit.UILabel NameLbl { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (DurationLbl != null) {
				DurationLbl.Dispose ();
				DurationLbl = null;
			}

			if (NameLbl != null) {
				NameLbl.Dispose ();
				NameLbl = null;
			}

			if (DurationIv != null) {
				DurationIv.Dispose ();
				DurationIv = null;
			}
		}
	}
}
