// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace EasyRecipezy.iOS.Views
{
	[Register ("SingleRecipeView")]
	partial class SingleRecipeView
	{
		[Outlet]
		UIKit.UILabel DifficultyLbl { get; set; }

		[Outlet]
		UIKit.UILabel DurationLbl { get; set; }

		[Outlet]
		UIKit.UILabel IngredientsLbl { get; set; }

		[Outlet]
		UIKit.UILabel MethodLbl { get; set; }

		[Outlet]
		UIKit.UILabel NameLbl { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (NameLbl != null) {
				NameLbl.Dispose ();
				NameLbl = null;
			}

			if (DurationLbl != null) {
				DurationLbl.Dispose ();
				DurationLbl = null;
			}

			if (DifficultyLbl != null) {
				DifficultyLbl.Dispose ();
				DifficultyLbl = null;
			}

			if (IngredientsLbl != null) {
				IngredientsLbl.Dispose ();
				IngredientsLbl = null;
			}

			if (MethodLbl != null) {
				MethodLbl.Dispose ();
				MethodLbl = null;
			}
		}
	}
}
