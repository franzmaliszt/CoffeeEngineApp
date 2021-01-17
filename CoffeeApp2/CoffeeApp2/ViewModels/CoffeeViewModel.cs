using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using CoffeeApp2.Models;

namespace CoffeeApp2.ViewModels
{
    class CoffeeViewModel
    {
        public ObservableCollection<Coffee> coffeeList { get; set; }

        public Coffee FindClosest(String roast, String brew, String extra, String rarity)
        {
            Coffee bestMatch = new Coffee();
            int bestCount = 0;

            foreach (Coffee coffee in coffeeList)
            {
                int count = 0;

                if (coffee.roast == roast)
                    count++;
                if (coffee.brew == brew)
                    count++;
                if (coffee.extra == extra)
                    count++;
                if (coffee.rarity == rarity)
                    count++;

                if (count >= bestCount)
                {
                    bestCount = count;
                    bestMatch = coffee;
                }
                    
            }

            return bestMatch;
        }

        public CoffeeViewModel()
        {
            coffeeList = new ObservableCollection<Coffee>();

            coffeeList.Add(new Coffee(
                "Ethiopia Deri Kochoha",
                "Light",
                "Mocha",
                "Sugar",
                "Authentic",
                "americano.png"
                ));
            coffeeList.Add(new Coffee(
                "Kenya Ruthaka Peaberry",
                "Light",
                "Mocha",
                "Milk",
                "Classic",
                "cappuccino.png"
                ));
            coffeeList.Add(new Coffee(
                "Ethiopia Gora Kone Sidamo",
                "Dark",
                "Chemex",
                "Black",
                "Authentic",
                "americano_ice.png"
                ));
            coffeeList.Add(new Coffee(
                "Honduras Les Flores Parainema",
                "Light",
                "Chemex",
                "Black",
                "Authentic",
                "chocolate.png"
                ));
            coffeeList.Add(new Coffee(
                "Santa Luzia Brazil",
                "Medium",
                "Cold",
                "Milk",
                "Authentic",
                "espresso.png"
                ));
            coffeeList.Add(new Coffee(
                "Porfirio Castellanos Honduras",
                "Light",
                "Mocha",
                "Syrup",
                "Classic",
                "espresso_ice.png"
                ));
            coffeeList.Add(new Coffee(
                "Ethiopia Yirgacheffe Awassa",
                "Dark",
                "Chemex",
                "Black",
                "Authentic",
                "flat_white_ice.png"
                ));
            coffeeList.Add(new Coffee(
                "Kenya Murunga New Gatanga",
                "Medium",
                "French",
                "Sugar",
                "Classic",
                "flat_white.png"
                ));
            coffeeList.Add(new Coffee(
                "Costa Rica Volcan Azul",
                "Medium",
                "Cold",
                "Syrup",
                "Classic",
                "latte.png"
                ));
            coffeeList.Add(new Coffee(
                "Poseidon Blend",
                "Medium",
                "Cold",
                "Milk",
                "Classic",
                "latte_ice.png"
                ));
            coffeeList.Add(new Coffee(
                "Guatemela Finca San Gerardo",
                "Dark",
                "French",
                "Syrup",
                "Classic",
                "macchiato.png"
                ));
            coffeeList.Add(new Coffee(
                "Ethiopia Washed Phoenix",
                "Dark",
                "French",
                "Sugar",
                "Authentic",
                "macchiato_ice.png"
                ));
            coffeeList.Add(new Coffee(
                "Camilina Geisha Auromar",
                "Light",
                "French",
                "Black",
                "Authentic",
                "mocha.png"
                ));
        }
    }
}
