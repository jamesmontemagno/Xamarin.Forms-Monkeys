using Monkeys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Monkeys.Views
{
  public partial class DetailsPage : ContentPage
  {
    public DetailsPage(Monkey monkey)
    {
      InitializeComponent();
      this.BindingContext = monkey;
    }
  }
}
