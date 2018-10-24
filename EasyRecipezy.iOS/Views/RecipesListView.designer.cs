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
	[Register ("RecipesListView")]
	partial class RecipesListView
	{
		[Outlet]
		UIKit.UITapGestureRecognizer DurationTgr { get; set; }

		[Outlet]
		UIKit.UITableView RecipesTableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (RecipesTableView != null) {
				RecipesTableView.Dispose ();
				RecipesTableView = null;
			}

			if (DurationTgr != null) {
				DurationTgr.Dispose ();
				DurationTgr = null;
			}
		}
	}
}
