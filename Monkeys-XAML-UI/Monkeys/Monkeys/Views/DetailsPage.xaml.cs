using Monkeys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkeys.Views
{
  public partial class DetailsPage
  {
    public DetailsPage(Monkey monkey)
    {
      InitializeComponent();
      this.BindingContext = monkey;
    }
  }
}
