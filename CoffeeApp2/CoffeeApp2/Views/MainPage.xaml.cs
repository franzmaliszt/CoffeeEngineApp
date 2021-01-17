using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoffeeApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void loginBtn_Clicked(object sender, EventArgs e)
        {
            if(checkfields())
            {
                Application.Current.MainPage = new AppShell();
            } else
            {
                DisplayAlert("Error", "Please fill all the necessary fields", "OK");
            }
           

            
        }
        public bool checkfields()
        {
            
            if (usernameEntry.Text != string.Empty && passwordEntry.Text != string.Empty)
            {
                return false;
            }
            else return true;
            
        }

        private void labelClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AppShell();
        }
    }
}
