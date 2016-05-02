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
  public partial class MonkeysPage : ContentPage
  {
    public MonkeysPage()
    {
      InitializeComponent();

      this.BindingContext = new MonkeysViewModel();
    }

    public void OnItemSelected(object sender, ItemTappedEventArgs args)
    {
      var monkey = args.Item as Monkey;
      if (monkey == null)
        return;

      Navigation.PushAsync(new DetailsPage(monkey));
      // Reset the selected item
      list.SelectedItem = null;
    }
  }
}
