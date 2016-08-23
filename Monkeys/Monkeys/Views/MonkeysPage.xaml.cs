using System;
using System.Collections.Generic;
using Monkeys.ViewModels;
using Xamarin.Forms;
using Monkeys.Models;

namespace Monkeys.Views
{
    public partial class MonkeysPage : ContentPage
    {
        MonkeysViewModel viewModel;
        public MonkeysPage()
        {
            InitializeComponent();

            viewModel = new MonkeysViewModel();
            foreach (var item in viewModel.LocationList)
                LocationPicker.Items.Add(item);

            BindingContext = viewModel;
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var monkey = ((ListView)sender).SelectedItem as Monkey;
            if (monkey == null)
                return;


        }
    }
}

