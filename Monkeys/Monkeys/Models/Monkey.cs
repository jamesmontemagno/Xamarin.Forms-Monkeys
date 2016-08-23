using Newtonsoft.Json;

namespace Monkeys.Models
{
    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        //URL for our monkey image!
        public string Image { get; set; }

        [JsonIgnore]
        public string NameSort => Name[0].ToString();
    }
}

