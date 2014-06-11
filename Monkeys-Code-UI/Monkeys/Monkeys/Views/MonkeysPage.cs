using Monkeys.Models;
using Monkeys.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Monkeys.Views
{
  public class MonkeysPage : ContentPage
  {
    public MonkeysPage()
    {
      Title = "Monkeys";
      
      var list = new ListView();
      var viewModel = new MonkeysViewModel();
      list.ItemsSource = viewModel.Monkeys;

      var cell = new DataTemplate(typeof(TextCell));
      
      cell.SetBinding(TextCell.TextProperty, "Name");
      cell.SetBinding(TextCell.DetailProperty, "Location");

      list.ItemTemplate = cell;

      list.ItemTapped += (sender, args) =>
      {
        var monkey = args.Item as Monkey;
        if (monkey == null)
          return;

        Navigation.PushAsync(new DetailsPage(monkey));
        // Reset the selected item
        list.SelectedItem = null;
      };

      Content = list;
    }
  }
}
