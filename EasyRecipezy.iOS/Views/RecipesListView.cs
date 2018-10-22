using System;
using EasyRecipezy.Core;
using EasyRecipezy.iOS.Views.Cells;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace EasyRecipezy.iOS.Views
{
    //To connect to the storyboard you need to add the following line
    [MvxFromStoryboard("Main")]
    public partial class RecipesListView : MvxViewController<RecipesListViewModel>
    {
        public RecipesListView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //Perform binding operations in this function

            //Set the data source for the table view from the inner class declared below
            var source = new RecipesTableViewSource(RecipesTableView);
            RecipesTableView.Source = source;

            //Set bindings
            var set = this.CreateBindingSet<RecipesListView, RecipesListViewModel>();
            //Bind data to the tableview source
            set.Bind(source).To(vm => vm.Recipes);
            //Bind onclick to the tableview source
            set.Bind(source).For(f => f.SelectionChangedCommand).To(vm => vm.ItemSelected);
            set.Apply();
        }

        public class RecipesTableViewSource : MvxTableViewSource
        {
            // Need to implement constructor
            public RecipesTableViewSource(UITableView tableView) : base(tableView)
            {
            }

            protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
            {
                //Configure recycling of cells
                //Note: need to put in the Reuse Identifier in storyboard
                return (RecipeCell)tableView.DequeueReusableCell("RecipeCell", indexPath);
            }
        }
    }
}

