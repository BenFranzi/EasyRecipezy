using System;
using Android.App;
using Android.Runtime;
using EasyRecipezy.Core;
using MvvmCross.Platforms.Android.Views;

namespace EasyRecipezy.Droid
{
    //Need to include 'Application'
    [Application]
    public class MainApplication : MvxAndroidApplication<Setup, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        //Note: you need to include a reference to 'Mono.Android.Export' inorder to compile the application
        //Note: you need MvvmCross.Droid.Support.V7.RecyclerView and Xamarin.Android.Support.v4 to use recyclerviews
    }
}
