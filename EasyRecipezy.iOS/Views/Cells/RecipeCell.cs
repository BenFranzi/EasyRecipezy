using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using UIKit;
using static EasyRecipezy.Core.RecipesListViewModel;

namespace EasyRecipezy.iOS.Views.Cells
{
    public partial class RecipeCell : MvxTableViewCell
    {
        public event EventHandler DurationActionEvent;

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
            //Configure TGR
            //https://docs.microsoft.com/en-us/xamarin/ios/app-fundamentals/touch/ios-touch-walkthrough#Gesture_Recognizer_Samples
            //https://github.com/xamarin/recipes/blob/master/Recipes/ios/input/touch/tap-gesture/TapGesture/TapGestureViewController.cs
            //https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/gestures/tap
            UITapGestureRecognizer DurationLblTgr = new UITapGestureRecognizer((s) => {
                DurationAction_TouchEvent(s, new EventArgs());
            })
            {
                CancelsTouchesInView = false,
                NumberOfTapsRequired = 1
            };
            UITapGestureRecognizer DurationIvTgr = new UITapGestureRecognizer((s) => {
                DurationAction_TouchEvent(s, new EventArgs());
            })
            {
                CancelsTouchesInView = false,
                NumberOfTapsRequired = 1
            };
            DurationLbl.UserInteractionEnabled = true;
            DurationIv.UserInteractionEnabled = true;
            //Note: only a single gesture recogniser can be attached to an element
            //https://developer.apple.com/documentation/uikit/
            DurationLbl.AddGestureRecognizer(DurationLblTgr);
            DurationIv.AddGestureRecognizer(DurationIvTgr);
            CellInit();
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
                var set = this.CreateBindingSet<RecipeCell, RecipeCellData>();
                set.Bind(NameLbl).To(mv => mv.Name);
                set.Bind(DurationLbl).To(mv => mv.Duration);
                set.Apply();
            });
        }

        /**
         * Invokes event handler listened to by the table view source
         * https://docs.microsoft.com/en-us/dotnet/api/system.eventargs?redirectedfrom=MSDN&view=netframework-4.7.2
         */
        void DurationAction_TouchEvent(object sender, EventArgs e)
        {
            Console.Write("It reached the handler");
            if (DurationActionEvent != null)
            {
                DurationActionEvent.Invoke(this, new EventArgs());
            }
        }
    }
}

