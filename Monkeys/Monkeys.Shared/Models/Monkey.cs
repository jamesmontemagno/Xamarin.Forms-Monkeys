namespace Monkeys.Models
{
    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        //URL for our monkey image!
        public string Image { get; set; }

        public string NameSort => Name[0].ToString();

        public override string ToString()
        {
            return string.Format("[Monkey: Name={0}, Location={1}, Details={2}, Image={3}, NameSort={4}]", Name, Location, Details, Image, NameSort);
        }

    }
}

