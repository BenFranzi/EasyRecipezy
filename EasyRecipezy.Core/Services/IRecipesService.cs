using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyRecipezy.Core.Models;

namespace EasyRecipezy.Core.Services
{
    public interface IRecipesService
    {
        Task<List<Recipe>> GetRecipes();
    }
}
