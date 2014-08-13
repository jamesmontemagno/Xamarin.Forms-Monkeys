using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkeys.Models
{
  public class Monkey
  {
    public string Name {get;set;}
    public string Location { get; set; }
    public string Details { get; set; }
    public string Image { get; set; }


    public string NameSort
    {
      get
      {
        if (string.IsNullOrWhiteSpace(Name) || Name.Length == 0)
          return "?";

        return Name[0].ToString().ToUpper();
      }
    }

  }
}
