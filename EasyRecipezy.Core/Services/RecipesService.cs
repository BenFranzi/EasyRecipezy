using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyRecipezy.Core.DummyData;
using EasyRecipezy.Core.Models;
using Newtonsoft.Json;

namespace EasyRecipezy.Core.Services
{
    public class RecipesService : IRecipesService
    {
        public async Task<List<Recipe>> GetRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();
            string rawJson = await DummyRecipes.GetDummyData();
            recipes = JsonConvert.DeserializeObject<List<Recipe>>(rawJson);
            return recipes;
        }
    }
}
