using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GalwayToursimApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Restaurants : ContentPage
	{
        public Restaurants()
        {
            InitializeComponent();
            var Image = new Image { Source = "Restaurants.jpg" };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.lonelyplanet.com/ireland/galway-city/restaurants/a/poi-eat/359685"));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.google.ie/maps/search/Restaurants/@53.2730346,-9.0564402,14z"));
        }
    }
}