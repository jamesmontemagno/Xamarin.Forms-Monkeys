using Monkeys.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Monkeys
{
  public class App
  {
    public static Page GetMainPage()
    {
      var monkeys = new MonkeysPage();
      return new NavigationPage(monkeys);
    }
  }
}
