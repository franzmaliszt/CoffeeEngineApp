using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeApp2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeShopDetail : ContentPage
    {
        public CoffeeShopDetail(String name, String address, String website, String imageUrl, bool wifi, bool takeaway, bool sandwich, bool award)
        {
            InitializeComponent();

            ItemName.Text = name;
            ItemAddress.Text = address;
            ItemWebsite.Text = website;
            ItemImage.Source = imageUrl;
            WifiIcon.IsVisible = wifi;
            TakeawayIcon.IsVisible = takeaway;
            FoodIcon.IsVisible = sandwich;
            AwardIcon.IsVisible = award;
        }
    }
}