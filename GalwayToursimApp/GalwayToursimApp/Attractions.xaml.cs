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
	public partial class Attractions : ContentPage
	{
		public Attractions ()
		{
			InitializeComponent ();
		}
        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.google.com/maps/place/Galway/@53.2838294,-9.1888286,11z/data=!3m1!4b1!4m5!3m4!1s0x485b93955a2d5bff:0x32b1b440a495281!8m2!3d53.270668!4d-9.0567905"));
        }
    }
}