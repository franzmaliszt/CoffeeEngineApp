
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
        private String roast, brew, extra, rarity;

        public SearchPage()
        {
            InitializeComponent();            
        }
        
        
        private void btnStart_Clicked(object sender, EventArgs e)
        {
             scrollView.ScrollToAsync(490, 0, true);
             btnBack.IsVisible = true;
            
            
        }
        private void btnBack_Clicked(object sender, EventArgs e)
        {
            scrollView.ScrollToAsync(0,0,true);
        }

        //First step button
        private void OnFirstClick(object sender, EventArgs e)
        {
            ImageButton btn1 = sender as ImageButton;
            roast = btn1.ClassId;
            
            scrollView.ScrollToAsync(880, 0, true);
        }

        //Second step button
        private void OnSecondClick(object sender, EventArgs e)
        {
            ImageButton btn2 = sender as ImageButton;
            brew = btn2.ClassId;

            scrollView.ScrollToAsync(1335, 0, true);
        }

        //Third step button
        private void OnThirdClick(object sender, EventArgs e)
        {
            ImageButton btn3 = sender as ImageButton;
            extra = btn3.ClassId;

            scrollView.ScrollToAsync(1830, 0, true);
        }

        //Fourth step button
        private void OnFourthClick(object sender, EventArgs e)
        {
            Label btn4 = sender as Label;
            rarity = btn4.ClassId;

            Navigation.PushAsync(new ResultPage(roast, brew, extra, rarity));
        }
    }
}