using Monkeys.Helpers;
using Monkeys.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace Monkeys.ViewModels
{
    public class MonkeysViewModel
    {
        public ObservableCollection<Monkey> Monkeys { get; set; }
        public ObservableCollection<Grouping<string, Monkey>> MonkeysGrouped { get; set; }

        public MonkeysViewModel()
        {

        }
        public MonkeysViewModel(bool designData)
        {
            if (designData)
            { 
                Monkeys = MonkeyHelper.Monkeys;
                MonkeysGrouped = MonkeyHelper.MonkeysGrouped;
            }
            else
            {
                //Setup web requests and such
            }
        }

        public bool IsBusy { get; set; }

        public int MonkeyCount => Monkeys?.Count ?? 0;
    }
}
