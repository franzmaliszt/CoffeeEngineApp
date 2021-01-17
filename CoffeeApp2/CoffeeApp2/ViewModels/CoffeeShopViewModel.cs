using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using CoffeeApp2.Models;

namespace CoffeeApp2.ViewModels
{
    class CoffeeShopViewModel
    {
        public ObservableCollection<CoffeeShop> coffeeShopList { get; set; }
        
        public CoffeeShopViewModel()
        {
            coffeeShopList = new ObservableCollection<CoffeeShop>();
            
            coffeeShopList.Add(new CoffeeShop(
                "Black Cat Coffee", 
                "Eskibağlar, No:, Baydemir Sk. No:12, 26170 Tepebaşı",
                "-",
                "https://10619-2.s.cdn12.com/rests/original/506_53781829.jpg", 
                new double[] { 39.78161707827267, 30.515460525115294 }, 
                true, 
                true, 
                false, 
                true
                ));
            coffeeShopList.Add(new CoffeeShop(
                "Hey Joe Coffee Co.", 
                "Güllük, Bacı Sk. No:4/A, 26170 Tepebaşı/Eskişehir",
                "-",
                "https://sehrirehber.com/images/rt2282.jpg", 
                new double[] { 39.781873605573665, 30.515649983732747 }, 
                true, 
                true, 
                true, 
                true
                ));
            coffeeShopList.Add(new CoffeeShop(
                "Kokopelli Coffee Co.", 
                "İstiklal, Sökmen Sk. No:7/B, 26040 Odunpazarı/Eskişehir",
                "-",
                "https://www.eskisehir.net/images/upload/koko_02.jpg", 
                new double[] {39.77523061895875, 30.514414656013678}, 
                false, 
                true, 
                true, 
                false
                ));
            coffeeShopList.Add(new CoffeeShop(
                "Ispanyol Kultur & Mucho Gusto",
                "Eskibağlar, Yenilik Sk. No:18, 26170 Tepebaşı/Eskişehir",
                "http://muchogusto.com.tr/",
                "https://neyiyo.com/wp-content/uploads/2019/03/20190221_155822.jpg",
                new double[] { 39.78397635102537, 30.5117818475608 },
                true,
                true,
                true,
                true
                ));
            coffeeShopList.Add(new CoffeeShop(
                "Arabica Cafe Collesium",
                "Eskibağlar, Genez Sk. no:3, 26170 Tepebaşı/Eskişehir",
                "https://arabicacoffee.com.tr/",
                "https://arabicacoffee.com.tr/assets/images/branchs/branchspicture_0391887001541079926.jpg",
                new double[] { 39.783533196540006, 30.512929832894997 },
                true,
                true,
                false,
                false
                ));
        }        
    }
}
