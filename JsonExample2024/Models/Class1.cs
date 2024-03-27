using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonExample2024.Models
{


    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public int Population { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }

    public class MonkeyList
    {
        public List<Monkey> Monkeys { get; set; }
        public void FillList()
        {
            string text = File.ReadAllText(@"../../../monkeydata.json");
            Monkeys = JsonSerializer.Deserialize<List<Monkey>>(text);
        }
        public static void newList(string text)
        {
            MonkeyList list = new MonkeyList();
        }
    }

    public class Joke
    {

        public class Rootobject
        {
            public bool error { get; set; }
            public string category { get; set; }
            public string type { get; set; }
            public string setup { get; set; }
            public string delivery { get; set; }
            public Flags flags { get; set; }
            public int id { get; set; }
            public bool safe { get; set; }
            public string lang { get; set; }
        }

        public class Flags
        {
            public bool nsfw { get; set; }
            public bool religious { get; set; }
            public bool political { get; set; }
            public bool racist { get; set; }
            public bool sexist { get; set; }
            public bool _explicit { get; set; }
        }

    }




}
