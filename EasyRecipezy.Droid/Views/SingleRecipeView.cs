
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EasyRecipezy.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace EasyRecipezy.Droid.Views
{
    [Activity(Label = "SingleRecipeView")]
    public class SingleRecipeView : MvxActivity<SingleRecipeViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Set the axml view for the view
            SetContentView(Resource.Layout.SingleRecipeView);
        }
    }
}
