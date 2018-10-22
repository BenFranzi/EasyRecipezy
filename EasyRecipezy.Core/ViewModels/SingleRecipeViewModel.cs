using System;
using EasyRecipezy.Core.Models;
using MvvmCross.ViewModels;

namespace EasyRecipezy.Core.ViewModels
{
    public class SingleRecipeViewModel : MvxViewModel<Recipe>
    {
        /**
         * Gets the passed parameter from the previous viewmodel
         * To send a parameter to a view you need to put it in the generic
         * implementation at the class MvxViewModel call
         * https://www.mvvmcross.com/documentation/fundamentals/viewmodel-lifecycle
         */
        //Note: Prepare is called before initialise
        //Note: Only values should be assigned in this section, all heavy processing should be done in initialize()
        public override void Prepare(Recipe parameter)
        {
            base.Prepare();
            _recipe = parameter;
        }
        /**
         * Expose recipe list to view
         */
        private Recipe _recipe;
        public Recipe Recipe
        {
            get => _recipe;
            set
            {
                _recipe = value;
                //RaisePropertyChanged(() => Recipe);
                /**
                 * Set property is used incase the object needs to updated regularly.
                 * When RaisePropertyChanged() is called the view is updated, SetProperty()
                 * only updates the view if the value of the data has been altered.
                 */
                SetProperty(ref _recipe, value);
            }
        }
    }
}
