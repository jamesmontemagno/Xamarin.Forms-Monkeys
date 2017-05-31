using System;
using System.Collections.Generic;
using Monkeys.Models;
using Monkeys.ViewModels;
using Xamarin.Forms;

namespace Monkeys.Views
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Monkey monkey)
        {
            InitializeComponent();
            BindingContext = new DetailsViewModel(monkey);
        }

        public DetailsPage()
        {
            InitializeComponent();
            BindingContext = new DetailsViewModel();
        }
    }
}

