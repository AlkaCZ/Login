using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Login
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            LoginInfo loginInfo = new LoginInfo(titlePicker.SelectedItem.ToString(), name.Text, password.Text);
            if (loginInfo.Password != password.Text)
            {
                Application.Current.MainPage.DisplayAlert("Error", loginInfo.Password, "OK");
            }

            else
            {
                Page p = new Ello(loginInfo);
                Application.Current.MainPage.Navigation.PushAsync(new NavigationPage(p));
            }
   

        }
    }
}
