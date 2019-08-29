using System;
using Monkeys.Helpers;
using Monkeys.ViewModels;
using Monkeys.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]
namespace Monkeys
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new HomePage())
            {
                BarTextColor = Color.White,
                BarBackgroundColor = Color.FromHex("#F2C500")
            };
        }
    }
}

