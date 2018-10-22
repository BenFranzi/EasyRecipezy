using System;
using System.Collections.Generic;
using System.Reflection;
using EasyRecipezy.Core;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Platforms.Android.Core;

namespace EasyRecipezy.Droid
{
    /**
     * Setup is used to configure plugins and libraries
     */
    public class Setup : MvxAndroidSetup<App>
    {
        //REVISE: what does this function do
        protected override IEnumerable<Assembly> AndroidViewAssemblies => new List<Assembly>(base.AndroidViewAssemblies)
        {
            typeof(MvxRecyclerView).Assembly
        };
    }
}
