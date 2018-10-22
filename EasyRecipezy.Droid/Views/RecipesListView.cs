
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using EasyRecipezy.Core;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Platforms.Android.Views;

namespace EasyRecipezy.Droid.Views
{
    //Links the activity and defines the view as the main
    [Activity(Label = "RecipesListView", MainLauncher = true)]
    public class RecipesListView : MvxActivity<RecipesListViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //Set the axml view for the view
            SetContentView(Resource.Layout.RecipesListView);

            //Note: casting to type is done through a generic in C#
            var recipesRv = FindViewById<MvxRecyclerView>(Resource.Id.recipes_rv);
            recipesRv.AddItemDecoration(new DividerItemDecoration(recipesRv.Context, DividerItemDecoration.Vertical));
            if (recipesRv != null)
            {
                recipesRv.HasFixedSize = true;
                var layoutManager = new LinearLayoutManager(this);
                recipesRv.SetLayoutManager(layoutManager);
            }
        }
    }
}
