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
	public partial class Pictures : ContentPage
	{
		public Pictures ()
		{
			InitializeComponent ();
            var Image = new Image { Source = "Galway1.jpg" };
            var Image1 = new Image { Source = "Galway2.jpg" };
            var Image2 = new Image { Source = "Galway3.png" };
            var Image3 = new Image { Source = "Galway4.jpg" };
            var Image4 = new Image { Source = "Galway5.jpg" };
            var Image5 = new Image { Source = "Galway6.jpg" };
        }
	}
}