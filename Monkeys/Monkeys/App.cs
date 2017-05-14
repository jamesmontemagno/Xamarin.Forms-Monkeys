
using Monkeys.Models;
using Monkeys.ViewModels;
using Monkeys.Views;
using Xamarin.Forms;

namespace Monkeys
{
    public static class ViewModelLocator
    {

        static MonkeysViewModel monkeysVM;

        public static MonkeysViewModel MonkeysViewModel
        {
            get
            {
                if (monkeysVM != null)
                    return monkeysVM;

                monkeysVM = new MonkeysViewModel();
                monkeysVM.Monkeys.Add(new Monkey
                {
                    Name = "Baboon",
                    Location = "Africa & Asia",
                    Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                    Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
                });

                monkeysVM.Monkeys.Add(new Monkey
                {
                    Name = "Capuchin Monkey",
                    Location = "Central & South America",
                    Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                    Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
                });

                monkeysVM.Monkeys.Add(new Monkey
                {
                    Name = "Blue Monkey",
                    Location = "Central and East Africa",
                    Details = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
                    Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
                });
                return monkeysVM;
            }
        }

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

