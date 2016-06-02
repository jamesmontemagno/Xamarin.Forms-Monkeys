using System;
using Monkeys.Helpers;
using Monkeys.ViewModels;
using Monkeys.Views;
using Xamarin.Forms;

namespace Monkeys
{

    public static class ViewModelLocator
    {
        static MonkeysViewModel monkeysVM;
        public static MonkeysViewModel MonkeysViewModel 
        => monkeysVM ?? (monkeysVM = new MonkeysViewModel());

        static DetailsViewModel detailsVM;
        public static DetailsViewModel DetailsViewModel
        => detailsVM ?? (detailsVM = new DetailsViewModel(MonkeyHelper.Monkeys[0]));
    }

    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new MonkeysPage())
            {
                BarTextColor = Color.White,
                BarBackgroundColor = Color.FromHex("#2196F3")
            };
        }



        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

