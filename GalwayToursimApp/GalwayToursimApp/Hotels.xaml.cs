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
	public partial class Hotels : ContentPage
	{
        public Hotels()
        {
            InitializeComponent();
            var Image = new Image { Source = "Hotels.jpg" };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.lonelyplanet.com/ireland/galway-city/hotels/a/lod/359685"));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.google.com/maps/search/Hotels/@53.2838737,-9.0952812,12z"));
        }
    }
}