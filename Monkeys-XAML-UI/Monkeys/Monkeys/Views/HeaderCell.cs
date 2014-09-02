using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Monkeys.Views
{
  public class HeaderCell : ViewCell
  {
    public HeaderCell()
    {
      this.Height = 25;
      var title = new Label
      {
        Font = Font.SystemFontOfSize(NamedSize.Small, FontAttributes.Bold),
        TextColor = Color.White,
        VerticalOptions = LayoutOptions.Center
      };

      title.SetBinding(Label.TextProperty, "Key");

      View = new StackLayout
      {
        HorizontalOptions = LayoutOptions.FillAndExpand,
        HeightRequest = 25,
        BackgroundColor = Color.FromRgb(52, 152, 218),
        Padding = 5,
        Orientation = StackOrientation.Horizontal,
        Children = { title }
      };
    }
  }
}
