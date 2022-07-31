using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CV.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CVJhosef : ContentPage
    {
        public CVJhosef()
        {
            InitializeComponent();
        }

        private void btnVolverJhosef_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}