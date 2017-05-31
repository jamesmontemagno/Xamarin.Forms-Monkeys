using System;
using System.Collections.Generic;
using Monkeys.ViewModels;
using Xamarin.Forms;
using Monkeys.Models;

namespace Monkeys.Views
{
    public partial class MonkeysPage : ContentPage
    {
        public MonkeysPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
            => ((ListView)sender).SelectedItem = null;


        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var monkey = e.SelectedItem as Monkey;
            if (monkey == null)
                return;
            await Navigation.PushAsync(new DetailsPage(monkey), true);

            ((ListView)sender).SelectedItem = null;
        }
    }
}

