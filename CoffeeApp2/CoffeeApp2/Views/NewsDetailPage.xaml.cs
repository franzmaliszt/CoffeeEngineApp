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
    public partial class NewsDetailPage : ContentPage
    {
        public NewsDetailPage(String Title, String Content, String ImageUrl)
        {
            InitializeComponent();

            TitleLabel.Text = Title;
            ContentLabel.Text = Content;
            NewsImage.Source = ImageUrl;
           

        }
        
        


    }
}