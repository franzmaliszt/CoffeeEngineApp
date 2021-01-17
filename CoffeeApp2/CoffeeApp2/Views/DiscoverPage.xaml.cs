using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using CoffeeApp2.Models;
using CoffeeApp2.ViewModels;
using CoffeeApp2.Views;
using Xamarin.Forms.Internals;

namespace CoffeeApp2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoverPage : ContentPage
    {
        public DiscoverPage()
        {
            InitializeComponent();

            CoffeeShopViewModel csvm = new CoffeeShopViewModel();
            BindingContext = csvm;

            foreach (CoffeeShop shop in csvm.coffeeShopList)
            {
                var pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(shop.position[0], shop.position[1]),
                    Label = shop.name,
                    Address = shop.address
                };
                map.Pins.Add(pin);
            }            

            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(39.78284416176044, 30.51041779848248), Distance.FromMeters(500)));            
        }

        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as CoffeeShop;
            await Navigation.PushAsync(new CoffeeShopDetail(details.name, details.address, details.website, details.imageUrl, details.wifi, details.takeaway, details.sandwich, details.award));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            Action<double> callback = input => BottomSlider.HeightRequest = input;
            double startHeight = 0;
            double endHeight = mainDisplayInfo.Height / 3;
            uint rate = 32;
            uint length = 500;
            Easing easing = Easing.CubicOut;
            BottomSlider.Animate("anim", callback, startHeight, endHeight, rate, length, easing);

            DetailsButton.IsVisible = false;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            Action<double> callback = input => BottomSlider.HeightRequest = input;
            double startHeight = mainDisplayInfo.Height / 3;
            double endiendHeight = 0;
            uint rate = 32;
            uint length = 500;
            Easing easing = Easing.SinOut;
            BottomSlider.Animate("anim", callback, startHeight, endiendHeight, rate, length, easing);

            DetailsButton.IsVisible = true;
        }
    }
}