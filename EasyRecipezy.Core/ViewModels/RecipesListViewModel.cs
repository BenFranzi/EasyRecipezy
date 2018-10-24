using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using EasyRecipezy.Core.Models;
using EasyRecipezy.Core.Services;
using EasyRecipezy.Core.ViewModels;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace EasyRecipezy.Core
{
    public class RecipesListViewModel : MvxViewModel
    {
        //Get recipes service singleton
        readonly IRecipesService _RecipesService;
        //Note: need to put an 'I' before the service, app will crash otherwise
        readonly IMvxNavigationService _NavigationService;

        public RecipesListViewModel(IRecipesService recipesService, IMvxNavigationService navigationService)
        {
            _RecipesService = recipesService;
            _NavigationService = navigationService;
        }

        public override async Task Initialize()
        {
            //Note: changed base from a return to an await to make this call async
            await base.Initialize();
            /* To use async retrieve functions you need to call them in this 
             * function 
             */
            Recipes = await _RecipesService.GetRecipes();

        }

        //Expose recipe list to view
        private List<Recipe> _recipes;
        public List<Recipe> Recipes
        {
            get { return _recipes; }
            set
            {
                _recipes = value;
                RaisePropertyChanged(() => Recipes);
            }
        }

        /**
         * ICommand handling navigation between views
         * https://www.mvvmcross.com/documentation/fundamentals/navigation
         */
        public virtual IMvxAsyncCommand<Recipe> ItemSelected
        {
            get
            {
                //Passes clicked item to next view model
                return new MvxAsyncCommand<Recipe>(async (item) => {
                    await _NavigationService.Navigate<SingleRecipeViewModel, Recipe>(item); //the next view model takes item as a parameter
                });
            }
        }

        public virtual IMvxAsyncCommand<Recipe> DurationOfItemSelected
        {
            get
            {
                //Passes clicked item to next view model
                return new MvxAsyncCommand<Recipe>(async (item) => {
                    //Modified object to demonstrate different click event
                    Recipe modifiedItem = new Recipe()
                    {
                        Name = item.Name + " from duration click event",
                        Difficulty = item.Difficulty,
                        Duration = item.Duration,
                        Ingredients = item.Ingredients,
                        Method = item.Method,
                        Image = item.Image
                };
                    await _NavigationService.Navigate<SingleRecipeViewModel, Recipe>(modifiedItem); //the next view model takes item as a parameter
                });
            }
        }


        /**
         * View model for the recipe cells in iOS to access the data from the recipes list.
         * This class isn't used in Android as the list objects are bound directly to the list items.
         */
        //Is not a ViewModel because it does not need to implement MvxViewModel
        public class RecipeCellData
        /** Note: If data is updated regularly in a cell view then it would need to
         * be implemented as a ViewModel to configure the RaisePropertyChanged()
         * function for the objects
         */
        {
            private string _name;
            public string Name
            {
                get { return _name; }
                set
                {
                    _name = value;
                }
            }

            private string _duration;
            public string Duration
            {
                get { return _duration; }
                set
                {
                    _duration = value;
                }
            }
        }
    }
}
