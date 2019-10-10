using System;
using System.Collections.Generic;
using Monkeys.ViewModels;
using Xamarin.Forms;
using Monkeys.Models;
using System.ComponentModel;

namespace Monkeys.Views
{
    public partial class MonkeysPage : ContentPage
    {
        public MonkeysPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel(true);
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var monkey = ((ListView)sender).SelectedItem as Monkey;
            if (monkey == null)
                return;

            await Navigation.PushAsync(new DetailsPage(monkey));
        }
    }
}

