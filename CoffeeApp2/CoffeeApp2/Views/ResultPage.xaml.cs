using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CoffeeApp2.ViewModels;
using CoffeeApp2.Models;

namespace CoffeeApp2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage : ContentPage
    {        
        public ResultPage(String roast, String brew, String extra, String rarity)
        {
            InitializeComponent();

            CoffeeViewModel cvm = new CoffeeViewModel();            
            Coffee match = cvm.FindClosest(roast, brew, extra, rarity);

            imgName.Source = match.imagePath;
            lblName.Text = match.name;
            lblRoast.Text = match.roast;
            lblBrew.Text = match.brew;
            lblExtra.Text = match.extra;
            lblRarity.Text = match.rarity;
        }             
    }
}