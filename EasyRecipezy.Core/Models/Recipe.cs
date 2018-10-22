using System;
using Newtonsoft.Json;

namespace EasyRecipezy.Core.Models
{
    /**
     * Basic structure of a JSON Obj in C#
     * 
     *  private string ingredients;
        [JsonProperty("ingredients")]
        public string Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
     */

    [JsonObject]
    public class Recipe
    {
        private string ingredients;
        [JsonProperty("ingredients")]
        public string Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
        private string method;
        [JsonProperty("method")]
        public string Method
        {
            get { return method; }
            set { method = value; }
        }
        private string name;
        [JsonProperty("name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string duration;
        [JsonProperty("duration")]
        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        private string difficulty;
        [JsonProperty("difficulty")]
        public string Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }
        private string image;
        [JsonProperty("image")]
        public string Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}
