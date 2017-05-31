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

            //var names = LookupName(1);
            //((Button)sender).Text = names.first + " " + names.last; 
        }

        (string first, string middle, string last) LookupName(long id) // tuple return type
		{
		    return ("James", "G", "Montemagno"); // tuple literal
		}



    }
}

