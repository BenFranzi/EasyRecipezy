using System;
using EasyRecipezy.Core.Services;
using MvvmCross;
using MvvmCross.ViewModels;

namespace EasyRecipezy.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            //Register services here and register app start viewmodel
            base.Initialize();
            /** Tells the IoC Container that whenever any code requests an 
             IRecipeService reference, an object of type 
             RecipeService should be created and returned. */

            //Note: register type does not generate a singleton
            //Mvx.IoCProvider.RegisterType<IRecipesService, RecipesService>(); //Singleton

            //USe RegisterSingleton to ensure that only one instance of the service is created
            Mvx.IoCProvider.RegisterSingleton<IRecipesService>(new RecipesService());
            RegisterAppStart<RecipesListViewModel>();
        }
    }
}
