using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Monkeys.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

        }

        async void ButtonTraditionalClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MonkeysPage());
        }

        async void ButtonDataPagesClicked(object sender, System.EventArgs e)
        {
            await DisplayAlert("Coming soon", "Waiting on those new NuGets!", "OK");
        }
    }
}

