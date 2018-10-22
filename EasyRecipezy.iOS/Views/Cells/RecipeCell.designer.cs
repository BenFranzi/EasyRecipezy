// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace EasyRecipezy.iOS.Views.Cells
{
    [Register ("RecipeCell")]
    partial class RecipeCell
    {
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
        }
    }
}