using Monkeys.Helpers;
using Monkeys.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkeys.ViewModels
{
  public class MonkeysViewModel
  {
    public ObservableCollection<Monkey> Monkeys { get; set; }
    public ObservableCollection<Grouping<string, Monkey>> MonkeysGrouped { get; set; }

    public MonkeysViewModel()
    {
      Monkeys = new ObservableCollection<Monkey>();
      Monkeys.Add(new Monkey
      {
       Name = "Baboon",
       Location = "Africa & Asia",
       Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
       Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
      });

      Monkeys.Add(new Monkey
      {
        Name = "Capuchin Monkey",
        Location = "Central & South America",
        Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
        Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
      });

      Monkeys.Add(new Monkey
      {
        Name = "Blue Monkey",
        Location = "Central and East Africa",
        Details = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
        Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
      });


      Monkeys.Add(new Monkey
      {
        Name = "Squirrel Monkey",
        Location = "Central & South America",
        Details = "The squirrel monkeys are the New World monkeys of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The name of the genus Saimiri is of Tupi origin, and was also used as an English name by early researchers.",
        Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
      });

      Monkeys.Add(new Monkey
      {
        Name = "Golden Lion Tamarin",
        Location = "Brazil",
        Details = "The golden lion tamarin also known as the golden marmoset, is a small New World monkey of the family Callitrichidae.",
        Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
      });

      Monkeys.Add(new Monkey
      {
        Name = "Howler Monkey",
        Location = "South America",
        Details = "Howler monkeys are among the largest of the New World monkeys. Fifteen species are currently recognised. Previously classified in the family Cebidae, they are now placed in the family Atelidae.",
        Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
      });

      Monkeys.Add(new Monkey
      {
        Name = "Japanese Macaque",
        Location = "Japan",
        Details = "The Japanese macaque, is a terrestrial Old World monkey species native to Japan. They are also sometimes known as the snow monkey because they live in areas where snow covers the ground for months each",
        Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
      });

      Monkeys.Add(new Monkey
      {
        Name = "Mandrill",
        Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
        Details = "The mandrill is a primate of the Old World monkey family, closely related to the baboons and even more closely to the drill. It is found in southern Cameroon, Gabon, Equatorial Guinea, and Congo.",
        Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"
      });

      Monkeys.Add(new Monkey
      {
        Name = "Proboscis Monkey",
        Location = "Borneo",
        Details = "The proboscis monkey or long-nosed monkey, known as the bekantan in Malay, is a reddish-brown arboreal Old World monkey that is endemic to the south-east Asian island of Borneo.",
        Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/250px-Proboscis_Monkey_in_Borneo.jpg"
      });

      Monkeys.Add(new Monkey
      {
        Name = "Spider Monkey",
        Location = "Central and South America",
        Details = "Spider monkeys of the genus Ateles are New World monkeys in the subfamily Atelinae, family Atelidae. Like other atelines, they are found in tropical forests of Central and South America, from southern Mexico to Brazil.",
        Image = "http://upload.wikimedia.org/wikipedia/commons/8/83/Spider_monkey_-Belize_Zoo-8b.jpg"
      });

      Monkeys.Add(new Monkey
      {
        Name = "Saki Monkey",
        Location = "South America",
        Details = "Sakis, or saki monkeys, are any of several New World monkeys of the genus Pithecia.[1] They are closely related to the bearded sakis of genus Chiropotes.",
        Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/WhiteFacedSaki.jpg/200px-WhiteFacedSaki.jpg"
      });

      Monkeys.Add(new Monkey
      {
        Name = "Emperor Tamarin",
        Location = "Amazon Basin",
        Details = "The emperor tamarin, is a species of tamarin allegedly named for its resemblance to the German emperor Wilhelm II. It lives in the southwest Amazon Basin, in east Peru, north Bolivia and in the west Brazilian states of Acre and Amazonas",
        Image = "http://upload.wikimedia.org/wikipedia/commons/5/55/Tamarin_portrait.JPG"
      });

      Monkeys.Add(new Monkey
      {
        Name = "Spectacled Langur",
        Location = "Malaysia",
        Details = "The dusky leaf monkey, spectacled langur, or spectacled leaf monkey (Trachypithecus obscurus) is a species of primate in the Cercopithecidae family. It is found in Malaysia, Burma, and Thailand.",
        Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Dusky_leaf_monkey%2C_Trachypithecus_obscurus.jpg/220px-Dusky_leaf_monkey%2C_Trachypithecus_obscurus.jpg"
      });

      Monkeys.Add(new Monkey
      {
        Name = "Colobus Monkey",
        Location = "Africa",
        Details = "Black-and-white colobuses (or colobi) are Old World monkeys of the genus Colobus, native to Africa. They are closely related to the brown colobus monkeys of genus Piliocolobus.[1] The word 'colobus' comes from Greek κολοβός kolobós ('docked'), and is so named because in this genus, the thumb is a stump. Colobuses are herbivorous, eating leaves, fruit, flowers, and twigs. Their habitats include primary and secondary forests, riverine forests, and wooded grasslands; they are found more in higher-density logged forests than in other primary forests. Their ruminant-like digestive systems have enabled these leaf-eaters to occupy niches that are inaccessible to other primates.",
        Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/6/6b/Colubusmonkey.JPG/200px-Colubusmonkey.JPG"
      });

      Monkeys.Add(new Monkey
      {
        Name = "De Brazza's Monkey",
        Location = "Africa",
        Details = "De Brazza's monkey (Cercopithecus neglectus) is an Old World monkey endemic to the wetlands of central Africa. It is one of the most widespread African primates that live in forests.",
        Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Cercopithecus_neglectus.jpg/220px-Cercopithecus_neglectus.jpg"
      });

      Monkeys.Add(new Monkey
      {
        Name = "Chimpanzee",
        Location = "West and Central Africa",
        Details = "Chimpanzees, sometimes colloquially chimps, are two extant hominid species of apes in the genus Pan. The Congo River divides the native habitats of the two species",
        Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/6/62/Schimpanse_Zoo_Leipzig.jpg/220px-Schimpanse_Zoo_Leipzig.jpg"
      });

      var sorted = from monkey in Monkeys
                   orderby monkey.Name
                   group monkey by monkey.NameSort into monkeyGroup
                   select new Grouping<string, Monkey>(monkeyGroup.Key, monkeyGroup);

      MonkeysGrouped = new ObservableCollection<Grouping<string, Monkey>>(sorted);
    }
  }
}
