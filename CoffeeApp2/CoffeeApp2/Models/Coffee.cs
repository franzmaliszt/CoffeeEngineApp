using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeApp2.Models
{
    public class Coffee
    {
        public String name { get; set; }
        public String roast { get; set; }
        public String brew { get; set; }
        public String extra { get; set; }
        public String rarity { get; set; }
        public String imagePath { get; set; }

        public Coffee()
        {

        }

        public Coffee(String name, String roast, String brew, String extra, String rarity, String imagePath)
        {
            this.name = name;
            this.roast = roast;
            this.brew = brew;
            this.extra = extra;
            this.rarity = rarity;
            this.imagePath = imagePath;
        }
    }    
}
