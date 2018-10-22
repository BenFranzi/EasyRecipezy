using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using static EasyRecipezy.Core.RecipesListViewModel;

namespace EasyRecipezy.iOS.Views.Cells
{
    public partial class RecipeCell : MvxTableViewCell
    {
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
    }
}

