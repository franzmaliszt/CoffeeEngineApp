using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeApp2.Models
{
    public class CoffeeShop
    {
        public String name { get; set; }
        public String address { get; set; }
        public String website { get; set; }
        public String imageUrl { get; set; }
        public double[] position { get; set; }
        public bool wifi { get; set; }
        public bool takeaway { get; set; }
        public bool sandwich { get; set; }
        public bool award { get; set; }

        public CoffeeShop(String name, String address, String website, String imageUrl, double[] position, bool wifi, bool takeaway, bool sandwich, bool award)
        {
            this.name = name;
            this.address = address;
            this.website = website;
            this.imageUrl = imageUrl;
            this.position = position;
            this.wifi = wifi;
            this.takeaway = takeaway;
            this.sandwich = sandwich;
            this.award = award;
        }
    }
}
