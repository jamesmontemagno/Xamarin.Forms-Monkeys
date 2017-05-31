using System;
using Monkeys.Models;

namespace Monkeys.ViewModels
{
    public class DetailsViewModel
    {
        public Monkey Monkey { get; set; }
        public DetailsViewModel(Monkey monkey)
        {
            Monkey = monkey;
        }
    }
}

