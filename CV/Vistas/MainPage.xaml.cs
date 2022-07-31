using CV.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CV
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Josue_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CVJosue());
        }
        private void Button_Erick_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CVErick());
        }
        private void Button_Jhosef_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CVJhosef());
        }
        private void Button_Chris_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CVChristian());
        }
    }
}
