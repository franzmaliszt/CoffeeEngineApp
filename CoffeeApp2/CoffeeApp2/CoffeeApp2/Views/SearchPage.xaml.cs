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
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        async void first_Clicked(object sender, System.EventArgs e)
        {
            await firstButton_first.TranslateTo(-300, 0, 250);
            await secondButton_first.TranslateTo(-300, 0, 250);
            await thirdButton_first.TranslateTo(-350, 0, 250);
            await fourthButton_first.TranslateTo(-350, 0, 250);

            await ScrollS.ScrollToAsync(FirstOption, ScrollToPosition.Center, true);
        }

        async void second_Clicked(object sender, EventArgs e)
        {
            await firstButton_second.TranslateTo(-300, 0, 250);
            await secondButton_second.TranslateTo(-300, 0, 250);
            await thirdButton_second.TranslateTo(-350, 0, 250);
            await fourthButton_second.TranslateTo(-350, 0, 250);
        }

        async void third_Clicked(object sender, EventArgs e)
        {
            await firstButton_third.TranslateTo(-300, 0, 250);
            await secondButton_third.TranslateTo(-300, 0, 250);
            await thirdButton_third.TranslateTo(-350, 0, 250);
            await fourthButton_third.TranslateTo(-350, 0, 250);
        }

        async void fourth_Clicked(object sender, EventArgs e)
        {
            await firstButton_fourth.TranslateTo(-300, 0, 250);
            await secondButton_fourth.TranslateTo(-300, 0, 250);
            await thirdButton_fourth.TranslateTo(-350, 0, 250);
            await fourthButton_fourth.TranslateTo(-350, 0, 250);
        }

        async void fifth_Clicked(object sender, EventArgs e)
        {
            await firstButton_fifth.TranslateTo(-300, 0, 250);
            await secondButton_fifth.TranslateTo(-300, 0, 250);
            await thirdButton_fifth.TranslateTo(-350, 0, 250);
            await fourthButton_fifth.TranslateTo(-350, 0, 250);
        }

        async void sixth_Clicked(object sender, EventArgs e)
        {
            await firstButton_sixth.TranslateTo(-300, 0, 250);
            await secondButton_sixth.TranslateTo(-300, 0, 250);
            await thirdButton_sixth.TranslateTo(-350, 0, 250);
            await fourthButton_sixth.TranslateTo(-350, 0, 250);
        }
    }
}