using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Monkeys.Utils;

namespace Monkeys.Views
{
	public class Monkey
	{
		public string Name {get;set;}
		public string Location { get; set; }
		public string Details { get; set; }
		//URL for our monkey image!
		public string Image { get; set; }
	}

  public class MonkeysPage : ContentPage
  {

		ObservableCollection<Monkey> Monkeys;
    public MonkeysPage()
    {
      Title = "Monkeys";
			Monkeys = new ObservableCollection<Monkey> ();

      var list = new ListView();
      list.ItemsSource = Monkeys;

      var cell = new DataTemplate(typeof(ImageCell));
      
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

			var addMonkeyButton = new Button {
				Text = "Add Monkey"
			};

			addMonkeyButton.Clicked += (sender, e) => {
				Monkeys.Add(MonkeyHelper.GetRandomMonkey());
			};

			var stack = new StackLayout {
				Children = { list, addMonkeyButton }
			};

      Content = stack;
    }
	}
}
