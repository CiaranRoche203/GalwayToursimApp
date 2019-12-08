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
	public partial class Pubs : ContentPage
	{
        public Pubs()
        {
            InitializeComponent();
            var Image = new Image { Source = "Pints.jpg" };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.lonelyplanet.com/ireland/galway-city/nightlife/a/poi-dri/359685"));
        }


        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.google.com/maps/search/Bars/@53.274178,-9.0616159,15z/data=!3m1!4b1"));
        }
    }
}