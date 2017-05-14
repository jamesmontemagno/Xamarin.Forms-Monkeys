using Newtonsoft.Json;
using System.ComponentModel;
using MvvmHelpers;

namespace Monkeys.Models
{
    public class Monkey : ObservableObject
    {
        string name;
        public string Name
        {
            get { return name; }
            set
            {
                if(SetProperty(ref name, value))
                {
                    //do something
                }
                else
                {
                    //do something else
                }
            }
        }
        public string Location { get; set; }

        public string Details { get; set; }

        public string Image { get; set; }

        [JsonIgnore]
        public string NameSort => Name[0].ToString();
    }
}

