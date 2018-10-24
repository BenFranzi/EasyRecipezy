using System;
using EasyRecipezy.Core.Models;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using UIKit;
using static EasyRecipezy.Core.RecipesListViewModel;

namespace EasyRecipezy.iOS.Views.Cells
{
    public partial class RecipeCell : MvxTableViewCell
    {
        /**
         * Understanding Handling and raising events
         * https://docs.microsoft.com/en-us/dotnet/standard/events/
         * https://docs.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=netframework-4.7.2
         */
        public event EventHandler<RecipeEventArgs> DurationActionEvent;

        protected RecipeCell(IntPtr handle) : base(handle)
        {
        }

        /**
         * Sends a message to each object recreated after all objects
         * Have been loaded an initialized
         * https://developer.apple.com/documentation/objectivec/nsobject/1402907-awakefromnib
         */
        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            //Prevent highlighting of cell onclick
            this.SelectionStyle = UITableViewCellSelectionStyle.None;
            //Links for more information
            //https://docs.microsoft.com/en-us/xamarin/ios/app-fundamentals/touch/ios-touch-walkthrough#Gesture_Recognizer_Samples
            //https://github.com/xamarin/recipes/blob/master/Recipes/ios/input/touch/tap-gesture/TapGesture/TapGestureViewController.cs
            //https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/gestures/tap
            //Configuration for label
            UITapGestureRecognizer DurationLblTapGestureRecognizer = new UITapGestureRecognizer(TapEventTriggered);
            DurationLblTapGestureRecognizer.NumberOfTapsRequired = 1;
            DurationLblTapGestureRecognizer.CancelsTouchesInView = false;
            DurationLbl.UserInteractionEnabled = true;
            DurationLbl.AddGestureRecognizer(DurationLblTapGestureRecognizer);
            //Configuration for imageview
            UITapGestureRecognizer DurationIvTapGestureRecognizer = new UITapGestureRecognizer(TapEventTriggered);
            DurationIvTapGestureRecognizer.NumberOfTapsRequired = 1;
            DurationIvTapGestureRecognizer.CancelsTouchesInView = false;
            DurationIv.UserInteractionEnabled = true;
            DurationIv.AddGestureRecognizer(DurationIvTapGestureRecognizer);
            //Note: only a single gesture recogniser can be attached to an element
            //https://developer.apple.com/documentation/uikit/
            CellInit();
        }

        void TapEventTriggered()
        {
            if (DurationActionEvent != null)
            {
                DurationActionEvent.Invoke(this, new RecipeEventArgs(this.DataContext as Recipe));
            }
        }


        private void CellInit()
        {
            /**
             * Delayed binding to wait for cells to load. It adds the function to an action
             * queue that is called in OnDataContextChange();
             * https://github.com/MvvmCross/MvvmCross/blob/bdaa09299714d94cf3f2c548a465d994c20d52f0/MvvmCross/Binding/BindingContext/MvxBindingContext.cs
             */
            this.DelayBind(() =>
            {
                /** Data is exposed for the displaying of information from the model specifically
                 * for use in iOS. This contains the variable that need to be exposed to
                 * display on the cell. In Android this binding is performed in the XML 
                 * of the recipe_item.
                 */
                var set = this.CreateBindingSet<RecipeCell, Recipe>();
                set.Bind(NameLbl).To(mv => mv.Name);
                set.Bind(DurationLbl).To(mv => mv.Duration);
                set.Apply();
            });
        }
    }

    /**
     * Custom args for the duration click event
     */
    public class RecipeEventArgs : EventArgs
    {
        public Recipe CurrentRecipe { get; set; }
        public RecipeEventArgs(Recipe recipe)
        {
            CurrentRecipe = recipe;
        }
    }


}

