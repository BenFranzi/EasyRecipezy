using System;
using EasyRecipezy.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace EasyRecipezy.iOS.Views
{
    //Connect controller to view on the storyboard
    [MvxFromStoryboard("Main")]
    public partial class SingleRecipeView : MvxViewController<SingleRecipeViewModel>
    {
        /** Note: guide to implementing a scrollable view in storyboard
         * http://synappse.co/blog/uiscrollview-has-ambiguous-scrollable-content-height/
         * and
         * https://www.youtube.com/watch?v=MKXZWbhtAQo
         */

        public SingleRecipeView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //Set bindings
            var set = this.CreateBindingSet<SingleRecipeView, SingleRecipeViewModel>();
            set.Bind(NameLbl).To(vm => vm.Recipe.Name);
            set.Bind(DurationLbl).To(vm => vm.Recipe.Duration);
            set.Bind(DifficultyLbl).To(vm => vm.Recipe.Difficulty);
            set.Bind(IngredientsLbl).To(vm => vm.Recipe.Ingredients);
            set.Bind(MethodLbl).To(vm => vm.Recipe.Method);
            set.Apply();
        }
    }
}

