using Monkeys.Helpers;
using Monkeys.Models;
using MvvmHelpers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Monkeys.ViewModels
{
    public class MonkeysViewModel
    {
        public int Location { get; set; }
        public List<string> LocationList => new List<string>
        {
            "Africa",
            "Asia",
            "Central America",
            "South America"
        };
       
        public MonkeysViewModel()
        {
            Monkeys = new ObservableRangeCollection<Monkey>();
            GetMonkeysCommand = new Command(async () => await GetMonkeysAsync());
        }

        public Command GetMonkeysCommand { get; }


        public ObservableRangeCollection<Monkey> Monkeys { get; set; }
        public async Task GetMonkeysAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var url = "https://mobile-ocr.azurewebsites.net/api/Monkeys";

                    var input = JsonConvert.SerializeObject(new { name = LocationList[Location] });
                    var res = await client.PostAsync(url,
                        new StringContent(input, Encoding.UTF8,"application/json"));

                    var json = await res.Content.ReadAsStringAsync();

                    var monkeys = JsonConvert.DeserializeObject<IEnumerable<Monkey>>(json);

                    Monkeys.ReplaceRange(monkeys);
                }
            }
            catch (System.Exception ex)
            {
                //Something has gone wrong
                Debug.WriteLine(ex);

            }
        }
           

        public int MonkeyCount => Monkeys.Count;
    }
}
