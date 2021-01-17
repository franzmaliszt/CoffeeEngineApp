using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CoffeeApp2.Models;
using CoffeeApp2.ViewModels;
using CoffeeApp2.Views;

namespace CoffeeApp2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BlogPage : ContentPage
    {
        public BlogPage()
        {
            InitializeComponent();

            NewsViewModel nvm = new NewsViewModel();
            BindingContext = nvm;
        }

        private async void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            var tappedItem = e.Item as News;

            await Navigation.PushAsync(new NewsDetailPage(tappedItem.Title, tappedItem.Content, tappedItem.ImageUrl));
        }
    }
}