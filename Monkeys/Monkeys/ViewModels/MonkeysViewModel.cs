using Monkeys.Models;
using MvvmHelpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Monkeys.ViewModels
{
    public class MonkeysViewModel : BaseViewModel
    {
        public MonkeysViewModel()
        {
            Title = "Monkeys";
            Monkeys = new ObservableRangeCollection<Monkey>();

            Monkeys.CollectionChanged += (sender, args) =>
            {
                Debug.WriteLine($"Item {args.Action}");
            };

            GetMonkeysCommand = new Command(async () => await GetMonkeysAsync());
        }

        public ObservableRangeCollection<Monkey> Monkeys { get; set; }
        public Command GetMonkeysCommand { get; }

#region Grouping
        public ObservableRangeCollection<Grouping<string, Monkey>> MonkeysGrouped { get; } = new ObservableRangeCollection<Grouping<string, Monkey>>();
        void Sort()
        {
            var sorted = from monkey in Monkeys
                         orderby monkey.Name
                         group monkey by monkey.NameSort into monkeyGroup
                         select new Grouping<string, Monkey>(monkeyGroup.Key, monkeyGroup);

            MonkeysGrouped.ReplaceRange(sorted);
        }
#endregion



        public async Task GetMonkeysAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;

                var url = "http://montemagno.com/monkeys.json";
                var client = new HttpClient();

                var json = await client.GetStringAsync(url).WithTimeout(TimeSpan.FromSeconds(10).Milliseconds);

                var monkeys = JsonConvert.DeserializeObject<IEnumerable<Monkey>>(json);

                Monkeys.ReplaceRange(monkeys);


                Sort();


                Title = $"{Monkeys.Count} Monkeys in {MonkeysGrouped.Count} groups";

            }
            catch (System.Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
        
    }
}
