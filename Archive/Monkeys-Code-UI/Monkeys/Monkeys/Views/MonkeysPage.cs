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

      list.ItemsSource = viewModel.MonkeysGrouped;
      list.IsGroupingEnabled = true;
      list.GroupDisplayBinding = new Binding("Key");
      list.GroupShortNameBinding = new Binding("Key");
      if(Device.OS != TargetPlatform.WinPhone)
        list.GroupHeaderTemplate = new DataTemplate(typeof(HeaderCell));
      list.HasUnevenRows = true; // if using a custom template for each cell you might want to enable this.

      var cell = new DataTemplate(typeof(AspectImageCell));
      
      cell.SetBinding(TextCell.TextProperty, "Name");
      cell.SetBinding(TextCell.DetailProperty, "Location");
      cell.SetBinding(ImageCell.ImageSourceProperty, "Image");

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

  public class AspectImageCell : ImageCell
  {
  }
}
