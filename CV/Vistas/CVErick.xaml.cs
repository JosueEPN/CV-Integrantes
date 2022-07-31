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
    public partial class CVErick : ContentPage
    {
        public CVErick()
        {
            InitializeComponent();
        }
        private void btnVolverErick_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }


    }
}