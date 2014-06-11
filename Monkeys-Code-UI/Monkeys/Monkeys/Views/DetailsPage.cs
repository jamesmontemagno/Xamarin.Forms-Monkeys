using Monkeys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Monkeys.Views
{
  public class DetailsPage : ContentPage
  {
    public DetailsPage(Monkey monkey)
    {
      this.Title = monkey.Name;

      var details = new Label{
        Text = monkey.Details
      };

      Content = new ScrollView
      {
        Padding = 20,
        Content = details
      };
    }
  }
}
